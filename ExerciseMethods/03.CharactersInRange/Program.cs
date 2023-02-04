using System;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            ASKII(letter1, letter2);
        }
        static void ASKII(char letter1, char letter2)
        {
            List<char> chars = new List<char>();


            if (letter1 > letter2)
            {
                for (char i = letter2; i < letter1; i++)
                {
                    chars.Add(i);
                }
            }
            else
            {
                for (char i = letter1; i < letter2; i++)
                {
                    chars.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ",chars.Skip(1)));
        }
    }
}