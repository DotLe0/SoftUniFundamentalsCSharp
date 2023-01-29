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
                string currentElement = array2[i];

                if (array1.Contains(currentElement))
                {
                    Console.WriteLine(currentElement + " ");
                }
            }
        }
    }
}