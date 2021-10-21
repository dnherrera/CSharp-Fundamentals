using System;
using System.Collections.Generic;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.
    /// </summary>
    public class BasicAlgo_0014
    {
        public static void Main(string[] args)
        {
            IDictionary<int, int> testData = new Dictionary<int, int>
            {
                { 100, 199 }, { 250, 300 }, { 105, 190 }
            };

            foreach (var item in testData)
            {
                Console.WriteLine(RangeChecker(item.Key, item.Value));

            }
        }

        public static bool RangeChecker(int x, int y)
        {
            return ( x >= 100 && x <= 200 ) || (y >= 100 && y <= 200);
        }
    }
}
