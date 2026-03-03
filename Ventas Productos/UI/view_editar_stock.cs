using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas_Productos.Data;
using Ventas_Productos.Domain;

namespace Ventas_Productos.UI
{
    public partial class view_editar_stock : BaseForm
    {
        private readonly FormDragSnapBehavior _snapBehavior;
        private readonly ProductoStock _producto;
        private DatabaseService _dbService;
        public view_editar_stock(ProductoStock producto )
        {
            InitializeComponent();
            _dbService = new DatabaseService();
            _producto = producto;
            lbl_producto.Text = _producto.Nombre;
            txtbox_cantidad.Text = producto.Stock.ToString();
            _snapBehavior = new FormDragSnapBehavior(this, help_bar_panel);
        }
        private void view_stock_edicion_Load(object sender, EventArgs e)
        {
            var distancia = lbl_producto.Text.Length / 2;
            var coor = lbl_producto.Location;
            coor.X -= distancia*8;
            lbl_producto.Location = coor;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cerrar_MouseClick(object sender, MouseEventArgs e)
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
            if (txtbox_cantidad.Text == "")
            {
                MessageBox.Show("Escriba una cantidad");
                return;
            }
            else
            {
                if (MessageBox.Show(
                "Confirmar Stock",
                "Confirmación",
                MessageBoxButtons.YesNo
            ) != DialogResult.Yes)
                    return;
                _producto.Stock = Convert.ToInt32(txtbox_cantidad.Text);
                _dbService.GuardarStock(_producto);
                this.Close();
            }
        }

        private void txtbox_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir dígitos
            if (char.IsDigit(e.KeyChar))
                return;



            // Todo lo demás, afuera
            e.Handled = true;
        }
    }
}
