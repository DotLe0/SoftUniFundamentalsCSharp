namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    even.Add(numbers[0]);
                    odd.Add(numbers[1]);
                }
                else
                {
                    odd.Add(numbers[0]);
                    even.Add(numbers[1]);
                }
            }
            Console.WriteLine(string.Join(" ", even));
            Console.WriteLine(string.Join(" ", odd));
        }
    }
}