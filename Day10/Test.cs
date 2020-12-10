using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day10Test
    {
        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day10();

            int result = solution.GetSolution1("Day10/Input.txt");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day10();

            long result = solution.GetSolution2("Day10/Input.txt");

            Assert.AreEqual(0, result);
        }
    }
}
