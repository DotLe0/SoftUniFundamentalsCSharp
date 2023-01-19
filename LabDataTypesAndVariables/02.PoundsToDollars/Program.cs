namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double paund = double.Parse(Console.ReadLine()) * 1.31;
            Console.WriteLine($"{paund:F3}");
        }
    }
}