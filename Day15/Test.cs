using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class Day15Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day15();

            Assert.AreEqual(436, solution.GetNthNumber(new List<int> { 0, 3, 6 }, 2020));
            Assert.AreEqual(1, solution.GetNthNumber(new List<int> { 1, 3, 2 }, 2020));
            Assert.AreEqual(10, solution.GetNthNumber(new List<int> { 2, 1, 3 }, 2020));
            Assert.AreEqual(27, solution.GetNthNumber(new List<int> { 1, 2, 3 }, 2020));
            Assert.AreEqual(78, solution.GetNthNumber(new List<int> { 2, 3, 1 }, 2020));
            Assert.AreEqual(438, solution.GetNthNumber(new List<int> { 3, 2, 1 }, 2020));
            Assert.AreEqual(1836, solution.GetNthNumber(new List<int> { 3, 1, 2 }, 2020));
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day15();

            long result = solution.GetNthNumber(new List<int> { 2, 0, 1, 7, 4, 14, 18 }, 2020);

            Assert.AreEqual(496, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day15();

            Assert.AreEqual(175594, solution.GetNthNumber(new List<int> { 0, 3, 6 }, 30000000));
            Assert.AreEqual(2578, solution.GetNthNumber(new List<int> { 1, 3, 2 }, 30000000));
            Assert.AreEqual(3544142, solution.GetNthNumber(new List<int> { 2, 1, 3 }, 30000000));
            Assert.AreEqual(261214, solution.GetNthNumber(new List<int> { 1, 2, 3 }, 30000000));
            Assert.AreEqual(6895259, solution.GetNthNumber(new List<int> { 2, 3, 1 }, 30000000));
            Assert.AreEqual(18, solution.GetNthNumber(new List<int> { 3, 2, 1 }, 30000000));
            Assert.AreEqual(362, solution.GetNthNumber(new List<int> { 3, 1, 2 }, 30000000));
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day15();

            long result = solution.GetNthNumber(new List<int> { 2, 0, 1, 7, 4, 14, 18 }, 30000000);

            Assert.AreEqual(883, result);
        }
    }
}
