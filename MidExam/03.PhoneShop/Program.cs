namespace _03.PhoneShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "End")
                {
                    break;
                }

                if (command[0] == "Add")
                {
                    string phone = command[2];

                    if (!phones.Contains(phone))
                    {
                        phones.Add(phone);
                    }
                }
                else if (command[0] == "Remove")
                {
                    string phone = command[2];

                    if (phones.Contains(phone))
                    {
                        phones.Remove(phone);
                    }
                }
                else if (command[0] == "Bonus")
                {
                    List<string> oldAndNew = command[3].Split(":").ToList();

                    if (phones.Contains(oldAndNew[0]))
                    {
                        int index = phones.IndexOf(oldAndNew[0]) + 1;
                        phones.Insert(index, oldAndNew[1]);
                    }
                }
                else if (command[0] == "Last")
                {
                    string phone = command[2];

                    if (phones.Contains(phone))
                    {
                        phones.Remove(phone);
                        phones.Insert(phones.Count,phone);
                    }
                }
            }
            Console.WriteLine(string.Join(", ",phones));
        }
    }
}