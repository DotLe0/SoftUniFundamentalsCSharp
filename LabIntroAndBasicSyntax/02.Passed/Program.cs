namespace _02.Passed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grande = double.Parse(Console.ReadLine());

            if (grande >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}