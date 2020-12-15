using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day14Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day14();

            long result = solution.ExecuteBitmaskProgram("Day14/Example1.txt", 1);

            Assert.AreEqual(165, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day14();

            long result = solution.ExecuteBitmaskProgram("Day14/Input.txt", 1);

            Assert.AreEqual(4297467072083, result);
        }

		[TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day14();

            long result = solution.ExecuteBitmaskProgram("Day14/Example2.txt", 2);

            Assert.AreEqual(208, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day14();

            long result = solution.ExecuteBitmaskProgram("Day14/Input.txt", 2);

            Assert.AreEqual(5030603328768, result);
        }
    }
}
