using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Lab4
{
    class Program
    {
        [DllImport("User32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("User32.dll")]
        static extern int ReleaseDC(IntPtr hwnd, IntPtr dc);

        static void Main(string[] args)
        {
            IntPtr desktop = GetDC(IntPtr.Zero);
            Graphics g = Graphics.FromHdc(desktop);
            g.FillEllipse(Brushes.Blue, 0, 0, 1340, 850);
            ReleaseDC(IntPtr.Zero, desktop);
        }
    }
}


