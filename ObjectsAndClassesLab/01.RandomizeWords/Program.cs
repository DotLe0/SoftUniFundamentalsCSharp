namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                Random rnd = new Random();
                int randomIndex = rnd.Next(0, input.Count);

                string currentWord = input[i];
                string WordToSwap = input[randomIndex];

                input[i] = WordToSwap;
                input[randomIndex] = currentWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}