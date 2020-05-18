using System;
using System.Collections;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            ArrayList numbers = new ArrayList();
            while (true)
            {
                RationalNumber r1, r2, result;
                Console.WriteLine("Write two rational numbers in one of these formats: " +
                    "\na/b" +
                    "\na,bcd...");
                Console.Write("\n\nThe first one: ");
                if(!RationalNumber.Extraction(Console.ReadLine(), out r1))
                {
                    Console.WriteLine("Error. Wrong input");
                    break;
                }
                numbers.Add(r1);
                Console.Write("The second: ");
                if (!RationalNumber.Extraction(Console.ReadLine(), out r2))
                {
                    Console.WriteLine("Error. Wrong input");
                    break;
                }
                numbers.Add(r2);
                Console.Clear();
                Console.WriteLine("What do you want to do?" +
                    "\n1.Add one to another" +
                    "\n2.Substract one from another" +
                    "\n3.Multiply these numbers" +
                    "\n4.Divide one by another" +
                    "\n5.Compare these numbers" +
                    "\n6.Convert to int and double" +
                    "\n7.Sort all entered numbers" +
                    "\n9.Exit the program");
                int K;
                if(!Int32.TryParse(Console.ReadLine(), out K))
                {
                    Console.WriteLine("Error. Wrong input");
                    break;
                }
                Console.Clear();
                switch(K)
                {
                    case 1:
                        {
                            result = r1 + r2;
                            Console.WriteLine(result.ToStringFormat1());
                            Console.WriteLine(result.ToStringFormat2());
                            break;
                        }
                    case 2:
                        {
                            result = r1 - r2;
                            Console.WriteLine(result.ToStringFormat1());
                            Console.WriteLine(result.ToStringFormat2());
                            break;
                        }
                    case 3:
                        {
                            result = r1 * r2;
                            Console.WriteLine(result.ToStringFormat1());
                            Console.WriteLine(result.ToStringFormat2());
                            break;
                        }
                    case 4:
                        {
                            result = r1 / r2;
                            Console.WriteLine(result.ToStringFormat1());
                            Console.WriteLine(result.ToStringFormat2());
                            break;
                        }
                    case 5:
                        {
                            if(r1 > r2)
                            {
                                Console.WriteLine($"{r1.ToStringFormat1()} > {r2.ToStringFormat1()}" +
                                    $"\n{r1.ToStringFormat2()} > {r2.ToStringFormat2()}");
                            }
                            if(r1 >= r2)
                            {
                                Console.WriteLine($"{r1.ToStringFormat1()} >= {r2.ToStringFormat1()}" +
                                    $"\n{r1.ToStringFormat2()} >= {r2.ToStringFormat2()}");
                            }
                            if(r1 < r2)
                            {
                                Console.WriteLine($"{r1.ToStringFormat1()} < {r2.ToStringFormat1()}" +
                                    $"\n{r1.ToStringFormat2()} < {r2.ToStringFormat2()}");
                            }
                            if(r1 <= r2)
                            {
                                Console.WriteLine($"{r1.ToStringFormat1()} <= {r2.ToStringFormat1()}" +
                                    $"\n{r1.ToStringFormat2()} <= {r2.ToStringFormat2()}");
                            }
                            if (r1 == r2)
                            {
                                Console.WriteLine($"{r1.ToStringFormat1()} = {r2.ToStringFormat1()}" +
                                    $"\n{r1.ToStringFormat2()} = {r2.ToStringFormat2()}");
                            }
                            if (r1 != r2)
                            {
                                Console.WriteLine($"{r1.ToStringFormat1()} != {r2.ToStringFormat1()}" +
                                    $"\n{r1.ToStringFormat2()} != {r2.ToStringFormat2()}");
                            }
                            break;
                        }
                    case 6:
                        {
                            int a = r1, b = r2;
                            Console.WriteLine($"r1 int : {a}" +
                                $"\nr1 double : {(double)r1}" +
                                $"\nr2 int : {b}" +
                                $"\nr2 double : {(double)r2}");
                            break;
                        }
                    case 7:
                        {
                            numbers.Sort();
                            foreach (RationalNumber r in numbers)
                            {
                                Console.WriteLine($"{r.ToStringFormat2()}");
                            }
                            break;
                        }
                    case 9:
                        {
                            exit = true;
                            break;
                        }
                }
                if(exit)
                {
                    break;
                }
                Console.WriteLine("Press any key to return...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
