using System;
using System.Drawing;
using System.Windows.Forms;
using Ventas_Productos.Data;
using Ventas_Productos.Domain;

namespace Ventas_Productos.UI
{

    public partial class view_editar_producto : BaseForm
    {
        private readonly FormDragSnapBehavior _snapBehavior;
        private DatabaseService _dbService;
        private decimal resultado;
        int id;
        public view_editar_producto(Producto producto)
        {
            InitializeComponent();

            _snapBehavior = new FormDragSnapBehavior(this, help_bar_panel);
            tlsp_porcentaje.Renderer = new MyToolStripRenderer();
            _dbService = new DatabaseService();
            tlsp_porcentaje.AutoSize = false;
            tlsp_porcentaje.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            id = producto.Id;
            txtbox_nombre.Text = producto.Nombre;
            txtbox_cod_barras.Text = producto.CodigoBarras;
            txtbox_precio_costo.Text = producto.PrecioCosto.ToString();
            txtbox_precio_venta.Text = producto.PrecioVenta.ToString();
            toolStripDropDownButton1.AutoSize = false;
            toolStripDropDownButton1.Width = 50;
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

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (txtbox_nombre.Text == "" || txtbox_cod_barras.Text == "" || txtbox_precio_costo.Text == "" || txtbox_precio_venta.Text == "")
            {
                MessageBox.Show("Complete todos los datos");
                return;
            }
            else
            {
                if (MessageBox.Show(
                "Confirmar Producto",
                "Confirmación",
                MessageBoxButtons.YesNo
            ) != DialogResult.Yes)
                    return;
                Producto producto = new Producto();
                producto.Nombre = txtbox_nombre.Text;
                producto.PrecioCosto = Decimal.Parse(txtbox_precio_costo.Text);
                producto.PrecioVenta = Decimal.Parse(txtbox_precio_venta.Text);
                producto.CodigoBarras = txtbox_cod_barras.Text;
                producto.Id = id;
                _dbService.EditarProducto(producto);
                this.Close();

            }
        }
        private void CalcularPorcentaje()
        {
            var texto = toolStripDropDownButton1.Text;

            texto = texto.Trim();          // ← clave
            texto = texto.TrimEnd('%');    // ← saca el %

            var porcentaje = Decimal.Parse(texto);
            var precio = Decimal.Parse(txtbox_precio_costo.Text);

            resultado = precio + (precio * porcentaje / 100);
            resultado = Math.Round(resultado / 100, 0) * 100;
            txtbox_precio_venta.Text = resultado.ToString("#,##0.00");
        }
        private void toolStripDropDownButton1_DropDownItemClicked(
            object sender, ToolStripItemClickedEventArgs e)
        {
            toolStripDropDownButton1.Text = TextoFijo(e.ClickedItem.Text, 4);

            if (!string.IsNullOrWhiteSpace(txtbox_precio_costo.Text))
                CalcularPorcentaje();
            else
                txtbox_precio_venta.Text = "$ 0,00";
        }
        private string TextoFijo(string texto, int largo)
        {
            if (texto.Length > largo)
                return texto.Substring(0, largo);

            return texto.PadRight(largo, ' ');
        }
        private void view_nuevo_producto_Load(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Text = toolStripMenuItem1.Text;
        }

        private void txtbox_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir dígitos
            if (char.IsDigit(e.KeyChar))
                return;

            // Permitir separador decimal UNA sola vez
            if (e.KeyChar == ',' && !txtbox_precio_costo.Text.Contains(","))
                return;

            // Todo lo demás, afuera
            e.Handled = true;
        }

        private void txtbox_cod_barras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtbox_precio_costo.Focus();
            }
        }

        private void txtbox_nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtbox_cod_barras.Focus();
            }
        }

        private void txtbox_precio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                toolStripDropDownButton1.Select();
            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txtbox_nombre.Text = "";
            txtbox_cod_barras.Text = "";
            txtbox_precio_costo.Text = "";
            toolStripDropDownButton1.Text = "0%";
        }
    }
}
