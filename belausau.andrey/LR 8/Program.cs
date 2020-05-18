using System;
using System.Collections.Generic;

namespace Pudge
{
    class Program
    {
        delegate bool Condition(int x);

        delegate void FillList();

        static void Main()
        {
            Student st = new Student("Stas", 9);
            st.Notify += ShowMessage;

            try
            {
                Human hum = new Human();
                Console.WriteLine(st.CompareTo(hum));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            st.GoToArmy();

            List<Student> students = new List<Student>();

            FillList fill = delegate
            {
                students.Add(new Student("Stas", 9));
                students.Add(new Student("Lesha", 5));
                students.Add(new Student("Misha", 7));
                students.Add(new Student("Vanya", 8));
                students.Add(new Student("Polina", 10));
            };

            fill();

            Console.WriteLine("\nAll students: ");
            ShowStudents(students, x => x > 0);
            Console.WriteLine();

            Console.WriteLine("Students with an average mark > 7:");
            ShowStudents(students, x => x > 7);
            Console.WriteLine();
        }

        static void ShowStudents(List<Student> students, Condition condition)
        {
            foreach(Student st in students)
            {
                if(condition(st.AverageMark))
                {
                    Console.WriteLine(st.Name + " - " + st.AverageMark);
                }
            }
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}