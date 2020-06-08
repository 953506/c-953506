using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Human stud = new Student("", "");
            stud["first name"] = "Bob";
            stud.humanPrintInfo();
            Student stud2 = new Student("", "");
            stud.doWork();
            stud2.doWork();
        }
    }
}
