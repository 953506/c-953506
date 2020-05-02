using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       static int  Ifer()
        {
            Console.WriteLine("Do you want to change something?: ");
            Console.WriteLine("(1)Yes   (2)No: ");
            char Key = Console.ReadKey().KeyChar;
            switch (Key)
            {
                case '1': return 1;
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
            char Key;
            int ifer = 0;
            
       
            Console.WriteLine("Human::Student::StudentIITP::StudentIITP1");
            Console.WriteLine("Choose one of the classes :");
            Console.WriteLine("(1)Student   (2)StudentIITP  (3)StudentIITP1:");
            Key = Console.ReadKey().KeyChar;
            switch (Key)
            {
                case '1': 
                    {
                        Student example1 = new Student();
                        Console.WriteLine("Class Student: ");
                        Console.WriteLine("Menu: ");
                        Console.WriteLine("(1)Change    (2)output   (3)Task option in the lab ");
                        Key = Console.ReadKey().KeyChar;
                        switch (Key)
                        {
                            case '1':
                                {
                                    Key = Console.ReadKey().KeyChar;
                                    ifer = Ifer();
                                    if (ifer == 1)
                                    {
                                        Console.WriteLine("What do you want to change?: ");
                                        Console.WriteLine("(1)age   (2)group   (3)course   (4)faculty   (5)specialty   (6)number");
                                        Key = Console.ReadKey().KeyChar;
                                        switch (Key)
                                        {
                                            case '1':
                                                {
                                                    example1.IfAge = Convert.ToInt32(Console.ReadLine());
                                                    break;
                                                }
                                            case '2':
                                                {
                                                    example1.Group = Convert.ToInt32(Console.ReadLine());
                                                    break;
                                                }
                                            case '3':
                                                {
                                                    example1.Сourse = Convert.ToInt32(Console.ReadLine());
                                                    break;
                                                }
                                            case '4':
                                                {
                                                    example1.Faculty = Console.ReadLine();
                                                    break;
                                                }
                                            case '5':
                                                {
                                                    example1.Specialty = Console.ReadLine();
                                                    break;
                                                }
                                            case '6':
                                                {
                                                    example1.Number = Console.ReadLine();
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("You can Enter only  numbers from 1 to 6");
                                                    Environment.Exit(0);
                                                    break;
                                                }
                                        }                                       
                                    }
                                    break;
                                }
                            case '2':
                                {
                                    Console.WriteLine("Do you want to see result?");
                                    Console.WriteLine("(1)Yes   (2)No: ");
                                    Key = Console.ReadKey().KeyChar;
                                    switch (Key)
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
                                    example1.Option("Second");
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("You can Enter only 1 2 or 3");
                                    Environment.Exit(0);
                                    break;
                                }
                        }
                        break;
                    } 
                case '2':
                    {
                        StudentIITP example2 = new StudentIITP();
                        Console.WriteLine("Class StudentIITP: ");
                        Console.WriteLine("Menu: ");
                        Console.WriteLine("(1)Change    (2)output");
                        Key = Console.ReadKey().KeyChar;
                        switch (Key)
                        {
                            case '1':
                                {
                                    Key = Console.ReadKey().KeyChar;
                                    ifer = Ifer();
                                    if (ifer == 1)
                                    {
                                        Console.WriteLine("What do you want to change?: ");
                                        Console.WriteLine("(1)age   (2)group   (3)course   (4)faculty   (5)specialty   (6)number");
                                        Key = Console.ReadKey().KeyChar;
                                        switch (Key)
                                        {
                                            case '1':
                                                {
                                                    example2.IfAge = Convert.ToInt32(Console.ReadLine());
                                                    break;
                                                }
                                            case '2':
                                                {
                                                    example2.Group = Convert.ToInt32(Console.ReadLine());
                                                    break;
                                                }
                                            case '3':
                                                {
                                                    example2.Сourse = Convert.ToInt32(Console.ReadLine());
                                                    break;
                                                }
                                            case '4':
                                                {
                                                    example2.Faculty = Console.ReadLine();
                                                    break;
                                                }
                                            case '5':
                                                {
                                                    example2.Specialty = Console.ReadLine();
                                                    break;
                                                }
                                            case '6':
                                                {
                                                    example2.Number = Console.ReadLine();
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("You can Enter only  numbers from 1 to 6");
                                                    Environment.Exit(0);
                                                    break;
                                                }
                                        }
                                    }
                                    break;
                                }
                            case '2':
                                {
                                    Console.WriteLine("Do you want to see result?");
                                    Console.WriteLine("(1)Yes   (2)No: ");
                                    Key = Console.ReadKey().KeyChar;
                                    switch (Key)
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
                        StudentIITP1 example3 = new StudentIITP1();
                        Console.WriteLine("Class StudentIITP1: ");
                        example3.Cout();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You can Enter only 1 2 or 3");
                        Environment.Exit(0);
                        break;
                    }
            }

        }
    }
}
