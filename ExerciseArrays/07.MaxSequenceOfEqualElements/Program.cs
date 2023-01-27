namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int longestSequenceStartIndex = 0;
            int longestSequenceLenght = 0;

            for (int i = 1; i < array.Length; i++)
            {
                int currentSequanceStart = i - 1;
                int currentSequenceLenght = 0;

                while (i < array.Length && array[i] == array[i - 1])
                {
                    currentSequenceLenght++;
                    i++;
                }

                if (currentSequenceLenght > longestSequenceLenght)
                {
                    longestSequenceLenght = currentSequenceLenght;
                    longestSequenceStartIndex = currentSequanceStart;
                }
            }

            for (int i = longestSequenceStartIndex; i <= longestSequenceStartIndex + longestSequenceLenght; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}