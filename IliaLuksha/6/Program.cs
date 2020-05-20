using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Exist()
        {
            Console.WriteLine("Do you want to exist: ");
            Console.WriteLine("(1)Yes   (2)No: ");
            char Key = Console.ReadKey().KeyChar;
            switch (Key)
            {
                case '1': Environment.Exit(0); return 1;
                case '2': return 2;
                default:
                    {
                        Console.WriteLine("You can Enter only 1 or 2");
                        Environment.Exit(0);
                        return 0;
                    }
            }
        }
        static void Main(string[] args)
        {
            int num = 2;
            Plane example1 = new Plane();
            Car example2 = new Car();

            Console.WriteLine($"Change class:");
            Console.WriteLine("(1)Plane     (2)Car");
            char a = Console.ReadKey().KeyChar;
            
            switch (a)
            {
                case '1':
                    {
                        Console.WriteLine("Class Plane:");
                        while (num == 2)
                        {
                            num = Exist();
                            Console.WriteLine("Menu:");
                            Console.WriteLine("(1)Change    (2)Output   (3)comparison");
                            a = Console.ReadKey().KeyChar;
                            switch (a)
                            {
                                case '1':
                                    {
                                        Console.WriteLine("(1)Characteristic   (2)Number Of Passengers   (3)Length   (4)Age   (5)Specialty");
                                        a = Console.ReadKey().KeyChar;
                                        switch (a)
                                        {
                                            case '1':
                                                {
                                                    Console.WriteLine("Enter the Characteristic ");
                                                    example1.Characteristic = Console.ReadLine();
                                                    break;
                                                }
                                            case '2':
                                                {
                                                    Console.WriteLine("Enter the Number Of Passengers ");
                                                    example1.NumberOfPassengers = Convert.ToInt32(Console.ReadLine());
                                                    break;
                                                }
                                            case '3':
                                                {
                                                    Console.WriteLine("Enter the Length ");
                                                    example1.Length = Convert.ToInt32(Console.ReadLine());
                                                    break;
                                                }
                                            case '4':
                                                {
                                                    Console.WriteLine("Enter the Age ");
                                                    example1.Age = Convert.ToInt32(Console.ReadLine());
                                                    break;
                                                }
                                            case '5':
                                                {
                                                    Console.WriteLine("Enter the Specialty ");
                                                    example1.Power = Convert.ToInt32(Console.ReadLine());
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("You can Enter only  numbers from 1 to 5");
                                                    Environment.Exit(0);
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case '2':
                                    {
                                        Console.WriteLine("Do you want to see result?");
                                        Console.WriteLine("(1)Yes   (2)No: ");
                                        a = Console.ReadKey().KeyChar;
                                        switch (a)
                                        {
                                            case '1':
                                                {
                                                    example1.Cout();
                                                    break;
                                                }
                                            case '2': break;
                                            default:
                                                {
                                                    Console.WriteLine("You can Enter only 1 or 2");
                                                    Environment.Exit(0);
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case '3':
                                    {
                                        int c = example1.CompareTo(example2);
                                        switch (c)
                                        {
                                            case 1:
                                                {
                                                    Console.WriteLine("Plane is heavier then Car");
                                                    break;
                                                }
                                            case -1:
                                                {
                                                    Console.WriteLine("Car is heavier then Plane");
                                                    break;
                                                }
                                            case 0:
                                                {
                                                    Console.WriteLine("The Plane is the same weight as the Car");
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("Functoin error");
                                                    Environment.Exit(0);
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("You can Enter only 1, 2 or 3");
                                        Environment.Exit(0);
                                        break;
                                    }
                            }

                        }

                        break;
                    }
                case '2':
                    {
                        num = Exist();
                        Console.WriteLine("Class Car:");
                        while (num == 2)
                        {
                            Console.WriteLine("Menu:");
                            Console.WriteLine("(1)Change    (2)Output   (3)The power factor of the motor    (4)comparison");
                            a = Console.ReadKey().KeyChar;
                            switch (a)
                            {
                                case '1':
                                    {
                                        Console.WriteLine("(1)Characteristic   (2)Number Of Passengers   (3)Age   (4)Specialty  (5)Tank Volume");
                                        a = Console.ReadKey().KeyChar;
                                        switch (a)
                                        {
                                            case '1':
                                                {
                                                    Console.WriteLine("Enter the Characteristic ");
                                                    example2.Characteristic = Console.ReadLine();
                                                    break;
                                                }
                                            case '2':
                                                {
                                                    Console.WriteLine("Enter the Number Of Passengers ");
                                                    example2.NumberOfPassengers = Convert.ToInt32(Console.ReadLine());
                                                    break;
                                                }
                                            case '3':
                                                {
                                                    Console.WriteLine("Enter the Age ");
                                                    example2.Age = Convert.ToInt32(Console.ReadLine());
                                                    break;
                                                }
                                            case '4':
                                                {
                                                    Console.WriteLine("Enter the Specialty ");
                                                    example2.Power = Convert.ToInt32(Console.ReadLine());
                                                    break;
                                                }
                                            case '5':
                                                {
                                                    Console.WriteLine("Enter the Tank Volume ");
                                                    example2.TankVolume = Convert.ToInt32(Console.ReadLine());
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("You can Enter only  numbers from 1 to 5");
                                                    Environment.Exit(0);
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case '2':
                                    {
                                        Console.WriteLine("Do you want to see result?");
                                        Console.WriteLine("(1)Yes   (2)No: ");
                                        a = Console.ReadKey().KeyChar;
                                        switch (a)
                                        {
                                            case '1':
                                                {
                                                    example2.Cout();
                                                    break;
                                                }
                                            case '2': break;
                                            default:
                                                {
                                                    Console.WriteLine("You can Enter only 1 or 2");
                                                    Environment.Exit(0);
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case '3':
                                    {
                                        Console.WriteLine("The power factor of the motor");
                                        Console.WriteLine("Do you want to see result?");
                                        Console.WriteLine("(1)Yes   (2)No: ");
                                        a = Console.ReadKey().KeyChar;
                                        switch (a)
                                        {
                                            case '1':
                                                {
                                                    example2.PowerFactor();
                                                    break;
                                                }
                                            case '2': break;
                                            default:
                                                {
                                                    Console.WriteLine("You can Enter only 1 or 2");
                                                    Environment.Exit(0);
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case '4':
                                    {
                                        int c = example2.CompareTo(example1);
                                        switch (c)
                                        {
                                            case 1:
                                                {
                                                    Console.WriteLine("Car is heavier then Plane");
                                                    break;
                                                }
                                            case -1:
                                                {
                                                    Console.WriteLine("Plane is heavier then Car");
                                                    break;
                                                }
                                            case 0:
                                                {
                                                    Console.WriteLine("The Plane is the same weight as the Car");
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("Functoin error");
                                                    Environment.Exit(0);
                                                    break;
                                                }

                                        }
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("You can Enter only 1 2 3 or 4");
                                        Environment.Exit(0);
                                        break;
                                    }
                            }
                        }
                        
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Change enter is not correct");
                        Environment.Exit(0);
                        break;
                    }
            }
        }
    }
}
