using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lightman210567.TGenerator;

namespace TGenerator.Tests
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        [DataRow(50)]
        public void ReturnsCorrectValue_Is187(int TNumber)
        {
            int result = Generator.TGenerate(TNumber);

            Assert.AreEqual(187, result);
        }
    }
}
