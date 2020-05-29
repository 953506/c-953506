using System;

    class Program
    {
        static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Выберите действие:\n" +
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
            int numerator, denominator;
            Console.WriteLine("Введите числитель первой дроби");
            numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой дроби");
            denominator = Convert.ToInt32(Console.ReadLine());
            a = new RationalNumber(numerator, denominator);
            Console.WriteLine("Введите число в формате a/b");
            string form = Console.ReadLine();
            b = new RationalNumber(form);
            int ch;
            bool exit = false;
            do
            {
                Menu();
                ch = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (ch)
                {
                    case 1:
                        Console.WriteLine($"{a + b} или {(double)(a + b)}");
                        break;
                    case 2:
                        Console.WriteLine($"{a - b} или {(double)(a - b)}");
                        break;
                    case 3:
                        Console.WriteLine($"{a * b} или {(double)(a * b)}");
                        break;
                    case 4:
                        Console.WriteLine($"{a / b} или {(double)(a / b)}");
                        break;
                    case 5:
                        if (a > b) Console.WriteLine($"{a} или {(double)(a)} больше");
                        else if (a < b) Console.WriteLine($"{b} или {(double)(b)} больше");
                        else Console.WriteLine("Числа не равны");
                        break;
                    case 6:
                        if (a < b) Console.WriteLine($"{a} или {(double)(a)} меньше");
                        else if (a > b) Console.WriteLine($"{b} или {(double)(b)} меньше");
                        else Console.WriteLine("Числа не равны");
                        break;
                    case 7:
                        if (a == b) Console.WriteLine("Числа равны");
                        else Console.WriteLine("Числа не равны");
                        break;
                    case 8:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Что-то не так.");
                        break;
                }
            } while (!exit);
        }
    }
