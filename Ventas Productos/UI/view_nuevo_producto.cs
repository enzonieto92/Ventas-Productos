using System;
using System.Drawing;
using System.Windows.Forms;
using Ventas_Productos.Data;
using Ventas_Productos.Domain;

namespace Ventas_Productos.UI
{
    
    public partial class view_nuevo_producto : BaseForm
    {
        private readonly FormDragSnapBehavior _snapBehavior;
        private DatabaseService _dbService;
        private decimal resultado;
        public view_nuevo_producto()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            _snapBehavior = new FormDragSnapBehavior(this, help_bar_panel);
            tlsp_porcentaje.Renderer = new MyToolStripRenderer();
            _dbService = new DatabaseService();

            // 🔒 BLOQUEO TOTAL DE LAYOUT
            tlsp_porcentaje.AutoSize = false;
            tlsp_porcentaje.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;

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
            if (txtbox_nombre.Text == "" || resultado == 0 || txtbox_cod_barras.Text == "")
            {
                MessageBox.Show("Complete todos los datos");
                return ;
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
                producto.Precio = resultado;
                producto.CodigoBarras = txtbox_cod_barras.Text;
                
                _dbService.GuardarProducto(producto);
                MessageBox.Show("Producto Guardado!");
                this.Close();
            }

        }

        private void txtbox_precio_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_precio.Text != "")
            {
                CalcularPorcentaje();
            }
            else
            {
                lbl_precio_porcentaje.Text = "$ 0,00";
            }
        }
        private void CalcularPorcentaje()
        {
            var texto = toolStripDropDownButton1.Text;

            texto = texto.Trim();          // ← clave
            texto = texto.TrimEnd('%');    // ← saca el %

            var porcentaje = Decimal.Parse(texto);
            var precio = Decimal.Parse(txtbox_precio.Text);

            resultado = precio + (precio * porcentaje / 100);
            resultado = Math.Round(resultado / 100, 0) * 100;
            lbl_precio_porcentaje.Text = resultado.ToString("$ #,##0.00");
        }
        private void toolStripDropDownButton1_DropDownItemClicked(
            object sender, ToolStripItemClickedEventArgs e)
        {
            toolStripDropDownButton1.Text = TextoFijo(e.ClickedItem.Text, 4);

            if (!string.IsNullOrWhiteSpace(txtbox_precio.Text))
                CalcularPorcentaje();
            else
                lbl_precio_porcentaje.Text = "$ 0,00";
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
            if (e.KeyChar == ',' && !txtbox_precio.Text.Contains(","))
                return;

            // Todo lo demás, afuera
            e.Handled = true;
        }

        private void txtbox_cod_barras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtbox_precio.Focus();
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
            txtbox_precio.Text = "";
            toolStripDropDownButton1.Text = "0%";
        }
    }
}
