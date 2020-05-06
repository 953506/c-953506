using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public static class MyProj
    {
        public static double Add(double firstValue, double secondValue)
        {
            return firstValue + secondValue;

        }
        public static double Subtract(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
        public static double Multiply(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
        public static double Divide(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                return 0;
            }
            return firstValue / secondValue;
        }

    }
}
