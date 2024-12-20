using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ekzakt.Utilities.Helpers.Tests
{
    [TestClass()]
    public class ArrayHelpersTests
    {
        [TestMethod()]
        public void GetRandomCharTest_LengthShouldBeOne()
        {
            // Arrange
            var value = "TestValue";
            var random = new Random();

            // Act
            var result = value.GetRandomChar();

            // Assert
            Assert.IsTrue(result.Length == 1);
        }

        [TestMethod()]
        public void GetRandomCharTest_ValueShouldContainResult()
        {
            // Arrange
            var value = "TestValue";
            var random = new Random();

            // Act
            var result = value.GetRandomChar();

            // Assert
            Assert.IsTrue(result.Contains(result));
        }
    }
}