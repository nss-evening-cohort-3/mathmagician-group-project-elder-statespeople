using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician.Tests
{
    [TestClass]
   public class EvenTest
    {
        [TestMethod]
        public void EvenEnsureICanCreateAnInstance()
        {      
            //Arrange

            //Act
            Even my_even = new Even();//What I want to be able to do
            my_even.GenerateEven(6);

            //Assert
            Assert.IsNotNull(my_even);
        }
       
         [TestMethod]
         public void TestEvenListCount()
        {
            Even my_even = new Even();
            my_even.GenerateEven(8);

            //Assert()
            Assert.AreEqual(8, my_even.EvenList.Count);   
        }

        [TestMethod]
        public void TestEvenType()
        {
            Even my_even = new Even();
            Assert.IsInstanceOfType(my_even, typeof(Even));
        }

        [TestMethod]
        public void TestListLength()
        {
            Even my_even = new Even();
            Assert.AreEqual(0, my_even.EvenList.Count);
        }

    }
}
