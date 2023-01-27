using System.Reflection.Emit;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string left = "left";
            const string right = "right";

            int fieldSize = int.Parse(Console.ReadLine());
            int[] positions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] ladyBugsOnField = new int[fieldSize];
            foreach (var position in positions)
            {
                if (position >= 0 && position < fieldSize)
                {
                    ladyBugsOnField[position] = 1;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if ("end" == input)
                {
                    break;
                }

                string[] instructions = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int position = int.Parse(instructions[0]);
                string direction = instructions[1];
                int  flightLenght = int.Parse(instructions[2]);

                if (position < 0 || position >= fieldSize || ladyBugsOnField[position] == 0)
                {
                    continue;
                }

                if (direction == left)
                {
                    flightLenght *= -1;
                }

                bool hasLanded = false;
                ladyBugsOnField[position] = 0;

                do
                {
                    position += flightLenght;
                    if (position < 0 || position >= fieldSize)
                    {
                        break;
                    }
                    if (ladyBugsOnField[position] == 0)
                    {
                        hasLanded = true;
                        ladyBugsOnField[position] = 1;
                    }
                } while (!hasLanded);
            }
            Console.WriteLine(string.Join(' ', ladyBugsOnField));
        }
    }
}