using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to check the largest number among three given integers.
    /// </summary>
    public class BasicAlgo_0018_MaxChecker
    {
        public static void Main(string[] args)
        {
           var testData = new List<int[]>
           {
                new int[] { 1, 2, 3 },
                new int[] { 1, 3, 2 },
                new int[] { 1, 1, 1 },
                new int[] { 1, 2, 2 }
           };

            foreach (var item in MaxChecker(testData))
            {
                Console.WriteLine(item);
            }

            foreach (var item in testData)
            {
                Console.WriteLine(MaxChecker(item[0], item[1], item[2]));
            }
        }

        public static IEnumerable<int> MaxChecker(List<int[]> request)
        {
            var result = new List<int>();
            foreach (var item in request)
            {
                var maxItem = item.Max();
                result.Add(maxItem);
            }

            return result;
        }

        public static int MaxChecker(int x, int y, int z)
        {
            var max = Math.Max(x, Math.Max(y, z));
            return max;
        }
    }
}
