using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day19Test
    {
        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day19();

            int result = solution.GetSolution1("Day19/Input.txt");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day19();

            long result = solution.GetSolution2("Day19/Input.txt");

            Assert.AreEqual(0, result);
        }
    }
}
