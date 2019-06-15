using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame();
        }

        static void PlayGame() 
        {
            do 
            {
                Console.Clear();
                Console.WriteLine("Let's Play Tic-Tac-Toe");
                Console.WriteLine("Player 1: What is your name?");
                Player playerOne = new Player()
                {
                    Name = Console.ReadLine(),
                    IsTurn = true, 
                    Marker = "X"
                };

                Console.WriteLine("Player 2: What is your name?");
                playerOne playerTwo = new Player()
                {
                    Name = Console.ReadLine(),
                    IsTurn = true,
                    Marker = "O"
                };

                Game game = new Game(playerOne, playerTwo);
                Player winner = game.Play();

                if(winner is null) Console.WriteLine("Draw!!");
                else Console.WriteLine($"{winner.Name} is the winner!?!");

                Console.WriteLine("Play Again?");
                Console.WriteLine("Enter yes to play again, anything else will exit.");
            } while (Console.ReadLine().ToLower() == "yes");

        }
    }
}
