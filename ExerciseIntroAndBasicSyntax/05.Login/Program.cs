namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = new string(username.Reverse().ToArray());
            int count = 3;

            while (count != 0)
            {
                string input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else if (input != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    count--;
                }
            }
            Console.WriteLine($"User {username} blocked!");
        }
    }
}