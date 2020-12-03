using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day01Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var day01 = new Solutions.Day01();

            int result = day01.GetSolution1("Input/Day01/Example.txt");

            Assert.AreEqual(result, 514579);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var day01 = new Solutions.Day01();

            int result = day01.GetSolution1("Input/Day01/Input.txt");

            Assert.AreEqual(result, 927684);
        }

        [TestMethod]
        public void TestExample2()
        {
            var day01 = new Solutions.Day01();

            int result = day01.GetSolution2("Input/Day01/Example.txt");

            Assert.AreEqual(result, 241861950);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var day01 = new Solutions.Day01();

            int result = day01.GetSolution2("Input/Day01/Input.txt");

            Assert.AreEqual(result, 292093004);
        }
    }
}
