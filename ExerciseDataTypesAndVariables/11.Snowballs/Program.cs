using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            BigInteger maxValue = 0;
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuantity = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quantity = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow(snow/time, quantity);

                if (value > maxValue)
                {
                    maxValue = value;
                    bestSnow= snow;
                    bestQuantity= quantity;
                    bestTime= time;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {maxValue} ({bestQuantity})");
        }
    }
}