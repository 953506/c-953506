using System;

namespace _7
{
    class Program
    {
        class RationalNumber : IEquatable<RationalNumber>
        {
            double _n;
            double _m;
            double _N;
            double _M;

            double _firstRationalNumber;
            double _secondRationalNumber;
            double _mainResult;

            public double FirstRationalNumber
            {
                get => _firstRationalNumber;
                set => _firstRationalNumber = value;   
            }

            public double SecondRationalNumber
            {
                get => _secondRationalNumber;
                set => _secondRationalNumber = value;
            }

            public double N 
            {
                get => _n;
                set => _n = value;
            }

            public double M 
            {
                get => _m;
                set
                {
                    if(value > 0)
                    {
                        _m = value;
                    }
                    else throw new Exception ("число должно быть натуральным");
                }
            }

            public static RationalNumber FloatFormat(RationalNumber obj, RationalNumber obj1, RationalNumber obj2)
            {
                
                obj._mainResult = obj._N / obj._M;
                obj._firstRationalNumber = obj1._n / obj1._m;
                obj._secondRationalNumber = obj2._n / obj2._m;
                return obj;
            }

            public static RationalNumber operator +(RationalNumber obj1, RationalNumber obj2)
            {
                RationalNumber resultOfSum = new RationalNumber();
                resultOfSum._N = (obj1._n * obj2._m + obj2._n * obj1._m);
                resultOfSum._M = (obj1._m * obj2._m);
                resultOfSum = RationalNumber.FloatFormat(resultOfSum, obj1, obj2);
                return resultOfSum;
            }

            public static RationalNumber operator -(RationalNumber obj1, RationalNumber obj2)
            {
                RationalNumber resultOfDiff = new RationalNumber();
                resultOfDiff._N = obj1._n * obj2._m - obj2._n * obj1._m;
                resultOfDiff._M = obj1._m * obj2._m;
                resultOfDiff = FloatFormat(resultOfDiff, obj1, obj2);
                return resultOfDiff;
            }

            public static RationalNumber operator *(RationalNumber obj1, RationalNumber obj2)
            {
                RationalNumber resultOfComposition = new RationalNumber();
                resultOfComposition._N = obj1._n * obj2._n;
                resultOfComposition._M = obj1._m * obj2._m;
                resultOfComposition = FloatFormat(resultOfComposition, obj1, obj2);
                return resultOfComposition;
            }

            public static RationalNumber operator /(RationalNumber obj1, RationalNumber obj2)
            {
                RationalNumber resultOfQuotient = new RationalNumber();
                resultOfQuotient._N = obj1._n * obj2._m;
                resultOfQuotient._M = obj1._m * obj2._n;
                resultOfQuotient = FloatFormat(resultOfQuotient, obj1, obj2);
                return resultOfQuotient;
            }

            public static bool operator >(RationalNumber obj1, RationalNumber obj2)
            {
                bool checkSign = (obj1._firstRationalNumber > obj2._secondRationalNumber) ? true : false ;
                return checkSign;
            }
            
            public static bool operator <(RationalNumber obj1, RationalNumber obj2)
            {
                bool checkSign = (obj1._firstRationalNumber < obj2._secondRationalNumber) ? true : false ;
                return checkSign;
            }
            
            public static bool operator >=(RationalNumber obj1, RationalNumber obj2)
            {
                bool checkSign = (obj1._firstRationalNumber > obj2._secondRationalNumber || obj1._firstRationalNumber == obj2._secondRationalNumber ) ? true : false ;
                return checkSign;
            }
            
            public static bool operator <=(RationalNumber obj1, RationalNumber obj2)
            {
                bool checkSign = (obj1._firstRationalNumber < obj2._secondRationalNumber || obj1._firstRationalNumber == obj2._secondRationalNumber) ? true : false ;
                return checkSign;
            }

            public bool Equals(RationalNumber obj)
            {
                if(obj is null)
                {
                    return false;
                }

                return obj._firstRationalNumber == obj._secondRationalNumber;
            } 

            public override bool Equals(Object obj)
            {   
                if(obj == null)
                {
                    return false;
                }
                
                RationalNumber num = obj as RationalNumber;
                if(num == null)
                {
                    return false;
                }
                else 
                {
                    return Equals(num);
                }
            }
            
