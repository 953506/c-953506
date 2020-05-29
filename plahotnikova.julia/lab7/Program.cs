using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber number1, number2;
            int numerator1, denominator1;
            Console.WriteLine("Введите числитель первой дроби: ");
            numerator1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой дроби: ");
            denominator1 = Convert.ToInt32(Console.ReadLine());
            number1 = new RationalNumber(numerator1, denominator1);
            Console.WriteLine("Введите второе число (a/b): ");
            string str = Console.ReadLine();
            number2 = new RationalNumber(str);
            while (true)
            {
                Console.WriteLine("Выберите действие:" +
                    "\n1.Сложить две дроби" +
                    "\n2.Вычесть дроби" +
                    "\n3.Перемножить дроби" +
                    "\n4.Поделить дроби" +
                    "\n5.Вывести большее число" +
                    "\n6.Вывести меньшее число" +
                    "\n7.Проверить числа на равенство" +
                    "\n8.Преобразовать в целое число" +
                    "\n9.Преобразовать в число с плавающей точкой" +
                    "\n10.Выход\n");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine($"{(number1 + number2).ToStringFormat1()}");
                            Console.WriteLine($"{(number1 + number2).ToStringFormat2()}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"{(number1 - number2).ToStringFormat1()}");
                            Console.WriteLine($"{(number1 - number2).ToStringFormat2()}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"{(number1 * number2).ToStringFormat1()}");
                            Console.WriteLine($"{(number1 * number2).ToStringFormat2()}");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"{(number1 / number2).ToStringFormat1()}");
                            Console.WriteLine($"{(number1 / number2).ToStringFormat2()}");
                            break;
                        }
                    case 5:
                        if (number1 > number2)
                        {
                            Console.WriteLine($"{number1.ToStringFormat1()}");
                            Console.WriteLine($"{number1.ToStringFormat2()}");
                        }
                        else
                        {
                            Console.WriteLine($"{number2.ToStringFormat1()}");
                            Console.WriteLine($"{number2.ToStringFormat2()}");
                        }
                        break;
                    case 6:
                        if (number1 < number2)
                        {
                            Console.WriteLine($"{number1.ToStringFormat1()}");
                            Console.WriteLine($"{number1.ToStringFormat2()}");
                        }
                        else
                        {
                            Console.WriteLine($"{number2.ToStringFormat1()}");
                            Console.WriteLine($"{number2.ToStringFormat2()}");
                        }
                        break;
                    case 7:
                        if (number1 == number2)
                            Console.WriteLine("Дроби равны");
                        else
                            Console.WriteLine("Дроби не равны");
                        break;
                    case 8: Console.WriteLine($"{(int)number1}\n{(int)number2}"); break;
                    case 9: Console.WriteLine($"{(double)number1}\n{(double)number2}"); break;
                    case 10: return;
                }
            }
        }
    }
}