using System;
using System.Runtime.InteropServices;
using static System.Console;

namespace ConsoleApp6
{
    class Program
    {
        [DllImport(@"C:\Users\Danila\source\repos\Dll1\Debug\Dll1.dll")]

        public static extern int Square(int a);
        static void Main(string[] args)
        {
            Write("Write a = ");
            WriteLine("a^2 = {0}", Square(int.Parse(ReadLine())));
            ReadKey();
        }
    }
}
