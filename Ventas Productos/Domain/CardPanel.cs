using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
public class CardPanel : Panel
{
    public int BorderRadius { get; set; } = 20;
    public int ShadowSize { get; set; } = 6;

    public CardPanel()
    {
        DoubleBuffered = true;
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        int d = BorderRadius * 2;
        int offset = ShadowSize;

        Rectangle cardRect = new Rectangle(0, 0, Width - offset, Height - offset);
        Rectangle shadowRect = new Rectangle(offset, offset, Width - offset, Height - offset);

        using (GraphicsPath shadowPath = GetPath(shadowRect, d))
        using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(60, 0, 0, 0)))
        {
            e.Graphics.FillPath(shadowBrush, shadowPath);
        }

        using (GraphicsPath cardPath = GetPath(cardRect, d))
        using (SolidBrush brush = new SolidBrush(BackColor))
        {
            e.Graphics.FillPath(brush, cardPath);
        }
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);

        int offset = ShadowSize;
        int d = BorderRadius * 2;

        Rectangle rect = new Rectangle(0, 0, Width - offset, Height - offset);

        using (GraphicsPath path = GetPath(rect, d))
        {
            Region = new Region(path);
        }

        Invalidate();
    }

    private GraphicsPath GetPath(Rectangle rect, int d)
    {
        GraphicsPath path = new GraphicsPath();

        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

        path.CloseFigure();
        return path;
    }
}