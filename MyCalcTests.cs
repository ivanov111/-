using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcLib.Tests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum123()
        {
            string x = "ул.Свободы";

            MyCalc c = new MyCalc();
            bool ac = c.Sum(x);

            Assert.AreEqual(true, ac);
        }
    }
}
