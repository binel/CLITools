using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {

        public static decimal Calculate(decimal lhs, decimal rhs, Operation op)
        {
            switch(op)
            {
                case Operation.ADDITION:
                    return lhs + rhs;
                case Operation.SUBTRACTION:
                    return lhs - rhs;
                case Operation.MULTIPLICATION:
                    return lhs * rhs;
                case Operation.DIVISION:
                    return lhs / rhs;
                default:
                    throw new ArgumentException($"Unsupported operation {op}");
            }
        }
    }
}
