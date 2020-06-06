using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab_7
{
    class RationalNumber : IComparable<RationalNumber>, IEquatable<RationalNumber>
    {
        private long _n;
        private long _m;
        private static long FindGCD(long a, long b) 
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0) return b;
            else if (b == 0) return a;
            else if (a == b) return a;
            else if (a == 1 || b == 1) return 1;
            else if ((a % 2 == 0) && (b % 2 == 0)) return 2 * FindGCD(a / 2, b / 2);
            else if ((a % 2 == 0) && (b % 2 != 0)) return FindGCD(a / 2, b);
            else if ((a % 2 != 0) && (b % 2 == 0)) return FindGCD(a, b / 2);
            else return FindGCD(b, (int)Math.Abs(a - b));
        }

        public RationalNumber(long _n, long _m)
        {
            long GCD = FindGCD(_n, _m);
            this._n = _n / GCD;
            this._m = _m / GCD;
        }

        public int CompareTo(RationalNumber num_2)
        {
            if ((double)this > (double)num_2)
                return 1;
            else if ((double)this < (double)num_2)
                return -1;
            else
                return 0;
        }

        public int CompareTo(object other)
        {
            if (other is RationalNumber)
                return CompareTo((RationalNumber)other);
            else
                throw new InvalidOperationException("CompareTo: not a rational number");
        }

        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }
            if (other is RationalNumber)
            {
                return Equals((RationalNumber)other);
            }
            return false;
        }
        
        public bool Equals(RationalNumber other)
        {
            if (other == null)
                return false;
            else
                return (this._n == other._n && this._m == other._m);
        }

        public override int GetHashCode()
        {
            return (int)(_n * 17 + _m);
        }

        public static RationalNumber operator +(RationalNumber num_1, RationalNumber num_2)
        {
            long mm_GCD = FindGCD(num_1._m, num_2._m);
            long new_n = num_1._n * (num_2._m / mm_GCD) + num_2._n * (num_1._m / mm_GCD);
            long new_m = num_1._m * (num_2._m / mm_GCD);
            long nm_GCD = FindGCD(new_n, new_m);
            return new RationalNumber(new_n / nm_GCD, new_m / nm_GCD);
        }

        public static RationalNumber operator -(RationalNumber num_1, RationalNumber num_2)
        {
            long mm_GCD = FindGCD(num_1._m, num_2._m);
            long new_n = num_1._n * (num_2._m / mm_GCD) - num_2._n * (num_1._m / mm_GCD);
            long new_m = num_1._m * (num_2._m / mm_GCD);
            long nm_GCD = FindGCD(new_n, new_m);
            return new RationalNumber(new_n / nm_GCD, new_m / nm_GCD);
        }

        public static RationalNumber operator *(RationalNumber num_1, RationalNumber num_2)
        {
            long new_n = num_1._n * num_2._n;
            long new_m = num_1._m * num_2._m;
            long nm_GCD = FindGCD(new_n, new_m);
            return new RationalNumber(new_n / nm_GCD, new_m / nm_GCD);
        }

        public static RationalNumber operator /(RationalNumber num_1, RationalNumber num_2)
        {
            long new_n = num_1._n * num_2._m;
            long new_m = num_1._m * num_2._n;
            long nm_GCD = FindGCD(new_n, new_m);
            return new RationalNumber(new_n / nm_GCD, new_m / nm_GCD);
        }

        public static bool operator <(RationalNumber num_1, RationalNumber num_2)
        {
            return num_1.CompareTo(num_2) < 0;
        }

        public static bool operator >(RationalNumber num_1, RationalNumber num_2)
        {
            return num_1.CompareTo(num_2) > 0;
        }

        public static bool operator <=(RationalNumber num_1, RationalNumber num_2)
        {
            return num_1.CompareTo(num_2) <= 0;
        }

        public static bool operator >=(RationalNumber num_1, RationalNumber num_2) 
        {
            return num_1.CompareTo(num_2) >= 0;
        }

        public static explicit operator long(RationalNumber num)
        {
            return num._n / num._m;
        }

        public static explicit operator double(RationalNumber num)
        {
            return (double)num._n / num._m;
        }

        public string RationalToString()
        {
            string str = $"{_n}/{_m}";
            return str;
        }

        public string RationalToStringDouble()
        {
            string str = $"{_n / _m}";
            return str;
        }

        public static RationalNumber StringToRational(string str) 
        {
            string pattern1 = @"^-?\d{1,9}\s*\/\s*\d{1,9}$";
            string pattern2 = @"^-?\d{1,9}\s*\.\s*\d{1,9}$";
            if (Regex.IsMatch(str, pattern1))
            {
                string[] numbers = str.Split(new char[] { ' ', '/' }, StringSplitOptions.RemoveEmptyEntries);
                long _n = long.Parse(numbers[0]); 
                long _m = long.Parse(numbers[1]);
                if (_m == 0)
                {
                    Console.WriteLine("The denominator cannot be equal to zero");
                    return null;
                }
                else
                {
                    return new RationalNumber(_n, _m);
                }
            }
            else if (Regex.IsMatch(str, pattern2))
            {
                string[] numbers = str.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
                long _n = long.Parse(numbers[0] + numbers[1]);
                long _m = (long)Math.Pow(10, numbers[1].Length);
                if (_m == 0)
                {
                    Console.WriteLine("The denominator cannot be equal to zero");
                    return null;
                }
                else
                {
                    return new RationalNumber(_n, _m);
                }
            }
            else
            {
                return null;
            }
        }
    }
}
