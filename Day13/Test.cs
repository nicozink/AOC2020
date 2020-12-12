using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day13Test
    {
        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day13();

            int result = solution.GetSolution1("Day13/Input.txt");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day13();

            long result = solution.GetSolution2("Day13/Input.txt");

            Assert.AreEqual(0, result);
        }
    }
}
