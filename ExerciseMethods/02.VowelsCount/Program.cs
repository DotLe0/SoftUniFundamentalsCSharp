using System.Linq;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            NumberInVowels(input);
        }
        static void NumberInVowels(string input)
        {
            char[] arr = input.ToCharArray();
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int count = 0;
            foreach (char item in arr)
            {
                if (vowels.Contains(item))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}