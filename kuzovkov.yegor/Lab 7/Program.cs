using System;

namespace Lab_7_Ind_1
{
    class Program
    {
        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("You can do the following:");
            Console.WriteLine("1. Get a sum of two fractions.");
            Console.WriteLine("2. Get a difference of two fractions.");
            Console.WriteLine("3. Get a product of two fractions.");
            Console.WriteLine("4. Get a division of two fractions.\n");
            Console.WriteLine("You can also do:");
            Console.WriteLine("5. Check if the fractions are equal or not.");
            Console.WriteLine("6. Get a fraction, which is bigger/less.");
            Console.WriteLine("7. Exit.\n");
        }
		
        static void Main(string[] args)
        {
            RationalNumber a, b;

            Console.WriteLine("Hello! Please, enter two numbers for each fraction: ");
            var forNum = int.Parse(Console.ReadLine());
            var forDenum = int.Parse(Console.ReadLine());
            a = new RationalNumber(forNum, forDenum);
            
            Console.WriteLine("Now the same for the second fraction: ");
            forNum = int.Parse(Console.ReadLine());
            forDenum = int.Parse(Console.ReadLine());
            b = new RationalNumber(forNum, forDenum); 
            
            int decision = 0;
            do
            {
                ShowMenu();
                decision = int.Parse(Console.ReadLine());
                switch (decision)
                {
                    case 1:
                    {
                        Console.WriteLine("The result is: {0}\n", (a + b).ToString());
                        break;
                    }

                    case 2:
                    {
                        Console.WriteLine("The result is: {0}\n", (a - b).ToString());
                        break;
                    }

                    case 3:
                    {
                        Console.WriteLine("The result is: {0}\n", (a * b).ToString());
                        break;
                    }

                    case 4:
                    {
                        Console.WriteLine("The result is: {0}\n", (a / b).ToString());
                        break;
                    }

                    case 5:
                    {
                        Console.WriteLine(a.Equals(b));
                        break;
                    }

                    case 6:
                    {
                        if (a > b)
                            Console.WriteLine("The first one ({0}) is bigger.", a.ToString());
                        else if (a < b)
                            Console.WriteLine("The second one ({0}) is bigger.", b.ToString());
                        else
                            Console.WriteLine("Both fractions are equal.");
                        break;
                    }
                    
                    case 7:
                        break;

                    default:
                    {
                        Console.WriteLine("Error.");
                        break;
                    }
                }
                
                Console.ReadKey();
            } while (decision != 7);

            Console.WriteLine("Thank you!");
            Console.ReadKey();
        }
    }
}