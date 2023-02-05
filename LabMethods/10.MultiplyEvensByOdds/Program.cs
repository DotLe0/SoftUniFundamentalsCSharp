namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            int result = GetMultipleOfEvenAndOdds(evenSum,oddSum);
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int temp = number % 10;
                if (temp % 2 == 0)
                {
                    sum += temp;
                }
                number /= 10;
            }
            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {    
            int sum = 0;
            while (number > 0)
            {
                int temp = number % 10;
                if (temp % 2 == 1)
                {
                    sum += temp;
                }
                number /= 10;
            }       
            return sum;
        }
    }
}