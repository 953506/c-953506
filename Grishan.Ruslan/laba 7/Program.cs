using System;

namespace LABA7
{
    class Program
    {
        class RationalNumber :IEquatable<RationalNumber>, IComparable
        {
            private int _n, _m;
            public RationalNumber(int n, int m)
            {
                _n = n;
                _m = (m > 0) ? m : 1;
                Reduction(n, m);
            }
            public int N
            {
                get { return _n; }
                set { _n = value; }
            }

            public int M
            {
                get { return _m; }
                set
                {
                    if (value > 0)
                        _m = value;
                    else
                        throw new Exception("Число должно быть натуральным!");
                }
            }
            //операторы действий
            public static RationalNumber operator +(RationalNumber a, RationalNumber b)
            {
                int num, dem;
                num = a._n * b._m + b._n * a._m; 
                dem = a._m * b._m;
                RationalNumber result = new RationalNumber(num,dem);
                return result;
            }

            public static RationalNumber operator -(RationalNumber a, RationalNumber b)
            {
                int num, dem;
                num = a._n * b._m - b._n * a._m; 
                dem=a._m * b._m;
                RationalNumber result = new RationalNumber(num, dem);
                return result;
            }
            public static RationalNumber operator *(RationalNumber a, RationalNumber b)
            {
                int num, dem;
                num = a._n * b._n; 
                dem=a._m * b._m;
                RationalNumber result = new RationalNumber(num, dem);
                return result;
            }

            public static RationalNumber operator /(RationalNumber a, RationalNumber b)
            {
                int num, dem;
                num = a._n * b._m;
                dem=a._m * b._n;
                RationalNumber result = new RationalNumber(num, dem);
                return result;
            }
            // сокращение
            static private int NOD(int n, int m)
            {
                int p = 0;
                n = Math.Abs(n); 
                m = Math.Abs(m); 
                if (m > n) 
                { 
                    p = n; 
                    n = m; 
                    m = p; 
                }
                do
                {
                    p = n % m; 
                    n = m; 
                    m = p;
                } while (m != 0); 
                return (n);
            }
            void Reduction(int n, int m)
            {
                int nod = NOD(n, m);
                if (nod != 1)
                {
                    N = n / nod;
                    M = m / nod;
                }
            }
            // сравнение
            public bool Equals(RationalNumber another)
            {
                if (another is null)
                    return false;
                return _n * another._m == another._n * _m;
            }
            public int CompareTo(object o)
            {
                RationalNumber r = o as RationalNumber;
                int num1 = _n * r._m;
                int num2 = r._n * _m;
                if (num1 < num2)
                    return -1;
                if (num1 > num2)
                    return 1;
                return 0;
            }
            public static int Compare(RationalNumber a, RationalNumber b)
            {
                int num1 = a._n * b._m;
                int num2 = b._n * a._m;
                if (num1 > num2)
                    return 1;
                if (num1 < num2)
                    return -1;
                return 0;
            }
            //операторы сравнеия
            public static bool operator >(RationalNumber a, RationalNumber b)
            {
                if (a.CompareTo(b) == 1)
                    return true;
                else
                    return false;
            }
            public static bool operator <(RationalNumber a, RationalNumber b)
            {
                if (a.CompareTo(b) == -1)
                    return true;
                else
                    return false;
            }

            public static bool operator >=(RationalNumber a, RationalNumber b)
            {
                if(Compare(a,b)==1 && Compare(a,b)==0)
                    return true;
                else
                    return false;
            }

            public static bool operator <=(RationalNumber a, RationalNumber b)
            {
                if(Compare(a,b)==-1 && Compare(a,b)==0)
                
                    return true;
                else
                    return false;
            }
            public static bool operator ==(RationalNumber a, RationalNumber b)
            {
                if(a.Equals(b))
                
                    return true;
                else
                    return false;
            }
            public static bool operator !=(RationalNumber a, RationalNumber b)
            {
                if (!a.Equals(b))
                    return true;
                else
                    return false;
            }
            // вывод
            public override string ToString()
            {
                return string.Format("{0}/{1}", _n, _m);
            }
        }

        static void Main(string[] args)
        {
            RationalNumber chislo = new RationalNumber(1,5);
            RationalNumber chislo1 = new RationalNumber(1,8);
            Console.WriteLine(chislo);
            Console.WriteLine(chislo1);
            Console.WriteLine(chislo + chislo1);
            Console.WriteLine(chislo1 - chislo);
            Console.WriteLine(chislo1 * chislo);
            Console.WriteLine(chislo1 / chislo);
            if (chislo > chislo1) Console.WriteLine(">");
            else Console.WriteLine("<");
            if (chislo == chislo1) Console.WriteLine("=");
            else Console.WriteLine("!=");

        }
    }
}