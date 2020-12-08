using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day08Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day08();

            int result = solution.GetSolution1("Day08/Example.txt");

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day08();

            int result = solution.GetSolution1("Day08/Input.txt");

            Assert.AreEqual(1475, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day08();

            int result = solution.GetSolution2("Day08/Example.txt");

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day08();

            long result = solution.GetSolution2("Day08/Input.txt");

            Assert.AreEqual(1270, result);
        }
    }
}
