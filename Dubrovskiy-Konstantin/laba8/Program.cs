using System;

namespace ConsoleApp10
{
    class Program
    {        
        static void Main()
        {
            Student student = new Student("Student");
            student.examPass += Print; //добавим событие
            student.massage = Print; //определим делегат
            student.GetFullInfo();

            Console.WriteLine();

            student.Examination(0, 3);
            student.Examination(1, 5);
            student.Examination(2, 7);
            student.Examination(13, 9); //сработает исключение try
            student.Examination(4, 4);
            student.Examination(0, 7);
                Console.WriteLine();
            student.GetFullInfo();
                Console.WriteLine();

            student = new Student("New Student", Print); // перегруженный конструктор (сразу принимает метод вывода Print)
            student.GetFullInfo();
        }

        static void Print(string str) //обработчик события examPass и метод делегата massage
        {
            Console.WriteLine(str);
        }
    }
}
