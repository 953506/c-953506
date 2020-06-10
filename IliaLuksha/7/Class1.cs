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
            if(n % 1 == 0 && m % 1 == 0)
            {
                _n = n;
                _m = m;
            }
            else
                throw new Exception("Numbers are not integer!");
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
                Number resultOne = new Number(o1._n * o2._m, o1._m * o2._m);
                Number resultTwo = new Number(o2._n * o1._m, o1._m * o2._m);

                if (resultOne._n > resultTwo._n)
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
                Number resultOne = new Number(o1._n * o2._m, o1._m * o2._m);
                Number resultTwo = new Number(o2._n * o1._m, o1._m * o2._m);

                if (resultOne._n < resultTwo._n)
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
                Number resultOne = new Number(o1._n * o2._m, o1._m * o2._m);
                Number resultTwo = new Number(o2._m * o1._m, o1._m * o2._m);

                if (resultOne._n > resultTwo._n)
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
                Number resultOne = new Number(o1._n * o2._m, o1._m * o2._m);
                Number resultTwo = new Number(o2._n * o1._m, o1._m * o2._m);

                if (resultOne._n < resultTwo._n)
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

        public static implicit operator int(Number fraction)
        {
            return (fraction._n / fraction._m);
        }

        public static explicit operator double(Number fraction)
        {
            return (double)fraction._n / fraction._m;
        }

    }
}
