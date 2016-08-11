using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mathmagician.Tests
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
         public void FibEnsureICanCreateAnInstance()
        {
            //Arrange

            //Act
            Fibonacci my_fib = new Fibonacci();//What I want to be able to do

            //Assert
            Assert.IsNotNull(my_fib);
        }

        [TestMethod]
        public void FibNotNullTest()
        {
            Fibonacci my_fib = new Fibonacci();
            List<int> temp = my_fib.GenerateFibonacci(9);

            //Assert
            Assert.IsTrue(temp[0] == 0);
        }

       [TestMethod]
        public void TestValueOfIndex3()
        {
            Fibonacci my_fib = new Fibonacci();
           List<int> temp =  my_fib.GenerateFibonacci(5);  

            //Assert
            Assert.IsTrue(temp[3] == 2);
        }

        [TestMethod]
        public void TestFibListWith5Elements()
        {
            Fibonacci my_fib = new Fibonacci();
           List<int>temp =  my_fib.GenerateFibonacci(5);

            //Assert
            CollectionAssert.AreEqual(new List <int>{0,1,1,2,3}, temp);
        }

        [TestMethod]
        public void TestFibListWith9Elements()
        {
            Fibonacci my_fib = new Fibonacci();
           List<int> temp =  my_fib.GenerateFibonacci(9);

            //Assert
            CollectionAssert.AreEqual(new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21 }, temp);
        }

    }
}
