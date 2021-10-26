using System;
using System.Collections.Generic;

namespace CSharp.Fundamentals.Algorithms
{
    /*
    Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, 
    or they are both in the range 50..60 inclusive. Go to the editor
    Sample Input:
    78, 95
    25, 35
    40, 50
    55, 60
    Expected Output:
    False
    False
    True
    True
    */
    public class BasicAlgo_0020
    {
        public static void Main(string[] args)
        {
            var testData = new Dictionary<int, int>()
            {
                { 78, 95 },
                { 25, 35 },
                { 40, 50 },
                { 55, 60 }
            };

            foreach (var item in testData)
            {
                Console.WriteLine(RangeChecker(item.Key, item.Value));
            }
        }

        public static bool RangeChecker(int x, int y)
        {
            return (x >= 40 && x <= 50 && y >= 40 && y <= 50) || (x >= 50 && x <= 60 && y >= 50 && y <= 60);
        }
    }
}
