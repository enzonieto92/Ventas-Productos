using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ventas_Productos.Data;
using Ventas_Productos.Domain;

namespace Ventas_Productos.UI
{
    public partial class view_lista_productos : BaseForm
    {
        private readonly FormDragSnapBehavior _snapBehavior;
        private readonly DatabaseService _dbService;
        private StringBuilder _scannerBuffer;
        public view_lista_productos()
        {
            InitializeComponent();
            _dbService = new DatabaseService();
            _scannerBuffer = new StringBuilder();
            _snapBehavior = new FormDragSnapBehavior(this, help_bar_panel);
            scrollbar_productos.Scroll += (s, e) =>
            {
                dgv_productos.FirstDisplayedScrollingRowIndex = scrollbar_productos.Value;
            };
            dgv_productos.MouseWheel += dgv_productos_MouseWheel;
            dgv_productos.MouseEnter += (s, e) => dgv_productos.Focus();
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
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cerrar_MouseEnter(object sender, EventArgs e)
        {
            btn_cerrar.BackColor = Color.IndianRed;
        }

        private void btn_cerrar_MouseLeave(object sender, EventArgs e)
        {
            btn_cerrar.BackColor = Color.FromArgb(85, 99, 115);
        }

        private void view_lista_productos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void dgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex].Name == "editar_producto")
            {
                var producto = (Producto)dgv_productos.Rows[e.RowIndex].DataBoundItem;
                Form editar_producto = new view_editar_producto(producto);
                editar_producto.ShowDialog();
                CargarProductos();
            }
            if (grid.Columns[e.ColumnIndex].Name == "eliminar_producto")
            {
                var producto = (Producto)dgv_productos.Rows[e.RowIndex].DataBoundItem;
                if (MessageBox.Show(
               "Eliminar Producto: " + producto.Nombre ,
               "Confirmación",
               MessageBoxButtons.YesNo
           ) != DialogResult.Yes)
                    return;
                _dbService.EliminarProducto(producto.Id);
                CargarProductos();

            }

        }

        private void view_lista_productos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete) && _scannerBuffer.Length >0)
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
        private void ProcesarCodigo(string buffer)
        {
            _dbService.ObtenerProductos(buffer);

            CargarProductos();
        }
        private void CargarProductos()
        {
            var productos = _dbService.ObtenerProductos(_scannerBuffer.ToString());
            dgv_productos.DataSource = productos;
            dgv_productos.Columns.Remove("Id");
            dgv_productos.Columns.Remove("CodigoBarras");
            var colEditar = dgv_productos.Columns["editar_producto"];
            var colEliminar = dgv_productos.Columns["eliminar_producto"];
            colEditar.DisplayIndex = dgv_productos.Columns.Count - 1;
            colEliminar.DisplayIndex = dgv_productos.Columns.Count - 1;
            dgv_productos.ClearSelection();
            dgv_productos.Columns["PrecioVenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["PrecioVenta"].DefaultCellStyle.Format = "C2";
            ActualizarScroll();
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
        private void dgv_productos_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                e.ToolTipText = dgv_productos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            }
        }
    }
}
