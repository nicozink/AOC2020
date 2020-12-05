using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day06Test
    {
        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day06();

            int result = solution.GetSolution1("Day05/Input.txt");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day06();

            long result = solution.GetSolution2("Day05/Input.txt");

            Assert.AreEqual(0, result);
        }
    }
}
