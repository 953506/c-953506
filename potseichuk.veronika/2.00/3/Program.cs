﻿using System;
using System.Collections.Generic;
using System.Net.Cache;

namespace lab_3
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
                Console.WriteLine("1. Add student.");
                Console.WriteLine("2. Display student information.");
                Console.WriteLine("3. List of entered students.");
                Console.WriteLine("4. Exit.");
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

            Console.Write("Enter student name: ");
            name = Console.ReadLine();
            Console.Write("Enter student lastname: ");
            lastname = Console.ReadLine();
            Console.Write("Enter student age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter student stage: ");
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
                Console.Write("Enter the lastname of the student whose information you want to receive: ");
                string choice = Console.ReadLine();            
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
            Console.WriteLine("Number of the student entered: {0}", BSUIRst.Count);
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
    
