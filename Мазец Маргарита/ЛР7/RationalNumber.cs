using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР7
{
    class RationalNumber: IComparable, IComparer<RationalNumber>, IEquatable<RationalNumber>
    {
        //поля для представления числа
        private int _numerator;
        private int _denominator;
      
        //конструктор
        public RationalNumber(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        //деструктор
        ~RationalNumber() {}

        //реализация интерфейсов
        public int CompareTo(object o)
        {
            RationalNumber r = o as RationalNumber;
            int num1 = _numerator * r._denominator;
            int num2 = r._numerator * _denominator;
            if (num1 < num2)
                return -1;
            if (num1 > num2)
                return 1;
            return 0;
        }

        public int Compare(RationalNumber r1, RationalNumber r2)
        {
            int num1 = r1._numerator * r2._denominator;
            int num2 = r2._numerator *r1._denominator;
            if (num1 > num2)
                return 1;
            if (num1 < num2)
                return -1;
            return 0;
        }
        public bool Equals(RationalNumber another)
        {
            if (another is null)
                return false;
            return _numerator * another._denominator == another._numerator * _denominator;
        }


        static private int NOD(int a, int b)
        {
            if (a > b)
            {
                int balance = 0, nod = 1;
                int del;
                while (true)
                {
                    del = a / b;
                    balance = a - del * b;
                    a = b;
                    b = balance;
                    if (balance == 0)
                        return nod;
                    nod = balance;
                }
            }
            else if (a < b)
            {
                int balance = 0, nod = 1;
                int del;
                while (true)
                {
                    del = b / a;
                    balance = b - del * a;
                    b = a;
                    a = balance;
                    if (balance == 0)
                        return nod;
                    nod = balance;
                }
            }
            else
                return a;
        }

        //Сокращение
        static private void reduction(int numerator, int denominator)
        {
            int nod = NOD(numerator,denominator);
            if (nod != 1)
            {
                numerator = numerator / nod;
                denominator = denominator / nod;
            }
        }

        //математические операции
        public static RationalNumber operator -(RationalNumber a)
        {
            return new RationalNumber ( -a._numerator,a._denominator);
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
                int numerator= a._numerator * b._denominator + b._numerator * a._denominator;
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
                int denominator = a._denominator * b._denominator;
                int numerator = a._numerator * b._denominator - b._numerator * a._denominator;
                reduction(numerator, denominator);
                return new RationalNumber(numerator, denominator);
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

        //операции сравнения
        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            //if(Compare(a,b)==1)
            if (a.CompareTo(b)==1)
                return true;
            else
                return false;
        }
        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            //if(Compare(a,b)==-1)
            if (a.CompareTo(b) == -1)
                return true;
            else
                return false;
        }

        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            //if(Compare(a,b)==1 && Compare(a,b)==0)
            if (a.CompareTo(b) == 1 || a.CompareTo(b)==0)
                return true;
            else
                return false;
        }

        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            //if(Compare(a,b)==-1 && Compare(a,b)==0)
            if (a.CompareTo(b) == -1 || a.CompareTo(b) == 0)
                return true;
            else
                return false;
        }

        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            //if(a.Equals(b))
            //if(Compare(a,b)==0)
            if (a.CompareTo(b) == 0)
                return true;
            else
                return false;
        }
        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            //if(!a.Equals(b))
            //if(Compare(a,b)!=0)
            if (a.CompareTo(b) != 0)
                return true;
            else
                return false;
        }

        //операциb преобразования типов
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
            return ($"{(double)(_numerator/_denominator)}");
        }

    }
}
