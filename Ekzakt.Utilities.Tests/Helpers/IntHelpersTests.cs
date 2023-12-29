using Ekzakt.Utilities.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Formats.Asn1;

namespace Ekzakt.Utilities.Helpers.Tests
{
    [TestClass()]
    public class IntHelpersTests
    {
        [TestMethod()]
        public void GetRandomInt_ShouldBeBetweenMinValueAndMaxValue()
        {
            int result = IntHelpers.GetRandomInt();

            Assert.IsTrue(result >= int.MinValue && result <= int.MaxValue);
        }


        [TestMethod()]
        public void GetRandomPositiveInt_ShouldBePositive()
        {
            int result = IntHelpers.GetRandomPositiveInt();

            Assert.IsTrue(result >= 0 && result <= int.MaxValue);
        }


        [TestMethod()]
        public void GetRandomNegativeInt_ShouldBeNegative()
        {
            int result = IntHelpers.GetRandomNegativeInt();

            Assert.IsTrue(result < 0);
        }


        [TestMethod()]
        public void GetRandomIntBetween_WithValidMinValueAndMaxValue()
        {
            int minValue = 10;
            int maxValue = 20;

            int result = IntHelpers.GetRandomIntBetween(minValue, maxValue);

            Assert.IsTrue(result >= minValue && result <= maxValue);
        }


        [TestMethod()]
        public void GetRandomIntBetween_WithMinValueAndMaxValueReversed()
        {
            int minValue = 200;
            int maxValue = 10;

            int result = IntHelpers.GetRandomIntBetween(minValue, maxValue);

            Assert.IsTrue(result >= maxValue && result <= minValue);
        }
    }
}