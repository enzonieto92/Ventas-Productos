using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System;
public class WindowResizeBehavior
{
    private readonly Form _form;
    private readonly int _minWidth;
    private readonly int _minHeight;
    private readonly int _resizeArea;

    public WindowResizeBehavior(Form form, int minWidth, int minHeight, int resizeArea = 8)
    {
        _form = form;
        _minWidth = minWidth;
        _minHeight = minHeight;
        _resizeArea = resizeArea;
    }

    public bool TryHandle(ref Message m)
    {
        const int WM_GETMINMAXINFO = 0x24;
        const int WM_NCHITTEST = 0x84;

        if (m.Msg == WM_GETMINMAXINFO)
        {
            MINMAXINFO mmi = Marshal.PtrToStructure<MINMAXINFO>(m.LParam);
            mmi.ptMinTrackSize.x = _minWidth;
            mmi.ptMinTrackSize.y = _minHeight;
            Marshal.StructureToPtr(mmi, m.LParam, true);
            return true;
        }

        if (m.Msg == WM_NCHITTEST)
        {
            // le pedimos al Form que ya haya ejecutado base.WndProc
            if ((int)m.Result != HTCLIENT)
                return false;

            Point p = _form.PointToClient(new Point(m.LParam.ToInt32()));

            if (p.X <= _resizeArea && p.Y <= _resizeArea)
                m.Result = (IntPtr)HTTOPLEFT;
            else if (p.X >= _form.Width - _resizeArea && p.Y <= _resizeArea)
                m.Result = (IntPtr)HTTOPRIGHT;
            else if (p.X <= _resizeArea && p.Y >= _form.Height - _resizeArea)
                m.Result = (IntPtr)HTBOTTOMLEFT;
            else if (p.X >= _form.Width - _resizeArea && p.Y >= _form.Height - _resizeArea)
                m.Result = (IntPtr)HTBOTTOMRIGHT;
            else if (p.X <= _resizeArea)
                m.Result = (IntPtr)HTLEFT;
            else if (p.X >= _form.Width - _resizeArea)
                m.Result = (IntPtr)HTRIGHT;
            else if (p.Y <= _resizeArea)
                m.Result = (IntPtr)HTTOP;
            else if (p.Y >= _form.Height - _resizeArea)
                m.Result = (IntPtr)HTBOTTOM;

            return true;
        }

        return false;
    }

    private const int HTCLIENT = 1;
    private const int HTLEFT = 10;
    private const int HTRIGHT = 11;
    private const int HTTOP = 12;
    private const int HTTOPLEFT = 13;
    private const int HTTOPRIGHT = 14;
    private const int HTBOTTOM = 15;
    private const int HTBOTTOMLEFT = 16;
    private const int HTBOTTOMRIGHT = 17;

    [StructLayout(LayoutKind.Sequential)]
    struct POINT
    {
        public int x;
        public int y;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct MINMAXINFO
    {
        public POINT ptReserved;
        public POINT ptMaxSize;
        public POINT ptMaxPosition;
        public POINT ptMinTrackSize;
        public POINT ptMaxTrackSize;
    }
}
