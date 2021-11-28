using System;
using System.Collections.Generic;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. 
    /// Return true if 1 or other is in the said range otherwise false.
    /// </summary>
    public class BasicAlgo_0016_RangeChecker_20_50_TwoGiven
    {
        public static void Main(string[] args)
        {
            IDictionary<int, int> testData = new Dictionary<int, int>()
            {
                { 20, 84 },
                { 14, 50 },
                { 11, 45 },
                { 25, 50 },
            };

            foreach (var item in testData)
            {
                Console.WriteLine(RangeChecker(item.Key, item.Value));
            }
        }

        public static bool RangeChecker(int x, int y)
        {
            if ((x >= 20 && x <= 50) && (y >= 20 && y <= 50))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
