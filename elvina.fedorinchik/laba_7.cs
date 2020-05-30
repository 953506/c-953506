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

        public RationalNumber(string form)                           
        {
            char[] numerator = new char[25];
            char[] denominator = new char[25];
            int i = 0;
            for (int j = 0; i < form.Length; i++, j++)
            {
                if (form[i] == '/')
                {
                    numerator[j] = '\0';
                    i++;
                    break;
                }
                numerator[j] = form[i];
            }
            for (int j = 0; i < form.Length; i++, j++)
            {
                denominator[j] = form[i];
            }
            string str1 = new string(numerator);
            string str2 = new string(denominator);
            _numerator = Convert.ToInt32(str1);
            _denominator = Convert.ToInt32(str2);
        }

        public bool Equals(RationalNumber another)
        {
            if (another is null)
                return false;
            return _numerator * another._denominator == another._numerator * _denominator;
        }

        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
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

        public static bool operator >(RationalNumber a, RationalNumber b)
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

        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !a.Equals((object)b);
        }


        public static explicit operator double(RationalNumber num)
        {
            return (double)num._numerator / num._denominator;
        }

        public static explicit operator int(RationalNumber num)
        {
            return num._numerator / num._denominator;
        }

        public override string ToString()
        {
            return $"{_numerator} / {_denominator}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber number1, number2;
            int numerator1, denominator1;
            Console.WriteLine("Heeey!");
            Console.WriteLine("Enter the numerator of the first fraction:");
            numerator1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the denominator of the first fraction:");
            denominator1 = Convert.ToInt32(Console.ReadLine());
            number1 = new RationalNumber(numerator1, denominator1);
            Console.WriteLine("Enter the second fractional number:");
            string form = Console.ReadLine();
            number2 = new RationalNumber(form);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Addition.");
                Console.WriteLine("2. Subtraction.");
                Console.WriteLine("3. Multiplication.");
                Console.WriteLine("4. Division.");
                Console.WriteLine("5. Print a larger number.");
                Console.WriteLine("6. Print a smaller number.");
                Console.WriteLine("7. Are these numbers equal?");
                Console.WriteLine("8. Convert to int.");
                Console.WriteLine("9. Convert to double.");
                Console.WriteLine("10. It's all. Bye!");
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
                            Console.WriteLine("The numbers are equal.");
                        else
                            Console.WriteLine("The numbers are not equal.");
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
