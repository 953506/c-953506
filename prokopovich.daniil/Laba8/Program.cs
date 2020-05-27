using System;

namespace Lab8
{
    class Program
    {
        //Делегат и событие, связанные с выводом сообщения
        public delegate void Messager(string message);
        public static event Messager Notify;
        
        static void Main(string[] args)
        {
            //Анонимный метод для работы с делегатом
            Messager messager =  message => Console.WriteLine(message);
            char choice;
            string name = "", surname = "", gender = "", selectedClass = "none";
            int birth_year;
            Human sportsman = new Sportsman();

            do
            {
                if (selectedClass == "none")
                {
                    Console.WriteLine("1 - Create Sportsman\n2 - Create Footballer\n3 - Create Basketballer\n4 - Create eSportsman\nq - Exit");
                }
                else
                {
                    Console.WriteLine("1 - Show info\n2 - Die\n3 - Change name\n4 - Change surname\n5 - Set disease\n6 - Sing\n7 - Set category\n");

                    if (sportsman is Footballer)
                    {
                        Console.WriteLine("8 - Bounce a ball");
                    }

                    if (sportsman is Basketballer)
                    {
                        Console.WriteLine("8 - Score a three-pointer");
                    }

                    if (sportsman is eSportsman)
                    {
                        Console.WriteLine("8 - Chop watermelon");
                    }
                    Console.WriteLine("9 - Play a quiz");
                    Console.WriteLine("As bonus: B - to compare your sportsman to another one.");
                    Console.WriteLine("Other - Start menu");
                }
                choice = Console.ReadKey().KeyChar;
                Console.Clear();

                if (selectedClass == "none")
                {
                    if (choice == '1' || choice == '2' || choice == '3' || choice == '4' || choice == '5')
                    {
                        Console.WriteLine("Enter name and surname");
                        name = Console.ReadLine();
                        surname = Console.ReadLine();
                        Console.WriteLine("Enter gender (male/female, other - skip)");
                        gender = Console.ReadLine();
                        Console.WriteLine("Enter birth year");
                        
                        //Обработка исключения с неправильным вводом данных
                        try
                        {
                            birth_year = Convert.ToInt32(Console.ReadLine());
                            if (birth_year < 1900 || birth_year > 2020)
                                throw new Exception("The hell you're trying to enter?) KEKW");
                        }
                        catch
                        {
                            Console.WriteLine("Wrong input!");
                            birth_year = 2020;
                        }

                        Human.birth_year = birth_year;
                    }
                    Console.Clear();

                    if (Human.birth_year < 2003)
                    {
                        selectedClass = "Sportsman";
                    }
                    else
                    {
                        Notify($"{sportsman.Name} is too young for being a professional sportsman.");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    switch (choice)
                    {
                        case '1':
                            sportsman = new Sportsman(name, surname, gender);
                            break;
                        case '2':
                            sportsman = new Footballer(name, surname, gender);
                            selectedClass = "Footballer";
                            break;
                        case '3':
                            sportsman = new Basketballer(name, surname, gender);
                            selectedClass = "Basketballer";
                            break;
                        case '4':
                            sportsman = new eSportsman(name, surname, gender);
                            selectedClass = "eSportsman";
                            break;
                    }
                }
                else
                {
                    switch (choice)
                    {
                        case '1':
                            sportsman.ShowInfo();
                            Console.ReadKey();
                            break;
                        case '2':
                            if (sportsman.IsDead)
                                sportsman.Resurrect();
                            else sportsman.Die();
                            break;
                        case '3':
                            Console.Write("name = ");
                            sportsman.Name = Console.ReadLine();
                            break;
                        case '4':
                            Console.Write("surname = ");
                            sportsman.Surname = Console.ReadLine();
                            break;
                        case '5':
                            Console.Write("disease = ");
                            sportsman.Disease = Console.ReadLine();
                            break;
                        case '6':
                            sportsman.Sing();
                            break;
                        case '7':
                            Console.WriteLine("Possible categories : Footballer, Basketballer, eSportsman");
                            Console.Write("category = ");
                            sportsman.Category = Console.ReadLine();
                            break;
                        case '8':
                            if (sportsman is Footballer)
                            {
                                sportsman.Bounce();
                                break;
                            }

                            if (sportsman is Basketballer)
                            {
                                sportsman.Score();
                                break;
                            }

                            if (sportsman is eSportsman)
                            {
                                sportsman.ChopWatermelon();
                                break;
                            }

                            if (sportsman is Sportsman)
                            {
                                selectedClass = "none";
                            }
                            break;

                        case '9':
                        {
                            sportsman.Play();
                            break;
                        }

                        case 'B':
                        {
                            Notify("Define the type of abstract sportsman: 1 for footballer, 2 for basketball player and  3 for e-sports player.");
                            int which = int.Parse(Console.ReadLine());
                            switch (which)
                            {
                                case 1:
                                {
                                    Console.WriteLine("Let's tale Paul Pogba.");
                                    Footballer Pogba = new Footballer("Paul", "Pogba", "male");
                                    Footballer Paul = Pogba.Clone() as Footballer;
                                    Pogba.Salary = 120000;
                                    if (sportsman.Gender == "male")
                                        Console.WriteLine("You're both men.");
                                    if (sportsman.Name == "Paul")
                                        Console.WriteLine("Grats! You're Paul as well!");
                                    if (sportsman.Salary > Pogba.Salary)
                                        Console.WriteLine("Grats! You earn more than Paul Pogba himself!");
                                    else
                                        Console.WriteLine(
                                            "Pogba's salary is higher. Well, money doesn't mean that much.");
                                    break;
                                }

                                case 2:
                                {
                                    Console.WriteLine("Let's take Michael Jordan");
                                    Basketballer Jordan = new Basketballer("Michael", "Jordan", "male");
                                    Basketballer Michael = Jordan.Clone() as Basketballer;
                                    Jordan.Salary = 250000;
                                    if (sportsman.Gender == "male")
                                        Console.WriteLine("You're both men.");
                                    if (sportsman.Name == "Michael")
                                        Console.WriteLine("Grats! You're Michael as well!");
                                    if (sportsman.Salary > Jordan.Salary)
                                        Console.WriteLine("Wow. You earn more than the legend! Do you really deserve that much?)");
                                    else
                                        Console.WriteLine(
                                            "Jordan earns more than you. You have the cap to grow.");
                                    break;
                                }

                                case 3:
                                {
                                    Console.WriteLine("Let's take Johan Sundstein");
                                    eSportsman Sundstein = new eSportsman("Johan", "Sundstein", "male");
                                    eSportsman Johan = Sundstein.Clone() as eSportsman;
                                    Sundstein.Salary = 550000;
                                    if (sportsman.Gender == "male")
                                        Console.WriteLine("You're both men.");
                                    if (sportsman.Name == "Johan")
                                        Console.WriteLine("Grats! You're Johan as well!");
                                    if (sportsman.Salary > Sundstein.Salary)
                                        Console.WriteLine("You earn more than a two-time TI champion? Wow!");
                                    else
                                        Console.WriteLine(
                                            "So, Johan defenitely has more money that you. Why not become a legend as well?");
                                    break;
                                }
                            }
                            break;
                        }

                        default:
                            selectedClass = "none";
                            break;
                    }
                    Console.Clear();
                }
            } while (choice != 'q');
        }
    }
}