            public override int GetHashCode()
            {
                return Tuple.Create(_firstRationalNumber, _secondRationalNumber).GetHashCode();
            }

            public static bool operator ==(RationalNumber obj1, RationalNumber obj2)
            {
                return obj1._firstRationalNumber == obj2._secondRationalNumber;
            }

            public static bool operator !=(RationalNumber obj1, RationalNumber obj2)
            {
                return !(obj1 == obj2);
            }

            public static implicit operator double(RationalNumber obj)
            {
               return obj._n/obj._m; 
            }

            public static implicit operator int(RationalNumber obj)
            {
                return (int) (obj._n/obj._m);
            } 

            public static void CalculationOutput(RationalNumber obj, string sign, RationalNumber obj1, RationalNumber obj2)
            {
                Console.WriteLine($"{obj1._n}/{obj1._m} {sign} {obj2._n}/{obj2._m} = {obj._N}/{obj._M}");
                Console.WriteLine($"{Math.Round(obj._firstRationalNumber,3)} {sign} {Math.Round(obj._secondRationalNumber,3)} = {Math.Round(obj._mainResult,4)}");
                Console.WriteLine(new string('_',25));
            }

            public static void ComparisonOutput(RationalNumber obj1, RationalNumber obj2, string sign)
            {
                Console.WriteLine($"первое число {sign} второго числа");
                Console.WriteLine($"{obj1._firstRationalNumber} {sign} {obj2._secondRationalNumber}");
                Console.WriteLine($"{obj1._n}/{obj1._m} {sign} {obj2._n}/{obj2._m}");
            }

            public static void EqualsOutput(RationalNumber obj1, RationalNumber obj2)
            {
                Console.WriteLine($"{Math.Round(obj1._firstRationalNumber,3)} = {Math.Round(obj2._secondRationalNumber,3)} : {obj1 == obj2}");
                Console.WriteLine($"{Math.Round(obj1._firstRationalNumber,3)} != {Math.Round(obj2._secondRationalNumber,3)} : {obj1 != obj2}");
                Console.WriteLine($"{Math.Round(obj1._firstRationalNumber,3)} = {Math.Round(obj2._secondRationalNumber,3)} : {obj1.Equals(obj2)}");
            }
        }

        static void Main(string[] args)
        {   
            string[] numberOne = new string[3];
            string[] numberTwo = new string[3];

            RationalNumber firstNumber = new RationalNumber();
            RationalNumber secondNumber = new RationalNumber();
            RationalNumber result = new RationalNumber();
           
            Console.WriteLine("Введите первое рациональное число в виде n/m :");
            Console.Write("где n = ");
            firstNumber.N = float.Parse(Console.ReadLine());
            Console.Write("где m = ");
            firstNumber.M = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе рациональное число в виде n/m:");
            Console.Write("где n = ");
            secondNumber.N = float.Parse(Console.ReadLine());
            Console.Write("где m = ");
            secondNumber.M = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Сумма:");
            result = firstNumber + secondNumber;
            RationalNumber.CalculationOutput(result, "+", firstNumber, secondNumber);

            Console.WriteLine("Разность:");
            result = firstNumber - secondNumber;
            RationalNumber.CalculationOutput(result, "-", firstNumber, secondNumber);
            
            Console.WriteLine("Произведение:");
            result = firstNumber * secondNumber;
            RationalNumber.CalculationOutput(result, "*", firstNumber, secondNumber);

            Console.WriteLine("Деление:");
            result = firstNumber / secondNumber;
            RationalNumber.CalculationOutput(result, ":", firstNumber, secondNumber);

            firstNumber.FirstRationalNumber = result.FirstRationalNumber;
            secondNumber.FirstRationalNumber = result.FirstRationalNumber;
            secondNumber.SecondRationalNumber = result.SecondRationalNumber;

            Console.WriteLine("Сравнение:");
            if(firstNumber > secondNumber)
            {
                RationalNumber.ComparisonOutput(firstNumber, secondNumber, ">");
            }
            else if (firstNumber < secondNumber)
            {
                RationalNumber.ComparisonOutput(firstNumber, secondNumber, "<");
            }
            else 
            {
                Console.WriteLine("два числа равны");
            }
            Console.WriteLine(new string('_',25));

            Console.WriteLine("Проверка на равенство двух чисел:");
            RationalNumber.EqualsOutput(firstNumber, secondNumber);
        }   
    }
}
