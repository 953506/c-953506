using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Human example1 = new Human();
            example1.Del();
            example1.ShowCount();
            example1.ex1("Vova");
            StudentIITP example2 = new StudentIITP();
            example2.Ifer();
            example2.ex2();
            StudentIITP1 example3 = new StudentIITP1();
            example3.CoutMarks();

            string name, surname, patronymic;
            try
            {
                name = Console.ReadLine();
                surname = Console.ReadLine();
                patronymic = Console.ReadLine();
            }

            catch 
            {
                Console.WriteLine("\nError");
            }

              



        }
    }
}
