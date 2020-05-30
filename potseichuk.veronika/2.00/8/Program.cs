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
                Console.WriteLine("1. Добавить студента");
                Console.WriteLine("2. Вывести информацию о студенте");
                Console.WriteLine("3. Список введённых студентов");
                Console.WriteLine("4. Выход");
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

            Console.Write("Введите имя студента: ");
            name = Console.ReadLine();
            Console.Write("Введите фамилию студента: ");
            lastname = Console.ReadLine();
            Console.Write("Введите возраст студента: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите курс студента: ");
            stage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Студент учится на бюджетной основе? (y/n)");
            budjet = Console.ReadLine();

            var student = Student.CreatStudent(budjet, name, lastname, age, stage);
            student.MyEvent += () =>
            {
                Console.WriteLine("Ничего себе балл!");
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
                Console.Write("Введите фамилию студента, информацию о котором, хотите получить: ");
                string choice = Console.ReadLine();
                foreach (var S in BSUIRst)
                {
                    if (choice == S["lastname"])
                    {
                        IsSuccess = true;
                        del = S.Display;
                        del += () =>
                        {
                            Console.WriteLine("\nО чём думает?\n");
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
            Console.WriteLine("Количество введенных студентов: {0}", BSUIRst.Count);
            foreach (Student S in BSUIRst)
            {
                Console.WriteLine("{0}.", BSUIRst.IndexOf(S) + 1);
                S.Display();
                Console.WriteLine("\n");
            }

            Console.WriteLine("Sravnit studentov? (y/n)");
            if (Console.ReadLine() == "y") CompareSt();
            Console.ReadKey();
        }

        static void CompareSt()
        {
            int choice1, choice2, result;
            Console.WriteLine("Vvedite index...");
            choice1 = Convert.ToInt32(Console.ReadLine());
            choice2 = Convert.ToInt32(Console.ReadLine());

            result = BSUIRst[choice1 - 1].CompareTo(BSUIRst[choice2 - 1]);
            switch (result)
            {
                case (-1):
                    Console.WriteLine("Рейтинг студента {0} ниже рейтинга студента {1}. ", choice1, choice2);
                    break;
                case (0):
                    Console.WriteLine("Рейтинг студента {0} равен рейтингу студента {1}. ", choice1, choice2);
                    break;
                case (1):
                    Console.WriteLine("Рейтинг студента {0} выше рейтинга студента {1}. ", choice1, choice2);
                    break;
            }
            Console.ReadKey();
        }
    }
}

