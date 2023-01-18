namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i * 2 - 1);
                totalSum += i * 2 - 1;
            }
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}