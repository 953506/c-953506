using System;
using static System.Console;
using System.Runtime.InteropServices;

namespace LB4._2
{
    class Program
    {
        [DllImport(@"C:\Users\Home\source\repos\MyLib\Debug\MyLib.dll")]
        public static extern int Add(int a, int b);
        [DllImport(@"C:\Users\Home\source\repos\MyLib\Debug\MyLib.dll")]
        public static extern int Sub(int a, int b);
        [DllImport(@"C:\Users\Home\source\repos\MyLib\Debug\MyLib.dll")]
        public static extern int Mult(int a, int b);
        [DllImport(@"C:\Users\Home\source\repos\MyLib\Debug\MyLib.dll")]
        public static extern int Div(int a, int b);
        [DllImport(@"C:\Users\Home\source\repos\MyLib\Debug\MyLib.dll")]
        public static extern int Power(int a, int b);
        static void Main()
        {
            WriteLine("Введите два числа подряд");
            int a = int.Parse(ReadLine()), b = int.Parse(ReadLine());
            WriteLine(" Сумма = {0}\n Вычитание = {1}\n Умножение = {2}\n Деление = {3}\n a в степени b = {4}",Add(a, b), Sub(a, b), Mult(a, b), Div(a, b), Power(a, b));
            ReadKey();
        }
    }
}
