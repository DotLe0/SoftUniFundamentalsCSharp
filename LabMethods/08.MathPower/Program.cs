namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double result = Power(firstNum, secondNum);
            Console.WriteLine(result);
        }

        private static double Power(double firstNum, double secondNum)
        {
            return Math.Pow(firstNum, secondNum);
        }
    }
}