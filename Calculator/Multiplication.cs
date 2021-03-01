using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWithPriority
{
    public class Multiplication : ICalc
    {
        public Multiplication() { }
        public double Calc(double fArg, double sArg)
        {
            return sArg * fArg;
        }
    }
}
