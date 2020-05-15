using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student("", "");
            stud.studentPrintInfo();

            Employee emp = new Employee("Dave", "Murray");
            Employee emp2 = new Employee("Joe", "Rogan");

            Console.WriteLine(emp.CompareTo(emp2));
        }
    }
}
