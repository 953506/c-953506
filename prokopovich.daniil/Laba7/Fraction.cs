using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Fraction : IComparable, IEquatable<Fraction>
    {
        //Поля
        private int _numerator;
        private int _denominator;

        //Конструктор
        public Fraction(int numerator, int denominator)
        {   
            _numerator = numerator;
            _denominator = denominator;
        }

        //Деструктор
        ~Fraction() { }

        //Методы
        //Перевод в другой тип данных
        public static bool TryParse(string str, out Fraction fraction)
        {
            Regex pattern = new Regex(@"^-?[0-9]{1,9}/|,[0-9]{1,9}$");
            fraction = null;

            if (pattern.IsMatch(str))
            {
                string[] numParts = str.Split('/');

                if (numParts.Length == 2)
                {
                    fraction = new Fraction(Convert.ToInt32(numParts[0]), Convert.ToInt32(numParts[1]));
                }
                else
                {
                    numParts = str.Split(',');

                    if (numParts.Length == 2)
                    {
                        int numerator = Convert.ToInt32(numParts[0]);
                        int numOfTens = 0;

                        foreach(char c in numParts[1])
                        {
                            if(numParts[0][0] == '-')
                                numerator = numerator * 10 - (c - '0');
                            else
                                numerator = numerator * 10 + c - '0';
                            numOfTens++;
                        }
                        fraction = new Fraction(numerator, (int)Math.Pow(10,numOfTens));
                    }
                    else
                    {
                        fraction = new Fraction(Convert.ToInt32(numParts[0]), 1);
                    }
                }
                return true;
            }
            return false;
        }
        
        //Нахождение НОДа
        private int GetGSD(int num1, int num2)
        {
            if (num1 % num2 == 0) 
                return num2;
            if (num2 % num1 == 0) 
                return num1;
            if (num1 > num2) 
                return GetGSD(num1 % num2, num2);
            return GetGSD(num1, num2 % num1);
        }

        //Сократить числитель и знаменатель на их НОД
        private void Simplify()
        {
            if (_numerator != 0)
            {
                int devider = GetGSD(Math.Abs(_numerator), Math.Abs(_denominator));
                _numerator /= devider;
                _denominator /= devider;
            }
        }

        //мат. операторы
        public static Fraction operator + (Fraction num1, Fraction num2)
        {
            int newNumerator = num1._numerator * num2._denominator + num2._numerator * num1._denominator;
            int newDenominator = num1._denominator * num2._denominator;
            Fraction result = new Fraction(newNumerator, newDenominator);

            return result;
        }

        public static Fraction operator - (Fraction num1)
        {
            return new Fraction(-num1._numerator, num1._denominator);
        }

        public static Fraction operator - (Fraction num1, Fraction num2)
        {
            return num1 + (-num2);
        }

        public static Fraction operator * (Fraction num1, Fraction num2)
        {
            int newNumerator = num1._numerator * num2._numerator;
            int newDenominator = num1._denominator * num2._denominator;
            Fraction result = new Fraction(newNumerator, newDenominator);
            
            return result;
        }

        public static Fraction operator / (Fraction num1, Fraction num2)
        {
            int newNumerator = num1._numerator * num2._denominator;
            int newDenominator = num1._denominator * num2._numerator;
            Fraction result = new Fraction(newNumerator, newDenominator);

            return result;
        }

        //Явные и неявные операторы приведения
        public static implicit operator double(Fraction num)
        {
            return (double)num._numerator / num._denominator;
        }

        public static explicit operator int(Fraction num)
        {
            return num._numerator / num._denominator;
        }

        //Операторы сравнения
        public int CompareTo(object obj)
        {
            Fraction anotherFraction = obj as Fraction;

            if((double)_numerator / _denominator < anotherFraction)
                return -1;
            if((double)_numerator / _denominator > anotherFraction)
                return 1;
            return 0;
        }

        public bool Equals(Fraction anotherFraction)
        {
            if (anotherFraction is null)
                return false;
            return (double)_numerator / _denominator == anotherFraction;
        }

        public static bool operator < (Fraction num1, Fraction num2)
        {
            return num1 < (double)num2;
        }

        public static bool operator > (Fraction num1, Fraction num2)
        {
            return num1 > (double)num2;
        }

        public static bool operator >= (Fraction num1, Fraction num2)
        {
            return num1 >= (double)num2;
        }

        public static bool operator <= (Fraction num1, Fraction num2)
        {
            return num1 <= (double)num2;
        }

        public static bool operator == (Fraction num1, Fraction num2)
        {
            return num1.Equals(num2);
        }

        public static bool operator != (Fraction num1, Fraction num2)
        {
            return !num1.Equals(num2);
        }

        //Перевод в строку 
        public override string ToString()
        {
            Simplify();
            string res = _numerator == 0 ? "0"
                : _denominator == 1 ? $"{_numerator}"
                : $"{_numerator}/{_denominator}";

            return res;
        }
    }
}