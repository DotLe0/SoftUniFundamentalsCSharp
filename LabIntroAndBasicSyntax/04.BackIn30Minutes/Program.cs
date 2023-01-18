namespace _04.BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 30;

            if (minutes >= 60)
            {
                hour++;
                minutes = minutes - 60;
            }

            if (hour >= 24)
            {
                hour = 0;
            }

            Console.WriteLine($"{hour}:{minutes:D2}");
        }
    }
}