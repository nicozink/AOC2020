using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day24Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day24();

            var result = solution.GetSolution1("Day24/Example.txt");

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day24();

            var result = solution.GetSolution1("Day24/Input.txt");

            Assert.AreEqual(538, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day24();

            var result = solution.GetSolution2("Day24/Example.txt");

            Assert.AreEqual(2208, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day24();

            var result = solution.GetSolution2("Day24/Input.txt");

            Assert.AreEqual(4259, result);
        }
    }
}
