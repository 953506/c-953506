using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number (in format a / b or a,bc...):");
            string input = Console.ReadLine();
            RationalNums a1 = new RationalNums(input);

            Console.WriteLine("Enter second number, formats are same:");
            string input2 = Console.ReadLine();
            RationalNums a2 = new RationalNums(input2);
            RationalNums res;

            Console.WriteLine("Enter type of delimeter you want to use");
            RationalNums.delimeter = Console.ReadLine();

            res = a1 * a2;
            Console.WriteLine($"{res.numerator}{RationalNums.delimeter}{res.denominator}"); 
            res = a1 / a2;
            Console.WriteLine($"{res.numerator}{RationalNums.delimeter}{res.denominator}");
            res = a1 + a2;
            Console.WriteLine($"{res.numerator}{RationalNums.delimeter}{res.denominator}");
            res = a1 - a2;
            Console.WriteLine($"{res.numerator}{RationalNums.delimeter}{res.denominator}");
            if (a1 == a2)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine("Numbers are not equal");
            }

            RationalNums a3 = new RationalNums(1, 4);
            double x = (double)a3;
            Console.WriteLine($"Explisit conversion: {x}");

            x *= 2;
            a3 = Convert.ToString(x);
            Console.WriteLine($"Implicit conversion: {a3.numerator} / {a3.denominator}");  
        }
    }
}
