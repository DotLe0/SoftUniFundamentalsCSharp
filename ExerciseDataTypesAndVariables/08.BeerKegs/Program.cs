namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            string bestKeg = string.Empty;
            double bigestVolume = double.MinValue;

            for (int i = 0; i < numberOfKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double result = Math.PI * Math.Pow(radius, 2) * height;

                if (result > bigestVolume)
                {
                    bigestVolume = result;
                    bestKeg= model;
                }
            }
            Console.WriteLine(bestKeg);
        }
    }
}