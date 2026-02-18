using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas_Productos.Data;
using Ventas_Productos.Domain;

namespace Ventas_Productos.UI
{

    public partial class view_stock : BaseForm
    {
        private string _scannerBuffer;
        private readonly FormDragSnapBehavior _snapBehavior;
        private readonly DatabaseService _dbService;
        public view_stock()
        {
            InitializeComponent();
            _dbService = new DatabaseService();
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
        private void btn_cerrar_MouseEnter(object sender, EventArgs e)
        {
            btn_cerrar.BackColor = Color.IndianRed;
        }

        private void btn_cerrar_MouseLeave(object sender, EventArgs e)
        {
            btn_cerrar.BackColor = Color.FromArgb(85, 99, 115);
        }

        private void view_stock_Load(object sender, EventArgs e)
        {
            _scannerBuffer = "";
            CargarProductos();
        }
        private void CargarProductos()
        {

            var productos = _dbService.ObtenerStock(_scannerBuffer);

            dgv_productos.DataSource = productos;
            dgv_productos.Columns.Remove("CodigoBarras");
            dgv_productos.Columns.Remove("Precio");
            dgv_productos.Columns.Remove("Id");
            dgv_productos.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbox_busqueda_TextChanged(object sender, EventArgs e)
        {
            _scannerBuffer = txtbox_busqueda.Text;
            CargarProductos();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            var producto = (ProductoStock)dgv_productos.SelectedRows[0].DataBoundItem;
            view_autenticar aut = new view_autenticar();
            var resultado = aut.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                view_editar_stock view = new view_editar_stock(producto);
                view.ShowDialog();
            }
            else if (resultado == DialogResult.No)
            {
                {
                    MessageBox.Show("Contraseña incorrecta");
                }

                CargarProductos();
            }
        }

    }
}
