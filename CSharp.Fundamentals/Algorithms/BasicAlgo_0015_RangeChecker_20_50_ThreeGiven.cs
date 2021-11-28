using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. 
    /// Return true if 1 or more of them are in the said range otherwise false
    /// </summary>
    public class BasicAlgo_0015_RangeChecker_20_50_ThreeGiven
    {
        public static void Main(string[] args)
        {
            var testData = new List<int[]>
            {
                new int[] { 11, 20, 12 },
                new int[] { 30, 30, 17 },
                new int[] { 25, 35, 50 },
                new int[] { 15, 12, 8 }
            };
            
            foreach (var item in RangeChecker(testData))
            {
                Console.WriteLine(item);
            }
           
        }
        public static IEnumerable<bool> RangeChecker(List<int[]> args)
        {
            var test = args.Select(x => x.Any(y => y >= 20 && y <= 50));
            return test;
        }
    }
}
