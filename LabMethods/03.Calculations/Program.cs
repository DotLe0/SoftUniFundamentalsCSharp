namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    add(num1, num2); break;
                case "multiply":
                    Multiply(num1, num2); break;
                case "subtract":
                    Subtract(num1, num2); break;
                case "divide":
                    Divide(num1, num2); break;
            }
        }

        private static void Divide(double num1, double num2)
        {
            Console.WriteLine(num1 / num2);
        }

        private static void Subtract(double num1, double num2)
        {
            Console.WriteLine(num1 - num2);
        }

        private static void Multiply(double num1, double num2)
        {
            Console.WriteLine(num1 * num2);
        }

        private static void add(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }
}