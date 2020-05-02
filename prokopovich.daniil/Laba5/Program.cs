using System;

namespace Chelovek
{
    class Program
    {
        static void Main()
        {
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
                    Console.WriteLine("1 - Show info\n2 - Die\n3 - Change name\n4 - Change surname\n5 - Set disease\n6 - Sing\n7 - Set category");

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
                        birth_year = Convert.ToInt32(Console.ReadLine());

                        if (birth_year < 1900 || birth_year > 2020)
                            birth_year = 2020;
                        Human.birth_year = birth_year;
                    }
                    Console.Clear();

                    if (Human.birth_year < 2003)
                    {
                        selectedClass = "Sportsman";
                    }
                    else
                    {
                        Console.WriteLine($"{sportsman.Name} is too young for being a professional sportsman.");
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
                            if (sportsman.isDead)
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
