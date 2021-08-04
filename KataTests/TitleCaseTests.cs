using Kata_Club.Katas.TitleCase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    // https://www.codewars.com/kata/5202ef17a402dd033c000009/train/csharp
    [TestClass]
    public class TitleCaseTests
    {
        [TestMethod]
        public void SimpleTitle_WithListOfExceptionWords_ExpectedTitleCaseReturned()
        {
            // Arrange
            var inputTitle = "a clash of KINGS";
            var exceptionWords = "a an the of";

            // Act
            var actual = TitleHelper.TitleCase(inputTitle, exceptionWords);

            // Assert
            var expected = "A Clash of Kings";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AllCapsTitle_WithCapatalisedExceptionWords_ExpectedTitleCaseReturned()
        {
            // Arrange
            var inputTitle = "THE WIND IN THE WILLOWS";
            var exceptionWords = "The In";

            // Act
            var actual = TitleHelper.TitleCase(inputTitle, exceptionWords);

            // Assert
            var expected = "The Wind in the Willows";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AllLowerTitle_WithNoExceptionWords_ExpectedTitleCaseReturned()
        {
            // Arrange
            var inputTitle = "the quick brown fox";
            
            // Act
            var actual = TitleHelper.TitleCase(inputTitle);

            // Assert
            var expected = "The Quick Brown Fox";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EmptyInput_WithNoExceptionWords_ReturnEmptyString()
        {
            // Arrange
            var inputTitle = "";

            // Act
            var actual = TitleHelper.TitleCase(inputTitle);

            // Assert
            var expected = "";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SimpleInput_WithNullExceptionWords_ExpectedTitleCaseReturned()
        {
            // Arrange
            var inputTitle = "aBC deF Ghi";
            string exceptionWords = null;

            // Act
            var actual = TitleHelper.TitleCase(inputTitle, exceptionWords);

            // Assert
            var expected = "Abc Def Ghi";
            Assert.AreEqual(expected, actual);
        }
    }
}
