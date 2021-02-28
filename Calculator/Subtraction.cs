using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWithPriority
{
    class Subtraction : ICalc
    {
        public Subtraction() { }
        public double Calc(double fArg, double sArg)
        {
            return sArg - fArg;
        }
    }
}
