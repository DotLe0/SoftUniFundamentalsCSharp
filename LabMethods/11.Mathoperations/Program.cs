namespace _11.Mathoperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            string operant = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());

            double result = Calculate(num1, operant, num2);
            Console.WriteLine(result);
        }

        private static double Calculate(double num1, string? operant, double num2)
        {
            double result = 0;

            switch (operant)
            {
                case "/": result = num1 / num2; break;
                case "*": result = num1 * num2; break;
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
            }
            return result;
        }
    }
}