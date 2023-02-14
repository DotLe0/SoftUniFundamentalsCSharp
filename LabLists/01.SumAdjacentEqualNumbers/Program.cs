namespace _01.SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> lst = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < lst.Count - 1; i++)
            {
                if (lst[i] == lst[i + 1])
                {
                    lst[i] += lst[i + 1];
                    lst.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ",lst));
        }
    }
}