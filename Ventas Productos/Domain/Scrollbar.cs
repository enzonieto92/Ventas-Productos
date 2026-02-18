using System;
using System.Drawing;
using System.Windows.Forms;

public class ScrollBar : Control
{
    public int Minimum { get; set; } = 0;
    public int Maximum { get; set; } = 100;
    public int Value { get; private set; } = 0;
    public int LargeChange { get; set; } = 10;

    private Rectangle thumbRect;
    private bool dragging;
    private int dragOffset;

    // 🎨 Paleta
    private Color TrackColor = ColorTranslator.FromHtml("#4F6378");
    private Color ThumbColor = ColorTranslator.FromHtml("#7F95AD");
    private Color ThumbHoverColor = ColorTranslator.FromHtml("#9BB2C9");

    private bool isHover;

    public event EventHandler Scroll;

    public ScrollBar()
    {
        DoubleBuffered = true;
        Width = 12;
        Cursor = Cursors.Hand;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        using (var trackBrush = new SolidBrush(TrackColor))
            g.FillRectangle(trackBrush, ClientRectangle);

        thumbRect = CalculateThumb();

        // 🔥 Hover o Drag = mismo color claro
        bool active = isHover || dragging;

        Color currentThumbColor = active
            ? ThumbHoverColor
            : ThumbColor;

        using (var thumbBrush = new SolidBrush(currentThumbColor))
            g.FillRectangle(thumbBrush, thumbRect);
    }

    private Rectangle CalculateThumb()
    {
        int range = Maximum - Minimum;
        if (range <= 0)
            return new Rectangle(0, 0, Width, Height);

        float ratio = (float)LargeChange / (range + LargeChange);
        int thumbHeight = (int)(Height * ratio);
        thumbHeight = Math.Max(30, thumbHeight);

        float valueRatio = (float)(Value - Minimum) / range;
        int y = (int)((Height - thumbHeight) * valueRatio);

        return new Rectangle(0, y, Width, thumbHeight);
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        if (thumbRect.Contains(e.Location))
        {
            dragging = true;
            dragOffset = e.Y - thumbRect.Y;
        }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        if (dragging)
        {
            int newY = e.Y - dragOffset;
            newY = Math.Max(0, Math.Min(Height - thumbRect.Height, newY));

            float ratio = (float)newY / (Height - thumbRect.Height);
            SetValue(Minimum + (int)((Maximum - Minimum) * ratio));
        }

        bool hoverNow = thumbRect.Contains(e.Location);
        if (hoverNow != isHover)
        {
            isHover = hoverNow;
            Invalidate();
        }
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        dragging = false;
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        isHover = false;
        Invalidate();
    }

    public void SetValue(int newValue)
    {
        newValue = Math.Max(Minimum, Math.Min(Maximum, newValue));

        if (Value != newValue)
        {
            Value = newValue;
            Scroll?.Invoke(this, EventArgs.Empty);
            Invalidate();
        }
    }
}