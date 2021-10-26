using System;
using System.Collections.Generic;
using CSharp.Fundamentals.LINQ;
using NUnit.Framework;

namespace CSharp.Console.Tests
{
    [TestFixture]
    public class LinqUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(0, 1, 2, 3, 4, 5, 6, 7, 8, 9)]
        public void Linq_001_DisplayEvenNumber(params int[] testData)
        {
            //Arrange
            var expectedResult = new List<int>() { 0, 2, 4, 6, 8 };

            // Act
            Linq_001.Main(new string[] { });
            var actualResult1 = Linq_001.GetEvenNumberByLambda(testData);
            var actualResult2 = Linq_001.GetEvenNumberByMethod(testData);

            // Assert
            Assert.AreEqual(expectedResult, actualResult1);
            Assert.AreEqual(expectedResult, actualResult2);
        }

        [Test]
        [TestCase(0, 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14)]
        public void Linq_002_DisplayPositiveValueInTheRange(params int[] testData)
        {
            //Arrange
            var expectedResult = new List<int>() { 1, 3, 6, 9, 10 };

            // Act
            Linq_002.Main(new string[] { });
            var actualResult = Linq_002.GetPositiveValue(testData);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(9, 8, 6, 5)]
        public void Linq_003_FindSquareRoot(params int[] testData)
        {
            //Arrange
          
            // Act
            Linq_003.Main(new string[] { });
            var actualResult = Linq_003.FindTheSquareRoot(testData);

            // Assert
            Assert.IsNotNull(actualResult);
        }
    }
}