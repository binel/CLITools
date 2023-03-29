namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Usage();
            }

            if (args[0] == "-n")
            {
                var now = DateTime.UtcNow;

                var unixEpoch = new DateTimeOffset(now).ToUnixTimeMilliseconds();

                Console.WriteLine($"Current UTC Time: {now} (Unix Epoch {unixEpoch})");
                return;
            }

            if (args[0] == "-u")
            {
                Console.Clear();
                while(true)
                {
                    var now = DateTime.UtcNow;

                    var unixEpoch = new DateTimeOffset(now).ToUnixTimeMilliseconds();

                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Current UTC Time: {now} (Unix Epoch {unixEpoch})");
                    Thread.Sleep(1000);
                }

                return;
            }

            Usage();
        }

        private static void Usage()
        {
            Console.WriteLine("time <-n | -u>");
            Console.WriteLine("\t-n  print the current unix time");
            Console.WriteLine("\t-u  print the current unix time in a loop");
        }
    }
}