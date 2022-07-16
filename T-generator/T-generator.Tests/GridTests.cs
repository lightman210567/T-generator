using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lightman210567.TGenerator;

namespace TGenerator.Tests
{
    [TestClass]
    internal class GridTests
    {
        // Checks if 4 values make the test fail like they should (less than 1/more than 90)
        [TestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(91)]
        [DataRow(92)]
        [ExpectedException(typeof(ArgumentException))] // This expects a ArgumentException to be thrown
        public void IsInGrid_ReturnFalse(int T)
        {
            int TTotal = Generator.TGenerate(T);
        }
    }
}
