using System;
using System.Collections.Generic;

namespace CSharp.Fundamentals.Algorithms
{
    /*
     Write a C# Sharp program to check if two given non-negative integers have the same last digit. Go to the editor
     Sample Input:
     123, 456
     12, 512
     7, 87
     12, 45
     Expected Output:
     False
     True
     True
     False
     */
    public class BasicAlgo_0023_CheckLastDigit_Equal
    {
        public static void Main(string[] args)
        {
            var testData = new Dictionary<int, int>()
            {
                { 123, 456 },
                { 12, 512 },
                { 7, 87 },
                { 150, 452 }
            };

            foreach (var item in testData)
            {
                Console.WriteLine(CheckLastDigit(item.Key, item.Value));
                Console.WriteLine(CheckLastDigitIsEqual(item.Key, item.Value));
            }
        }

        public static bool CheckLastDigit(int x, int y)
        {
            var test = x.ToString();
            var xx = test.Substring(test.Length-1, 1);

            var test2 = y.ToString();
            var yy = test2.Substring(test2.Length-1, 1);

            return xx == yy;
        }

        public static bool CheckLastDigitIsEqual(int x, int y)
        {
            return Math.Abs(x % 10) == Math.Abs(y % 10);
        }
    }
}
