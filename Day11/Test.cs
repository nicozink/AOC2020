using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day11Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day11();

            int result = solution.GetSolution1("Day11/Example.txt");

            Assert.AreEqual(37, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day11();

            int result = solution.GetSolution1("Day11/Input.txt");

            Assert.AreEqual(2346, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day11();

            int result = solution.GetSolution2("Day11/Example.txt");

            Assert.AreEqual(26, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day11();

            long result = solution.GetSolution2("Day11/Input.txt");

            Assert.AreEqual(2111, result);
        }
    }
}
