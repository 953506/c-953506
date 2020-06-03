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

            Console.WriteLine("Enter type of delimeter you want to use");
            RationalNums.delimeter = Console.ReadLine();

            Console.WriteLine(RationalNums.multiply(a1.numerator, a1.denominator, a2.numerator, a2.denominator));
            Console.WriteLine(RationalNums.divide(a1.numerator, a1.denominator, a2.numerator, a2.denominator));
            Console.WriteLine(RationalNums.plus(a1.numerator, a1.denominator, a2.numerator, a2.denominator));
            Console.WriteLine(RationalNums.minus(a1.numerator, a1.denominator, a2.numerator, a2.denominator));
            Console.WriteLine(RationalNums.compare(a1.numerator, a1.denominator, a2.numerator, a2.denominator));
            Console.WriteLine($"\nIComparable realization: { a1.CompareTo(a2)}\n");

            RationalNums a3 = new RationalNums(1, 4);
            double x = (double)a3;
            Console.WriteLine($"Explisit conversion: {x}");

            x *= 2;
            a3 = Convert.ToString(x);
            Console.WriteLine($"Implicit conversion: {a3.numerator} / {a3.denominator}");
        }
    }
}
