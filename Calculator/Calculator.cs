using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static class Calculator
    {
        public static double Add(double arg1, double arg2)
        {
            double val;
            val = arg1 + arg2;
            return val;
        }

        public static double Subtract(double arg1, double arg2)
        {
            double val;
            val = arg1 - arg2;
            return val;
        }

        public static double Multiply(double arg1, double arg2)
        {
            double val;
            val = arg1 * arg2;
            return val;
        }

        public static double Divide(double arg1, double arg2)
        {
            double val;
            val = arg1 / arg2;
            return val;
        }
    }

}
