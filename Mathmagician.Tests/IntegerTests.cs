﻿using System;
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
    }
}
