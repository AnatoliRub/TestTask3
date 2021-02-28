using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CalculatorWithPriority
{
    public class Validator
    {
        private List<string> exp = new List<string>();
        private string pattern = @"[0-9]+.[0-9]+|[0-9]+|\+|-|/|\*";
        private string patternNumb = @"[0-9]+.[0-9]+|[0-9]+";
        private string patternOp = @"\+|-|/|\*";
        public Validator(IRead reader)
        {
            exp = reader.Read().Split(" ").ToList();
        }
        public List<string> Validate()
        {
            CheckDuplicated();
            
            foreach (var item in exp)
            {
                if(Regex.IsMatch(item, pattern, RegexOptions.IgnoreCase)){
                    
                } else
                {
                    throw new ArgumentException("Проверьте последовательность");
                }
            }
            return exp;
        }
        private void CheckDuplicated()
        {
            for (int i = 1; i < exp.Count; i++)
            {
                if(
                    (Regex.IsMatch(exp[i-1], patternNumb, RegexOptions.IgnoreCase) && Regex.IsMatch(exp[i], patternNumb, RegexOptions.IgnoreCase)) 
                    || 
                    (Regex.IsMatch(exp[i - 1], patternOp, RegexOptions.IgnoreCase) && Regex.IsMatch(exp[i], patternOp, RegexOptions.IgnoreCase))
                )
                {
                    throw new ArgumentException("Check order");
                }
            }
        }
    }
}
