using System;
using System.Runtime.InteropServices;

namespace UsingLib
{
    class Program
    {
        [DllImport("C:\\Users\\Admin\\Desktop\\lib\\library\\Debug\\library.dll")]
        public static extern double SquareRect(double Side1, double Side2);

        [DllImport("C:\\Users\\Admin\\Desktop\\lib\\library\\Debug\\library.dll")]
        public static extern double SquareTr(double Side, double Height);

        static void Main(string[] args)
        {
            Console.WriteLine("Enter side 1 for rectangle: ");
            double side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side 2 for rectangle: ");
            double side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side for triangle: ");
            double side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height for triangle: ");
            double height = Convert.ToInt32(Console.ReadLine());

            double Square = SquareRect(side1, side2);
            double SquareTriangle = SquareTr(side, height);

            Console.WriteLine($" Square of Triangle = {SquareTriangle}");
            Console.WriteLine($" Square of Rectangle = {Square}");

            Console.ReadKey();
        }
    }
}
