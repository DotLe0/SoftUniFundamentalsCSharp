namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            decimal fiftyPercent = (n * 0.5m);
            int count = 0;
            while (n >= m)
            {
                n -= m;
                count++;

                if (n == fiftyPercent && y != 0)
                {
                    n /= y;      
                }               
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}