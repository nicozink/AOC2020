using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day04Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day04();

            int result = solution.GetSolution1("Day04/Example1.txt");

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day04();

            int result = solution.GetSolution1("Day04/Input.txt");

            Assert.AreEqual(237, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day04();

            long result = solution.GetSolution2("Day04/Example2.txt");

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day04();

            long result = solution.GetSolution2("Day04/Input.txt");

            Assert.AreEqual(172, result);
        }
    }
}
