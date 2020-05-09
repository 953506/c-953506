using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    class Converter : IComparable, IEquatable<Converter>
    {
        private int _num;
        private int _denom;

        public Converter(int _num, int _denom)
        {
            int devide = GreatDivisor(_num, _denom);
            this._denom = _denom / devide;
            this._num = _num / devide;
        }

        public int GreatDivisor(int _num, int _denom)
        {
            if (_num % _denom == 0)
                return _denom;
            if (_denom % _num == 0)
                return _num;
            if (_num > _denom)
                return GreatDivisor(_num % _denom, _denom);
            return GreatDivisor(_num, _denom % _num);
        }

        public static Converter operator +(Converter num1, Converter num2)
        {
            int num = num1._num * num2._denom + num2._num * num1._denom;
            int denom = num1._denom * num2._denom;
            Converter result = new Converter(num, denom);
            return result;
        }

        public static Converter operator -(Converter num1, Converter num2)
        {
            num2._num = (-num2._num);
            return num1 + num2;
        }

        public static Converter operator *(Converter num1, Converter num2)
        {
            int num = num1._num * num2._num;
            int denom = num1._denom * num2._denom;
            Converter result = new Converter(num, denom);
            return result;
        }

        public static Converter operator /(Converter num1, Converter num2)
        {
            int num = num1._num * num2._denom;
            int denom = num1._denom * num2._num;
            Converter result = new Converter(num, denom);
            return result;
        }
        public static bool operator <(Converter num1, Converter num2)
        {
            num1._num *= num2._denom;
            num2._num *= num1._denom;
            num1._denom *= num2._denom;
            num2._denom = num1._denom;
            return num1._num < num2._num;

        }

        public static bool operator >(Converter num1, Converter num2)
        {
            num1._num *= num2._denom;
            num2._num *= num1._denom;
            num1._denom *= num2._denom;
            num2._denom = num1._denom;
            return num1._num > num2._num;
        }

        public override string ToString()
        {
            string res = $"{_num}/{_denom}";
            return res;
        }

        public double ToDouble()
        {
            double value = _num / _denom;
            return value;
        }

        public int CompareTo(object obj)
        {
            Converter another = obj as Converter;

            if ((double)_num / _denom < another.ToDouble())
                return -1;
            if ((double)_num / _denom > another.ToDouble())
                return 1;
            return 0;
        }

        public bool Equals(Converter other)
        {
            if (other == null)
            {
                return false;
            }
            return _num * other._denom == other._num* _denom;
        }

    }
}
