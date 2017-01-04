﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OneOf.Tests
{
    [TestClass]
    public class CtorTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullValueThrowsException()
        {
            var x = new OneOf<string, bool>(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WrongTypeThrowsException()
        {
            var x = new OneOf<int, decimal>("ABC");
        }
    }
}