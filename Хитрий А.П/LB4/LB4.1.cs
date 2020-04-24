using System;
using System.Drawing;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("kernel32.dll")]
    static extern IntPtr GetConsoleWindow();

    [DllImport("user32.dll")]
    static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    const int SW_HIDE = 0;

    [DllImport("User32.dll")]
    static extern IntPtr GetDC(IntPtr hwnd);

    [DllImport("User32.dll")]
    static extern int ReleaseDC(IntPtr hwnd, IntPtr dc);

    static void Main()
    {

        IntPtr desktop = GetDC(IntPtr.Zero);
        using (Graphics g = Graphics.FromHdc(desktop))
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            g.FillRectangle(Brushes.Red, 0, 0, 2000, 1000);
            Console.Read();
        }
        ReleaseDC(IntPtr.Zero, desktop);
    }
}