using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Ventas_Productos.Data;
using Ventas_Productos.Domain;
using Ventas_Productos.UI;
using Ventas_Productos.Properties;

namespace Ventas_Productos
{
    public partial class view_ventas : BaseForm
    {
        private readonly DatabaseService dbService;
        private readonly FormDragSnapBehavior _snapBehavior;
        private WindowResizeBehavior _resizeBehavior;
        private BindingList<ProductoVenta> _seleccionados;
        private StringBuilder _scannerBuffer;
        private decimal _totalVenta;
        private readonly Timer _timer;
        private Usuario _usuario;
        public view_ventas()
        {
            InitializeComponent();
            this.KeyPreview = true;
            toolStrip1.Renderer = new MyToolStripRenderer();
            dbService = new DatabaseService();
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
            _timer.Start();
            _scannerBuffer = new StringBuilder();
            _seleccionados = new BindingList<ProductoVenta>();
            _seleccionados.ListChanged += (_, __) =>
            {
                ActualizarTotal();
            };
            _snapBehavior = new FormDragSnapBehavior(this, help_bar_panel);
            scrollbar_productos.Scroll += (s, e) =>
            {
                dgv_productos.FirstDisplayedScrollingRowIndex = scrollbar_productos.Value;
            };
            scrollbar_ventas.Scroll += (s, e) =>
            {
                dgv_ventas.FirstDisplayedScrollingRowIndex = scrollbar_ventas.Value;
            };
            dgv_productos.MouseWheel += dgv_productos_MouseWheel;
            dgv_productos.MouseEnter += (s, e) => dgv_productos.Focus();
            dgv_ventas.MouseWheel += dgv_ventas_MouseWheel;
            dgv_ventas.MouseEnter += (s, e) => dgv_ventas.Focus();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ActualizarHora();
        }

        private void ActualizarHora()
        {
            var cultura = new CultureInfo("es-AR");
            var texto = DateTime.Now.ToString("ddd, d 'de' MMMM | HH:mm") + " Hs";
            lbl_fecha_hora.Text = char.ToUpper(texto[0], cultura) + texto.Substring(1);


        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_cerrar_MouseLeave(object sender, EventArgs e)
        {
            btn_cerrar.BackColor = Color.FromArgb(85, 99, 115);
        }
        private void btn_cerrar_MouseEnter(object sender, EventArgs e)
        {
            btn_cerrar.BackColor = Color.IndianRed;
        }
        private void btn_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
    "¿Seguro que desea borrar los artículos?",
    "Confirmación",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.None
);

