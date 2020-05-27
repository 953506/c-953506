using System;
using System.Collections;
using System.ComponentModel.Design;

namespace lr7
{
    class Program
    {

        static void Main(string[] args)
        {
            RationalNumber num1, num2, result;
            ArrayList numbers = new ArrayList();
            string input;
            Console.WriteLine("input format" +
                "\n a/b" +
                "\n a b" +
                "\n a is an integer" +
                "\n b is a natural namber");
            Console.WriteLine("first number");
            input = Console.ReadLine();
            RationalNumber.Initialization(input,out num1);
            Console.WriteLine("second number");
            input = Console.ReadLine();
            RationalNumber.Initialization(input, out num2);
            int menu;
            Menu();
            while (!Int32.TryParse(Console.ReadLine(), out menu))
                Console.WriteLine("incorrect input");
            while(true)
            {
                if(menu==1)
                {
                    Console.Clear();
                    result = num1 + num2;
                    Console.WriteLine(RationalNumber.ToStringIrreducible(result));
                    Console.WriteLine(RationalNumber.ToString(result));
                    numbers.Add(result);
                }
                if (menu==2)
                {
                    Console.Clear();
                    result = num1 - num2;
                    Console.WriteLine(RationalNumber.ToStringIrreducible(result));
                    Console.WriteLine(RationalNumber.ToString(result));
                    numbers.Add(result);
                }
                if (menu==3)
                {
                    Console.Clear();
                    result = num1 * num2;
                    Console.WriteLine(RationalNumber.ToStringIrreducible(result));
                    Console.WriteLine(RationalNumber.ToString(result));
                    numbers.Add(result);
                }
                if (menu==4)
                {
                    Console.Clear();
                    result = num1 / num2;
                    Console.WriteLine(RationalNumber.ToStringIrreducible(result));
                    Console.WriteLine(RationalNumber.ToString(result));
                    numbers.Add(result);
                }
                if(menu==5)
                {
                    Console.Clear();
                    if (num1 > num2)
                        Console.WriteLine(RationalNumber.ToString(num1) + ">"+ RationalNumber.ToString(num2));
                    if (num1 <num2)
                        Console.WriteLine(RationalNumber.ToString(num1) + "<" + RationalNumber.ToString(num2));
                    if (num1 == num2)
                        Console.WriteLine(RationalNumber.ToString(num1) + "=" + RationalNumber.ToString(num2));
                    if (num1 != num2)
                        Console.WriteLine(RationalNumber.ToString(num1) + "!=" + RationalNumber.ToString(num2));
                    if (num1 <= num2)
                        Console.WriteLine(RationalNumber.ToString(num1) + "<=" + RationalNumber.ToString(num2));
                    if (num1 >=num2)
                        Console.WriteLine(RationalNumber.ToString(num1) + ">=" + RationalNumber.ToString(num2));
                }
                if(menu==6)
                {
                    Console.Clear();
                    double implis1 = num1, implis2 = num2;
                    int expl1 = (int)num1, expl2 = (int)num2;
                    Console.WriteLine($"double(num1)={implis1};   double(num2)={implis2}");
                    Console.WriteLine($"   int(num1)={expl1};        int(num2)={expl2}");
                }
                if(menu==7)
                {
                    Console.Clear();
                    numbers.Sort();
                    foreach(RationalNumber o in numbers )
                    {
                        double a = o;
                        Console.WriteLine(a);
                    }
                }
                if(menu==8)
                {
                    Console.Clear();
                    Console.WriteLine("program completed");
                    Environment.Exit(1);
                }
                Menu();
                while (!Int32.TryParse(Console.ReadLine(), out menu))
                    Console.WriteLine("incorrect input");
            }               
        }

        public static void Menu()
        {
            Console.WriteLine("1.Sum" +
                "\n2.Residual" +
                "\n3.Multiplication" +
                "\n4.Division" +
                "\n5.Compare" +
                "\n6.ToInt ToDouble" +
                "\n7.Sorting" +
                "\n8.Exit");              
        }        
    }
}
