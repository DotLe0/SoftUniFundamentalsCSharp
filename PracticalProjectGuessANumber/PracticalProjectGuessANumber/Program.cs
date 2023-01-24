namespace PracticalProjectGuessANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number (1 - 100):");
            Random rnd = new Random();
            int computerNumber = rnd.Next(1, 101);

            while (true)
            {
                bool isValid = int.TryParse(Console.ReadLine(), out int playerNumber);

                if (isValid)
                {
                    if (playerNumber == computerNumber)
                    {
                        Console.WriteLine("You guessed it.");
                        break;
                    }
                    else if (playerNumber < computerNumber)
                    {
                        Console.WriteLine("Too low");
                    }
                    else
                    {
                        Console.WriteLine("Too High");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}