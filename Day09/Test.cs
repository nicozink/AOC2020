using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Day09Test
    {
        [TestMethod]
        public void TestExample1()
        {
            var encription = new Solutions.Day09.Encription("Day09/Example.txt", 5);
            long result = encription.GetInvalidNumber();

            Assert.AreEqual(127, result);
        }

        [TestMethod]
        public void TestSolution1()
        {
            var encription = new Solutions.Day09.Encription("Day09/Input.txt", 25);
            long result = encription.GetInvalidNumber();

            Assert.AreEqual(41682220, result);
        }

        [TestMethod]
        public void TestExample2()
        {
            var encription = new Solutions.Day09.Encription("Day09/Example.txt", 5);
            long result = encription.GetEncryptionWeakness();

            Assert.AreEqual(62, result);
        }

        [TestMethod]
        public void TestSolution2()
        {
            var encription = new Solutions.Day09.Encription("Day09/Input.txt", 25);
            long result = encription.GetEncryptionWeakness();

            Assert.AreEqual(5388976, result);
        }
    }
}
