using System;
using System.Collections.Generic;

namespace CSharp.Fundamentals.Algorithms
{
    /*Write a C# Sharp program to check if a triple is presents in an array of integers or not. If a value appears three times in a row in an array it is called a triple. Go to the editor

    Sample Input:
    { 1, 1, 2, 2, 1 }
    { 1, 1, 2, 1, 2, 3 }
    { 1, 1, 1, 2, 2, 2, 1 }
    Expected Output:
    False
    False
    True*/
    class BasicAlgo_0039_CheckTheTriples
    {
        static void Main(string[] args)
        {
            var testData = new List<int[]>
            {
                new int[] { 1, 1, 2, 2, 1 },
                new int[] { 1, 1, 2, 1, 2, 3 },
                new int[] { 1, 1, 1, 2, 2, 2, 1 }
            };

            foreach (var item in testData)
            {
                Console.WriteLine(CheckTheTriples(item));
            }
        }

        static bool CheckTheTriples(int[] nums)
        {
            int arra_len = nums.Length - 1, n = 0;
            for (int i = 0; i < arra_len; i++)
            {
                n = nums[i]; // get the first element [0]
                if (n == nums[i + 1] && n == nums[i + 2]) return true;
            }
            return false;
        }
    }
}
