namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                isPalindorme(input);
                input = Console.ReadLine();
            }
        }

        private static void isPalindorme(string? input)
        {
            string palindrom = new string(input.Reverse().ToArray());
            if (palindrom == input)
            {
                Console.WriteLine("true");
                return;
            }
            Console.WriteLine("false");
        }
    }
}