using System;

namespace Lab_7_Ind_1
{
    public class RationalNumber : IComparable, IEquatable<RationalNumber>
    {
        //Fields
        private readonly int _numerator;
        private readonly int _denominator;
        
        //Constructor
        public RationalNumber(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }
        
        //Destructor
        ~RationalNumber() { }

        //Mathematical operations
        public static RationalNumber operator +(RationalNumber o1, RationalNumber o2)
        {
            RationalNumber result;
            
            if (o1._denominator == o2._denominator)
                result = new RationalNumber(o1._numerator + o2._numerator, o1._denominator);
            else 
                result = new RationalNumber((o1._numerator * o2._denominator) + (o2._numerator * o1._denominator),o1._denominator * o2._denominator);
            
            return result;
        }

        public static RationalNumber operator -(RationalNumber o1, RationalNumber o2)
        {
            RationalNumber result;
            
            if (o1._denominator == o2._denominator)
                result = new RationalNumber(o1._numerator - o2._numerator, o1._denominator);
            else 
                result = new RationalNumber((o1._numerator * o2._denominator) - (o2._numerator * o1._denominator),o1._denominator * o2._denominator);
            return result;
        }

        public static RationalNumber operator *(RationalNumber o1, RationalNumber o2)
        {
            RationalNumber result = new RationalNumber(o1._numerator * o2._numerator,o1._denominator * o2._denominator);
            return result;
        }

        public static RationalNumber operator /(RationalNumber o1, RationalNumber o2)
        {
            RationalNumber result = new RationalNumber(o1._numerator * o2._denominator,o1._denominator * o2._numerator);
            return result;
        }
        
        //Comparison operations
        public static bool operator >(RationalNumber o1, RationalNumber o2)
        {
            if (o1._numerator == o2._numerator && o1._denominator == o2._denominator)
                return false;
            else if (o1._denominator == o2._denominator & o1._numerator > o2._numerator)
                return true;
            else if (o1._numerator == o2._numerator & o1._denominator < o2._denominator)
                return true;
            else if (o1._numerator != o2._numerator & o1._denominator != o2._denominator)
            {
                RationalNumber resultOne = new RationalNumber(o1._numerator * o2._denominator, o1._denominator * o2._denominator);
                RationalNumber resultTwo = new RationalNumber(o2._numerator * o1._denominator, o1._denominator * o2._denominator);
                
                if (resultOne._numerator > resultTwo._numerator)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator <(RationalNumber o1, RationalNumber o2)
        {
            if (o1._numerator == o2._numerator & o1._denominator == o2._denominator)
                return false;
            else if (o1._denominator == o2._denominator && o1._numerator < o2._numerator)
                return true;
            else if (o1._numerator == o2._numerator & o1._denominator > o2._denominator)
                return true;
            else if (o1._numerator != o2._numerator & o1._denominator != o2._denominator)
            {
                RationalNumber resultOne = new RationalNumber(o1._numerator * o2._denominator, o1._denominator * o2._denominator);
                RationalNumber resultTwo = new RationalNumber(o2._numerator * o1._denominator, o1._denominator * o2._denominator);

                if (resultOne._numerator < resultTwo._numerator)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        
        public static bool operator >=(RationalNumber o1, RationalNumber o2)
        {
            if (o1._numerator == o2._numerator && o1._denominator == o2._denominator)
                return true;
            else if (o1._denominator == o2._denominator & o1._numerator > o2._numerator)
                return true;
            else if (o1._numerator == o2._numerator & o1._denominator < o2._denominator)
                return true;
            else if (o1._numerator != o2._numerator & o1._denominator != o2._denominator)
            {
                RationalNumber resultOne = new RationalNumber(o1._numerator * o2._denominator, o1._denominator * o2._denominator);
                RationalNumber resultTwo = new RationalNumber(o2._numerator * o1._denominator, o1._denominator * o2._denominator);
                
                if (resultOne._numerator > resultTwo._numerator)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator <=(RationalNumber o1, RationalNumber o2)
        {
            if (o1._numerator == o2._numerator & o1._denominator == o2._denominator)
                return true;
            else if (o1._denominator == o2._denominator && o1._numerator < o2._numerator)
                return true;
            else if (o1._numerator == o2._numerator & o1._denominator > o2._denominator)
                return true;
            else if (o1._numerator != o2._numerator & o1._denominator != o2._denominator)
            {
                RationalNumber resultOne = new RationalNumber(o1._numerator * o2._denominator, o1._denominator * o2._denominator);
                RationalNumber resultTwo = new RationalNumber(o2._numerator * o1._denominator, o1._denominator * o2._denominator);
                
                if (resultOne._numerator < resultTwo._numerator)
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
            return $"{_numerator} / {_denominator}";
        }

        //Equality checks
        public bool Equals(RationalNumber other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _numerator == other._numerator && _denominator == other._denominator;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((RationalNumber) obj);
        }

        public override int GetHashCode()
        {
            return _numerator.GetHashCode();
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

        //Implicit type cast cover
        public static implicit operator int(RationalNumber fraction)
        {
            return (fraction._numerator / fraction._denominator);
        }

        public static implicit operator double(RationalNumber fraction)
        {
            return (double) fraction._numerator / fraction._denominator;
        }
    }
}