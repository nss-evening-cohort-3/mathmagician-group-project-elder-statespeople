using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTests
    {
        [TestMethod]
        public void IntegerEnsureICanCreateAnInstance()
        {
            //Arrange

            //Act
            Integer my_int = new Integer();//What I want to be able to do

            //Assert
            Assert.IsNotNull(my_int);
        }
        [TestMethod]
        public void GenerateIntegerTest()
        {
            //Arrange

            //Act
            Integer my_int = new Integer();//What I want to be able to do
            my_int.GenerateInteger(6);
            int IntVal = my_int.IntegerList[4];
            
            //Assert
            Assert.IsNotNull(IntVal);
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestCreatingOutOfRangeException()
        {
            Integer my_int = new Integer();
            my_int.GenerateInteger(5);
            int IntVal = my_int.IntegerList[9];
        }
    }
}
