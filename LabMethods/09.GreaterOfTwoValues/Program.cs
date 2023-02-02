namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(a,b)); 
                    break;
                case "char":
                    char a1 = char.Parse(Console.ReadLine());
                    char b1 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(a1, b1));
                    break;
                case "string":
                    string a2 = Console.ReadLine();
                    string b2 = Console.ReadLine();
                    Console.WriteLine(GetMax(a2, b2));
                    break;
            }

        }

        private static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        private static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        private static string GetMax(string a, string b)
        {
            int n = string.Compare(a, b);
            if (n == 1)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}