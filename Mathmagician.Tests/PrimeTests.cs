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
        public void TestLengthOfPrimesArray()
        {
            Primes p = new Primes();
            int[] testP = p.GeneratePrimes(200);
            Assert.AreEqual((int)200, testP.Length);
        }

        [TestMethod]
        public void TestInstanceofPrimes()
        {
            Primes p = new Primes();
            Assert.IsNotNull(p);
        }

    }
}
