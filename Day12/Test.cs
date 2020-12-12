using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day12Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day12();

            int result = solution.GetSolution1("Day12/Example.txt");

            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day12();

            int result = solution.GetSolution1("Day12/Input.txt");

            Assert.AreEqual(319, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day12();

            var result = solution.GetSolution2("Day12/Example.txt");

            Assert.AreEqual(286, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day12();

            long result = solution.GetSolution2("Day12/Input.txt");

            Assert.AreEqual(50157, result);
        }
    }
}
