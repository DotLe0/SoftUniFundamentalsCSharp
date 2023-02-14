namespace _02.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> reselt= new List<int>();

            for (int i = 0; i < list.Count / 2; i++)
            {
                reselt.Add(list[i] + list[list.Count - 1 - i]);
            }

            if (list.Count %2 == 1)
            {
                reselt.Add(list[list.Count / 2]);
            }
            Console.WriteLine(string.Join(" ",reselt));
        }
    }
}