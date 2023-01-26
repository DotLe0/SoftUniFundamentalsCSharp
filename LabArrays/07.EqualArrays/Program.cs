namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool areEqual = true;
            int sum = 0;
            int indexDifferance = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];
                if (array1[i] == array2[i])
                {
                    areEqual = true;
                }
                else
                {
                    areEqual = false;
                    indexDifferance = i;
                    break;
                }
            }
            if (areEqual) 
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {indexDifferance} index");
            }
        }
    }
}