using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Summarize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add("1,2,3,4"));
        }

        public static int Add(string numbers)
        {
            var parts = numbers.Split(',');
            var result = 0;

            foreach (var part in parts)
            {
                int.TryParse(part, out int number);

                if (number <= 1000)
                    result += number;
            }

            return result;
        }
    }
}
