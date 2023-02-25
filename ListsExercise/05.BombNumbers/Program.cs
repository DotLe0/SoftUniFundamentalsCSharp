namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = ints[0];
            int radius = ints[1];

            List<int> indexToDelite = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int bombIndex = i;
                    int start = bombIndex - radius;
                    int end = bombIndex + radius;

                    for (int j = start; j <= end; j++)
                    {
                        indexToDelite.Add(j);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", indexToDelite));

            for (int i = 0; i <= numbers.Count; i++)
            {
                if (indexToDelite.Contains(i))
                {
                    numbers.Remove(numbers[i]);
                    indexToDelite.Remove(i);
                    Console.WriteLine(string.Join(" ", numbers));
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(numbers.Sum());
        }
    }
}