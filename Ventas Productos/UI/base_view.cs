namespace Ventas_Productos.UI
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class BaseForm : Form
    {
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            EnableShadow();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; 
                return cp;
            }
        }
        private void EnableShadow()
        {
            int val = 2;
            DwmSetWindowAttribute(this.Handle, 2, ref val, sizeof(int));
        }

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(
            IntPtr hwnd,
            int attr,
            ref int attrValue,
            int attrSize
        );
    }
}
