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
            for (int i = 0; i < number; i++)
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
            List<int> numbers = new List<int>();
            int sum = 0;
            for (int i = 0; i <= number; i++)
            {
                int temp = number % 10;
                numbers.Add(temp);
                number /= 10;
            }
            numbers.Add(number);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 ==1)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }
    }
}