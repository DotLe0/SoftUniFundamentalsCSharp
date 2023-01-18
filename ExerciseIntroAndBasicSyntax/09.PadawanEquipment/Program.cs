namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyAmount = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceOfLightSaber = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double freeBelts = Math.Floor(studentsCount / 6.0);
            double a = Math.Ceiling(studentsCount * 1.10);

            double total = priceOfLightSaber * a + priceOfRobes * studentsCount + priceOfBelts * (studentsCount - freeBelts);

            if (total <= moneyAmount)
            {
                Console.WriteLine($"The money is enough - it would cost {total:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total - moneyAmount:F2}lv more.");
            }
        }
    }
}