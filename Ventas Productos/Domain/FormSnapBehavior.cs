using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ventas_Productos.Domain
{
    public class FormDragSnapBehavior
    {
        private readonly Form _form;
        private readonly Control _dragControl;

        private Point _startCursor;
        private Point _startForm;
        private bool _dragging;

        private const int SNAP = 10;

        public FormDragSnapBehavior(Form form, Control dragControl)
        {
            _form = form;
            _dragControl = dragControl;

            _dragControl.MouseDown += MouseDown;
            _dragControl.MouseMove += MouseMove;
            _dragControl.MouseUp += MouseUp;
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            _dragging = true;
            _startCursor = Cursor.Position;

            if (_form.WindowState == FormWindowState.Maximized)
            {
                // punto relativo del mouse en la ventana
                float percentX = (float)Cursor.Position.X / Screen.PrimaryScreen.Bounds.Width;

                _form.WindowState = FormWindowState.Normal;

                int newX = Cursor.Position.X - (int)(_form.Width * percentX);
                int newY = Cursor.Position.Y - e.Y;

                _form.Location = new Point(newX, newY);
            }

            _startForm = _form.Location;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;

            Point diff = new Point(
                Cursor.Position.X - _startCursor.X,
                Cursor.Position.Y - _startCursor.Y);

            _form.Location = new Point(
                _startForm.X + diff.X,
                _startForm.Y + diff.Y);
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;

            Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;

            if (Cursor.Position.Y <= screen.Top + SNAP)
            {
                _form.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
