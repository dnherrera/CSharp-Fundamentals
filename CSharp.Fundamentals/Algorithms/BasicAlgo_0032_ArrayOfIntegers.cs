using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.Algorithms
{
    /*Write a C# Sharp program to check a specified number is present in a given array of integers. Go to the editor
    Sample Input:
    {1,2,9,3}, 3
    { 1,2,2,3}, 2
    { 1,2,2,3}, 9
    Expected Output:
    True
    True
    False*/
    public class BasicAlgo_0032_ArrayOfIntegers
    {
        static void Main(string[] args)
        {
            var testData = new List<int[]>
            {
                new int[] { 1, 2, 3, 9 },
                new int[] { 1, 2, 2, 3 },
                new int[] { 1, 2, 2, 3 }
            };

            var number = new int[] { 3, 2, 9 };

            for (int i = 0; i < testData.Count; i++)
            {
                Console.WriteLine(IntegerChecker(testData[i], number[i]));
            }
        }

        static bool IntegerChecker(int[] arrayRequest, int request)
        {
            var res = arrayRequest.Any(x => x == request);
            return res;
        }

        public static bool test(int[] numbers, int n)
        {
            if (numbers.Contains(n))
                return true;
            return false;
        }
    }
}
