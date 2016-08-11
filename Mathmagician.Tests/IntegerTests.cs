using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            List <int> temp = my_int.GenerateInteger(6);
            
            //Assert
            Assert.IsNotNull(temp[4]);
        }

        [TestMethod]
        public void Test4thIndex()
        {
            Integer my_int = new Integer();
           List <int> temp =  my_int.GenerateInteger(5);
           
            //Assert
            Assert.AreEqual(4, temp[4]);
        }
    }
}
