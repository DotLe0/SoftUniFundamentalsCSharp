using System;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);

                    if (index < 0 || index > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(command[1]));
                    }
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    if (index < 0 || index > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }
                }
                else if (command[1] == "left")
                {
                    int times = int.Parse(command[2]);

                    for (int i = 0; i < times; i++)
                    {
                        int firstNum = numbers.First();       
                        numbers.Remove(firstNum);
                        numbers.Add(firstNum);
                        
                    }
                }
                else if (command[1] == "right")
                {
                    int times = int.Parse(command[2]);

                    for (int i = 0; i < times; i++)
                    {
                        int lastNum = numbers.Last();
                        numbers.Insert(0, lastNum);
                        numbers.RemoveAt(numbers.Count - 1);
                        
                    }
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}