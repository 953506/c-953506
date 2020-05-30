using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace Lab8
{
    class Program
    {
        static List<Student> BSUIRst = new List<Student>();

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Clear();
                Console.Clear();
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Display student information");
                Console.WriteLine("3. List of entered student");
                Console.WriteLine("4. Exit..");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddSt();
                        break;
                    case 2:
                        ShowInfSt();
                        break;
                    case 3:
                        NumberSt();
                        break;
                }
            } while (choice != 4);
        }

        static void AddSt()
        {
            Console.Clear();
            string name;
            string lastname;
            int age;
            int stage;
            string budjet;

            Console.Write("Enter student name: ");
            name = Console.ReadLine();
            Console.Write("Enter student lastname: ");
            lastname = Console.ReadLine();
            Console.Write("Enter student age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter student stage: ");
            stage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Does the student study a budgetary basic? (y/n)");
            budjet = Console.ReadLine();

            var student = Student.CreatStudent(budjet, name, lastname, age, stage);
            student.MyEvent += () =>
            {
                Console.WriteLine("Wow score!");
                Console.ReadKey();
            };
            student.SetRating();
            BSUIRst.Add(student);
        }

        static void ShowInfSt()
        {
            bool IsSuccess = false;
            Student.MyDelegate del;
            do
            {
                Console.Clear();
                Console.Write("Enter the lastname of the student whose information you want to receive: ");
                string choice = Console.ReadLine();
                foreach (var S in BSUIRst)
                {
                    if (choice == S["lastname"])
                    {
                        IsSuccess = true;
                        del = S.Display;
                        del += () =>
                        {
                        Console.WriteLine("What is he thinking about?");
                        };
                        del += S.Complain;
                        del();
                    }
                }
            } while (IsSuccess == false);
            Console.ReadKey();
        }

        static void NumberSt()
        {
            Console.Clear();
            Console.WriteLine("Number of the student entered: {0}", BSUIRst.Count);
            foreach (Student S in BSUIRst)
            {
                Console.WriteLine("{0}.", BSUIRst.IndexOf(S) + 1);
                S.Display();
                Console.WriteLine("\n");
            }

            Console.WriteLine("Compare students? (y/n)");
            if (Console.ReadLine() == "y") CompareSt();
            Console.ReadKey();
        }

        static void CompareSt()
        {
            int choice1, choice2, result;
            Console.WriteLine("Enter indexes...");
            choice1 = Convert.ToInt32(Console.ReadLine());
            choice2 = Convert.ToInt32(Console.ReadLine());

            result = BSUIRst[choice1 - 1].CompareTo(BSUIRst[choice2 - 1]);
            switch(result)
            {
                case (-1): 
                    Console.WriteLine("Student rating {0} below student rating {1}. ", choice1, choice2); 
                    break;
                case (0): 
                    Console.WriteLine("Student rating {0} is equal to student rating {1}. ", choice1, choice2); 
                    break;
                case (1): 
                    Console.WriteLine("Student rating {0} higher than student rating {1}. ", choice1, choice2); 
                    break;
            }
            Console.ReadKey();
        }
    }
}

