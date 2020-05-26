using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            Number a = new Number(9, 3);    // Создание с помощью конструктора
            Number b = Number.Create("8/19");   // Создание из строки с помощью метода Create
            Number c = "2/3";   // Создание с помощью неявного преобразования string к Number

            Console.WriteLine($"{ a.ToString() }");     // Вывод с помощью переопределенного метода ToString()
            Console.WriteLine($"{ b }");    // Вывод как строку (неявное преобразование типов)
            Console.WriteLine($"{ (double)c }");    // Вывод как double (явное преобразование типов)

            Console.WriteLine($"{a} + {b} = {a + b}");   // Number + Number
            Console.WriteLine($"{a} / {c} = {a / c}");   // Number / Number
            Console.WriteLine($"{b} + 3 = {b + 3}");    // Number + int

            if (b > c)      //Сравнение двух Number
                Console.WriteLine($"{b} > {c}");
            if (a != c)     //Сравнение двух Number
                Console.WriteLine($"{(double)a} != {(double)c}");

            var n1 = new Number(10, 22);
            var n2 = new Number(5, 11);

            Console.WriteLine($"{ n1.CompareTo(n2) }"); // Метод вернет 0
            Console.WriteLine($"{ n1.Equals(n2) }"); // Метод вернет true
            if (n1 == n2) 
                Console.WriteLine("n1 == n2");
        }
    }
}
