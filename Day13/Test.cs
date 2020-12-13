using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day13Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day13();

            int result = solution.GetSolution1("Day13/Example.txt");

            Assert.AreEqual(295, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day13();

            int result = solution.GetSolution1("Day13/Input.txt");

            Assert.AreEqual(5257, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day13();

            Assert.AreEqual(1068781, solution.SolveSubsequentDepartures("7,13,x,x,59,x,31,19"));
            Assert.AreEqual(3417, solution.SolveSubsequentDepartures("17,x,13,19"));
            Assert.AreEqual(754018, solution.SolveSubsequentDepartures("67,7,59,61"));
            Assert.AreEqual(779210, solution.SolveSubsequentDepartures("67,x,7,59,61"));
            Assert.AreEqual(1261476, solution.SolveSubsequentDepartures("67,7,x,59,61"));
            Assert.AreEqual(1202161486, solution.SolveSubsequentDepartures("1789,37,47,1889"));
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day13();

            long result = solution.GetSolution2("Day13/Input.txt");

            Assert.AreEqual(538703333547789, result);
        }
    }
}
