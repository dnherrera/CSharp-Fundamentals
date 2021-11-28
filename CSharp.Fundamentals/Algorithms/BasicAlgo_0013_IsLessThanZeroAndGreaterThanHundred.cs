using System;
using System.Collections.Generic;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100.
    /// </summary>
    public class BasicAlgo_0013_IsLessThanZeroAndGreaterThanHundred
    {
        public static void Main(string[] args)
        {
            IDictionary<int, int> testData = new Dictionary<int, int>
            {
                { 120, -1 }, { -1, 120 }, { 2, 121 }
            };

            foreach (var item in testData)
            {
                Console.WriteLine(IsLessThanZeroAndGreaterThanHundred(item.Key, item.Value));

            }
        }
        public static bool IsLessThanZeroAndGreaterThanHundred(int x, int y)
        {
            return (x < 0 || x > 100) && (y < 0 || y > 100);
        }
    }
}
