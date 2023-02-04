namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? input = Console.ReadLine();
            MiddleCharacters(input);
        }

        private static void MiddleCharacters(string? input)
        {
            if (input.Length % 2 == 0)
            {
                int middle = input.Length / 2;
                Console.WriteLine(input[middle-1] + "" + input[middle]);
            }
            else
            {
                Console.WriteLine(input[input.Length / 2]);
            }
        }
    }
}