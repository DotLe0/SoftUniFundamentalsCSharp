namespace ConsoleApp75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[nums.Length - 1];

            if (nums.Length == 1)
            {
                Console.WriteLine($"{nums[0]}");
            }
            else
            {
                int n = nums.Length - 1;
                while (n != 0)
                {
                    for (int i = 0; i < nums.Length - 1; i++)
                    {
                        condensed[i] = nums[i] + nums[i + 1];
                    }
                    nums = condensed;
                    n--;
                }

                Console.WriteLine(string.Join(" ", condensed[0]));
            }        
        }
    }
}