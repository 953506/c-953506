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
            int num = 0, num1 = 0;
            while (true)
            {
                int Key = Convert.ToInt32(Console.ReadKey(true).Key);
                Class1 example1 = new Class1();
                num = example1.IfNumPad(Key,num);
                num1 = example1.IfCaps(Key,num1);
                if (num == 0)//NumPad
                {
                    if((GetKeyState(16) == 65408 || GetKeyState(16) == 65409)) // Shift
                    {
                        example1.Shift(Key);    
                    }
                    else
                    {
                        if (num1 != 0)
                        {
                            example1.Caps(Key);
                        }
                        else
                        {
                            example1.Ifer(Key);
                        }
                    }
                }
                else
                {
                    example1.NumPad(Key);
                }
                
            } 
        }
    }
}
