using System;
using System.Collections.Generic;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;
            Console.WriteLine("1 - Work with user." +
                "\n2 - Example.");
            choice = Console.ReadKey().KeyChar;
            Console.Clear();

            switch (choice)
            {
                case '1': WorkWithUser(); break;
                case '2': Example(); break;
            }
        }

        static void WorkWithUser()
        {
            Fraction num1 = null, num2 = null;
            bool flag;
            char choice;
            while (true)
            {
                do
                {
                    Console.WriteLine("Enter first fraction\nExamples: 1/2; -0,5; 54");
                    flag = Fraction.TryParse(Console.ReadLine(), out num1);
                } while (!flag);

                do
                {
                    Console.WriteLine("Enter second fraction");
                    flag = Fraction.TryParse(Console.ReadLine(), out num2);
                } while (!flag);

                do
                {
                    Console.WriteLine($"1: {num1} - {num2}" +
                        $"\n2: {num1} + {num2}" +
                        $"\n3: {num1} * {num2}" +
                        $"\n4: {num1} / {num2}" +
                        $"\n5: {num1} == {num2} ?" +
                        $"\n6: {num1} != {num2} ?" +
                        $"\n7: {num1} < {num2} ?" +
                        $"\n8: {num1} > {num2} ?" +
                        $"\n9: {num1} <= {num2} ?" +
                        $"\n0: {num1} >= {num2} ?" +
                        $"\nw: Input again." +
                        $"\nq: Exit.");
                    choice = Console.ReadKey().KeyChar;
                    Console.Clear();

                    switch (choice)
                    {
                        case '1':
                            Console.WriteLine($"{num1} - {num2} = {num1 - num2} = {(double)(num1 - num2)}");
                            break;
                        case '2':
                            Console.WriteLine($"{num1} + {num2} = {num1 + num2} = {(double)(num1 + num2)}");
                            break;
                        case '3':
                            Console.WriteLine($"{num1} * {num2} = {num1 * num2} = {(double)(num1 * num2)}");
                            break;
                        case '4':
                            Console.WriteLine($"{num1} / {num2} = {num1 / num2} = {(double)(num1 / num2)}");
                            break;
                        case '5':
                            Console.WriteLine($"{num1} == {num2} ? {num1 == num2}");
                            break;
                        case '6':
                            Console.WriteLine($"{num1} != {num2} ? {num1 != num2}");
                            break;
                        case '7':
                            Console.WriteLine($"{num1} < {num2} ? {num1 < num2}");
                            break;
                        case '8':
                            Console.WriteLine($"{num1} > {num2} ? {num1 > num2}");
                            break;
                        case '9':
                            Console.WriteLine($"{num1} <= {num2} ? {num1 <= num2}");
                            break;
                        case '0':
                            Console.WriteLine($"{num1} >= {num2} ? {num1 >= num2}");
                            break;
                        case 'q':return;
                    }
                    Console.ReadKey();
                    Console.Clear();
                } while (choice != 'w');
            }
        }

        static void Example()
        {
            Fraction a = new Fraction(5, 13);
            Fraction b = new Fraction(5, 13);
            Fraction c = new Fraction(-5, 13);
            Fraction d = new Fraction(13, 5);
            var list = new List<Fraction>() { a, b, c, d };

            foreach (var num in list)
                Console.WriteLine(num.ToString());
            list.Sort();

            Console.WriteLine("\nSorted nums:");
            foreach (var num in list)
                Console.WriteLine(num.ToString());
            Console.WriteLine();

            Console.WriteLine($"a + b - c = {a + b - c} = {(double)(a + b - c)}");
            Console.WriteLine($"a - b = {a - b} = {(double)(a - b)}");
            Console.WriteLine($"a - d = {a - d} = {(double)(a - d)}");
            Console.WriteLine($"a * b = {a * b} = {(double)(a * b)}");
            Console.WriteLine($"a / b = {a / b} = {(double)(a / b)}");
            Console.WriteLine();

            Console.WriteLine($"d > b ? {d > b}");
            Console.WriteLine($"a < b ? {a < b}");
            Console.WriteLine($"a <= b ? {a <= b}");
            Console.WriteLine($"c >= b ? {c >= b}");
            Console.WriteLine($"a == b ? {a == b}");
            Console.WriteLine($"a == c ? {a == c}");
            Console.WriteLine();

            Console.WriteLine("d = " + d.ToString());
            Console.WriteLine("(int)d = " + ((int)d).ToString());
            Console.WriteLine("(double)d = " + ((double)d).ToString());
        }
    }
}
