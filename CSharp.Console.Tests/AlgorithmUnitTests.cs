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
            //Arrange
            var expectedResultSameRequest = (x + y) * 3;
            var expectedResultDiffRequest = x + y;

            // Act
            BasicAlgo_0001_Addition.Main(new string[] { });
            var result = BasicAlgo_0001_Addition.SumFunc(x, y);

            // Assert
            if (x == y)
            {
                Assert.AreEqual(expectedResultSameRequest, result);
            }
            else
            {
                Assert.AreEqual(expectedResultDiffRequest, result);
            }
        }
    }
}