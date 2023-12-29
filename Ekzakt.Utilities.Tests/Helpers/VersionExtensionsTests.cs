using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ekzakt.Utilities.Helpers.Tests
{
    [TestClass()]
    public class VersionExtensionsTests
    {
        [TestMethod()]
        public void Format_RevisionIsZeroAndNoPrefix()
        {
            Version version = new Version(1, 2, 3, 0);

            var result = version.Format();

            Assert.AreEqual("1.2.3.", result);
        }


        [TestMethod()]
        public void Format_RevisionIsZeroAndPrefix()
        {
            Version version = new Version(1, 2, 3, 0);

            var result = version.Format("v");

            Assert.AreEqual("v1.2.3.", result);
        }


        [TestMethod()]
        public void Format_RevisionIsNotZeroAndNoPrefix()
        {
            Version version = new Version(1, 2, 3, 1);

            var result = version.Format();

            Assert.AreEqual("1.2.3.1.", result);
        }


        [TestMethod()]
        public void Format_RevisionIsNotZeroAndPrefix()
        {
            Version version = new Version(1, 2, 3, 1);

            var result = version.Format("v ");

            Assert.AreEqual("v 1.2.3.1.", result);
        }
    }
}