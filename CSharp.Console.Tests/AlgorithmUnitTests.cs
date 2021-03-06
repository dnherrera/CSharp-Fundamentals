using System;
using System.Collections.Generic;
using System.Linq;
using CSharp.Fundamentals.Algorithms;
using NUnit.Framework;

namespace CSharp.Console.Tests
{
    [TestFixture]
    public class AlgorithmUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1000000001, 1000000002, 1000000003, 1000000004, 1000000005)]
        public void HackerRank_aVeryBigSum(params long[] x)
        {
            //Arrange
            var expectedResult = 5000000015;
            var count = 5;
            
            /* To mock the console readline.
            var output = new StringWriter();
            System.Console.SetOut(output);

            var input = new StringReader("1");
            System.Console.SetIn(input);
            */

            // Act
            HackerRank_AVeryBigSum.Main(new string[] { });
            var actualResult = HackerRank_AVeryBigSum.SumBigValuesUsingLinq(x);
            var actualResult2 = HackerRank_AVeryBigSum.SumBigValuesUsingForLoop(x, count);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(expectedResult, actualResult2);
        }

        [Test]
        [TestCase(3, 2, 1, 3, 3)]
        public void HackerRank_CountTallestCandles(params int[] x)
        {
            //Arrange
            var expectedResult = 3;

            // Act
            //TODO: Need to investigate
            HackerRank_BirthdayCakeCandles.Main(new string[] { });
            var actualResult = HackerRank_BirthdayCakeCandles.CountTallestCandles(x);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
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
            BasicAlgo_0001_Sum_Two_Integers.Main(new string[] { });
            var result = BasicAlgo_0001_Sum_Two_Integers.SumTwoIntegers(x, y);

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
            BasicAlgo_0002_Absolute_Difference.Main(new string[] { });
            var result = BasicAlgo_0002_Absolute_Difference.ComputeAbsDifference(x);

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
            BasicAlgo_0003_Equals_Condition.Main(new string[] { });
            var result = BasicAlgo_0003_Equals_Condition.IsEqualsToThirty(x, y);

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
            BasicAlgo_0004_Check_Within_100.Main(new string[] { });
            var result = BasicAlgo_0004_Check_Within_100.CheckWithin100(x);

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
            BasicAlgo_0005_Contains_If_Checker.Main(new string[] { });
            var actualResult = BasicAlgo_0005_Contains_If_Checker.StringIfChecker(request);

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
            BasicAlgo_0006_Remove_Character.Main(new string[] { });
            var actualResult = BasicAlgo_0006_Remove_Character.CharacterRemover(requestString, startIndex);

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
            BasicAlgo_0007_Reverse_String.Main(new string[] { });
            var actualResult = BasicAlgo_0007_Reverse_String.ReverseString(requestString);
            var actualResult2 = BasicAlgo_0007_Reverse_String.ReverseStringSecondMethod(requestString);

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
            BasicAlgo_0008_Create_Four_Copies.Main(new string[] { });
            var actualResult = BasicAlgo_0008_Create_Four_Copies.CreateFourCopies(requestString);

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
            BasicAlgo_0009_Add_LastCharTo_FirstAndLast.Main(new string[] { });
            var actualResult = BasicAlgo_0009_Add_LastCharTo_FirstAndLast.AddLastCharToFirstAndLast(request);

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
            BasicAlgo_0010_IsMultipleBy3Or7.Main(new string[] { });
            var actualResult = BasicAlgo_0010_IsMultipleBy3Or7.IsMultipleByThreeOrSeven(request);

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
            BasicAlgo_0011_AddFirstThreeCharacter_To_FrontAndBack.Main(new string[] { });
            var actualResult = BasicAlgo_0011_AddFirstThreeCharacter_To_FrontAndBack.AddFirstThreeCharacterToFrontAndBack(request);

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
            Fundamentals.Algorithms.BasicAlgo_0012_IsStartsWithCSharp.Main(new string[] { });
            var actualResult = Fundamentals.Algorithms.BasicAlgo_0012_IsStartsWithCSharp.IsStartsWithCSharp(request);
            var actualResult2 = Fundamentals.Algorithms.BasicAlgo_0012_IsStartsWithCSharp.IsStartsWithCSharp2(request);

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

        [Test]
        [TestCase(120, -1)]
        [TestCase(-1, 120)]
        [TestCase(2, 121)]
        public void BasicAlgo_0013_CheckTemperatue(int x, int y)
        {
            //Arrange
            var expectedResult = (x < 0 || x > 100) && (y < 0 || y > 100);

            // Act
            BasicAlgo_0013_IsLessThanZeroAndGreaterThanHundred.Main(new string[] { });
            var actualResult = BasicAlgo_0013_IsLessThanZeroAndGreaterThanHundred.IsLessThanZeroAndGreaterThanHundred(x, y);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(100, 199)]
        [TestCase(250, 300)]
        [TestCase(105, 190)]
        public void BasicAlgo_0014_RangeChecker(int x, int y)
        {
            //Arrange
            var expectedResult = (x >= 100 && x <= 200) || (y >= 100 && y <= 200);

            // Act
            BasicAlgo_0014_RangeChecker_100_200_Inclusive.Main(new string[] { });
            var actualResult = BasicAlgo_0014_RangeChecker_100_200_Inclusive.RangeChecker(x, y);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void BasicAlgo_0015_RangeChecker()
        {
            //Arrange
            var request = new List<int[]>
            {
                new int[] { 11, 20, 12 },
                new int[] { 30, 30, 17 },
                new int[] { 25, 35, 50 },
                new int[] { 15, 12, 8 }
            };

            IEnumerable<bool> expectedResult = new List<bool>() { true, true, true, false };

            // Act
            BasicAlgo_0015_RangeChecker_20_50_ThreeGiven.Main(new string[] { });
            var actualResult = BasicAlgo_0015_RangeChecker_20_50_ThreeGiven.RangeChecker(request);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(20, 84)]
        [TestCase(14, 50)]
        [TestCase(11, 45)]
        [TestCase(25, 50)]
        public void BasicAlgo_0016_RangeChecker(int x, int y)
        {
            //Arrange
            var expectedResult = (x >= 20 && x <= 50) && (y >= 20 && y <= 50) ? false : true;

            // Act
            BasicAlgo_0016_RangeChecker_20_50_TwoGiven.Main(new string[] { });
            var actualResult = BasicAlgo_0016_RangeChecker_20_50_TwoGiven.RangeChecker(x, y);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("Python")]
        [TestCase("ytsda")]
        [TestCase("Don")]
        public void BasicAlgo_0017_CharactersRemover(string request)
        {
            //Arrange
            string expectedResult;
            if (request.Substring(1, 2) == "yt")
            {
                expectedResult = request.Remove(1, 2);
            }
            else
            {
                expectedResult = request;
            }

            // Act
            BasicAlgo_0017_Remove_Substring.Main(new string[] { });
            var actualResult = BasicAlgo_0017_Remove_Substring.CharactersRemover(request, 1, 2);
            var actualResult2 = BasicAlgo_0017_Remove_Substring.CharactersRemover2(request);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(expectedResult, actualResult2);
        }

        [Test]
        public void BasicAlgo_0018_MaxChecker()
        {
            //Arrange
            var request = new List<int[]>
            {
                new int[] { 11, 20, 12 },
                new int[] { 30, 30, 17 },
                new int[] { 25, 35, 50 },
                new int[] { 15, 12, 8 }
            };

            IEnumerable<int> expectedResult = new List<int>() { 20, 30, 50, 15 };

            // Act
            Fundamentals.Algorithms.BasicAlgo_0018_MaxChecker.Main(new string[] { });
            var actualResult = Fundamentals.Algorithms.BasicAlgo_0018_MaxChecker.MaxChecker(request);
            var actualResult2 = new List<int>();
            foreach (var item in request)
            {
                actualResult2.Add(Fundamentals.Algorithms.BasicAlgo_0018_MaxChecker.MaxChecker(item[0], item[1], item[2]));
            }

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(expectedResult, actualResult);
            
        }

        [Test]
        public void BasicAlgo_0019_NearestValueChecker()
        {
            //Arrange
            IDictionary<int, int> testData = new Dictionary<int, int>()
            {
                { 95, 75 },
                { 99, 99 },
                { 75, 90 }
            };

            IEnumerable<int> expectedResults = new List<int>() { 95, 0, 90 };

            // Act
            BasicAlgo_0019_NearestValue_Checker.Main(new string[] { });

            List<int> actualResults = new List<int>();
            foreach (var item in testData)
            {
                var actualResult = BasicAlgo_0019_NearestValue_Checker.NearestValueChecker(item.Key, item.Value);
                actualResults.Add(actualResult);
            }

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }

        [Test]
        public void BasicAlgo_0020_RangeChecker()
        {
            //Arrange
            IDictionary<int, int> testData = new Dictionary<int, int>()
            {
                { 78, 95 },
                { 25, 35 },
                { 40, 50 },
                { 55, 60 }
            };

            IEnumerable<bool> expectedResults = new List<bool>() { false, false, true, true };

            // Act
            BasicAlgo_0020_Range_Checker_40_50_50_60.Main(new string[] { });

            List<bool> actualResults = new List<bool>();
            foreach (var item in testData)
            {
                var actualResult = BasicAlgo_0020_Range_Checker_40_50_50_60.RangeChecker(item.Key, item.Value);
                actualResults.Add(actualResult);
            }

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }

        [Test]
        public void BasicAlgo_0021_FindLargerValueInTheRange()
        {
            //Arrange
            IDictionary<int, int> testData = new Dictionary<int, int>()
            {
                { 78, 95 },
                { 20, 30 },
                { 21, 25 },
                { 28, 28 }
            };

            IEnumerable<int> expectedResults = new List<int>() { 0, 30, 25, 28 };

            // Act
            Fundamentals.Algorithms.BasicAlgo_0021_FindLargerValueInTheRange.Main(new string[] { });

            List<int> actualResults = new List<int>();
            var res = testData.Select(x => Fundamentals.Algorithms.BasicAlgo_0021_FindLargerValueInTheRange.FindLargerValueInTheRange(x.Key, x.Value));
            actualResults.AddRange(res);

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }

        [Test]
        public void BasicAlgo_0022_StringCharacterChecker()
        {
            //Arrange
            var testData = new string[]
            {
                "frizz",
                "zane",
                "Zazz",
                "false"
            };

            IEnumerable<bool> expectedResults = new List<bool>() { true, false, true, false };

            // Act
            Fundamentals.Algorithms.BasicAlgo_0022_StringCharacterChecker.Main(new string[] { });

            List<bool> actualResults = new List<bool>();
            var res = testData.Select(x => Fundamentals.Algorithms.BasicAlgo_0022_StringCharacterChecker.StringCharacterChecker(x));
            actualResults.AddRange(res);

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }

        [Test]
        public void BasicAlgo_0023_CheckLastDigit()
        {
            //Arrange
            List<bool> actualResults = new List<bool>();
            List<bool> actualResults2 = new List<bool>();
            IDictionary<int, int> testData = new Dictionary<int, int>()
            {
                { 78, 95 },
                { 20, 30 },
                { 21, 25 },
                { 28, 28 }
            };

            IEnumerable<bool> expectedResults = new List<bool>() { false, true, false, true };

            // Act
            BasicAlgo_0023_CheckLastDigit_Equal.Main(new string[] { });
            var res = testData.Select(x => BasicAlgo_0023_CheckLastDigit_Equal.CheckLastDigit(x.Key, x.Value));
            actualResults.AddRange(res);
            var res2 = testData.Select(x => BasicAlgo_0023_CheckLastDigit_Equal.CheckLastDigitIsEqual(x.Key, x.Value));
            actualResults2.AddRange(res2);

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
            Assert.AreEqual(expectedResults, actualResults2);
        }

        [Test]
        public void BasicAlgo_0024_ConvertStringToUpper()
        {
            //Arrange
            var testData = new string[] { "Dondon", "dd" };
            var expectedResults = new string[] { "DonDON", "DD" };

            // Act
            BasicAlgo_0024_ConvertToUpper.Main(new string[] { });
            var actualResults = testData.Select(x => BasicAlgo_0024_ConvertToUpper.ConvertStringToUpper(x)).ToArray();

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }

        [Test]
        public void BasicAlgo_0025_StringRepeater()
        {
            //Arrange
            var testData = new Dictionary<string, int>()
            {
                { "DD", 1 },
                { "JJ", 2 },
                { "XX", 3 }
            };

            var expectedResults = new List<string>() { "DD", "JJJJ", "XXXXXX" };

            // Act
            Fundamentals.Algorithms.BasicAlgo_0025_StringRepeater.Main(new string[] { });
            var actualResults = testData.Select(x => Fundamentals.Algorithms.BasicAlgo_0025_StringRepeater.StringRepeater(x.Key, x.Value));

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }

        [Test]
        public void BasicAlgo_0026_ThreeLetterRepeater()
        {
            //Arrange
            var testData = new Dictionary<string, int>()
            {
                { "Don", 1 },
                { "JavaScript", 2 },
                { "Socks", 3 }
            };

            var expectedResults = new List<string>() { "Don", "JavJav", "SocSocSoc" };

            // Act
            Fundamentals.Algorithms.BasicAlgo_0026_ThreeLetterRepeater.Main(new string[] { });
            var actualResults = testData.Select(x => Fundamentals.Algorithms.BasicAlgo_0026_ThreeLetterRepeater.ThreeLetterRepeater(x.Key, x.Value));

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }

        [Test]
        public void BasicAlgo_0027_StringCounterr()
        {
            //Arrange
            var testData = new string[] { "Daaadaaa", "Jaa", "Xaaaxxxxxaa" };

            var expectedResults = new List<int>() { 4, 1, 3 };

            // Act
            BasicAlgo_0027_CountRepeatedCharacter.Main(new string[] { });
            var actualResults = testData.Select(x => BasicAlgo_0027_CountRepeatedCharacter.StringCounter(x));

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }

        [Test]
        public void BasicAlgo_0028_IsStartsWithAFollowedByA()
        {
            //Arrange
            var testData = new string[] { "caabb", "babaaba", "aaaaa" };

            var expectedResults = new List<bool>() { true, false, true };

            // Act
            Fundamentals.Algorithms.BasicAlgo_0028_IsStartsWithAFollowedByA.Main(new string[] { });
            var actualResults = testData.Select(x => Fundamentals.Algorithms.BasicAlgo_0028_IsStartsWithAFollowedByA.IsStartsWithAFollowedByA(x));

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }

        [Test]
        public void BasicAlgo_0029_ProduceNewString()
        {
            //Arrange
            var testData = new string[] { "Python", "PHP", "JS" };

            var expectedResults = new List<string>() { "Pto", "PP", "J" };

            // Act
            BasicAlgo_0029_Produce_NewString_ByEveryOtherCharacter.Main(new string[] { });
            var actualResults = testData.Select(x => BasicAlgo_0029_Produce_NewString_ByEveryOtherCharacter.ProduceNewString(x));

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }

        [Test]
        public void BasicAlgo_0030_AABABCABCDPattern()
        {
            //Arrange
            var testData = new string[] { "a", "abc", "abcd" };

            var expectedResults = new List<string>() { "a", "aababc", "aababcabcd" };

            // Act
            BasicAlgo_0030_AABABCABCD.Main(new string[] { });
            var actualResults = testData.Select(x => BasicAlgo_0030_AABABCABCD.ProduceAbcd(x));

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }
    }
}