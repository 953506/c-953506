using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random x = new Random();
            int first = x.Next(1, 101);
            int second = x.Next(1, 101);
            Console.WriteLine($"{first}   {second}");
            double result = MyProj.Add(first, second);
            Console.WriteLine($"Add:{result}");
            result = MyProj.Subtract(first, second);
            Console.WriteLine($"Subtract:{result}");
            result = MyProj.Multiply(first, second);
            Console.WriteLine($"Multiply:{result}");
            result = MyProj.Divide(first, second);
            Console.WriteLine($"Divide:{result}");
            Console.ReadLine();
        }
    }
}
