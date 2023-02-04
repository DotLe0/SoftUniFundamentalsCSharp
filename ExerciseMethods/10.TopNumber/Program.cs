namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (IsDivisibleBy8(i) && IsHoldingAtLeastOneOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsHoldingAtLeastOneOddDigit(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                int temp = number % 10;
                if (temp % 2 == 1)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        private static bool IsDivisibleBy8(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}