            if (result == DialogResult.Yes)
            {
                _seleccionados.Clear();
                btn_confirmar.Enabled = false;
                btn_limpiar.Enabled = false;
            }
        }
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Confirmar Venta",
                "Confirmación",
                MessageBoxButtons.YesNo
            ) != DialogResult.Yes)
                return;

            var ventaService = new VentaService(dbService);
            ventaService.ConfirmarVenta(_seleccionados, _totalVenta);
            _seleccionados.Clear();
            btn_confirmar.Enabled = false; btn_limpiar.Enabled = false;
            CalcularGanancias();
        }
        private void CalcularGanancias()
        {
            DateTime desde = DateTime.Today;        // Hoy a las 00:00:00
            DateTime hasta = DateTime.Now.AddMinutes(1);
            var ventasHoy = dbService.ObtenerVentas(desde, hasta);
            var gananciasHoy = dbService.CalcularGanancias(ventasHoy);
            if (lbl_ojo.Tag.ToString() == "abierto")
            {
                lbl_ganancias.Text = gananciasHoy.ToString("C2", new System.Globalization.CultureInfo("es-AR"));
            }
            else
            {
                lbl_ganancias.Text = "****";
            }
        }
        private void view_ventas_Load(object sender, EventArgs e)
        {
            lbl_ojo.Tag = "cerrado";
            CalcularGanancias();
            CargarProductos();
            CargarPanelVentas();
            ActualizarHora();
            _resizeBehavior = new WindowResizeBehavior(this, 900, 700);
            this.AcceptButton = null;



        }

        private void CargarProductos()
        {
            var productos = dbService.ObtenerProductosConStock(_scannerBuffer.ToString());
            dgv_productos.DataSource = productos;
            dgv_productos.Columns.Remove("CodigoBarras");
            dgv_productos.Columns.Remove("PrecioCosto");
            dgv_productos.Columns.Remove("Id");
            dgv_productos.Columns.Remove("Stock");

            dgv_productos.ClearSelection();
            dgv_productos.Columns["PrecioVenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_productos.Columns["PrecioVenta"].DefaultCellStyle.Format = "C2";
            ActualizarScroll();
        }
        private void CargarPanelVentas()
        {
            dgv_ventas.AutoGenerateColumns = true;
            dgv_ventas.DataSource = _seleccionados;
            dgv_ventas.Columns["Id"].Visible = false;
            dgv_ventas.Columns["PrecioCosto"].Visible = false;
            dgv_ventas.Columns["PrecioVenta"].DefaultCellStyle.Format = "C2";
            dgv_ventas.Columns["PrecioVenta"].DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight;
            dgv_ventas.Columns["Cantidad"].DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;
            dgv_ventas.ClearSelection();
            ActualizarScroll2();
            if (_usuario != null)
            {
                if (_usuario.Rol == "Admin")
                {
                    btn_user.Image = Resources.user_admin;
                }
                else if (_usuario.Rol == "Invitado")
                {

                }
            }
            else            
            {
                btn_user.Image = Resources.user;
            }
        }
        private void ActualizarTotal()
        {
            _totalVenta = 0;

            foreach (var item in _seleccionados)
                _totalVenta += item.PrecioVenta * item.Cantidad;

            lbl_total.Text = _totalVenta.ToString("C2");
        }
        private void ActualizarScroll()
        {
            int visibles = dgv_productos.DisplayedRowCount(false);
            int total = dgv_productos.RowCount;

            if (total <= visibles)
            {
                scrollbar_productos.Enabled = false;
                scrollbar_productos.Visible = false;
                return;
            }

            scrollbar_productos.Enabled = true;
            scrollbar_productos.Visible = true;

            scrollbar_productos.Minimum = 0;
            scrollbar_productos.Maximum = total - visibles;
            scrollbar_productos.LargeChange = visibles;
        }
        private void ActualizarScroll2()
        {
            int visibles = dgv_ventas.DisplayedRowCount(false);
            int total = dgv_ventas.RowCount;

            if (total <= visibles)
            {
                scrollbar_ventas.Enabled = false;
                scrollbar_ventas.Visible = false;
                return;
            }

            scrollbar_ventas.Enabled = true;
            scrollbar_ventas.Visible = true;

            scrollbar_ventas.Minimum = 0;
            scrollbar_ventas.Maximum = total - visibles;
            scrollbar_ventas.LargeChange = visibles;
        }
        private void dgv_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var producto = (ProductoStock)dgv_productos.Rows[e.RowIndex].DataBoundItem;

            var existente = _seleccionados.FirstOrDefault(p => p.Id == producto.Id);
            VerExistente(existente, producto);
            CargarPanelVentas();

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_usuario == null)
            {
                view_autenticar auth = new view_autenticar();

                if (auth.ShowDialog() == DialogResult.OK)
                {
                    _usuario = auth.UsuarioAutenticado;
                    CargarPanelVentas();
                    view_historial form = new view_historial();
                    form.ShowDialog();
                    return; // <- esto evita que siga ejecutando
                }
                else
                {
                    return;
                }
            }

            if (_usuario.Rol == "Admin")
            {
                view_historial form = new view_historial();
                form.ShowDialog();
            }
        }

        private void view_ventas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete) && _scannerBuffer.Length > 0)
            {
                if (txtbox_busqueda.SelectionLength > 0)
                {
                    _scannerBuffer.Remove(
                        txtbox_busqueda.SelectionStart,
                        txtbox_busqueda.SelectionLength
                    );
                }
                else
                {
                    _scannerBuffer.Remove(
                         txtbox_busqueda.SelectionStart - 1,
                         1
                     );
                }
                txtbox_busqueda.Text = _scannerBuffer.ToString();
                txtbox_busqueda.SelectionStart = txtbox_busqueda.Text.Length;
                txtbox_busqueda.SelectionLength = 0;
                ProcesarCodigo(_scannerBuffer.ToString());
                e.Handled = true;
                return;
            }


            if (!char.IsControl(e.KeyChar))
            {
                _scannerBuffer.Append(e.KeyChar);
                ProcesarCodigo(_scannerBuffer.ToString());
                txtbox_busqueda.Text = _scannerBuffer.ToString();
                txtbox_busqueda.SelectionStart = txtbox_busqueda.Text.Length;
                txtbox_busqueda.SelectionLength = 0;
                e.Handled = true;
            }
        }
        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_nuevo_producto form = new view_nuevo_producto();
            form.ShowDialog();
            CargarProductos();
        }
        private void ProcesarCodigo(string buffer)
        {
            dbService.ObtenerProductos(buffer);

            CargarProductos();
        }
        public void VerExistente(ProductoVenta existente, ProductoStock producto)
        {
            if (existente != null)
            {
                existente.Cantidad++;
            }
            else
            {
                _seleccionados.Add(new ProductoVenta
                {
                    Id = producto.Id,
                    Nombre = producto.Nombre,
                    PrecioCosto = producto.PrecioCosto,
                    PrecioVenta = producto.PrecioVenta,
                    Cantidad = 1
                });
            }
            txtbox_busqueda.Clear();
            _scannerBuffer.Clear();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (_resizeBehavior != null && _resizeBehavior.TryHandle(ref m))
                return;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (dgv_productos.Rows.Count == 1)
                {
                    _scannerBuffer.Clear();
                    txtbox_busqueda.Text = _scannerBuffer.ToString();
                    var producto = (ProductoStock)dgv_productos.Rows[0].DataBoundItem;
                    var existente = _seleccionados.FirstOrDefault(p => p.Id == producto.Id);
                    VerExistente(existente, producto);
                }
                ProcesarCodigo(_scannerBuffer.ToString());

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_lista_productos view_lista = new view_lista_productos();

            view_lista.ShowDialog();
            CargarProductos();

        }

        private void dgv_productos_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                e.ToolTipText = dgv_productos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            }
        }
        private void dgv_ventas_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                e.ToolTipText = dgv_ventas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            }
        }
        private void dgv_productos_MouseWheel(object sender, MouseEventArgs e)
        {
            if (dgv_productos.RowCount == 0) return;

            int visibles = dgv_productos.DisplayedRowCount(false);
            int max = dgv_productos.RowCount - visibles;

            int actual = dgv_productos.FirstDisplayedScrollingRowIndex;

            int lineas = SystemInformation.MouseWheelScrollLines;
            int delta = (e.Delta > 0 ? -lineas : lineas);

            int nuevo = actual + delta;
            nuevo = Math.Max(0, Math.Min(max, nuevo));

            dgv_productos.FirstDisplayedScrollingRowIndex = nuevo;
            scrollbar_productos.SetValue(nuevo);
        }
        private void dgv_ventas_MouseWheel(object sender, MouseEventArgs e)
        {
            if (dgv_ventas.RowCount == 0) return;

            int visibles = dgv_ventas.DisplayedRowCount(false);
            int max = dgv_ventas.RowCount - visibles;

            int actual = dgv_ventas.FirstDisplayedScrollingRowIndex;

            int lineas = SystemInformation.MouseWheelScrollLines;
            int delta = (e.Delta > 0 ? -lineas : lineas);

            int nuevo = actual + delta;
            nuevo = Math.Max(0, Math.Min(max, nuevo));

            dgv_ventas.FirstDisplayedScrollingRowIndex = nuevo;
            scrollbar_ventas.SetValue(nuevo);
        }
        private void view_ventas_Shown(object sender, EventArgs e)
        {
            this.Opacity = 1;
            this.Visible = true;
        }
        private void verStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_stock view_Stock = new view_stock();
            view_Stock.ShowDialog();
            CargarProductos();
        }

        private void btn_borrar_seleccion_Click(object sender, EventArgs e)
        {
            if (dgv_ventas.SelectedRows.Count > 0)
            {
                var item = (ProductoVenta)dgv_ventas.CurrentRow.DataBoundItem;
                if (item.Cantidad > 1)
                {
                    item.Cantidad--;
                    dgv_ventas.Refresh(); // solo si no implementaste INotifyPropertyChanged
                }
                else
                {
                    _seleccionados.Remove(item);
                    dgv_ventas.ClearSelection();
                    if (dgv_ventas.Rows.Count == 0)
                    {
                        btn_confirmar.Enabled = false;
                        btn_limpiar.Enabled = false;
                    }
                }

            }
        }

        private void dgv_ventas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_ventas.SelectedRows.Count > 0)
            {
                btn_borrar_seleccion.Enabled = true;
                lbl_borrar_seleccion.ForeColor = Color.FromArgb(224, 224, 224);

            }
            else
            {
                btn_borrar_seleccion.Enabled = false;
                lbl_borrar_seleccion.ForeColor = Color.FromArgb(150, 150, 150);
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            MessageBox.Show($"Versión: {version}");
        }

        private void dgv_ventas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btn_confirmar.Enabled = true;
            btn_limpiar.Enabled = true;
        }

        private DashboardControl dashboard;

        private void verEstadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_usuario == null)
            {
                view_autenticar auth = new view_autenticar();
                if (auth.ShowDialog() == DialogResult.OK)
                {
                    _usuario = auth.UsuarioAutenticado;
                    CargarPanelVentas();
                    AbrirEstadisticas();
                }
                else
                {
                    return;
                }
            }
            else if (_usuario.Rol == "Admin")
            {
                AbrirEstadisticas();
            }
            return;
        }

        private void AbrirEstadisticas()
        {
            if (dashboard == null)
            {
                dashboard = new DashboardControl();
                dashboard.Dock = DockStyle.Fill;

                dashboard.VolverAVentas += (s, ev) =>
                {
                    dashboard.Visible = false;

                    foreach (Control c in panel_menu.Controls)
                        if (c != dashboard)
                            c.Visible = true;

                    CargarProductos();
                };

                panel_menu.Controls.Add(dashboard);
            }
            foreach (Control c in panel_menu.Controls)
                if (c != dashboard)
                    c.Visible = false;

            dashboard.Visible = true;
            dashboard.BringToFront();
        }
        private void lbl_ojo_Click(object sender, EventArgs e)
        {
            if (lbl_ojo.Tag.ToString() == "abierto")
            {
                lbl_ganancias.Text = "****";
                lbl_ojo.Image = Properties.Resources.cerrado;
                lbl_ojo.Tag = "cerrado";
            }
            else
            {
                if (_usuario == null)
                {
                    view_autenticar auth = new view_autenticar();

                    if (auth.ShowDialog() == DialogResult.OK)
                    {
                        _usuario = auth.UsuarioAutenticado;
                        CargarPanelVentas();
                        lbl_ganancias.Text = _totalVenta.ToString("C2");
                        lbl_ojo.Image = Properties.Resources.abierto;
                        lbl_ojo.Tag = "abierto";
                    }
                    else
                    {
                        return;
                    }
                }

                if (_usuario.Rol == "Admin")
                {
                    lbl_ganancias.Text = _totalVenta.ToString("C2");
                    lbl_ojo.Image = Properties.Resources.abierto;
                    lbl_ojo.Tag = "abierto";
                }

            }
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            btn_user.ContextMenuStrip = usuario_context;
                usuario_context.Show(btn_user, new Point(0, btn_user.Height));
        }

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _usuario = null;
            CargarPanelVentas();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_usuario == null)
            {
                view_autenticar auth = new view_autenticar();
                if (auth.ShowDialog() == DialogResult.OK)
                {
                    _usuario = auth.UsuarioAutenticado;
                    CargarPanelVentas();
                }
                else
                {
                    return;
                }
            }
        }
    }
}

