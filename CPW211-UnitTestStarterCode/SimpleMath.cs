using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode
{
    /*****************************************************************************
    * 
    * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
    * 
    * ***************************************************************************/
    public static class SimpleMath
    {
        public static double Add(double a, double b)
        {
            double sum = a + b;
                return sum;
        }

        public static double Subtract(double a, double b)
        {
            double result = a - b;
            return result;
        }

        public static double Multiply(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public static double Divide(double a, double b)
        {
            if ( b == 0)
            {
                throw new ArgumentException($"{nameof(b)} cannot be 0");
            }
            double result = a / b;
            return result;
        }
    }
}
