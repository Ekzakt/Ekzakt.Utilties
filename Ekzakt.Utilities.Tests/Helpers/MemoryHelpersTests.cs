using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ekzakt.Utilities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekzakt.Utilities.Helpers.Tests
{
    [TestClass()]
    public class MemoryHelpersTests
    {
        [TestMethod()]
        public void DeepCopyTest_ListOfIntIsEqual()
        {
            var original = new List<int> { 1, 2, 3, 4, 5 };
            var expected = new List<int> { 1, 2, 3, 4, 5 };

            var copy = MemoryHelpers.DeepCopy(original);

            CollectionAssert.AreEqual(expected, copy);
            Assert.AreNotSame(original, copy);
        }
    }
}