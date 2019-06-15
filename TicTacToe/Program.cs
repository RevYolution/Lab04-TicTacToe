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

            }

        }

        // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. 
        // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them. 
    }
}
