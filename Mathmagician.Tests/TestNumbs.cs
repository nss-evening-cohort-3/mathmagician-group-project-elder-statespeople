using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class TestNumbs
    {
        [TestMethod]
        public void TestPrintPrimes()
        {
            Primes p = new Primes();
            int[] testP = p.GeneratePrimes(10);
            string output = p.PrintOut(testP);
            Assert.AreEqual(" 2  3  5  7  11  13  17  19  23  29 ", output);
        }

        [TestMethod]
        public void TestPrintOdds()
        {
            Odds o = new Odds();
            int[] testO = o.GenerateOdds(10);
            string output = o.PrintOut(testO);
            Assert.AreEqual(" 1  3  5  7  9  11  13  15  17  19 ", output);
        }
    }
}
