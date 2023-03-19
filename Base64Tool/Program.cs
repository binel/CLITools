namespace Base64Tool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                PrintUsage();
                return;
            }

            if (args[0] != "-e" && args[0] != "-d")
            {
                PrintUsage();
                return;
            }

            if (args[0] == "-d")
            {
                byte[] decodeBytes;
                try {
                    decodeBytes = Convert.FromBase64String(args[1]);
                }     
                catch (FormatException)
                {
                    Console.WriteLine($"Error: {args[1]} was not valid base64");
                    return;
                }
                var decodeString = System.Text.Encoding.UTF8.GetString(decodeBytes);
                Console.WriteLine(decodeString);
            }
            else 
            {
                var encodeBytes = System.Text.Encoding.UTF8.GetBytes(args[1]);
                var encodeString = Convert.ToBase64String(encodeBytes);
                Console.WriteLine(encodeString);
            }
        }

        private static void PrintUsage()
        {
            Console.WriteLine("Useage: [-e|-d] <string>");
            Console.WriteLine("\t-e Encode");
            Console.WriteLine("\t-d Decode");
        }
    }
}