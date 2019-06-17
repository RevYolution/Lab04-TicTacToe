using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace TicTacToeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanDetermineWinner()
        {
            Game testGame = new Game(new Player(), new Player());
            testGame.Board.GameBoard = new string[,]
            {
                {"X", "X", "X" },
                {"O", "O", "X" },
                {"X", "X", "O" },
            };
            Assert.True(testGame.CheckForWinner(testGame.Board));
        }

        [Fact]
        public void CanDetermineWinner2()
        {
            Game testGame = new Game(new Player(), new Player());
            testGame.Board.GameBoard = new string[,]
            {
                {"O", "X", "X" },
                {"O", "O", "X" },
                {"O", "X", "O" },
            };
            Assert.True(testGame.CheckForWinner(testGame.Board));
        }

        [Fact]
        public void CanMoveToNextPlayer()
        {
            Player one = new Player() { Name = "Winnie" };
            Player two = new Player() { Name = "Piglett" };

            Game testGame = new Game(one, two);
            Player move = testGame.NextPlayer();

            Assert.Equal(two.Name, move.Name);
        }

    }
}
