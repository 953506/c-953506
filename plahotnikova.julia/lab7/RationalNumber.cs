using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
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

        public RationalNumber(string str)
        {
            if (str != "")
            {
                char ch = '/';
                string[] num = str.Split(ch);
                int[] c = new int[num.Length];

                for (int i = 0; i < num.Length; i++)
                {
                    c[i] = Convert.ToInt32(num[i]);
                }

                _numerator = c[0];
                _denominator = c[1];
            }
            else
            {
                _numerator = 0;
                _denominator = 1;
            }
        }

        public static RationalNumber operator +(RationalNumber frst, RationalNumber sec)
        {
            return new RationalNumber((frst._numerator * sec._denominator) + (sec._numerator * frst._denominator),
                frst._denominator * sec._denominator);
        }

        public static RationalNumber operator -(RationalNumber frst, RationalNumber sec)
        {
            return new RationalNumber((frst._numerator * sec._denominator) - (sec._numerator * frst._denominator),
                frst._denominator * sec._denominator);
        }

        public static RationalNumber operator *(RationalNumber frst, RationalNumber sec)
        {
            return new RationalNumber(frst._numerator * sec._numerator, frst._denominator * sec._denominator);
        }

        public static RationalNumber operator /(RationalNumber frst, RationalNumber sec)
        {
            return new RationalNumber(frst._numerator * sec._denominator, frst._denominator * sec._numerator);
        }

        public static bool operator >(RationalNumber frst, RationalNumber sec)
        {
            return (double)frst > (double)sec;
        }

        public static bool operator <(RationalNumber frst, RationalNumber sec)
        {
            return (double)frst < (double)sec;
        }

        public static bool operator >=(RationalNumber frst, RationalNumber sec)
        {
            return (double)frst >= (double)sec;
        }

        public static bool operator <=(RationalNumber frst, RationalNumber sec)
        {
            return (double)frst <= (double)sec;
        }

        public static bool operator ==(RationalNumber frst, RationalNumber sec)
        {
            return frst.Equals((object)sec);
        }

        public static bool operator !=(RationalNumber frst, RationalNumber sec)
        {
            return !frst.Equals((object)sec);
        }

        public static explicit operator double(RationalNumber num)
        {
            return (double)num._numerator / num._denominator;
        }

        public static explicit operator int(RationalNumber num)
        {
            return num._numerator / num._denominator;
        }

        public bool Equals(RationalNumber another)
        {
            return _numerator * another._denominator == another._numerator * _denominator;
        }

        public string ToStringFormat1()
        {
            return $"{_numerator}/{_denominator}";
        }

        public string ToStringFormat2()
        {
            return $"{_numerator / (double)_denominator}";
        }

    }
}
