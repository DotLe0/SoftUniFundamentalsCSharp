namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());
            double sum1 = Factoriel(num1);
            double sum2 = Factoriel(num2);
            FactorielDivide(sum1, sum2);
        }

        private static void FactorielDivide(double num1, double num2)
        {
            if (num2 != 0)
            {
                double result = num1 / num2;
                Console.WriteLine($"{result:F2}");
            }
        }

        private static double Factoriel(double num)
        {
            double sum = 1;
            for (int i = 1; i <= num; i++)
            {
                sum *= i;
            }
            return sum;
        }

    }
}