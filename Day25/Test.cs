using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day25Test
    {
        [TestMethod]
        public void TestSolution()
        {
            var solution = new Solutions.Day25();

            var result = solution.GetSolution("Day25/Input.txt");

            Assert.AreEqual(0, result);
        }
    }
}
