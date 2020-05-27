using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace lr7
{

    class RationalNumber: IEquatable<RationalNumber>, IComparable
    {

        //------------Поля
        private int _numerator;
        private int _denominator;
        
        //--------Конструктор
        public RationalNumber (int integer, int naturalNumber )
        {
            _numerator = integer;
            while (naturalNumber == 0)
                naturalNumber = Convert.ToInt32(Console.ReadLine());
            _denominator = naturalNumber;
        }

        //---------Перегрузка операторов
        public static RationalNumber operator + (RationalNumber num1, RationalNumber num2)
        {
            RationalNumber result = new RationalNumber((num1._numerator * num2._denominator + num2._numerator * num1._denominator), num1._denominator * num2._denominator);
            return result;
        }

        public static RationalNumber operator - (RationalNumber num1, RationalNumber num2)
        {
            RationalNumber result =  new RationalNumber((num1._numerator * num2._denominator - num2._numerator * num1._denominator), num1._denominator * num2._denominator);
            return result;
        }

        public static RationalNumber operator *(RationalNumber num1, RationalNumber num2)
        {
            RationalNumber result = new RationalNumber(num1._numerator * num2._numerator, num1._denominator * num2._denominator);
            return result;
        }

        public static RationalNumber operator /(RationalNumber num1, RationalNumber num2)
        {             
                RationalNumber result = new RationalNumber(num1._numerator * num2._denominator, num1._denominator * num2._numerator);
                return result;          
        }

        public static bool operator >(RationalNumber num1, RationalNumber num2)
        {
            return num1 >(double) num2;
        }

        public static bool operator < (RationalNumber num1, RationalNumber num2)
        {
            return num1 >(double) num2;
        }

        public static bool operator >=(RationalNumber num1, RationalNumber num2)
        {
            return num1 >=(double) num2;
        }

        public static bool operator <=(RationalNumber num1, RationalNumber num2)
        {
            return num1 <=(double) num2;
        }

        public static bool operator ==(RationalNumber num1, RationalNumber num2)
        {
            return num1.Equals((object)num2);
        }

        public static bool operator !=( RationalNumber num1, RationalNumber num2)
        {
            return !num1.Equals((object)num2);
        }

        //--------Методы
        public override bool Equals(object obj)
        {
            if(obj==null)
            {
                return false;
            }
            RationalNumber objtest = obj as RationalNumber;
            if (objtest == null)
            {
                return false;
            }
            else
                return Equals(objtest);
        }

        public bool Equals (RationalNumber  other)
        {
            if (other == null)
                return false;
            if (this._numerator == other._numerator && this._denominator == other._denominator)
                return true;
            else return false;
        }

        public static void Initialization(string input, out RationalNumber number)
        {
            int num, denom;
            string[] cell = input.Split(' ','/');
            if (cell.Length == 1&&Int32.TryParse(cell[0],out num))
            {
                number = new RationalNumber(num, 1);
                return;
            }                
            else if (cell.Length == 2 && Int32.TryParse(cell[0], out num) && Int32.TryParse(cell[1], out denom) && denom > 0)
            {
                number = new RationalNumber(num, denom);
                return;
            }
            else
            {
                throw new Exception("Input Error");
            }              
        }

        public static  string ToStringIrreducible(RationalNumber result)
        {
            int gcd = GCD(result);
            result._numerator /= gcd;
            result._denominator /=gcd;
            int full;
            if (Math.Abs(result._numerator) > Math.Abs(result._denominator))
            {
                full = result._numerator / result._denominator;
                return $"{full} {Math.Abs(result._numerator % result._denominator)}/{result._denominator}";
            }
            else
                return $"{result._numerator}/{result._denominator}";
        }

        public static string ToString(RationalNumber result)
        {
            return $"{result._numerator}" +
                "\n---" +
                $"\n{result._denominator}";
        }

        private static int GCD(RationalNumber num)
        {
            int a = num._numerator;
            int b = num._denominator;
            if (a == 0)
            {
                return b;
            }
            while (b != 0)
            {
                if (Math.Abs(a) > Math.Abs(b))
                   a -=Math.Abs( b);                
                else                
                    b -= Math.Abs(a);               
            }
            return Math.Abs(a);
        }

        public int CompareTo (object obj)
        {
            if (obj == null)
                return 1;
            RationalNumber objTransform = obj as RationalNumber;
            if(objTransform!=null)
            {
                double num1 = _numerator / _denominator;
                double num2 = objTransform._numerator / objTransform._denominator;
                return num2.CompareTo(num1);
            }
            else
            {
                throw new ArgumentException("Object is a not rational number");
            }
            
        }

        //-------Перегрузка операций преобразования типов
        public static implicit operator bool (RationalNumber num)
        {
            if (num._numerator!=0) return true;
            else return false;
        }

        public static explicit operator int(RationalNumber num)
        {
            return num._numerator / num._denominator;
        }

        public static implicit operator double(RationalNumber num)
        {
            return (double)num._numerator /(double) num._denominator;
        }   
    }
}
