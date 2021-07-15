using Kata_Club.Katas.SimpleSum_Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class SimpleSumsTests
    {
        [TestMethod]
        public void SimpleAddition()
        {
            // Arrange
            var simpleSums = new SimpleSums();

            // Act
            var actualResult = simpleSums.Add(1, 2);

            // Assert
            var expectedResult = 3;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
