using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json;

namespace JWTTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: jwt <jwt>");
                return;
            }

            var split = args[0].Split(".");

            if (split.Length != 3)
            {
                Console.WriteLine("Invalid JWT");
            }

            var jsonOptions = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
        
            // TODO pretty-print
            Console.WriteLine("Header:");
            Console.WriteLine(Decode(split[0]));

            Console.WriteLine("Payload:");
            Console.WriteLine(Decode(split[1]));
        }

        private static string Decode(string val)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            var uglyJson = Base64UrlEncoder.Decode(val);
            var element = JsonSerializer.Deserialize<JsonElement>(uglyJson);

            return JsonSerializer.Serialize(element, options);
        }
    }
}