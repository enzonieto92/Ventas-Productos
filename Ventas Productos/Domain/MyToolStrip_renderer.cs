using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Ventas_Productos.Domain
{
    class MyToolStripRenderer : ToolStripProfessionalRenderer
    {
        public MyToolStripRenderer()
       : base(new MyColorTable())
        {
        }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            using (var brush = new SolidBrush(e.ToolStrip.BackColor)) 
            e.Graphics.FillRectangle(brush, e.AffectedBounds);
        }

        protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item is ToolStripDropDownButton btn)
            {
                if (btn.Pressed || btn.DropDown.Visible || btn.Selected)
                {
                    using (var brush = new SolidBrush(Color.FromArgb(120, 135, 150)))
                        e.Graphics.FillRectangle(
                            brush,
                            new Rectangle(Point.Empty, btn.Size)
                        );
                    return;
                }
            }

            base.OnRenderDropDownButtonBackground(e);
        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                using (var brush = new SolidBrush(Color.FromArgb(120, 135, 150)))
                    e.Graphics.FillRectangle(
                        brush,
                        new Rectangle(Point.Empty, e.Item.Size)
                    );
                return;
            }

            base.OnRenderButtonBackground(e);
        }
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            // sin borde
        }
    }
}
