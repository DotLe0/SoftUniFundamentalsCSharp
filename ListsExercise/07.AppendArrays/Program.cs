namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();

            List<string> final = new List<string>();

            foreach (var item in list)
            {
                final.AddRange(item.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList());
            }

            Console.WriteLine(string.Join(" ",final));

        }
    }
}