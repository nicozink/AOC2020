using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day20Test
    {
        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day20();

            int result = solution.GetSolution1("Day20/Input.txt");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day20();

            long result = solution.GetSolution2("Day20/Input.txt");

            Assert.AreEqual(0, result);
        }
    }
}
