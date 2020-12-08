using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day08Test
    {
        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day08();

            int result = solution.GetSolution1("Day08/Input.txt");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day08();

            long result = solution.GetSolution2("Day08/Input.txt");

            Assert.AreEqual(0, result);
        }
    }
}
