using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public enum Operation
    {
        ADDITION,
        SUBTRACTION,
        MULTIPLICATION,
        DIVISION
    }
        
    public static class OperationParser
    {
        public static bool TryParse(string value, out Operation operation)
        {
            if (OperationReverseMap.ContainsKey(value))
            {
                operation = OperationReverseMap[value];
                return true;
            }
            operation = Operation.ADDITION;
            return false;
        }
    
        public readonly static Dictionary<Operation, string> OperationForwardMap =
            new Dictionary<Operation, string> 
            {
                { Operation.ADDITION, "+"},
                { Operation.SUBTRACTION, "-" },
                { Operation.MULTIPLICATION, "." },
                { Operation.DIVISION, "/" }
            };

        public readonly static Dictionary<string, Operation> OperationReverseMap =
            new Dictionary<string, Operation>
            {
                { "+", Operation.ADDITION },
                { "-", Operation.SUBTRACTION },
                { ".", Operation.MULTIPLICATION },
                { "/", Operation.DIVISION }
            };
    }



        
}
