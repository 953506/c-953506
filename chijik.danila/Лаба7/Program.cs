using System;
using static System.Console;
    class Program
    {
        
        static void Menu()
        {
            WriteLine("Выберите действие:\n" +
                              "1)Сложить два числа\n" +
                              "2)Вычесть из первого числа второе\n" +
                              "3)Умножить числа\n" +
                              "4)Разделить первое число на второе\n" +
                              "5)Показать большее число\n" +
                              "6)Показать меньшее число\n" +
                              "7)Показать, равны ли числа\n" +
                              "8)Выход");
        }
        
        static void Main(string[] args)
        {
            RationalNumber a, b;
            int numerator, denominator, ch;
            bool exit = false;
            
            WriteLine("Введите числитель первой дроби");
            numerator = int.Parse(ReadLine());
            WriteLine("Введите знаменатель первой дроби");
            denominator = int.Parse(ReadLine());
            a = new RationalNumber(numerator, denominator);
            
            WriteLine("Введите число в формате a/b");
            string form = ReadLine();
            b = new RationalNumber(form);
            
            do
            {
                Menu();
                ch = int.Parse(ReadLine());
                Clear();
                switch (ch)
                {
                    case 1:
                        WriteLine($"{a + b} или {(double)(a + b)}");
                        break;
                    case 2:
                        WriteLine($"{a - b} или {(double)(a - b)}");
                        break;
                    case 3:
                        WriteLine($"{a * b} или {(double)(a * b)}");
                        break;
                    case 4:
                        WriteLine($"{a / b} или {(double)(a / b)}");
                        break;
                    case 5:
                        if (a > b) { WriteLine($"{a} или {(double)(a)} больше"); }
                        else if (a < b) { WriteLine($"{b} или {(double)(b)} больше"); }
                        else WriteLine("Числа не равны");
                        break;
                    case 6:
                        if (a < b) { WriteLine($"{a} или {(double)(a)} меньше"); }
                        else if (a > b) { WriteLine($"{b} или {(double)(b)} меньше"); }
                        else WriteLine("Числа не равны");
                        break;
                    case 7:
                        if (a == b) { WriteLine("Числа равны"); }
                        else WriteLine("Числа не равны");
                        break;
                    case 8:
                        exit = true;
                        break;
                    default:
                        WriteLine("Что-то не так.");
                        break;
                }
            } 
            while (!exit);
        }
    }
