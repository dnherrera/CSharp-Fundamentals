using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Fundamentals.Algorithms
{
    /*
     Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element.

    Sample Input:
    {1,2,9,3}, 3
    {1,2,3,4,5,6}, 2
    {1,2,2,3}, 9
    Expected Output:
    True
    True
    False
     */
    public class BasicAlgo_0033_ArrayRangeIntegers
    {
        static void Main(string[] args)
        {
            var testData = new List<int[]>
            {
                new int[] { 1, 2, 3, 9 },
                new int[] { 1, 2, 3, 4, 5, 6 },
                new int[] { 1, 2, 2, 3 }
            };

            var number = new int[] { 3, 2, 9 };

            for (int i = 0; i < testData.Count; i++)
            {
                Console.WriteLine(CheckIntegerWithinFourElements(testData[i], number[i]));
            }
        }

        static bool CheckIntegerWithinFourElements(int[] args, int request)
        {
            var res = args.Take(4).Any(x => x == request);
            return res;
        }

        public static bool test(int[] numbers, int n)
        {
            return numbers.Length < 4 ? numbers.Contains(n) : numbers.Take(4).Contains(n);
        }
    }
}
