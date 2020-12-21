using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day21Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var solution = new Solutions.Day21();

            var result = solution.GetSolution1("Day21/Example.txt");

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var solution = new Solutions.Day21();

            var result = solution.GetSolution1("Day21/Input.txt");

            Assert.AreEqual(2584, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var solution = new Solutions.Day21();

            var result = solution.GetSolution2("Day21/Example.txt");

            Assert.AreEqual("mxmxvkd,sqjhc,fvjkl", result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var solution = new Solutions.Day21();

            var result = solution.GetSolution2("Day21/Input.txt");

            Assert.AreEqual("fqhpsl,zxncg,clzpsl,zbbnj,jkgbvlxh,dzqc,ppj,glzb", result);
        }
    }
}
