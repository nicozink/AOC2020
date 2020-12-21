using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day22Test
    {
        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day22();

            var result = solution.GetSolution1("Day22/Input.txt");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day22();

            var result = solution.GetSolution2("Day22/Input.txt");

            Assert.AreEqual(0, result);
        }
    }
}
