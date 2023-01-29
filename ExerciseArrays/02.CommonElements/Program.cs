namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();

            for (int i = 0; i < array2.Length; i++)
            {
                

                if (array1.Contains(array2[i]))
                {
                    Console.Write(array2[i] + " ");
                }
            }
        }
    }
}