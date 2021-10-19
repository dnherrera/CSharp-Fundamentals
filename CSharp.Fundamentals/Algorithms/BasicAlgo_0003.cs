using System;
using System.Collections.Generic;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30
    /// </summary>
    public class BasicAlgo_0003
    {
        public static void Main(string[] args)
        {
            IDictionary<int, int> testData = new Dictionary<int, int>() { { 30, 0 }, { 25, 5 }, { 20, 30 }, { 35, 25} };

            foreach (var item in testData)
            {
                Console.WriteLine(IsEqualsToThirty(item.Key, item.Value));
            }
        }

        public static bool IsEqualsToThirty(int x, int y)
        {
            return x == 30 || y == 30 || (x + y == 30);
        }
    }
}
