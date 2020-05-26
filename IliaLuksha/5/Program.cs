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
        static int Exist()
        {
            Console.WriteLine("Do you want to exist: ");
            Console.WriteLine("(1)Yes   (2)No: ");
            char Key = Console.ReadKey().KeyChar;
            switch (Key)
            {
                case '1': Environment.Exit(0); return 1;
                case '2':  return 2;
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
            int ifer = 0, num = 2;
            Student example1 = new Student();
            Console.WriteLine("Human::Student::StudentIITP::StudentIITP1");
            Console.WriteLine("Choose one of the classes :");
            Console.WriteLine("(1)Student   (2)StudentIITP  (3)StudentIITP1:");
            Key = Console.ReadKey().KeyChar;
            switch (Key)
            {
                case '1': 
                    {
                        Console.WriteLine("Class Student: ");
                        
                           while(num == 2)
                           {
                                num = Exist();
                                Console.WriteLine("Menu: ");
                                Console.WriteLine("(1)Change    (2)output   (3)Task option in the lab");
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
                                                Console.WriteLine("(1)age   (2)group   (3)course   (4)faculty   (5)specialty   (6)number    (7)name");
                                                Key = Console.ReadKey().KeyChar;
                                                switch (Key)
                                                {
                                                    case '1':
                                                        {
                                                            Console.WriteLine("Enter the Age ");
                                                            example1.IfAge = Convert.ToInt32(Console.ReadLine());
                                                            break;
                                                        }
                                                    case '2':
                                                        {
                                                            Console.WriteLine("Enter the Group ");
                                                            example1.Group = Convert.ToInt32(Console.ReadLine());
                                                            break;
                                                        }
                                                    case '3':
                                                        {
                                                            Console.WriteLine("Enter the Сourse ");
                                                            example1.Сourse = Convert.ToInt32(Console.ReadLine());
                                                            break;
                                                        }
                                                    case '4':
                                                        {
                                                            Console.WriteLine("Enter the Faculty ");
                                                            example1.Faculty = Console.ReadLine();
                                                            break;
                                                        }
                                                    case '5':
                                                        {
                                                            Console.WriteLine("Enter the Specialty ");
                                                            example1.Specialty = Console.ReadLine();
                                                            break;
                                                        }
                                                    case '6':
                                                        {
                                                            Console.WriteLine("Enter the Number ");
                                                            example1.Number = Console.ReadLine();
                                                            break;
                                                        }
                                                    case '7':
                                                        {
                                                        //реализация наследования(2)
                                                        Console.WriteLine("Enter the Name ");
                                                            example1.Name = Console.ReadLine();
                                                            break;
                                                        }
                                                default:
                                                        {
                                                            Console.WriteLine("You can Enter only  numbers from 1 to 7");
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
                           }                       
                           
                        break;
                    } 
                case '2':
                    {
                        example1 = new StudentIITP();
                        Console.WriteLine("Class StudentIITP: ");
                        while (num == 2)
                        {
                            num = Exist();
                            Console.WriteLine("Menu: ");
                            Console.WriteLine("(1)Change    (2)output   (3)Task option in the lab");
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
                                            Console.WriteLine("(1)age   (2)group   (3)course   (4)faculty   (5)specialty   (6)number     (7)name");
                                            Key = Console.ReadKey().KeyChar;
                                            switch (Key)
                                            {
                                                case '1':
                                                    {
                                                        Console.WriteLine("Enter the Age ");
                                                        example1.IfAge = Convert.ToInt32(Console.ReadLine());
                                                        break;
                                                    }
                                                case '2':
                                                    {
                                                        Console.WriteLine("Enter the Group ");
                                                        example1.Group = Convert.ToInt32(Console.ReadLine());
                                                        break;
                                                    }
                                                case '3':
                                                    {
                                                        Console.WriteLine("Enter the Сourse ");
                                                        example1.Сourse = Convert.ToInt32(Console.ReadLine());
                                                        break;
                                                    }
                                                case '4':
                                                    {
                                                        Console.WriteLine("Enter the Faculty ");
                                                        example1.Faculty = Console.ReadLine();
                                                        break;
                                                    }
                                                case '5':
                                                    {
                                                        Console.WriteLine("Enter the Specialty ");
                                                        example1.Specialty = Console.ReadLine();
                                                        break;
                                                    }
                                                case '6':
                                                    {
                                                        Console.WriteLine("Enter the Number ");
                                                        example1.Number = Console.ReadLine();
                                                        break;
                                                    }
                                                case '7':
                                                    {
                                                        Console.WriteLine("Enter the Name ");
                                                        example1.Name = Console.ReadLine();
                                                        break;
                                                    }
                                                default:
                                                    {
                                                        Console.WriteLine("You can Enter only  numbers from 1 to 7");
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
                                        Console.WriteLine("Enter number of the student: ");
                                        string a;
                                        a = Console.ReadLine();
                                        example1.Option(a);
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
                case '3': 
                    {
                       example1 = new StudentIITP1();
                        Console.WriteLine("Class StudentIITP1: ");
                        while (num == 2)
                        {
                            num = Exist();
                            Console.WriteLine("Menu: ");
                            Console.WriteLine("(1)Change    (2)output   (3)Task option in the lab   (4)Enter Marks");
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
                                            Console.WriteLine("(1)age   (2)group   (3)course   (4)faculty   (5)specialty   (6)number     (7)name");
                                            Key = Console.ReadKey().KeyChar;
                                            switch (Key)
                                            {
                                                case '1':
                                                    {
                                                        Console.WriteLine("Enter the Age ");
                                                        example1.IfAge = Convert.ToInt32(Console.ReadLine());
                                                        break;
                                                    }
                                                case '2':
                                                    {
                                                        Console.WriteLine("Enter the Group ");
                                                        example1.Group = Convert.ToInt32(Console.ReadLine());
                                                        break;
                                                    }
                                                case '3':
                                                    {
                                                        Console.WriteLine("Enter the Сourse ");
                                                        example1.Сourse = Convert.ToInt32(Console.ReadLine());
                                                        break;
                                                    }
                                                case '4':
                                                    {
                                                        Console.WriteLine("Enter the Faculty ");
                                                        example1.Faculty = Console.ReadLine();
                                                        break;
                                                    }
                                                case '5':
                                                    {
                                                        Console.WriteLine("Enter the Specialty ");
                                                        example1.Specialty = Console.ReadLine();
                                                        break;
                                                    }
                                                case '6':
                                                    {
                                                        Console.WriteLine("Enter the Number ");
                                                        example1.Number = Console.ReadLine();
                                                        break;
                                                    }
                                                case '7':
                                                    {
                                                        Console.WriteLine("Enter the Name ");
                                                        example1.Name = Console.ReadLine();
                                                        break;
                                                    }
                                                default:
                                                    {
                                                        Console.WriteLine("You can Enter only  numbers from 1 to 7");
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
                                        Console.WriteLine("Enter number of the student: ");
                                        string a;
                                        a = Console.ReadLine();
                                        example1.Option(a);
                                        break;
                                    }
                                case '4':
                                    {
                                        example1.Cout();
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
