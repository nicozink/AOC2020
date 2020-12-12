using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day12Test
    {
        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day12();

            int result = solution.GetSolution1("Day12/Input.txt");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day12();

            long result = solution.GetSolution2("Day12/Input.txt");

            Assert.AreEqual(0, result);
        }
    }
}
