using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day25Test
    {
        [TestMethod]
        public void TestExample()
        {
            var solution = new Solutions.Day25();

            var result = solution.GetSolution(5764801, 17807724);

            Assert.AreEqual(14897079, result);
        }

        [TestMethod]
        public void TestSolution()
        {
            var solution = new Solutions.Day25();

            var result = solution.GetSolution(18499292, 8790390);

            Assert.AreEqual(18433997, result);
        }
    }
}
