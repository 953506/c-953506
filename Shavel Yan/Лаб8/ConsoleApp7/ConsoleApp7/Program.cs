using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static List<Student> Students = new List<Student>();
        static void Add()
        {
            Console.Clear();
            string name;
            string surname;
            int birthYear;
            bool budget = false;
            string paysornot = "";
            Console.Write("Enter student name: ");
            name = Console.ReadLine();
            Console.Write("Enter student surname: ");
            surname = Console.ReadLine();
            Console.Write("Enter student year of birth: ");
            birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student`s ID");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What gender is the student? ");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter speciality");
            string speciality = Console.ReadLine();
            Console.Write("Enter student course: ");
            int course = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student study a budgetary?");
            string b = Console.ReadLine();
            if (b == "yes") budget = true;
            if (budget)
            {
                BudgetStudent student = new BudgetStudent(name, surname, ID, birthYear, course, gender, speciality, paysornot);
                Students.Add(student);
            }
            if (!budget)
            {
                Student student = new PStudent(name, surname, ID, birthYear, course, gender, speciality, paysornot);
                Students.Add(student);
            }
        }
        static void Compare()
        {
            int choice1, choice2, result;
            Console.WriteLine("Enter student`s index in list");
            choice1 = Convert.ToInt32(Console.ReadLine());
            choice2 = Convert.ToInt32(Console.ReadLine());

            result = Students[choice1 - 1].CompareTo(Students[choice2 - 1]);
            switch (result)
            {
                case (-1):
                    Console.WriteLine($"{choice1} has lower marks than {choice2} ");
                    break;
                case (0):
                    Console.WriteLine($"{choice1} has eual marks as {choice2} ");
                    break;
                case (1):
                    Console.WriteLine($"{choice1} has higher marks than {choice2} ");
                    break;
            }
            Console.ReadKey();
        }

        static void Info()
        {
            bool Success = false;
            do
            {
                Console.Clear();
                Console.Write("Enter ID of the student whose information you want to receive: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                foreach (Student L in Students)
                {
                    if (choice == L.ID)
                    {
                        Success = true;
                        L.ShowInfo();
                    }
                }
            } while (Success == false);
            Console.ReadKey();
        }
        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("1-Добавить студента");
                Console.WriteLine("2-вывести информацтю о студенте");
                Console.WriteLine("3-Стравнить студентов по оценкам");
                Console.WriteLine("4-завершить программу");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: Add(); break;
                    case 2: Info(); break;
                    case 3: Compare(); break;
                }
            } while (choice != 4);
        }
    }
}