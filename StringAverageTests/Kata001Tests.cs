using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringAverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAverage.Tests
{
    [TestClass()]
    public class Kata001Tests
    {
        [TestMethod()]
        public void AverageStringTest()
        {
            Assert.AreEqual("four", Kata001.AverageString("zero nine five two"));
            Assert.AreEqual("three", Kata001.AverageString("four six two three"));
            Assert.AreEqual("three", Kata001.AverageString("one two three four five"));
            Assert.AreEqual("four", Kata001.AverageString("five four"));
            Assert.AreEqual("zero", Kata001.AverageString("zero zero zero zero zero"));
            Assert.AreEqual("two", Kata001.AverageString("one one eight one"));
            Assert.AreEqual("n/a", Kata001.AverageString(""));
        }
    }
}