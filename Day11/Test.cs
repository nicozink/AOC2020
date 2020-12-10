using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day11Test
    {
        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day11();

            int result = solution.GetSolution1("Day11/Input.txt");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day11();

            long result = solution.GetSolution2("Day11/Input.txt");

            Assert.AreEqual(0, result);
        }
    }
}
