using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day10Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day10();

            int result = solution.GetJoltProduct("Day10/Example1.txt");

            Assert.AreEqual(35, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day10();

            int result = solution.GetJoltProduct("Day10/Example2.txt");

            Assert.AreEqual(220, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day10();

            int result = solution.GetJoltProduct("Day10/Input.txt");

            Assert.AreEqual(2277, result);
        }

        [TestMethod]
        public void TestExample3()
        {
            var solution = new Solutions.Day10();

            long result = solution.CountValidArrangements("Day10/Example1.txt");

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestExample4()
        {
            var solution = new Solutions.Day10();

            long result = solution.CountValidArrangements("Day10/Example2.txt");

            Assert.AreEqual(19208, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day10();

            long result = solution.CountValidArrangements("Day10/Input.txt");

            Assert.AreEqual(37024595836928, result);
        }
    }
}
