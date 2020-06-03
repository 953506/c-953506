using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student("", "");
            stud.studentPrintInfo();

            Employee emp = new Employee("Dave", "Murray");
            Employee emp2 = new Employee("Joe", "Rogan");

            emp.Notify += displayMessage;
            emp.employeePrintInfo();
            emp.Notify -= displayMessage;

            emp.Notify += delegate (string message)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
            };
            emp.employeePrintInfo();            

            try
            {
                Console.WriteLine(emp.CompareTo(null));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void displayMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
