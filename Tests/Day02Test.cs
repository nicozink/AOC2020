using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day02Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var day02 = new Solutions.Day02();

            int result = day02.GetSolution1("Input/Day02/Example.txt");

            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var day02 = new Solutions.Day02();

            int result = day02.GetSolution1("Input/Day02/Input.txt");

            Assert.AreEqual(result, 622);
        }

        [TestMethod]
        public void TestExample2()
        {
            var day02 = new Solutions.Day02();

            int result = day02.GetSolution2("Input/Day02/Example.txt");

            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var day02 = new Solutions.Day02();

            int result = day02.GetSolution2("Input/Day02/Input.txt");

            Assert.AreEqual(result, 263);
        }
    }
}
