﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ekzakt.Utilities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekzakt.Utilities.Helpers.Tests
{
    [TestClass()]
    public class ArrayHelpersTests
    {
        [TestMethod()]
        public void GetRandomTest()
        {
            // Arrange
            var value = "TestValue";
            var random = new Random();

            // Act
            var result = ArrayHelpers.GetRandom(value);

            // Assert
            Assert.IsTrue(result.Length == 1);
        }
    }
}