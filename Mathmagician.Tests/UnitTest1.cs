using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public void ThisIsNotATest()//all other methods can use this one
        {

        }

        [TestMethod]//This must be annotated, required for VS to view it as a test and put it in Test Explorer
        public void TestThatThisIsTrue()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void ThisShouldFail()
        {
            //Arrange

            //Act

            //Assert
            Assert.Fail();
        }
    }
}
