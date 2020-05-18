using System;
using System.Collections.Generic;
using System.Text;

namespace z1
{
    class RationalNumber : IComparable, IEquatable<RationalNumber>
    {
        private readonly int _numerator;
        private readonly int _denominator;
        public RationalNumber(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }
        public RationalNumber(string num)
        {
            char[] numer = new char[25];
            char[] denom = new char[25];
            int i = 0;
            for(int j = 0; i < num.Length; i++, j++)
            {
                if (num[i] == '/') 
                {
                    numer[j] = '\0';
                    i++;
                    break;
                }
                numer[j] = num[i];
            }
            for (int j = 0; i < num.Length; i++, j++)
            {
                   denom[j] = num[i];
            }
            string str1 = new string(numer);
            string str2 = new string(denom);
            _numerator = Convert.ToInt32(str1);
            _denominator = Convert.ToInt32(str2);
        }
        public static RationalNumber operator +(RationalNumber a, RationalNumber b) 
        {
            RationalNumber res;
            res = new RationalNumber(a._numerator * b._denominator + b._numerator * a._denominator , a._denominator * b._denominator);
            return res;
        }
        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            RationalNumber res;
            res = new RationalNumber(a._numerator * b._denominator - b._numerator * a._denominator, a._denominator * b._denominator);
            return res;
        }
        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            RationalNumber res;
            res = new RationalNumber(a._numerator * b._numerator, a._denominator * b._denominator);
            return res;
        }
        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            RationalNumber res;
            res = new RationalNumber(a._numerator * b._denominator, a._denominator * b._numerator);
            return res;
        }
        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            if (a.CompareTo(b) == -1)
                return true;
            else return false;
        }
        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            if (a.CompareTo(b) == 1)
                return true;
            else return false;
        }
        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            if (a.CompareTo(b) == 1|| a.CompareTo(b) == 0)
                return true;
            else return false;
        }
        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            if (a.CompareTo(b) == -1 || a.CompareTo(b) == 0)
                return true;
            else return false;
        }
        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return a.Equals(b);
        }
        public int CompareTo(object o) 
        {
            RationalNumber num = o as RationalNumber;
            if (num is RationalNumber)
            {
                if (_numerator * num._denominator < num._numerator * _denominator)
                    return -1;
                if (_numerator * num._denominator > num._numerator * _denominator)
                    return 1;
                return 0;
           }
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
        public bool Equals(RationalNumber a) 
        {
            if (a is null)
                return false;
            return _numerator * a._denominator == a._numerator * _denominator;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            RationalNumber num = obj as RationalNumber;
            if (num == null)
                return false;
            else
                return Equals(num);
        }
        public static explicit operator double(RationalNumber a)
        {
            return (double)a._numerator / a._denominator;
        }
        public static implicit operator int(RationalNumber a)
        {
            return a._numerator / a._denominator;
        }
        public override string ToString()
        {
            return ($"{_numerator}/{_denominator}");
        }
        ~RationalNumber() { }
    }
}
