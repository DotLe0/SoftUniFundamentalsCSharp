namespace _01.HuntingGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerPerson = double.Parse(Console.ReadLine());
            double foodPerPerson = double.Parse(Console.ReadLine());

            double groupWater = days * waterPerPerson * playersCount;
            double groupFood = days *  foodPerPerson * playersCount;

            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                energy -= energyLoss;
                if (energy <= 0)
                {
                    break;
                }
                if (i % 2 == 0)
                {
                    energy += energy * 0.05;
                    groupWater -= groupWater * 0.3;
                }
                if (i % 3 == 0)
                {
                    groupFood -= (groupFood / playersCount);
                    energy += energy * 0.10; 
                }
            }

            if (energy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:F2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {groupFood:F2} food and {groupWater:F2} water.");
            }
        }
    }
}