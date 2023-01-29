using System.Buffers;

namespace ConsoleApp75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = Console.ReadLine().Split().Select(int.Parse).ToList();
            int k = int.Parse(Console.ReadLine());

            for (int i = 1; i <= k; i++)
            {
                int temp = lst[0];
                lst.RemoveAt(0);
                lst.Insert(lst.Count, temp);
                Console.WriteLine(string.Join(" ", lst));
            }
            //Console.WriteLine(string.Join(" ", lst));
        }
    }
}