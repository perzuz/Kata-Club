using Kata_Club;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace KataTests
{
    public class TicTacToeTests
    {
        [Fact]
        public void VerticalWin()
        {
            var tictactoe = new TicTacToe();

            int[,] board = new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
            Assert.Equal(1, tictactoe.IsSolved(board));
        }

        [Fact]
        public void DiagonalWin()
        {
            var tictactoe = new TicTacToe();

            int[,] board = new int[,] { { 2, 1, 0 }, { 0, 2, 1 }, { 0, 0, 2 } };
            Assert.Equal(2, tictactoe.IsSolved(board));
        }

        [Fact]
        public void Stalemate()
        {
            var tictactoe = new TicTacToe();

            int[,] board = new int[,] { { 2, 1, 2 }, { 2, 1, 1 }, { 1, 2, 1 } };
            Assert.Equal(0, tictactoe.IsSolved(board));
        }
    }
}
