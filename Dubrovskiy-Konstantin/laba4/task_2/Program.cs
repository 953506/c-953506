using System;
using System.Runtime.InteropServices;

namespace ConsoleApp7
{
    class Program
    {
        [DllImport("C:\\work\\sharp\\Dubrovskiy-Konstantin\\laba4\\task2\\MyLib\\Win32\\Debug\\MyLib.dll")]
        public extern static double Sum(double a, double b);

        [DllImport("C:\\work\\sharp\\Dubrovskiy-Konstantin\\laba4\\task2\\MyLib\\Win32\\Debug\\MyLib.dll")]
        public extern static double Sub(double a, double b);

        [DllImport("C:\\work\\sharp\\Dubrovskiy-Konstantin\\laba4\\task2\\MyLib\\Win32\\Debug\\MyLib.dll")]
        public extern static double Mult(double a, double b);

        [DllImport("C:\\work\\sharp\\Dubrovskiy-Konstantin\\laba4\\task2\\MyLib\\Win32\\Debug\\MyLib.dll")]
        public extern static double Div(double a, double b);

        static void Main()
        {
            double a, b;

            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("a + b = " + Sum(a,b).ToString());
            Console.WriteLine("a - b = " + Sub(a, b).ToString());
            Console.WriteLine("a * b = " + Mult(a, b).ToString());
            Console.WriteLine("a / b = " + Div(a, b).ToString());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
