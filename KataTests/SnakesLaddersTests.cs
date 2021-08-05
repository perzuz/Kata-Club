using Kata_Club.Katas.SnakesAndLadders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace KataTests
{
    [TestClass]
    public class SnakesLaddersTests
    {
        [TestMethod]
        public void ANewGameStarts_BothPlayersAreOnSquareZero()
        {
            // Arrange
            SnakesLadders game = new SnakesLadders();

            // Act
            var player1 = game.GetPlayer(0);
            var player2 = game.GetPlayer(1);

            // Assert
            var expectedStartPosition = 0;
            Assert.AreEqual(expectedStartPosition, player1.Position);
            Assert.AreEqual(expectedStartPosition, player2.Position);
        }

        [TestMethod]
        public void ANewGameStarts_FirstRoll_PlayerOneMovesToExpectedPosition()
        {
            // Arrange
            SnakesLadders game = new SnakesLadders();

            // Act
            var actual = game.play(2, 1);

            // Assert
            var expectedGameOutput = "Player 1 is on square 3";
            Assert.AreEqual(expectedGameOutput, actual);
        }

        [TestMethod]
        public void ANewGameStarts_AfterTwoRolls_BothPlayersAreOnExpectedPositions()
        {
            // Arrange
            SnakesLadders game = new SnakesLadders();

            // Act
            var actualRound1 = game.play(2, 1);
            var actualRound2 = game.play(3, 1);

            // Assert
            var expectedRound1Output = "Player 1 is on square 3";
            Assert.AreEqual(expectedRound1Output, actualRound1);

            var expectedRound2Output = "Player 2 is on square 4";
            Assert.AreEqual(expectedRound2Output, actualRound2);
        }

        [TestMethod]
        public void ANewGameStarts_AfterThreeRolls_BothPlayersAreOnExpectedPositions()
        {
            // Arrange
            SnakesLadders game = new SnakesLadders();

            // Act
            var actualRound1 = game.play(2, 1);
            var actualRound2 = game.play(3, 1);
            var actualRound3 = game.play(4, 2);

            // Assert
            var expectedRound1Output = "Player 1 is on square 3";
            Assert.AreEqual(expectedRound1Output, actualRound1);

            var expectedRound2Output = "Player 2 is on square 4";
            Assert.AreEqual(expectedRound2Output, actualRound2);

            var expectedRound3Output = "Player 1 is on square 9";
            Assert.AreEqual(expectedRound3Output, actualRound3);
        }

        [TestMethod]
        public void ANewGameStarts_PlayerRollsDouble_PlayerGoesAgain()
        {
            // Arrange
            SnakesLadders game = new SnakesLadders();

            // Act
            var actualRound1 = game.play(2, 2);
            var actualRound2 = game.play(4, 1);

            var actualRound3 = game.play(4, 2);

            // Assert
            var expectedRound1Output = "Player 1 is on square 4";
            Assert.AreEqual(expectedRound1Output, actualRound1);

            var expectedRound2Output = "Player 1 is on square 9";
            Assert.AreEqual(expectedRound2Output, actualRound2);

            var expectedRound3Output = "Player 2 is on square 6";
            Assert.AreEqual(expectedRound3Output, actualRound3);
        }
    }
}
