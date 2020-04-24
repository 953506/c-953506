using System;
using System.Runtime.InteropServices;

namespace Laba4
{
    class Program
    {
        [DllImport("D:\\LabsCSharp\\Lab 4\\Lab 4.2\\MathDLL\\Debug\\MathDLL.dll")]
        public static extern double Add(double var_x, double var_y);
        public static extern double Subtract(double var_x, double var_y);
        public static extern double Compose(double var_x, double var_y);
        public static extern double Divide(double var_x, double var_y);

        static void Main(string[] args)
        {
            double x = 30.5, y = 0.5;
            double result = 0;
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                {
                    result = Add(x, y);
                    break;
                }

                case 2:
                {
                    result = Subtract(x, y);
                    break;
                }

                case 3:
                {
                    result = Compose(x, y);
                    break;
                }

                case 4:
                {
                    result = Divide(x, y);
                    break;
                }

                default:
                {
                    result = 0;
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
