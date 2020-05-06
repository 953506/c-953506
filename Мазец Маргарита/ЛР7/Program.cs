using System;

namespace ЛР7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, den1, den2;
            Console.WriteLine("Привет! Моя программа реализует операции с рациональными числами");
            Console.WriteLine("Введите 2 целых числа для представления первой рациональной дроби:");
            num1 = Convert.ToInt32(Console.ReadLine());
            den1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 целых числа для представления второй рациональной дроби:");
            num2 = Convert.ToInt32(Console.ReadLine());
            den2 = Convert.ToInt32(Console.ReadLine());
            RationalNumber value1 = new RationalNumber(num1, den1);
            RationalNumber value2 = new RationalNumber(num2, den2);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1-cложение");
                Console.WriteLine("2-вычетание");
                Console.WriteLine("3-умнажение");
                Console.WriteLine("4-деление");
                Console.WriteLine("5-вывести большее число");
                Console.WriteLine("6-вывести меньшее число");
                Console.WriteLine("7- проверить числа на равенство");
                Console.WriteLine("8-преобразовать в целое число");
                Console.WriteLine("9-завешить работу");
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1: Console.WriteLine($"{(double)(value1 + value2)}"); break;
                    case 2: Console.WriteLine($"{(double)(value1 - value2)}"); break;
                    case 3: Console.WriteLine($"{(double)(value1 * value2)}"); break;
                    case 4: Console.WriteLine($"{(double)(value1 / value2)}"); break;
                    case 5:
                        if (value1 > value2)
                            Console.WriteLine($"{(double)value1}");
                        else
                            Console.WriteLine($"{(double)value2}");
                        break;
                    case 6:
                        if (value1 < value2)
                            Console.WriteLine($"{(double)value1}");
                        else
                            Console.WriteLine($"{(double)value2}");
                        break;
                    case 7:
                        if (value1 == value2)
                            Console.WriteLine("Числа равны");
                        else
                            Console.WriteLine("Числа неравны");
                        break;
                    case 8: Console.WriteLine($"{(int)value1}    {(int)value2}"); break;
                    case 9: return;
                    default:
                        break;
                }
            }
        }
    }
}
