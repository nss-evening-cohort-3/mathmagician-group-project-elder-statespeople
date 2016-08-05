using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace Mathmagician.Tests
{
    [TestClass]
    public class PrimeTests
    {
        [TestMethod]
        public void TestReturnPrimes()
        {
            Primes p = new Primes();
            int[] twoItems = p.GeneratePrimes(2);
            CollectionAssert.AreEqual(new int[] { 2, 3 }, twoItems);
        }

        [TestMethod]
        public void Test100thPrime()
        {
            Primes p = new Primes();
            int[] testP = p.GeneratePrimes(100);
            Assert.AreEqual((int)541, testP[99]);
        }

        [TestMethod]
        public void TestPrintPrimes()
        {
            Primes p = new Primes();
            int[] testP = p.GeneratePrimes(10);
            string output = p.PrintPrimes(testP);
            Assert.AreEqual(" 2  3  5  7  11  13  17  19  23  29 ", output);
        }
    }
}
