using Kata_Club.Katas.SnakesAndLadders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace KataTests
{
    // https://www.codewars.com/kata/587136ba2eefcb92a9000027/train/csharp
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

        [TestMethod]
        public void ANewGameStarts_PlayerLandsOnStartOfLadder_PlayerIsTransportedToLadderEnd()
        {
            // Arrange
            SnakesLadders game = new SnakesLadders();

            // Act
            var actualRound1 = game.play(1, 1);

            // Assert
            var expectedRound1Output = "Player 1 is on square 38";
            Assert.AreEqual(expectedRound1Output, actualRound1);
        }

        [TestMethod]
        public void ANewGameStarts_PlayerLandsOnStartOfSnake_PlayerIsTransportedToSnakeEnd()
        {
            // Arrange
            SnakesLadders game = new SnakesLadders();

            // Act
            var actualRound1 = game.play(6, 6);
            var actualRound2 = game.play(3, 1);

            // Assert
            var expectedRound2Output = "Player 1 is on square 6";
            Assert.AreEqual(expectedRound2Output, actualRound2);
        }

        [TestMethod]
        public void APlayerIsNearTheFinalSpace_PlayerRollsHigherThanNeccesary_PlayerBouncesBackExtraSpaces()
        {
            // Arrange
            SnakesLadders game = new SnakesLadders();

            // Act
            var actualRound1 = game.play(47, 47);
            var actualRound2 = game.play(5, 4);

            // Assert
            var expectedRound2Output = "Player 1 is on square 97";
            Assert.AreEqual(expectedRound2Output, actualRound2);
        }

        [TestMethod]
        public void APlayerBouncesBackFromEnd_PlayerLandsOnSnake_PlayerEndsAtBottomOfSnake()
        {
            // Arrange
            SnakesLadders game = new SnakesLadders();

            // Act
            var actualRound1 = game.play(47, 47);
            var actualRound2 = game.play(3, 4);

            // Assert
            var expectedRound2Output = "Player 1 is on square 80";
            Assert.AreEqual(expectedRound2Output, actualRound2);
        }

        [TestMethod]
        public void PlayerLandsExactlyOnLastSquare_GameReturnsWinState()
        {
            // Arrange
            SnakesLadders game = new SnakesLadders();

            // Act
            var actualRound1 = game.play(90, 7);

            var actualRound2 = game.play(4, 1);

            var actualRound3 = game.play(1, 2);

            // Assert
            var expectedRound1Output = "Player 1 is on square 97";
            Assert.AreEqual(expectedRound1Output, actualRound1);

            var expectedRound2Output = "Player 2 is on square 5";
            Assert.AreEqual(expectedRound2Output, actualRound2);

            var expectedRound3Output = "Player 1 Wins!";
            Assert.AreEqual(expectedRound3Output, actualRound3);
        }

        [TestMethod]
        public void APlayerHasWon_AnotherPlayerTriesToPlay_GameOverStateReturned()
        {
            // Arrange
            SnakesLadders game = new SnakesLadders();

            // Act
            var actualRound1 = game.play(90, 7);

            var actualRound2 = game.play(4, 1);

            var actualRound3 = game.play(1, 2);

            var extraRound = game.play(3, 2);

            // Assert
            var expectedRound1Output = "Player 1 is on square 97";
            Assert.AreEqual(expectedRound1Output, actualRound1);

            var expectedRound2Output = "Player 2 is on square 5";
            Assert.AreEqual(expectedRound2Output, actualRound2);

            var expectedRound3Output = "Player 1 Wins!";
            Assert.AreEqual(expectedRound3Output, actualRound3);

            var expectedExtraRoundOutput = "Game over!";
            Assert.AreEqual(expectedExtraRoundOutput, extraRound);
        }
    }
}
