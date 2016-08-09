using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class OddsTests
    {
        [TestMethod]
        public void TestReturningOddNumbers()
        {
            Odds o = new Odds();
            int[] twoOddNums = o.GenerateOdds(4);
            CollectionAssert.AreEqual(new int[] { 1, 3, 5, 7 }, twoOddNums);
        }

        [TestMethod]
        public void TestReturning100thOddNum()
        {
            Odds o = new Odds();
            int[] hundredthOddNum = o.GenerateOdds(100);
            Assert.AreEqual((int)199, hundredthOddNum[99]);
        }

        [TestMethod]
        public void TestInstanceOfOdds()
        {
            Odds o = new Odds();
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void TestLengthOfOddsArray()
        {
            Odds o = new Odds();
            int[] ArrayOfOddNumbers = o.GenerateOdds(200);
            Assert.AreEqual((int)200, ArrayOfOddNumbers.Length);
        }
    }
}
