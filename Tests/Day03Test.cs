using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day03Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day03();

            int result = solution.GetSolution1("Input/Day03/Example.txt");

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day03();

            int result = solution.GetSolution1("Input/Day03/Input.txt");

            Assert.AreEqual(247, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day03();

            long result = solution.GetSolution2("Input/Day03/Example.txt");

            Assert.AreEqual(336, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day03();

            long result = solution.GetSolution2("Input/Day03/Input.txt");

            Assert.AreEqual(2983070376, result);
        }
    }
}
