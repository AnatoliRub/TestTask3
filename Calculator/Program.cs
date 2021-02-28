using System;

namespace CalculatorWithPriority
{
    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator(new Validator(new FileReader()));
            calc.Calculate();
        }
    }
}
