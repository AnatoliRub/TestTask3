using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWithPriority
{
    class Operation
    {
        private double firstArgument, secondArgument;
        private string operation;
        public Operation(double fArgument, double sArgument, string operation)
        {
            firstArgument = fArgument;
            secondArgument = sArgument;
            this.operation = operation;
        }
        public double Compute()
        {
            double result = default;
            switch (operation)
            {
                case "*":
                    Multiplication mult = new Multiplication();
                    result = mult.Calc(firstArgument, secondArgument);
                    break;
                case "/":
                    Division divis = new Division();
                    result = divis.Calc(firstArgument, secondArgument);
                    break;
                case "+":
                    Addition add = new Addition();
                    result = add.Calc(firstArgument, secondArgument);
                    break;
                case "-":
                    Subtraction sub = new Subtraction();
                    result = sub.Calc(firstArgument, secondArgument);
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
