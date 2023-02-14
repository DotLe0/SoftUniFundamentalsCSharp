namespace _05.RemoveNegativesandReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] < 0)
                {
                    lst.Remove(lst[i]);
                    i = -1;
                }
            }

            if (lst.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            lst.Reverse();
            Console.WriteLine(string.Join(" ",lst));
        }
    }
}