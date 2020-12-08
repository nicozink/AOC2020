using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day09Test
    {
        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day09();

            int result = solution.GetSolution1("Day09/Input.txt");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day09();

            long result = solution.GetSolution2("Day09/Input.txt");

            Assert.AreEqual(0, result);
        }
    }
}
