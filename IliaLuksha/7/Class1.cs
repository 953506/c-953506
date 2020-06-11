using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Number : IComparable, IEquatable<Number>
    {
        private int _n;
        private int _m;

        public Number(int n, int m)
        {
                _n = n;
                _m = m;
        }

        public int Name { get; set; }
        public int CompareTo(object obj)
        {
            if (obj is Number p)
            {
                if (this > p)
                    return 1;
                else if (this < p)
                    return -1;
                else return 0;
            }
            else
                throw new Exception("Unable to compare these two objects!");
        }

        public bool Equals(Number other)
        {
            if (other == null)
                return false;
            if (this._n == other._n)
                return true;
            else
                return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Number exObj = obj as Number;
            if (exObj == null)
                return false;
            else
                return Equals(exObj);
        }

        public override int GetHashCode()
        {
            if (this.Name == 0)
            {
                return 0;
            }
            else
            {
                return this.Name.GetHashCode();
            }
        }

        public static bool operator ==(Number security1, Number security2)
        {
            if (security1 is null || (security2) is null)
            {
                return Object.Equals(security1, security2);
            }

            return security1.Equals(security2);
        }

        public static bool operator !=(Number security1, Number security2) => !(security1 == security2);

        public static Number operator +(Number o1, Number o2)
        {
            Number result;

            if (o1._m == o2._m)
                result = new Number(o1._n + o2._n, o1._m);
            else
                result = new Number((o1._n * o2._m) + (o2._n * o1._m), o1._m * o2._m);

            return result;
        }

        public static Number operator -(Number o1, Number o2)
        {
            Number result;

            if (o1._m == o2._m)
                result = new Number(o1._n - o2._n, o1._m);
            else
                result = new Number((o1._n * o2._m) - (o1._m * o2._n), o1._m * o2._m);
            return result;
        }

        public static Number operator *(Number o1, Number o2)
        {
            Number result = new Number(o1._n * o2._n, o1._m * o2._m);
            return result;
        }

        public static Number operator /(Number o1, Number o2)
        {
            Number result = new Number(o1._n * o2._m, o1._m * o2._n);
            return result;
        }

        public static bool operator >(Number o1, Number o2)
        {
            if (o1._n == o2._n && o1._m == o2._m)
                return false;
            else if (o1._m == o2._m & o1._n > o2._n)
                return true;
            else if (o1._n == o2._n & o1._m < o2._m)
                return true;
            else if (o1._n != o2._n & o1._m != o2._m)
            {

                if (o1._n * o2._m > o2._n * o1._m)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator <(Number o1, Number o2)
        {
            if (o1._n == o2._n & o1._m == o2._m)
                return false;
            else if (o1._m == o2._m && o1._n < o2._n)
                return true;
            else if (o1._n == o2._n & o1._n > o2._m)
                return true;
            else if (o1._n != o2._n & o1._m != o2._m)
            {
                if (o1._n * o2._m < o2._n * o1._m)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }


        public static bool operator >=(Number o1, Number o2)
        {
            if (o1._n == o2._n && o1._m == o2._m)
                return true;
            else if (o1._m == o2._m & o1._n > o2._n)
                return true;
            else if (o1._n == o2._n & o1._m < o2._m)
                return true;
            else if (o1._n != o2._n & o1._n != o2._n)
            {

                if (o1._n * o2._m > o2._n * o1._m)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator <=(Number o1, Number o2)
        {
            if (o1._n == o2._n & o1._m == o2._m)
                return true;
            else if (o1._m == o2._m && o1._n < o2._n)
                return true;
            else if (o1._n == o2._n & o1._m > o2._m)
                return true;
            else if (o1._n != o2._n & o1._m != o2._m)
            {
                if (o1._n * o2._m < o2._n * o1._m)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }


        public override string ToString()
        {
            return $"{_n} / {_m}";
        }

        public static explicit operator int(Number fraction)
        {
            return (fraction._n / fraction._m);
        }

        public static implicit operator double(Number fraction)
        {
            return (double)fraction._n / fraction._m;
        }

        public static bool Extraction(string stroka, out Number result)
        {
            int part1;
            int part2;
            result = null;
            string[] parts = stroka.Split('/');
            if (parts.Length == 2 && Int32.TryParse(parts[0], out part1) && Int32.TryParse(parts[1], out part2) && part1 != 0 && part2 > 0)
            {
                result = new Number(Convert.ToInt32(parts[0]), Convert.ToInt32(parts[1]));
                return true;
            }
            else if (parts.Length == 1)
            {
                parts = stroka.Split(',');
                if (parts.Length == 2 && Int32.TryParse(parts[0], out part1))
                {
                    for (int i = 0; i < parts[1].Length; i++)
                    {
                        if (parts[0][0] == '-')
                        {
                            part1 = part1 * 10 - (int)Char.GetNumericValue(parts[1][i]);
                        }
                        else
                        {
                            part1 = part1 * 10 + (int)Char.GetNumericValue(parts[1][i]);
                        }
                    }
                    result = new Number(part1, (int)Math.Pow(10, parts[1].Length));
                    return true;
                }
                else if (parts.Length == 1 && Int32.TryParse(parts[0], out part1))
                {
                    result = new Number(part1, 1);
                    return true;
                }
            }
            return false;
        }
    }
}
