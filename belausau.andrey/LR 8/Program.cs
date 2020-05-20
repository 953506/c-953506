using System;

namespace Pudge
{
    class Program
    {
        static void Main()
        {
            GroupOfStudents students = new GroupOfStudents(7);
            Student st = new Student("Stas", 9);

            Student.GoToArmyHandler goToArmyHandler1 = delegate (string msg)
            {
                Console.WriteLine(msg);
            };

            Student.GoToArmyHandler goToArmyHandler2 = (msg) => Console.WriteLine(msg);

            st.ArmyNotify += ShowMessage;
            st.ArmyNotify += goToArmyHandler1;
            st.ArmyNotify += goToArmyHandler2;

            st.ArmyNotify -= ShowMessage;
            st.ArmyNotify -= goToArmyHandler1;

            st.GoToArmy();
            
            try
            {
                Human hum = new Human();
                Console.WriteLine(st.CompareTo(hum));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            students.FillRandomStudents();

            Console.WriteLine("\nAll students: ");
            students.ShowStudents();

            Console.WriteLine("\nStudents with an average mark > 4:");
            students.ShowStudents(x => x > 4);
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}