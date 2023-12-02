namespace FizzBuzz
{
    public class FizzBuzzService
    {
        public static string CheckResult(int n)
        {
            var result = string.Empty;

            if (n % 3 == 0)
            {
                result += "Fizz";
            }

            if(n % 5 == 0)
            {
                result += "Buzz";
            }

            if (string.IsNullOrEmpty(result))
            {
                result += $"{n}";
            }

            return result;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int n = 100;

            for(int i = 1; i<n; i++)
            {
                Console.WriteLine(FizzBuzzService.CheckResult(i));
            }
        }
    }
}