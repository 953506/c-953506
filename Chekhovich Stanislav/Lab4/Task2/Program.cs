using System;
using System.Runtime.InteropServices;

namespace Lab4_Part2
{
    class Program
    {
        [DllImport("C:\\Programming\\2 SEM\\Lib2\\Win32\\Debug\\Project1.dll")]
        public extern static double Pow(double a, int b);

        [DllImport("C:\\Programming\\2 SEM\\Lib2\\Win32\\Debug\\Project1.dll")]
        public extern static double Add(double a, double b);

        [DllImport("C:\\Programming\\2 SEM\\Lib2\\Win32\\Debug\\Project1.dll")]
        public extern static double Sub(double a, double b);

        [DllImport("C:\\Programming\\2 SEM\\Lib2\\Win32\\Debug\\Project1.dll")]
        public extern static double Multiply(double a, double b);

        [DllImport("C:\\Programming\\2 SEM\\Lib2\\Win32\\Debug\\Project1.dll")]
        public extern static double Divide(double a, double b);

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Простейший калькулятор" +
                    "\n1.Сложить два числа" +
                    "\n2.Вычесть одно число из другого" +
                    "\n3.Умножить одно число на другое" +
                    "\n4.Разделить одно число на другое" +
                    "\n5.Возвести число в степень" +
                    "\n6.Выход из программы");
                uint K;
                double a;
                double b;
                int c;
                bool exit = false;
                if (!UInt32.TryParse(Console.ReadLine(), out K) || K == 0 || K > 6)
                {
                    Console.WriteLine("Error");
                    return;
                }
                Console.Clear();
                switch (K)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите числа, которые хотите сложить:");
                            if (!Double.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Error");
                                exit = true;
                                break;
                            }
                            if (!Double.TryParse(Console.ReadLine(), out b))
                            {
                                Console.WriteLine("Error");
                                exit = true;
                                break;
                            }
                            Console.WriteLine($"Сумма: {Add(a, b)}");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Введите уменьшаемое: ");
                            if (!Double.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Error");
                                exit = true;
                                break;
                            }
                            Console.Write("Введите вычитаемое: ");
                            if (!Double.TryParse(Console.ReadLine(), out b))
                            {
                                Console.WriteLine("Error");
                                exit = true;
                                break;
                            }
                            Console.WriteLine($"Разность: {Sub(a, b)}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите числа, которые хотите умножить:");
                            if (!Double.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Error");
                                exit = true;
                                break;
                            }
                            if (!Double.TryParse(Console.ReadLine(), out b))
                            {
                                Console.WriteLine("Error");
                                exit = true;
                                break;
                            }
                            Console.WriteLine($"Произведение: {Multiply(a, b)}");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Введите делимое: ");
                            if (!Double.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Error");
                                exit = true;
                                break;
                            }
                            Console.Write("Введите делитель: ");
                            if (!Double.TryParse(Console.ReadLine(), out b))
                            {
                                Console.WriteLine("Error");
                                exit = true;
                                break;
                            }
                            Console.WriteLine($"Частное: {Divide(a, b)}");
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Введите число, которое хотите возвести в степень: ");
                            if (!Double.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Error");
                                exit = true;
                                break;
                            }
                            Console.Write("Введите степень: ");
                            if (!Int32.TryParse(Console.ReadLine(), out c))
                            {
                                Console.WriteLine("Error");
                                exit = true;
                                break;
                            }
                            Console.WriteLine($"Получилось число: {Pow(a, c)}");
                            break;
                        }
                    case 6:
                        {
                            exit = true;
                            break;
                        }
                }
                if(exit == true)
                {
                    break;
                }
                Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню...");
                Console.ReadKey();
            }
        }
    }
}
