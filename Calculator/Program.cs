namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                PrintUsage();
                return;
            }

            bool success = decimal.TryParse(args[0], out decimal lhs);
            success &= OperationParser.TryParse(args[1], out Operation op);
            success &= decimal.TryParse(args[2], out decimal rhs);

            if (!success)
            {
                Console.WriteLine("Could not parse input.");
                return;
            }

            var result = Calculator.Calculate(lhs, rhs, op);
            Console.WriteLine(result);
        }

        private static void PrintUsage()
        {
            Console.WriteLine("Usage: <lhs> <operation> <rhs>");
        }
    }
}