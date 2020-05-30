using System;
using System.Text.RegularExpressions;

namespace laba_7
{
    class RationalNumber
    {
        public RationalNumber(int n, uint m)
        {
            N = n;
            M = m;
            fusion();
        }
        int _n;
        uint _m;

        public int N { get => _n; set => _n = value; }
        public uint M { get => _m; set => _m = value; }

        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            uint denom = a.M * b.M;
            int nom = (int)(a.N * (denom / a.M) + b.N * (denom / b.M));
            RationalNumber r = new RationalNumber(nom, denom);
            r.fusion();
            return r;
        }

        public static int operator +(int a, RationalNumber b)
        {
            uint denom = b.M;
            int nom = (int)(a * (denom) + b.N);
            RationalNumber r = new RationalNumber(nom, denom);
            r.fusion();
            return (int)(r.N / r.M);
        }

        public static int operator +(RationalNumber b, int a)
        {
            uint denom = b.M;
            int nom = (int)(a * (denom) + b.N);
            RationalNumber r = new RationalNumber(nom, denom);
            return (int)(r.N / r.M);
        }

        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            uint denom = a.M * b.M;
            int nom = (int)(a.N * (denom / a.M) - b.N * (denom / b.M));
            return new RationalNumber(nom, denom);


        }

        public static RationalNumber operator -(int a, RationalNumber b)
        {
            uint denom = b.M;
            int nom = (int)(a * (denom) - b.N);
            return new RationalNumber(nom, denom);

        }

        public static RationalNumber operator -(RationalNumber b, int a)
        {
            uint denom = b.M;
            int nom = (int)(-(a * denom) + b.N);
            return new RationalNumber(nom, denom);

        }

        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.N * b.N, a.M * b.M);
        }

        public static RationalNumber operator *(int a, RationalNumber b)
        {
            return new RationalNumber(a * b.N, b.M);
        }

        public static RationalNumber operator *(RationalNumber a, int b)
        {
            return new RationalNumber(a.N * b, a.M);
        }
        
        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            if (b.M >= 0)
            {
                if (b.N >= 0)
                {
                    return a * new RationalNumber((int)b.M, (uint)b.N);
                }
                else
                {
                    return a * new RationalNumber(-(int)b.M, (uint)-b.N);
                }
            }
            else
            {
                return a * new RationalNumber(-(int)(b.M), (uint)-b.N);
            }
        }

        public static RationalNumber operator /(int a, RationalNumber b)
        {
            if (b.N >= 0)
            {
                return a * new RationalNumber((int)b.M, (uint)b.N);
            }
            else
            {
                return a * new RationalNumber(-(int)b.M, (uint)-b.N);
            }
        }

        public static RationalNumber operator /(RationalNumber a, int b)
        {
            if (b < 0)
                return new RationalNumber(-a.N, (uint)(a.M * (-b)));
            else
            {
                return new RationalNumber(a.N, (uint)(a.M * b));
            }

        }

        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            if (a.N == b.N && a.M == b.M)
                return false;
            else
            {
                return true;
            }
        }

        public static bool operator ==(int a, RationalNumber b)
        {
            if (a / 1.0 == (float)b.N / b.M)
                return true;
            else
            {
                return false;
            }
        }

        public static bool operator ==(RationalNumber b, int a)
        {
            if (a / 1.0 == (float)b.N / b.M)
                return true;
            else
            {
                return false;
            }
        }

        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            if (a.N != b.N || a.M != b.M)
                return true;
            else
            {
                return false;
            }
        }

        public static bool operator !=(int a, RationalNumber b)
        {
            if (a / 1.0 != (float)b.N / b.M)
                return true;
            else
            {
                return false;
            }
        }

        public static bool operator !=(RationalNumber b, int a)
        {
            if (a / 1.0 != (float)b.N / b.M)
                return true;
            else
            {
                return false;
            }
        }

        public static bool operator ==(float a, RationalNumber b)
        {
            if (a / 1.0 == (float)b.N / b.M)
                return true;
            else
            {
                return false;
            }
        }

        public static bool operator ==(RationalNumber b, float a)
        {
            if (a / 1.0 == (float)b.N / b.M)
                return true;
            else
            {
                return false;
            }
        }

        public static bool operator !=(float a, RationalNumber b)
        {
            if (a / 1.0 != (float)b.N / b.M)
                return true;
            else
            {
                return false;
            }
        }

        public static bool operator !=(RationalNumber b, float a)
        {
            if (a / 1.0 != (float)b.N / b.M)
                return true;
            else
            {
                return false;
            }
        }

        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            if ((double)(a.N / a.M) > (double)(b.N / b.M))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(RationalNumber a, int b)
        {
            if ((double)(a.N / a.M) > (double)b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(int a, RationalNumber b)
        {
            if ((double)a > (double)(b.N / b.M))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            if ((double)(a.N / a.M) < (double)(b.N / b.M))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(RationalNumber a, int b)
        {
            if ((double)(a.N / a.M) < (double)b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(int a, RationalNumber b)
        {
            if ((double)a < (double)(b.N / b.M))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static explicit operator int(RationalNumber a)
        {
            return (int)(a.N / a.M);
        }

        public static explicit operator float(RationalNumber a)
        {
            return (float)a.N / a.M;
        }

        public override string ToString()
        {
            return Convert.ToString(N) + "/" + Convert.ToString(M);
        }

        public void fusion()
        {
            int a = N > M ? (int)M : N;
            for (int i = 2; i <= a / 2; i++)
            {
                if (N % i == 0 && M % i == 0)
                {
                    N /= i;
                    M /= (uint)i;
                }
            }
            if (a != 0)
                if (N % a == 0 && M % (uint)a == 0)
                {
                    N /= a;
                    M /= (uint)a;
                }
        }

        public static RationalNumber GetForomString(string s)
        {
            Regex regex = new Regex(@"^(\d)*");
            MatchCollection numbers = regex.Matches(s);
            Regex regex1 = new Regex(@"(\d)*$");
            RationalNumber ans = new RationalNumber(0, 0);
            ans.N = Convert.ToInt32(numbers[0].ToString());
            numbers = regex1.Matches(s);
            ans.M = (uint)Convert.ToInt32(numbers[0].ToString());
            return ans;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an expression");
            string expression = Console.ReadLine();
            Regex regex = new Regex(@"^(\d)*/\d* [/|*|+|-] (\d)*$");
            MatchCollection coll = regex.Matches(expression);
            if (coll.Count != 0)
            {
                regex = new Regex(@"^\d*/\d*");
                coll = regex.Matches(expression);
                string rn = coll[0].ToString();
                regex = new Regex(@"\d*$");
                string n = regex.Matches(expression)[0].ToString();
                switch (expression[rn.Length + 1])
                {
                    case '+':
                        Console.WriteLine($"Answer is {(float)RationalNumber.GetForomString(rn) + Convert.ToInt32(n)}");
                        break;
                    case '-':
                        Console.WriteLine($"Answer is {(float)RationalNumber.GetForomString(rn) - Convert.ToInt32(n)}");
                        break;
                    case '/':
                        Console.WriteLine($"Answer is {(float)(RationalNumber.GetForomString(rn) / Convert.ToInt32(n))}");
                        break;
                    case '*':
                        Console.WriteLine($"Answer is {(float)(RationalNumber.GetForomString(rn) * Convert.ToInt32(n))}");
                        break;
                }
            }

            regex = new Regex(@"^(\d)*/(\d)* [/|*|+|-] (\d)*/(\d)*$");
            coll = regex.Matches(expression);
            if (coll.Count != 0)
            {
                regex = new Regex(@"^\d*/\d*");
                coll = regex.Matches(expression);
                string rn = coll[0].ToString();
                regex = new Regex(@"\d*/\d*$");
                string n = regex.Matches(expression)[0].ToString();
                switch (expression[rn.Length + 1])
                {
                    case '+':
                        Console.WriteLine($"Answer is {RationalNumber.GetForomString(rn) + RationalNumber.GetForomString(n)}");
                        break;
                    case '-':
                        Console.WriteLine($"Answer is {(RationalNumber.GetForomString(rn) - RationalNumber.GetForomString(n)).ToString()}");
                        break;
                    case '/':
                        Console.WriteLine($"Answer is {(RationalNumber.GetForomString(rn) / RationalNumber.GetForomString(n)).ToString()}");
                        break;
                    case '*':
                        Console.WriteLine($"Answer is {(RationalNumber.GetForomString(rn) * RationalNumber.GetForomString(n)).ToString()}");
                        break;
                }
            }

            regex = new Regex(@"^(\d)* [/|*|+|-] (\d)*/(\d)*$");
            coll = regex.Matches(expression);
            if (coll.Count != 0)
            {
                regex = new Regex(@"^\d*");
                coll = regex.Matches(expression);
                string rn = coll[0].ToString();
                regex = new Regex(@"\d*/\d*$");
                string n = regex.Matches(expression)[0].ToString();
                switch (expression[rn.Length + 1])
                {
                    case '+':
                        Console.WriteLine($"Answer is {(float)RationalNumber.GetForomString(n) + Convert.ToInt32(rn)}");
                        break;
                    case '-':
                        Console.WriteLine($"Answer is {(float)RationalNumber.GetForomString(n) - Convert.ToInt32(rn)}");
                        break;
                    case '/':
                        Console.WriteLine($"Answer is {(float)(RationalNumber.GetForomString(n) / Convert.ToInt32(rn))}");
                        break;
                    case '*':
                        Console.WriteLine($"Answer is {(float)(RationalNumber.GetForomString(n) * Convert.ToInt32(rn))}");
                        break;
                }
            }
        }
    }
}
