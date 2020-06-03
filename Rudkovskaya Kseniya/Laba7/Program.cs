using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    class RationalNumber : IEquatable<RationalNumber>
    {
        private int _numerator;
        private int _denominator;

        public RationalNumber(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        ~RationalNumber() { }
 
        public bool Equals(RationalNumber another)   //Реализация интерфейса
        {
            if (another is null)
                return false;
            return _numerator * another._denominator == another._numerator * _denominator;
        }
   
        public static RationalNumber operator +(RationalNumber a, RationalNumber b)   //Математические операции
        {
            if (a._denominator == b._denominator)
            {
                return new RationalNumber(a._numerator + b._numerator, a._denominator);
            }
            else
            {
                int denominator = a._denominator * b._denominator;
                int numerator = a._numerator * b._denominator + b._numerator * a._denominator;
                return new RationalNumber(numerator, denominator);
            }
        }

        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            if (a._denominator == b._denominator)
            {
                return new RationalNumber(a._numerator - b._numerator, a._denominator);
            }
            else
            {
                return new RationalNumber((a._numerator * b._denominator) - (b._numerator * a._denominator), a._denominator * b._denominator);
            }
        }

        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a._numerator * b._numerator, a._denominator * b._denominator);
        }

        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a._numerator * b._denominator, a._denominator * b._numerator);
        }
  
        public static bool operator >(RationalNumber a, RationalNumber b)  //Операции сравнения
        {
            return (double)a > (double)b;
        }

        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return (double)a < (double)b;
        }

        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return (double)a >= (double)b;
        }

        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return (double)a <= (double)b;
        }

        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            return a.Equals((object)b);
        }

        public static bool operator !=(RationalNumber r1, RationalNumber r2)
        {
            return !r1.Equals((object)r2);
        }

        public static explicit operator double(RationalNumber num)   //Операции преобразования типов
        {
            return (double)num._numerator / num._denominator;
        }

        public static explicit operator int(RationalNumber num)
        {
            return num._numerator / num._denominator;
        }
        
        public override string ToString()  // Преобразование в строку
        {
            return $"{_numerator} / {_denominator}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numerator1, numerator2, denominator1, denominator2;
            Console.WriteLine("Введите числитель первой рациональной дроби:");
            numerator1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой рациональной дроби:");
            denominator1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числитель второй рациональной дроби:");
            numerator2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второй рациональной дроби:");
            denominator2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ваши числа: {0}/{1} и {2}/{3} ", numerator1, denominator1, numerator2, denominator2);
            RationalNumber number1 = new RationalNumber(numerator1, denominator1);
            RationalNumber number2 = new RationalNumber(numerator2, denominator2);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1.Сложение");
                Console.WriteLine("2.Вычетание");
                Console.WriteLine("3.Умнажение");
                Console.WriteLine("4.Деление");
                Console.WriteLine("5.Вывести большее число");
                Console.WriteLine("6.Вывести меньшее число");
                Console.WriteLine("7.Проверить числа на равенство");
                Console.WriteLine("8.Преобразовать в int");
                Console.WriteLine("9.Преобразовать в double");
                Console.WriteLine("10.Завешить работу");
                int otvet = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (otvet)
                {
                    case 1: Console.WriteLine($"{(number1 + number2).ToString()}"); break;
                    case 2: Console.WriteLine($"{(number1 - number2).ToString()}"); break;
                    case 3: Console.WriteLine($"{(number1 * number2).ToString()}"); break;
                    case 4: Console.WriteLine($"{(number1 / number2).ToString()}"); break;
                    case 5:
                        if (number1 > number2)
                            Console.WriteLine($"{number1.ToString()}");
                        else
                            Console.WriteLine($"{number2.ToString()}");
                        break;
                    case 6:
                        if (number1 < number2)
                            Console.WriteLine($"{number1.ToString()}");
                        else
                            Console.WriteLine($"{number2.ToString()}");
                        break;
                    case 7:
                        if (number1 == number2)
                            Console.WriteLine("Числа равны");
                        else
                            Console.WriteLine("Числа не равны");
                        break;
                    case 8: Console.WriteLine($"{(int)number1}    {(int)number2}"); break;
                    case 9: Console.WriteLine($"{(double)number1}    {(double)number2}"); break;
                    case 10: return;
                    default:
                        break;
                }
            }
        }
    }
}