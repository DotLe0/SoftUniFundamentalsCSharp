namespace _04.ListofProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> lst = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                lst.Add(input);
            }
            lst.Sort();
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine($"{i+1}.{lst[i]}");
            }
        }
    }
}