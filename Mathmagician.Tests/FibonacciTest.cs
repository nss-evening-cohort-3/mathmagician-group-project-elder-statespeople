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
            my_fib.GenerateFibonacci(5);
            int temp = my_fib.FibonacciList[0];

            //Assert
            Assert.IsNotNull(temp);
        }

       [TestMethod]
        public void FibTrueTest()
        {
            Fibonacci my_fib = new Fibonacci();
            my_fib.GenerateFibonacci(5);
            int temp = my_fib.FibonacciList[3];

            //Assert
            Assert.IsTrue(temp == 2);
        }

        [TestMethod]
        public void FibListTest1()
        {
            Fibonacci my_fib = new Fibonacci();
            my_fib.GenerateFibonacci(5);

            //Assert
            CollectionAssert.AreEqual(new List <int>{0,1,1,2,3}, my_fib.FibonacciList);
        }

        [TestMethod]
        public void FibListTest2()
        {
            Fibonacci my_fib = new Fibonacci();
            my_fib.GenerateFibonacci(9);

            //Assert
            CollectionAssert.AreEqual(new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21 }, my_fib.FibonacciList);
        }

    }
}
