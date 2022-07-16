using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lightman210567.TGenerator;

namespace TGenerator.Tests
{
    [TestClass]
    public class TrueReturningGridTest
    {
        [TestMethod]
        [DataRow(1)]
        [DataRow(90)]
        public void IsInGrid_TrueReturning(int T)
        {
            int TTotal = Generator.TGenerate(T);

            // no Assert is used because exceptions will fail the test,
            // no exceptions is what is being tested for
        }
    }
}
