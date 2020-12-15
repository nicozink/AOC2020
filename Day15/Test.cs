using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day15Test
    {
        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day15();

            long result = solution.GetSolution1("Day15/Input.txt");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day15();

            long result = solution.GetSolution2("Day15/Input.txt");

            Assert.AreEqual(0, result);
        }
    }
}
