using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace _7
{
    class RationalNums: IComparable
    {
        public double numerator = 0;
        public int denominator = 0;
        static public string delimeter;
        static public string input;
        
        //Конструктор
        public RationalNums(string _input)
        {
            input = _input;
            converter(input);
        }
        
        //Перегрузка
        public RationalNums(int _num, int _denom)
        {
            numerator = _num;
            denominator = _denom;
        }

        //Еще одна
        public RationalNums()
        {
            numerator = 0;
            denominator = 0;
        }

        //Метод по переводу строки в число
        private void converter(string input)
        {
            Regex regex1 = new Regex(@"^\d+[\/:]\d+$");
            Regex regex2 = new Regex(@"^\d+(,\d+){0,1}$");
            if (!regex1.IsMatch(input) && !regex2.IsMatch(input))
            {
                Console.WriteLine("Wrong string format");
                numerator = 0;
                denominator = 1;
                //break;
            }
            else
            {
                char[] delimeters = { '/', ':' };
                if (input.Contains(delimeters[0]) || input.Contains(delimeters[1]))
                {
                    string[] arr = input.Split(delimeters);
                    numerator = Convert.ToInt32(arr[0].Trim());
                    denominator = Convert.ToInt32(arr[1].Trim());
                }
                else
                {
                    double tmp = Convert.ToDouble(input);
                    double i = 0;
                    while (true)
                    {
                        if (tmp % 1 != 0)
                        {
                            tmp *= 10;
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    numerator = tmp;
                    denominator = Convert.ToInt32(Math.Pow(10, i));
                }
            }
        }

        //Перегрузка операторов, неявное преобразование
        public static implicit operator RationalNums(string input)
        {
            RationalNums tmp = new RationalNums();
            tmp.converter(input);
            return tmp;
        }

        //Явное преобразование
        public static explicit operator double(RationalNums a)
        {
            return a.numerator / a.denominator;
        }

        //Методы математических операций
        static public string plus(double numerator1, int denominator1, double numerator2, int denominator2)
        {
            int denom = nok(denominator1, denominator2);
            numerator1 *= denom / denominator1;
            numerator2 *= denom / denominator2;
            double num = numerator1 + numerator2;
            string res = num.ToString() + delimeter + denom.ToString();
            return res;
        }

        static public string minus(double numerator1, int denominator1, double numerator2, int denominator2)
        {
            int denom = nok(denominator1, denominator2);
            numerator1 *= denom / denominator1;
            numerator2 *= denom / denominator2;
            double num = numerator1 - numerator2;
            string res = num.ToString() + delimeter + denom.ToString();
            return res;
        }

        static public string multiply(double numerator1, int denominator1, double numerator2, int denominator2)
        {
            double resNumerator = numerator1 * numerator2;
            int resDenominator = denominator1 * denominator2;
            string res = resNumerator.ToString() + delimeter + resDenominator.ToString();
            return res;
        }

        static public string divide(double numerator1, int denominator1, double numerator2, int denominator2)
        {
            double resNumerator = numerator1 * denominator2;
            double resDenominator = numerator2 * denominator1;
            string res = resNumerator.ToString() + delimeter + resDenominator.ToString();
            return res;
        }

        static public string compare(double numerator1, int denominator1, double numerator2, int denominator2)
        {
            int denom = nok(denominator1, denominator2);
            double num1 = numerator1 * denom / denominator1;
            double num2 = numerator2 * denom / denominator2;
            if (num1 > num2)
            {
                string res = numerator1.ToString() + delimeter + denominator1.ToString() + " > " + numerator2.ToString() + delimeter + denominator2.ToString();
                return res;
            }
            if (num1 < num2)
            {
                string res = numerator1.ToString() + delimeter + denominator1.ToString() + " < " + numerator2.ToString() + delimeter + denominator2.ToString();
                return res;
            }
            else
            {
                string res = numerator1.ToString() + delimeter + denominator1.ToString() + " = " + numerator2.ToString() + delimeter + denominator2.ToString();
                return res;
            }

        }

        //Реализация метода интерфейса IComparable
        public int CompareTo(object o)
        {
            RationalNums a = o as RationalNums;
            int denom = nok(this.denominator, a.denominator);
            this.numerator *= denom / this.denominator;
            a.numerator *= denom / a.denominator;
            if (a != null)
            {
                if (this.numerator > a.numerator)
                {
                    return 1;
                }
                if (this.numerator < a.denominator)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Can't compare two objects");
                return -2;
            }
        }

        //Метода по нахождению НОК и НОД
        static int nod(int a, int b)
        {
            if (b < 0)
            {
                b = -b;
            }
            
            if (a < 0)
            {
                a = -a;
            }
                
            while (b > 0)
            {
                int tmp = b;
                b = a % b;
                a = tmp;
            }
            return a;
        }

        static int nok(int a, int b)
        {
            return (a * b) / nod(a, b);
        }
    }
}
