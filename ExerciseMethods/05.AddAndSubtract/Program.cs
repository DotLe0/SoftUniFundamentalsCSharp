namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = SumFirstTwo(num1, num2);
            int result = SubtractThurd(sum, num3);
            Console.WriteLine(result);
        }

        private static int SubtractThurd(int sum, int num3)
        {
            int result = sum - num3;
            return result;
        }

        private static int SumFirstTwo(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
    }
}