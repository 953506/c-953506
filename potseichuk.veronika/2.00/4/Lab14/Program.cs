using System;
using System.Runtime.InteropServices;

namespace Lib14
{
    class Program
    {
        [DllImport("C:\\Users\\Nika\\source\\repos\\Lib14\\Debug\\Lib14.dll")]
        public static extern double Circumference(double radius);
        public static extern double CircleArea(double radius);
		

        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Circumference:");
            Console.WriteLine(Circumference(radius));            
			Console.WriteLine("CircleArea:");
            Console.WriteLine(CircleArea(radius));
        }
    }
}