using System;

namespace _1
{

    public class RationalNumber : IComparable, IEquatable<RationalNumber>
    {
        //whole/natural;(n/m)
        private readonly int _whole;
        private readonly int _natural;

        public RationalNumber(int whole, int natural)
        {
            _whole = whole;
            _natural = natural;
        }

        ~RationalNumber() { }

        public static RationalNumber operator +(RationalNumber o1, RationalNumber o2)
        {
            RationalNumber result;

            if (o1._natural == o2._natural)
                result = new RationalNumber(o1._whole + o2._whole, o1._natural);
            else
                result = new RationalNumber((o1._whole * o2._natural) + (o2._whole * o1._natural), o1._natural * o2._natural);

            return result;
        }

        public static RationalNumber operator -(RationalNumber o1, RationalNumber o2)
        {
            RationalNumber result;

            if (o1._natural == o2._natural)
                result = new RationalNumber(o1._whole - o2._whole, o1._natural);
            else
                result = new RationalNumber((o1._whole * o2._natural) - (o1._natural * o2._whole), o1._natural * o2._natural);
            return result;
        }

        public static RationalNumber operator *(RationalNumber o1, RationalNumber o2)
        {
            RationalNumber result = new RationalNumber(o1._whole * o2._whole, o1._natural * o2._natural);
            return result;
        }

        public static RationalNumber operator /(RationalNumber o1, RationalNumber o2)
        {
            RationalNumber result = new RationalNumber(o1._whole * o2._natural, o1._natural * o2._whole);
            return result;
        }


        public static bool operator >(RationalNumber o1, RationalNumber o2)
        {
            if (o1._whole == o2._whole && o1._natural == o2._natural)
                return false;
            else if (o1._natural == o2._natural & o1._whole > o2._whole)
                return true;
            else if (o1._whole == o2._whole & o1._natural < o2._natural)
                return true;
            else if (o1._whole != o2._whole & o1._natural != o2._natural)
            {
                RationalNumber resultOne = new RationalNumber(o1._whole * o2._natural, o1._natural * o2._natural);
                RationalNumber resultTwo = new RationalNumber(o2._whole * o1._natural, o1._natural * o2._natural);

                if (resultOne._whole > resultTwo._whole)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator <(RationalNumber o1, RationalNumber o2)
        {
            if (o1._whole == o2._whole & o1._natural == o2._natural)
                return false;
            else if (o1._natural == o2._natural && o1._whole < o2._whole)
                return true;
            else if (o1._whole == o2._whole & o1._whole > o2._natural)
                return true;
            else if (o1._whole != o2._whole & o1._natural != o2._natural)
            {
                RationalNumber resultOne = new RationalNumber(o1._whole * o2._natural, o1._natural * o2._natural);
                RationalNumber resultTwo = new RationalNumber(o2._whole * o1._natural, o1._natural * o2._natural);

                if (resultOne._whole < resultTwo._whole)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator >=(RationalNumber o1, RationalNumber o2)
        {
            if (o1._whole == o2._whole && o1._natural == o2._natural)
                return true;
            else if (o1._natural == o2._natural & o1._whole > o2._whole)
                return true;
            else if (o1._whole == o2._whole & o1._natural < o2._natural)
                return true;
            else if (o1._whole != o2._whole & o1._whole != o2._whole)
            {
                RationalNumber resultOne = new RationalNumber(o1._whole * o2._natural, o1._natural * o2._natural);
                RationalNumber resultTwo = new RationalNumber(o2._natural * o1._natural, o1._natural * o2._natural);

                if (resultOne._whole > resultTwo._whole)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator <=(RationalNumber o1, RationalNumber o2)
        {
            if (o1._whole == o2._whole & o1._natural == o2._natural)
                return true;
            else if (o1._natural == o2._natural && o1._whole < o2._whole)
                return true;
            else if (o1._whole == o2._whole & o1._natural > o2._natural)
                return true;
            else if (o1._whole != o2._whole & o1._natural != o2._natural)
            {
                RationalNumber resultOne = new RationalNumber(o1._whole * o2._natural, o1._natural * o2._natural);
                RationalNumber resultTwo = new RationalNumber(o2._whole * o1._natural, o1._natural * o2._natural);

                if (resultOne._whole < resultTwo._whole)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        //Convertion to string
        public override string ToString()
        {
            return $"{_whole} / {_natural}";
        }

        //Equality checks
        public bool Equals(RationalNumber other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _whole == other._whole && _natural == other._natural;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((RationalNumber)obj);
        }

        public override int GetHashCode()
        {
            return _whole.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj is RationalNumber p)
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

        public static implicit operator int(RationalNumber fraction)
        {
            return (fraction._whole / fraction._whole);
        }

        public static implicit operator double(RationalNumber fraction)
        {
            return (double)fraction._whole / fraction._natural;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber a, b;

            Console.WriteLine("Enter two number: ");
            var forNum = int.Parse(Console.ReadLine());
            var forDenum = int.Parse(Console.ReadLine());
            a = new RationalNumber(forNum, forDenum);

            Console.WriteLine("Now the same for the second fraction: ");
            forNum = int.Parse(Console.ReadLine());
            forDenum = int.Parse(Console.ReadLine());
            b = new RationalNumber(forNum, forDenum);

            Console.WriteLine("Result (a + b): {0}\n", (a + b).ToString());
            Console.WriteLine("Result (a - b): {0}\n", (a - b).ToString());
            Console.WriteLine("Result (a * b): {0}\n", (a * b).ToString());
            Console.WriteLine("Result (a / b): {0}\n", (a / b).ToString());
            Console.WriteLine(a.Equals(b));

            Console.WriteLine("Сomparison");

            if (a > b)
            {
                Console.WriteLine("This one ({0}) is bigger.", a.ToString());
            }
            else if (a < b)
            { 
                Console.WriteLine("This one ({0}) is bigger.", b.ToString()); 
            }
            else
            { 
                Console.WriteLine("Both are equal."); 
            }
                                       
            Console.ReadKey();

        }
    }
}