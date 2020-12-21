using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day20Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day20();

            var result = solution.GetSolution1("Day20/Example.txt");

            Assert.AreEqual(20899048083289, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day20();

            var result = solution.GetSolution1("Day20/Input.txt");

            Assert.AreEqual(18482479935793, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day20();

            var result = solution.GetSolution2("Day20/Example.txt");

            Assert.AreEqual(273, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day20();

            var result = solution.GetSolution2("Day20/Input.txt");

            Assert.AreEqual(2118, result);
        }
    }
}
