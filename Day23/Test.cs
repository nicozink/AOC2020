using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day23Test
    {
		[TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day23();

            var result10 = solution.GetSolution1("389125467", 10);
            Assert.AreEqual("92658374", result10);

			var result100 = solution.GetSolution1("389125467", 100);
            Assert.AreEqual("67384529", result100);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day23();

            var result = solution.GetSolution1("284573961", 100);

            Assert.AreEqual("26354798", result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day23();

            var result = solution.GetSolution2("389125467");
            Assert.AreEqual(149245887792, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day23();

            var result = solution.GetSolution2("284573961");

            Assert.AreEqual(166298218695, result);
        }
    }
}
