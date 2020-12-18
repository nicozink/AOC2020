using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day18Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solver = new Solutions.Day18.LinearSolver();

            Assert.AreEqual(71, solver.Solve("1 + 2 * 3 + 4 * 5 + 6"));
            Assert.AreEqual(51, solver.Solve("1 + (2 * 3) + (4 * (5 + 6))"));
            Assert.AreEqual(26, solver.Solve("2 * 3 + (4 * 5)"));
            Assert.AreEqual(437, solver.Solve("5 + (8 * 3 + 9 + 3 * 4 * 3)"));
            Assert.AreEqual(12240, solver.Solve("5 * 9 * (7 * 3 * 3 + 9 * 3 + (8 + 6 * 4))"));
            Assert.AreEqual(13632, solver.Solve("((2 + 4 * 9) * (6 + 9 * 8 + 6) + 6) + 2 + 4 * 2"));
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day18();

            long result = solution.GetSolution1("Day18/Input.txt");

            Assert.AreEqual(1890866893020, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solver = new Solutions.Day18.PrecedenceSolver();

            Assert.AreEqual(231, solver.Solve("1 + 2 * 3 + 4 * 5 + 6"));
            Assert.AreEqual(51, solver.Solve("1 + (2 * 3) + (4 * (5 + 6))"));
            Assert.AreEqual(46, solver.Solve("2 * 3 + (4 * 5)"));
            Assert.AreEqual(1445, solver.Solve("5 + (8 * 3 + 9 + 3 * 4 * 3)"));
            Assert.AreEqual(669060, solver.Solve("5 * 9 * (7 * 3 * 3 + 9 * 3 + (8 + 6 * 4))"));
            Assert.AreEqual(23340, solver.Solve("((2 + 4 * 9) * (6 + 9 * 8 + 6) + 6) + 2 + 4 * 2"));
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day18();

            long result = solution.GetSolution2("Day18/Input.txt");

            Assert.AreEqual(34646237037193, result);
        }
    }
}
