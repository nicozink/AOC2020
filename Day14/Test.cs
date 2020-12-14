using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day14Test
    {
        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day14();

            int result = solution.GetSolution1("Day14/Input.txt");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day14();

            long result = solution.GetSolution2("Day14/Input.txt");

            Assert.AreEqual(0, result);
        }
    }
}
