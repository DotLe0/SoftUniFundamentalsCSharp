namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string final = RepeatString(text, count);
            Console.WriteLine(final);
        }

        private static string RepeatString(string? text, int count)
        {
            string temp = string.Empty;

            for (int i = 0; i < count; i++)
            {
                temp += text;
            }
            return temp;
        }
    }
}