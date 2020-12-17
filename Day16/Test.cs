using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day16Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day16();

            int result = solution.GetSolution1("Day16/Example1.txt");

            Assert.AreEqual(71, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day16();

            int result = solution.GetSolution1("Day16/Input.txt");

            Assert.AreEqual(19070, result);
        }

		[TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day16();

            var result = solution.GetExample2("Day16/Example2.txt");

            Assert.AreEqual(12, result[0]);
            Assert.AreEqual(11, result[1]);
            Assert.AreEqual(13, result[2]);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day16();

            long result = solution.GetSolution2("Day16/Input.txt");

            Assert.AreEqual(161926544831, result);
        }
    }
}
