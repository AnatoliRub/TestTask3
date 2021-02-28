using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorWithPriority
{
    public class Calculator
    {
        private List<String> startExp;

        Dictionary<string, int> operations = new Dictionary<string, int>()
        {
            { "-", 1 },
            { "+", 1 },
            { "*", 2 },
            { "/", 2 }
        };

        Stack<double> NumbersStack = new Stack<double>();
        Stack<string> OperationsStack = new Stack<string>();

        public Calculator(Validator Exp)
        {
            startExp = Exp.Validate();
        }
        
        public void Calculate()
        {
            int previousOperPriority = 1;

            for (int i = 0; i < startExp.Count; i++)
            {
                if (operations.ContainsKey(startExp[i]))
                {
                    if (previousOperPriority > operations[startExp[i]])
                    {
                        ComputeSubStack(NumbersStack, OperationsStack);
                        OperationsStack.Push(startExp[i]);
                    } else {
                    previousOperPriority = operations[startExp[i]];
                    OperationsStack.Push(startExp[i]);
                    }
                } else
                {
                    NumbersStack.Push(double.Parse(startExp[i]));
                }
                if (i == startExp.Count - 1)
                {
                    ComputeSubStack(NumbersStack, OperationsStack);
                }
            }
            Console.WriteLine($"Result: {NumbersStack.First()}");
        }
        private void ComputeSubStack(Stack<double> stackN, Stack<string> stackO)
        {
            while (stackO.Count != 0)
            {
                Operation oper = new Operation(stackN.Pop(), stackN.Pop(), stackO.Pop());
                stackN.Push(oper.Compute());
            }
        }   
    }
}
