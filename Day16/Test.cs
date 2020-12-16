using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day16Test
    {
        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day16();

            int result = solution.GetSolution1("Day16/Input.txt");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day16();

            long result = solution.GetSolution2("Day16/Input.txt");

            Assert.AreEqual(0, result);
        }
    }
}
