using System;

namespace CalculatorWithPriority
{
    class Program
    {
        static void Main()
        {
            new Calculator(new Validator(new FileReader())).Calculate();
            
        }
    }
}
