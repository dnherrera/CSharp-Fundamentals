using CSharp.Fundamentals.Algorithms;
using NUnit.Framework;

namespace CSharp.Console.Tests
{
    public class AlgorithmUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 3)]
        public void BasicAlgo_0001(int x, int y)
        {
            var result = BasicAlgo_0001_Addition.SumFunc(x, y);
            if (x == y)
            {
                Assert.AreEqual((x + y) * 3, result);
            }
            else
            {
                Assert.AreEqual(x + y, result);
            }
        }
    }
}