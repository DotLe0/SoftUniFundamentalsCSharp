namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double result = GetArea(width, hight);
            Console.WriteLine(result);
        }

        private static double GetArea(double width, double hight)
        {
            return width * hight;
        }
    }
}