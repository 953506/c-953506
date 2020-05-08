using System;
using System.Runtime.InteropServices;


namespace _4._2_Fin_
{
    class AlgebraClass
    {
        [DllImport("C:\\Users\\TommyWiseau\\Desktop\\lab4\\ind2\\Dll1\\Debug\\Dll1.dll")]
        public static extern double Add(double _x, double _y);

        [DllImport("C:\\Users\\TommyWiseau\\Desktop\\lab4\\ind2\\Dll1\\Debug\\Dll1.dll")]
        public static extern double Sub(double _x, double _y);

        [DllImport("C:\\Users\\TommyWiseau\\Desktop\\lab4\\ind2\\Dll1\\Debug\\Dll1.dll")]
        public static extern double Multiply(double _x, double _y);

        [DllImport("C:\\Users\\TommyWiseau\\Desktop\\lab4\\ind2\\Dll1\\Debug\\Dll1.dll")]
        public static extern double Divide(double _x, double _y);

        static void Main()
        {
            double x = 8, y = 4;
            double result ;
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        result = Add(x, y);
                        break;
                    }

                case 2:
                    {
                        result = Sub(x, y);
                        break;
                    }

                case 3:
                    {
                        result = Multiply(x, y);
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
            Console.ReadLine();
        }
    }
}