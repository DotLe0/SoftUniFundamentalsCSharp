using System.Xml.Linq;

namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            int moves = 0;

            while (command != "end")
            {
                int[] indexes = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int firstIndex = indexes[0];
                int secondIndex = indexes[1];

                moves++;

                if (firstIndex == secondIndex || firstIndex < 0 || firstIndex >= elements.Count 
                    || secondIndex < 0 || secondIndex >= elements.Count)
                {
                    int middleIndex = elements.Count / 2;

                    elements.Insert(middleIndex, $"-{moves}a");
                    elements.Insert(middleIndex, $"-{moves}a");

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (elements[firstIndex] == elements[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");

                    if (firstIndex > secondIndex)
                    {
                        elements.RemoveAt(firstIndex);
                        elements.RemoveAt(secondIndex);
                    }
                    else
                    {
                        elements.RemoveAt(secondIndex);
                        elements.RemoveAt(firstIndex);
                    }
                }
                else if (elements[firstIndex] != elements[secondIndex])
                {
                    Console.WriteLine("Try again!");
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }
                command = Console.ReadLine();
            }

            if (elements.Count > 0)
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(string.Join(" ",elements));
            }
        }
    }
}