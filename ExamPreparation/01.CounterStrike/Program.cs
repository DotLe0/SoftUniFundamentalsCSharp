namespace _01.CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int wins = 0;

            while (command != "End of battle")
            { 
                if ((initialEnergy - int.Parse(command)) < 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {initialEnergy} energy");
                    Environment.Exit(0);
                }

                initialEnergy -= int.Parse(command);
                wins++;

                if (wins % 3 == 0)
                {
                    initialEnergy += wins;
                }
                command= Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {wins}. Energy left: {initialEnergy}");
        }
    }
}