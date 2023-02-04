namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            Minimal(n1, n2,n3);
        }
        static void Minimal(int n1, int n2, int n3)
        {
            Console.WriteLine(Math.Min(n1,Math.Min(n2,n3)));
        }
    }
}