using System;
using System.Collections.Generic;
using System.Net.Cache;

namespace Пробный_3
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


        //static readonly Student[] BSUIRst = new Student[10];

        static void AddSt()
        {
            Console.Clear();
            /*BSUIRst[numst] = new Student();
            numst++;*/
            string name;
            string lastname;
            int age;
            int stage;

            Console.Write("Введите имя студента: ");
            name = Console.ReadLine();
            Console.Write("Введите фамилию студента: ");
            lastname = Console.ReadLine();
            Console.Write("Введите возраст студента: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите курс студента: ");
            stage = Convert.ToInt32(Console.ReadLine());

            Student newStudent = new Student(name, lastname, age, stage);
            BSUIRst.Add(newStudent);
        }

        static void ShowInfSt()
        {
            bool IsSuccess = false;
            do
            {
                Console.Clear();
                Console.Write("Введите фамилию студента, информацию о котором, хотите получить: ");
                string choice = Console.ReadLine();
                /*for (int i = 0; i < numst && success == false; i++)
                {
                    if (choice == BSUIRst[i]["lastname"]) 
                    { 
                        success = true;
                        Console.Clear();
                        BSUIRst[i].Display();
                    }
                }*/
                foreach (Student S in BSUIRst)
                {
                    if (choice == S["lastname"])
                    {
                        IsSuccess = true;
                        S.Display();
                    }
                }
            } while (IsSuccess == false);
            Console.ReadKey();
        }

        static void NumberSt()
        {
            Console.Clear();
            int count = 1;
            Console.WriteLine("Количество введенных студентов: {0}", BSUIRst.Count);
            foreach (Student S in BSUIRst)
            {
                Console.WriteLine("{0}.", count);
                S.Display();
                count++;
            }
            Console.ReadKey();
        }


    }
}
    