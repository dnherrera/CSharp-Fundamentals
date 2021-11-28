using System;
using System.Collections.Generic;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to compute the sum of the two given integer values. 
    /// If the two values are the same, then return triple their sum.
    /// </summary>
    public class BasicAlgo_0001_Sum_Two_Integers
    {
        public static void Main(string[] args)
        {
            IDictionary<int, int> testData = new Dictionary<int, int> 
            {
                { 1, 2 },
                { 2, 3 },
                { 3, 3 }
            };

            foreach (var item in testData)
            {
                Console.WriteLine(SumTwoIntegers(item.Key, item.Value));
            }
            
        }

        public static int SumTwoIntegers(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}
