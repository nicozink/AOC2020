using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day05Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day05();

            var result = solution.GetPositionFromString("FBFBBFF");

            Assert.AreEqual(44, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day05();

            long result = solution.GetPositionFromString("RLR");

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestExample3()
        {
            var solution = new Solutions.Day05();

            var result = solution.GetSeatPosition("FBFBBFFRLR");

            Assert.AreEqual(44, result.Item1);
            Assert.AreEqual(5, result.Item2);
        }

        [TestMethod]
        public void TestExample4()
        {
            var solution = new Solutions.Day05();

            Assert.AreEqual(567, solution.GetSeatID("BFFFBBFRRR"));
            Assert.AreEqual(119, solution.GetSeatID("FFFBBBFRRR"));
            Assert.AreEqual(820, solution.GetSeatID("BBFFBBFRLL"));
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day05();

            int result = solution.GetMaximumSeatID();

            Assert.AreEqual(816, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day05();

            long result = solution.GetMissingSeat();

            Assert.AreEqual(539, result);
        }
    }
}
