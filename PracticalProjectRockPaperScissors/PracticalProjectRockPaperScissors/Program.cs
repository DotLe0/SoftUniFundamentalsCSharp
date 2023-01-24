using System.Linq.Expressions;

namespace PracticalProjectRockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chosee [r]ock [p]aper [s]cissors: ");
            string playerMove = Console.ReadLine();

            string rock = "Rock";
            string paper = "Paper";
            string Scissors = "Scissors";

            switch (playerMove)
            {
                case "r":
                    playerMove = rock; break;
                case "p":
                    playerMove = paper; break;
                case "s":
                    playerMove = Scissors; break;
                default:
                    Console.WriteLine("Invalid Input. Try Again...");
                    break;
            }

            string[] computerMoves = new string[] { "Rock", "Paper", "Scissors" };  
            Random rnd = new Random();
            int index = rnd.Next(0,3);

            string computerMove = computerMoves[index];
            Console.WriteLine($"The computer chose {computerMove}");

            if ((playerMove == "Rock" && computerMove == "Scissors") || 
                (playerMove == "Paper" && computerMove == "Rock")    || 
                (playerMove == "Scissors" && computerMove == "Paper"))
            {
                Console.WriteLine("You win.");
            }
            else if ((computerMove == "Rock" && playerMove == "Scissors") ||
                (computerMove == "Paper" && playerMove == "Rock") ||
                (computerMove == "Scissors" && playerMove == "Paper"))
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("This game was a draw.");
            }
        }
    }
}