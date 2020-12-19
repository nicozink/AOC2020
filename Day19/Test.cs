using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day19Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day19();

            int result = solution.GetSolution1("Day19/Example1.txt");

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day19();

            int result = solution.GetSolution1("Day19/Input.txt");

            Assert.AreEqual(134, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day19();

            int result = solution.GetSolution2("Day19/Example2.txt");

            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day19();

            int result = solution.GetSolution2("Day19/Input.txt");

            Assert.AreEqual(377, result);
        }
    }
}
