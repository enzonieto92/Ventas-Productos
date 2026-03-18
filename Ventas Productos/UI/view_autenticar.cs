using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Ventas_Productos.Data;
using Ventas_Productos.Domain;
namespace Ventas_Productos.UI
{
    public partial class view_autenticar : BaseForm
    {
        public Usuario UsuarioAutenticado { get; set; }
        private DatabaseService _databaseService  = new DatabaseService();
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
            var users = _databaseService.TraerUsuarios();
            foreach (var user in users)
            {
                if (user.Nombre == txtbox_contraseña.Text && user.Contraseña == txtbox_nombre.Text)
                {
                    Sesion.Autenticar(user); // <-- esto
                    this.DialogResult = DialogResult.OK;
                    UsuarioAutenticado = user;
                    this.Close();
                    return;
                }
            }
            this.DialogResult |= DialogResult.No;
        }

        private void view_autenticar_Shown(object sender, System.EventArgs e)
        {
            txtbox_nombre.Focus();
        }

        private void view_autenticar_Load(object sender, System.EventArgs e)
        {
            txtbox_contraseña.Focus();
        }
    }
}
