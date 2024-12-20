using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ekzakt.Utilities.Helpers;

namespace Ekzakt.Utilities.Helpers.Tests
{
    [TestClass()]
    public class StringHelpersTests
    {
        [TestMethod()]
        public void RemoveDuplicateCharsTest_ShouldReturnExpectedString()
        {
            string input = "aabbcc";
            string expected = "abc";

            string actual = input.RemoveDuplicateChars();

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void RemoveDuplicateCharsTest_ShouldReturnEmptyString()
        {
            string? input = "";
            string expected = "";

            string actual = StringHelpers.RemoveDuplicateChars(input);

            Assert.AreEqual(expected, actual);
        }
    }
}