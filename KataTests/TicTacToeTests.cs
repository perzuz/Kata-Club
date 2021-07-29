using Kata_Club.Katas.TicTacToe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace KataTests
{
    [TestClass]
    public class TicTacToeTests
    {
        [TestMethod]
        public void GivenBoardNotYetFinished_ReturnNegativeOne()
        {
            // Arrange
            var ticTacToe = new TicTacToe();

            int[,] board = new int[,] {
            { 1, 1, 0 },
            { 0, 2, 2 },
            { 0, 0, 0 } };

            // Act
            var actual = ticTacToe.IsSolved(board);

            // Assert
            var expected = -1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenXwins_ReturnOne()
        {
            // Arrange
            var ticTacToe = new TicTacToe();

            int[,] board = new int[,] {
            { 1, 1, 1 },
            { 0, 2, 2 },
            { 0, 0, 0 } };

            // Act
            var actual = ticTacToe.IsSolved(board);

            // Assert
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }
    }
}
