namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isSpecialNum = false;

            for (int i = 1; i <= n; i++)
            {
                int currentNum = i;
                int sum = 0;

                while (currentNum > 0)
                {
                    sum += i % 10;
                    currentNum = currentNum / 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecialNum = true;
                }
                
                Console.WriteLine($"{i} -> {isSpecialNum}");
            }
        }
    }
}