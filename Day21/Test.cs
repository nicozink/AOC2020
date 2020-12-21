using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day21Test
    {
        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day21();

            var result = solution.GetSolution1("Day21/Input.txt");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day21();

            var result = solution.GetSolution2("Day21/Input.txt");

            Assert.AreEqual(0, result);
        }
    }
}
