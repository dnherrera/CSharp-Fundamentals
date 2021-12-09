using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Fundamentals.Algorithms
{
    /*
     Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere. Go to the editor

    Sample Input:
    {1,1,2,3,1}
    {1,1,2,4,1}
    {1,1,2,1,2,3}
    Expected Output:
    True
    False
    True
     */
    public class BasicAlgo_0034_CheckTheSequence
    {
        static void Main(string[] args)
        {
            var testData = new List<int[]>
            {
                new int[] {1, 1, 2, 3, 1},
                new int[] {1, 1, 2, 4, 1},
                new int[] {1, 1, 2, 1, 2, 3, 4}
            };

            foreach (var item in testData)
            {
                Console.WriteLine(CheckTheSequence(item));
            }
        }

        public static bool CheckTheSequence(int[] nums)
        {
            for (var i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] == 1 && nums[i + 1] == 2 && nums[i + 2] == 3)
                    return true;
            }
            return false;
        }
    }
}
