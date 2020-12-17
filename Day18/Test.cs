using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day18Test
    {
        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day18();

            int result = solution.GetSolution1("Day18/Input.txt");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day18();

            long result = solution.GetSolution2("Day18/Input.txt");

            Assert.AreEqual(0, result);
        }
    }
}
