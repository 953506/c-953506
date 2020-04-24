using System;
using System.Runtime.InteropServices;


namespace _4._2_Fin_
{
    class AlgebraClass
    {
       [DllImport("D:\\labolotornaya\\ISP(C#)\\lab4\\Dll1\\Debug\\Dll1")]
        public static extern double Addition(double _x, double _y);
        public static extern double deduction(double _x, double _y);
        public static extern double multiplication(double _x, double _y);
        public static extern double Divide(double _x, double _y);

        static void Main(string[] args)
        {
            double x = 8, y = 4;
            double result = 0;
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        result = Addition(x, y);
                        break;
                    }

                case 2:
                    {
                        result = deduction(x, y);
                        break;
                    }

                case 3:
                    {
                        result = multiplication(x, y);
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
