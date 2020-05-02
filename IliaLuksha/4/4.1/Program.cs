using System;
using System.Runtime.InteropServices;//нужно для работы DLL
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using MyClass;

namespace ConsoleApp1
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int i);
        [DllImport("User32.dll")]
        public static extern int GetKeyState(int i);

        static void Main(string[] args)
        {
            while (true)
            {
                //true
                int Key = Convert.ToInt32(Console.ReadKey(true).Key);
                Class1 example1 = new Class1();

                    if((GetKeyState(16) == 65408 || GetKeyState(16) == 65409)) // Shift
                    {
                        example1.Shift(Key);    
                    }
                    else
                    {
                        example1.Ifer(Key);
                    }               
            } 
        }
    }
}
