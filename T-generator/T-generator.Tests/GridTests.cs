﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lightman210567.TGenerator;

namespace TGenerator.Tests
{
    [TestClass]
    public class GridTests
    {
        // Checks if 4 values make the test fail like they should (less than 1/more than 90)
        [TestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(91)]
        [DataRow(92)]
        [ExpectedException(typeof(ArgumentException))] // This expects a ArgumentException to be thrown
        public void IsInGrid_ReturnFalse(int TNumber)
        {
            int TTotal = Generator.TGenerate(TNumber);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(90)]
        public void IsInGrid_TrueReturning(int TNumber)
        {
            int TTotal = Generator.TGenerate(TNumber);

            // no Assert is used because exceptions will fail the test,
            // no exceptions is what is being tested for
        }
    }
}
