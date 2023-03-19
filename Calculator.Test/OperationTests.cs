using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test
{
    [TestFixture]
    public class OperationTests
    {
        [TestCase("+", ExpectedResult = Operation.ADDITION)]
        [TestCase("-", ExpectedResult = Operation.SUBTRACTION)]
        [TestCase("*", ExpectedResult = Operation.MULTIPLICATION)]
        [TestCase("/", ExpectedResult = Operation.DIVISION)]
        public Operation ParseTest(string val)
        {
            OperationParser.TryParse(val, out Operation op);
            return op;
        }
    }
}
