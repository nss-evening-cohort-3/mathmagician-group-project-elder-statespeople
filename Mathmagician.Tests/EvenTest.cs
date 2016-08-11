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
         public void Test8thValueInEvenList()
        {
            Even my_even = new Even();
           List<int> temp =  my_even.GenerateEven(8);

            //Assert()
            Assert.AreEqual(14, temp[7]);   
        }

        
        [TestMethod]
        public void Test0thValueInEvenList()
        {
            Even my_even = new Even();
            List<int> temp = my_even.GenerateEven(1);

            Assert.IsTrue(0 == temp[0]);
        }

    }
}
