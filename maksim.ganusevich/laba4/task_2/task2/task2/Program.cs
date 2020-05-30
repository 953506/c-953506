using System;
using System.Runtime.InteropServices;

namespace task2
{
    class Program
    {
        [DllImport("D:\\C#\\laba4\\task_2\\task2\\task2\\bin\\Debug\\netcoreapp3.1\\Figure.dll")]
        public extern static double circle(float side, ushort parameterNumber);
        [DllImport("D:\\C#\\laba4\\task_2\\task2\\task2\\bin\\Debug\\netcoreapp3.1\\Figure.dll")]
        public extern static double square(float side, ushort parameterNumber);
        [DllImport("D:\\C#\\laba4\\task_2\\task2\\task2\\bin\\Debug\\netcoreapp3.1\\Figure.dll")]
        public extern static double triangle(float side, ushort parameterNumber);
        [DllImport("D:\\C#\\laba4\\task_2\\task2\\task2\\bin\\Debug\\netcoreapp3.1\\Figure.dll")]
        public extern static double hexagon(float side, ushort parameterNumber);

        static void Main(string[] args)
        {
            uint value=0;
            bool check = true;
            while (check)
            {
                Console.WriteLine(@"
What shape do you want to know?
            
1. Circle
2. Square
3. Triangle
4. Hexagon
5. Exit");

                ushort parameter = Convert.ToUInt16(Console.ReadLine());
                if (parameter < 5)
                {
                    Console.WriteLine("Enter " + (parameter == 1 ? "radius" : "side"));
                    value = Convert.ToUInt32(Console.ReadLine());
                }
                switch (parameter)
                {
                    case 1:
                        Console.WriteLine($@"
diameter:{circle(value, 1)}
perimeter:{circle(value, 2)}
area:{circle(value, 3)}");
                        break;
                    case 2:
                        Console.WriteLine($@"
diagonal:{square(value, 1)}
perimeter:{square(value, 2)}
area:{square(value, 3)}"); break;
                    case 3:
                        Console.WriteLine($@"
height:{triangle(value, 1)}
perimeter:{triangle(value, 2)}
area:{triangle(value, 3)}"); break;
                    case 4:
                        Console.WriteLine($@"
diagonal:{hexagon(value, 1)}
perimeter:{hexagon(value, 2)}
area:{hexagon(value, 3)}"); break;
                    case 5:
                        check = false;
                        break;
                }
            }
        }
    }
}
