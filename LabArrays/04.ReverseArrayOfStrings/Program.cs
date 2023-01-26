namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            Console.WriteLine(string.Join(" ",array.Reverse()));
        }
    }
}