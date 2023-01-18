namespace _12.EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            while (true)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    return;
                }
                Console.WriteLine("Please write an even number.");
                num = double.Parse(Console.ReadLine());
            }
        }
    }
}