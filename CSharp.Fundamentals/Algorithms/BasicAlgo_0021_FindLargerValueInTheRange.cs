using System;
using System.Collections.Generic;

namespace CSharp.Fundamentals.Algorithms
{
    /*
     Write a C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive, 
    or return 0 if neither is in that range. Go to the editor
     Sample Input:
     78, 95
     20, 30
     21, 25
     28, 28
     Expected Output:
     0
     30
     25
     28
     */
    public class BasicAlgo_0021_FindLargerValueInTheRange
    {
        public static void Main(string[] args)
        {
            var testData = new Dictionary<int, int>()
            {
                { 78, 95 },
                { 20, 30 },
                { 21, 25 },
                { 28, 28 }
            };

            foreach (var item in testData)
            {
                Console.WriteLine(FindLargerValueInTheRange(item.Key, item.Value));
            }
        }

        public static int FindLargerValueInTheRange(int x, int y)
        {
            var num = x > y ? x : y;
            var res = num >= 20 && num <= 30 ? num : 0;
            return res;
        }
    }
}
