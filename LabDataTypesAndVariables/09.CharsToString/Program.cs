namespace _09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c1 = char.Parse(Console.ReadLine());
            char c2 = char.Parse(Console.ReadLine());
            char c3 = char.Parse(Console.ReadLine());

            string combined = c1.ToString() + c2.ToString() + c3.ToString();

            Console.WriteLine(combined);
        }
    }
}