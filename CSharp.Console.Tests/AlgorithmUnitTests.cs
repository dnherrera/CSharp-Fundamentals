using System;
using System.Linq;
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
        public void BasicAlgo_0001_SumOfTwoIntegers(int x, int y)
        {
            //Arrange
            var expectedResultSameRequest = (x + y) * 3;
            var expectedResultDiffRequest = x + y;

            // Act
            BasicAlgo_0001.Main(new string[] { });
            var result = BasicAlgo_0001.SumTwoIntegers(x, y);

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

        [Test]
        [TestCase(53)]
        [TestCase(30)]
        [TestCase(51)]
        public void BasicAlgo_0002_ComputeAbsDifference(int x)
        {
            //Arrange
            var expectedGreaterThan51 = Math.Abs((x - 51) * 3);
            var expectedLessThan51 = Math.Abs(x - 51);

            // Act
            BasicAlgo_0002.Main(new string[] { });
            var result = BasicAlgo_0002.ComputeAbsDifference(x);

            // Assert
            if (x > 51)
            {
                Assert.AreEqual(expectedGreaterThan51, result);
            }
            else
            {
                Assert.AreEqual(expectedLessThan51, result);
            }
        }

        [Test]
        [TestCase(30, 0)]
        [TestCase(25, 5)]
        [TestCase(20, 30)]
        [TestCase(35, 25)]
        public void BasicAlgo_0003_IsEqualsToThirty(int x, int y)
        {
            //Arrange
            var isEqualTo30 = x == 30 || y == 30 || (x + y == 30);

            // Act
            BasicAlgo_0003.Main(new string[] { });
            var result = BasicAlgo_0003.IsEqualsToThirty(x, y);

            // Assert
            if (isEqualTo30)
            {
                Assert.AreEqual(true, result);
            }
            else
            {
                Assert.AreEqual(false, result);
            }
        }

        [Test]
        [TestCase(103)]
        [TestCase(90)]
        [TestCase(89)]
        public void BasicAlgo_0004_CheckWithin100(int x)
        {
            // Arrange
            var isValueWithin = Math.Abs(x - 100) <= 10 || Math.Abs(x - 200) <= 10;

            // Act
            BasicAlgo_0004.Main(new string[] { });
            var result = BasicAlgo_0004.CheckWithin100(x);

            // Assert
            if (isValueWithin)
            {
                Assert.AreEqual(true, result);
            }
            else
            {
                Assert.AreEqual(false, result);
            }
        }

        [Test]
        [TestCase("if else")]
        [TestCase("if")]
        [TestCase("else")]
        public void BasicAlgo_0005_StringIfChecker(string request)
        {
            // Arrange
            var expectedResult = request.StartsWith("if") ? request : $"if { request }";

            // Act
            BasicAlgo_0005.Main(new string[] { });
            var actualResult = BasicAlgo_0005.StringIfChecker(request);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("Dondon", 1)]
        [TestCase("Philippines", 3)]
        [TestCase("Canada", 4)]
        public void BasicAlgo_0006_CharacterRemover(string requestString, int startIndex)
        {
            //Arrange
            var numberOfCharTobeDeleted = 1;
            var expectedResult = requestString.Remove(startIndex, numberOfCharTobeDeleted);

            // Act
            BasicAlgo_0006.Main(new string[] { });
            var actualResult = BasicAlgo_0006.CharacterRemover(requestString, startIndex);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("Dondon")]
        [TestCase("a")]
        [TestCase("Canada")]
        public void BasicAlgo_0007_ReverseString(string requestString)
        {
            //Arrange
            char[] convertedToChar = requestString.ToCharArray();
            Array.Reverse(convertedToChar);
            var expectedResult = String.Join("", convertedToChar.Select(x => x.ToString()).ToArray());

            // Act
            BasicAlgo_0007.Main(new string[] { });
            var actualResult = BasicAlgo_0007.ReverseString(requestString);
            var actualResult2 = BasicAlgo_0007.ReverseStringSecondMethod(requestString);

            // Assert
            Assert.AreEqual(convertedToChar, actualResult);
            Assert.AreEqual(expectedResult, String.Join("", actualResult.Select(x => x.ToString()).ToArray()));
            Assert.AreEqual(expectedResult, actualResult2);
        }

        [Test]
        [TestCase("C Sharp")]
        [TestCase("JS")]
        [TestCase("b")]
        public void BasicAlgo_0008_CreateFourCopies(string requestString)
        {
            // Arrange
            var expectedResult = requestString.Length < 2 ? requestString : requestString.Substring(0, 2) + requestString.Substring(0, 2) + requestString.Substring(0, 2) + requestString.Substring(0, 2);

            // Act
            BasicAlgo_0008.Main(new string[] { });
            var actualResult = BasicAlgo_0008.CreateFourCopies(requestString);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("C Sharp")]
        [TestCase("JS")]
        [TestCase("b")]
        public void BasicAlgo_0009_AddLastCharacterToFirstAndLast(string request)
        {
            // Arrange
            var lastChar = request.Substring(request.Length - 1);
            var expectedResult = $"{lastChar}{request}{lastChar}";

            // Act
            BasicAlgo_0009.Main(new string[] { });
            var actualResult = BasicAlgo_0009.AddLastCharToFirstAndLast(request);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(3)]
        [TestCase(14)]
        [TestCase(12)]
        [TestCase(37)]
        public void BasicAlgo_0010_IsMultipleByThreeOrSeven(int request)
        {
            // Arrange
            var expectedResult = request % 3 == 0 || request % 7 == 0;

            // Act
            BasicAlgo_0010.Main(new string[] { });
            var actualResult = BasicAlgo_0010.IsMultipleByThreeOrSeven(request);

            // Assert
            if (expectedResult)
            {
                Assert.AreEqual(true, actualResult);
            }
            else
            {
                Assert.AreEqual(false, actualResult);
            }
        }

        [Test]
        [TestCase("Python")]
        [TestCase("JS")]
        [TestCase("Code")]
        public void BasicAlgo_0011_AddFirstThreeCharacterToFrontAndBack(string request)
        {
            // Arrange
            var expectedResult = request.Length < 3 ? $"{request}{request}{request}" : $"{request.Substring(0, 3)}{request}{request.Substring(0, 3)}"; ;

            // Act
            BasicAlgo_0011.Main(new string[] { });
            var actualResult = BasicAlgo_0011.AddFirstThreeCharacterToFrontAndBack(request);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("C#")]
        [TestCase("CSS")]
        [TestCase("C S")]
        public void BasicAlgo_0012_IsStartsWithCSharp(string request)
        {
            // Arrange
            var expectedResult = request.StartsWith("C#");

            // Act
            BasicAlgo_0012.Main(new string[] { });
            var actualResult = BasicAlgo_0012.IsStartsWithCSharp(request);
            var actualResult2 = BasicAlgo_0012.IsStartsWithCSharp2(request);

            // Assert
            if (expectedResult)
            {
                Assert.AreEqual(true, actualResult);
                Assert.AreEqual(true, actualResult2);
            }
            else
            {
                Assert.AreEqual(false, actualResult);
                Assert.AreEqual(false, actualResult2);
            }
        }
    }
}