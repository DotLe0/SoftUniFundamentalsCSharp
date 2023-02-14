namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();

            bool isChanged = false;

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "Remove")
                {
                    numbers.Remove(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    numbers.Insert(index, number);
                    isChanged = true;
                }
                else if (command[0] == "Contains")
                {
                    int number = int.Parse(command[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0] == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2==0)));
                }
                else if (command[0] == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (command[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command[0] == "Filter")
                {
                    string condition = command[1];
                    int number = int.Parse(command[2]);

                    switch (condition)
                    {
                        case "<":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x < number)));
                            break; 
                        case ">":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x > number)));
                            break;
                        case ">=":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x >= number)));
                            break;
                        case "<=":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x <= number)));
                            break;
                    }
                }
                command = Console.ReadLine().Split();
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ",numbers));
            }
        }
    }
}