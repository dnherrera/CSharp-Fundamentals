using System;
using System.Collections.Generic;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to check which number is nearest to the value 100 among two given integers. 
    /// Return 0 if the two numbers are equal.
    /// Sample Input:
    /// 78, 95
    /// 95, 95
    /// 99, 70
    /// Expected Output:
    /// 95
    /// 0
    /// 99
    /// </summary>
    public class BasicAlgo_0019
    {
        public static void Main(string[] args)
        {
            IDictionary<int, int> testData = new Dictionary<int, int>
            {
                {75, 95},
                {95, 95},
                {99, 70},
                {101, 99}
            };

            foreach (var item in testData)
            {
                Console.WriteLine(NearestValueChecker(item.Key, item.Value));
            }
        }

        public static int NearestValueChecker(int x, int y)
        {
            const int def = 100;
            var result = Math.Abs(x - def) < Math.Abs(y - def) ? x : y;
            return x == y ? 0 : result;
        }
    }
}
