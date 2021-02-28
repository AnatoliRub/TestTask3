using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWithPriority
{
    public interface IRead
    {
        public string Expression { get; set; }
        public string Read();
    }
}
