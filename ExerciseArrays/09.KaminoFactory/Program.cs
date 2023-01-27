namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());
            int[] currentLongestSequance = new int[dnaLenght];
            int currentSequanceLenght = 0;
            int currentStartIndex = 0;
            int currentSum = 0;
            int dnaNumber = 0;

            int count = 0;
            while (true)
            {
                count++;
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                int[] array = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int lenght = 0;
                foreach (var item in array)
                {
                    if (item == 1)
                    {
                        lenght++;
                    }
                    else if (item == 0 && lenght > 0)
                    {
                        break;
                    }
                }

                int startingIndex = Array.IndexOf(array, 1);
                int sum = array.Sum();

                if (lenght > currentSequanceLenght || lenght == currentSequanceLenght && currentStartIndex > startingIndex || lenght == currentStartIndex && currentStartIndex == startingIndex && sum > currentSum)
                {
                    currentLongestSequance = array;
                    currentSequanceLenght = lenght;
                    currentStartIndex = startingIndex;
                    currentSum = sum;
                    dnaNumber = count;
                }
            }
            Console.WriteLine($"Best DNA sample {dnaNumber} with sum: {currentSum}.");
            Console.WriteLine(string.Join(" ",currentLongestSequance));
        }
    }
}