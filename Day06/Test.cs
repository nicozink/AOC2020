using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day06Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day06();

            int result = solution.GetSolution1("Day06/Example.txt");

            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day06();

            int result = solution.GetSolution1("Day06/Input.txt");

            Assert.AreEqual(6633, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day06();

            int result = solution.GetSolution2("Day06/Example.txt");

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day06();

            long result = solution.GetSolution2("Day06/Input.txt");

            Assert.AreEqual(3202, result);
        }
    }
}
