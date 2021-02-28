using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWithPriority
{
    class Multiplication : ICalc
    {
        public Multiplication() { }
        public double Calc(double fArg, double sArg)
        {
            return sArg * fArg;
        }
    }
}
