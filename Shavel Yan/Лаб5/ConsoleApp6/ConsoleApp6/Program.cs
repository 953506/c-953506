using System;
using System.Collections.Generic;

namespace ConsoleApp6
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
            bool budget=false;
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
                BudgetStudent student = new BudgetStudent(name, surname, ID, birthYear, course, gender, speciality);
                Students.Add(student);
            }
           if(!budget)
            {
                Student student = new PStudent(name, surname, ID, birthYear, course, gender, speciality);
                Students.Add(student);
            }
        }
        static void Info()
        {
            bool Success = false;
            do
            {
                Console.Clear();
                Console.Write("Enter ID of the student whose information you want to receive: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                foreach (Student ID in Students)
                {
                    if (choice == ID.ID)
                    {
                        Success = true;
                        ID.ShowInfo();
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
                Console.WriteLine("3-завершить программу");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:Add();break;
                    case 2:Info(); break;
                    case 3:Console.WriteLine("Exit");break;
                }
            } while (choice != 3);
        }
    }
}