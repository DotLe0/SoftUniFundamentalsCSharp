namespace _02.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
     
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Finish")
                {
                    break;
                }

                if (command[0] == "Add")
                {
                    numbers.Add(double.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    double number = double.Parse(command[1]);

                    if (numbers.Contains(number))
                    {
                        numbers.Remove(number);
                    }
                }
                else if (command[0] == "Replace")
                {
                    double numberToReplace = double.Parse(command[1]);
                    double replacement = double.Parse(command[2]);

                    if (numbers.Contains(numberToReplace))
                    {
                        int index = numbers.IndexOf(numberToReplace);
                        numbers[index] = replacement;
                    }
                }
                else if (command[0] == "Collapse")
                {
                    double number = double.Parse(command[1]);

                    numbers.RemoveAll(x => x < number);
                }            
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}