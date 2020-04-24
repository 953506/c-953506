using System;

namespace pudge
{
    class Program
    {
        static void Main()
        {
            char choice;
            string name = "", surname = "", gender = "", selectedClass = "none";
            int birth_year;
            Human bsuir_student = new BSUIR_Student();

            do
            {
                if (selectedClass == "none")
                {
                    Console.WriteLine("1 - Create BSUIR student\n2 - Create IITP student\n3 - Create IPOIT student\n4 - Create ASOI student\nq - Exit");
                }
                else
                {
                    Console.WriteLine("1 - Show info\n2 - Die\n3 - change name\n4 - change surname\n5 - Set disease\n6 - Shout\n7 - Set faculty\n8 - Set specialty\n9 - Set numer of group");
                    
                    if(bsuir_student is IITP_Student)
                    {
                        Console.WriteLine("0 - Use goto");
                    }

                    if(bsuir_student is IPOIT_Student)
                    {
                        Console.WriteLine("0 - Go to the army");
                    }

                    if(bsuir_student is ASOI_Student)
                    {
                        Console.WriteLine("0 - Drink beer");
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
                        selectedClass = "BSUIR_Student";
                    }
                    else
                    {
                        Console.WriteLine($"{bsuir_student.Name} is too young for being a student.");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    switch (choice)
                    {
                        case '1':
                            bsuir_student = new BSUIR_Student(name, surname, gender);
                            break;
                        case '2':
                            bsuir_student = new IITP_Student(name, surname, gender);
                            selectedClass = "IITP_Student";
                            break;
                        case '3':
                            bsuir_student = new IPOIT_Student(name, surname, gender);
                            selectedClass = "IPOIT_Student";
                            break;
                        case '4':
                            bsuir_student = new ASOI_Student(name, surname, gender);
                            selectedClass = "ASOI_Student";
                            break;
                    }
                }
                else
                {
                    switch (choice)
                    {
                        case '1':
                            bsuir_student.ShowInfo();
                            Console.ReadKey();
                            break;
                        case '2':
                            if (bsuir_student.isDead)
                                bsuir_student.Resurrect();
                            else bsuir_student.Die();
                            break;
                        case '3':
                            Console.Write("name = ");
                            bsuir_student.Name = Console.ReadLine();
                            break;
                        case '4':
                            Console.Write("surname = ");
                            bsuir_student.Surname = Console.ReadLine();
                            break;
                        case '5':
                            Console.Write("disease = ");
                            bsuir_student.Disease = Console.ReadLine();
                            break;
                        case '6':
                            bsuir_student.Shout();
                            break;
                        case '7':
                            Console.WriteLine("Possible faculties : KSIS, FCP, FITU");
                            Console.Write("faculty = ");
                            bsuir_student.Faculty = Console.ReadLine();
                            break;
                        case '8':
                            Console.WriteLine("Possible specalties : IITP/POIT(KSIS), IPOIT(FCP), ASOI(FITU)");
                            Console.Write("specialty = ");
                            bsuir_student.Specialty = Console.ReadLine();
                            break;
                        case '9':
                            Console.WriteLine("Possible groups : 1..9");
                            Console.Write("group = ");
                            bsuir_student.Group = Console.ReadLine();
                            break;
                        case '0':
                            if(bsuir_student is IITP_Student)
                            {
                                bsuir_student.UseGoto();
                                break;
                            }

                            if(bsuir_student is IPOIT_Student)
                            {
                                bsuir_student.GoToArmy();
                                break;
                            }

                            if(bsuir_student is ASOI_Student)
                            {
                                bsuir_student.DrinkBeer();
                                break;
                            }

                            if(bsuir_student is BSUIR_Student)
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