using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day17Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day17();

            int result = solution.GetSolution1("Day17/Example.txt");

            Assert.AreEqual(112, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day17();

            int result = solution.GetSolution1("Day17/Input.txt");

            Assert.AreEqual(348, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day17();

            int result = solution.GetSolution2("Day17/Example.txt");

            Assert.AreEqual(848, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day17();

            long result = solution.GetSolution2("Day17/Input.txt");

            Assert.AreEqual(2236, result);
        }
    }
}
