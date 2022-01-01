using System;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere.
    /// </summary>
    public class BasicAlgo_0034_SequenceOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 1, 2, 3, 1 }));
            Console.WriteLine(test(new[] { 1, 1, 2, 4, 1 }));
            Console.WriteLine(test(new[] { 1, 1, 2, 1, 2, 3 }));
            Console.ReadLine();
        }

        public static bool test(int[] nums)
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
