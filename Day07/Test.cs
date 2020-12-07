using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day07Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day07();

            int result = solution.GetSolution1("Day07/Example1.txt");

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day07();

            int result = solution.GetSolution1("Day07/Input.txt");

            Assert.AreEqual(185, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day07();

            int result = solution.GetSolution2("Day07/Example2.txt");

            Assert.AreEqual(126, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day07();

            long result = solution.GetSolution2("Day07/Input.txt");

            Assert.AreEqual(89084, result);
        }
    }
}
