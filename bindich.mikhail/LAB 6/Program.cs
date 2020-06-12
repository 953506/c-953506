using System;
using System.Collections.Generic;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student("", "");
            stud.studentPrintInfo();

            List<Human> humans = new List<Human>();
            humans.Add(new Employee("Dave", "Murray"));
            humans.Add(new Employee("FName", "LName"));
            humans.Add(new Employee("Joe", "Rogan"));

            humans.Sort();

            foreach (Human human in humans)
            {
                Console.WriteLine($"{human.firstName} {human.lastName}");
            }
        }
    }
}
