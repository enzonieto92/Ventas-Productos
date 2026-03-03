using System.Drawing;
using System.Windows.Forms;
namespace Ventas_Productos.UI
{
    public partial class view_autenticar : BaseForm
    {
        public view_autenticar()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btn_cerrar_MouseEnter(object sender, System.EventArgs e)
        {
            btn_cerrar.BackColor = Color.IndianRed;
        }

        private void btn_cerrar_MouseLeave(object sender, System.EventArgs e)
        {
            btn_cerrar.BackColor = Color.FromArgb(85, 99, 115);
        }

        private void btn_confirmar_Click(object sender, System.EventArgs e)
        {
            if (txtbox_busqueda.Text == "stock2026")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult |= DialogResult.No;
            }
        }

        private void view_autenticar_Shown(object sender, System.EventArgs e)
        {
            txtbox_busqueda.Focus();
        }
    }
}
