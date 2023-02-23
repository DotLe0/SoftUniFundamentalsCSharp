namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    int num = int.Parse(command[1]);
                    list.RemoveAll(x => x == num);
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    int element = int.Parse(command[1]);

                    list.Insert(index, element);
                }
                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}