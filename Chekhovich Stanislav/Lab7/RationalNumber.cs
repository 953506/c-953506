using System;

namespace Lab7
{
    class RationalNumber : IComparable, IEquatable<RationalNumber>
    {
        //--------------Поля
        private int _numerator;
        private int _denominator;

        //--------------Конструктор
        public RationalNumber(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        //--------------Перегрузка операторов
        public static RationalNumber operator + (RationalNumber r1, RationalNumber r2)
        {
            RationalNumber result = new RationalNumber((r1._numerator * r2._denominator) + (r2._numerator * r1._denominator) , r1._denominator * r2._denominator);
            result.ReduceWithGCD();
            return result;
        }

        public static RationalNumber operator - (RationalNumber r1, RationalNumber r2)
        {
            RationalNumber result = new RationalNumber((r1._numerator * r2._denominator) - (r2._numerator * r1._denominator), r1._denominator * r2._denominator);
            result.ReduceWithGCD();
            return result;
        }

        public static RationalNumber operator * (RationalNumber r1, RationalNumber r2)
        {
            RationalNumber result = new RationalNumber(r1._numerator * r2._numerator , r1._denominator * r2._denominator);
            result.ReduceWithGCD();
            return result;
        }

        public static RationalNumber operator / (RationalNumber r1, RationalNumber r2)
        {
            int numerator = r2._numerator < 0 ? -r1._numerator * r2._denominator : r1._numerator * r2._denominator;
            int denominator = r2._numerator < 0 ? -r1._denominator * r2._numerator : r1._denominator * r2._numerator;
            RationalNumber result = new RationalNumber(numerator, denominator);
            result.ReduceWithGCD();
            return result;
        }

        public static bool operator > (RationalNumber r1, RationalNumber r2)
        {
            return r1 > (double)r2;
        }

        public static bool operator < (RationalNumber r1, RationalNumber r2)
        {
            return r1 < (double)r2;
        }

        public static bool operator >= (RationalNumber r1, RationalNumber r2)
        {
            return r1 >= (double)r2;
        }

        public static bool operator <= (RationalNumber r1, RationalNumber r2)
        {
            return r1 <= (double)r2;
        }

        public static bool operator == (RationalNumber r1, RationalNumber r2)
        {
            return r1.Equals((object)r2);
        }

        public static bool operator != (RationalNumber r1, RationalNumber r2)
        {
            return !r1.Equals((object)r2);
        }

        //--------------Методы
        public static bool Extraction(string str, out RationalNumber result)
        {
            int part1;
            int part2;
            result = null;
            string[] parts = str.Split('/');
            if (parts.Length == 2 && Int32.TryParse(parts[0], out part1) && Int32.TryParse(parts[1], out part2) && part1 != 0 && part2 > 0)
            {
                result = new RationalNumber(Convert.ToInt32(parts[0]), Convert.ToInt32(parts[1]));
                return true;
            }
            else if(parts.Length == 1)
            {
                parts = str.Split(',');
                if (parts.Length == 2 && Int32.TryParse(parts[0], out part1))
                {
                    for (int i = 0; i < parts[1].Length; i++) 
                    {
                        if(parts[0][0] == '-')
                        {
                            part1 = part1 * 10 - (int)Char.GetNumericValue(parts[1][i]);
                        }
                        else
                        {
                            part1 = part1 * 10 + (int)Char.GetNumericValue(parts[1][i]);
                        }
                    }
                    result = new RationalNumber(part1, (int)Math.Pow(10, parts[1].Length));
                    return true;
                }
                else if (parts.Length == 1 && Int32.TryParse(parts[0], out part1))
                {
                    result = new RationalNumber(part1, 1);
                    return true;
                }
            }
            return false;
        }

        public int CompareTo(object obj)
        {
            RationalNumber rationalNumber = obj as RationalNumber;
            if(obj != null)
            {
                double r1 = _numerator / (double)_denominator;
                double r2 = rationalNumber._numerator / (double)rationalNumber._denominator;
                return r1.CompareTo(r2);
            }
            else
            {
                throw new ArgumentException("Object is not a RationalNumber");
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            RationalNumber objAsRN = obj as RationalNumber;
            if (objAsRN == null)
            {
                return false;
            }
            else
            {
                return Equals(objAsRN);
            }
        }

        public bool Equals(RationalNumber other)
        {
            if (other == null)
            {
                return false;
            }
            return _numerator * other._denominator == other._numerator * _denominator;
        }

        private void ReduceWithGCD()
        {
            int a = _numerator < 0 ? -_numerator : _numerator;
            int b = _denominator < 0 ? -_denominator : _denominator;
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            _numerator /= a;
            _denominator /= a;
        }

        public string ToStringFormat1()
        {
            return $"{_numerator}/{_denominator}"; 
        }

        public string ToStringFormat2()
        {
            return $"{_numerator / (double)_denominator}";
        }

        //--------------Перегрузка операций преобразования типов
        public static implicit operator int(RationalNumber r)
        {
            return r._numerator / r._denominator;
        }

        public static explicit operator double(RationalNumber r)
        {
            return r._numerator / (double)r._denominator;
        }
    }
}
