namespace _04.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int startNum);
            int.TryParse(Console.ReadLine(), out int endNum);
            int sum = 0;

            for (int i = startNum; i <= endNum; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }
            Console.WriteLine($"\nSum: {sum}");
        }
    }
}