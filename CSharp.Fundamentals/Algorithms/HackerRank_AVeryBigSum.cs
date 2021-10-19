/*
    Problem: https://www.hackerrank.com/challenges/a-very-big-sum/problem
    Thoughts :
    1. Store all the input numbers in an array of size n.
    2. Let the sum of all the input numbers be s. Initialize s to 0. Ensure that storage width of the data type of s is 64 bit.
    3. Start iterating the elments of an array in a loop
    3.1 Let the current element be c.
    3.2 Increment s by c.
    3.3 Move to next element in the array and repeat steps 3.1 through 3.2.
    4. Print s.
    Time Complexity:  O(n) //A loop is required which iterates through n elements in the array to create their sum.
    Space Complexity: O(n) //Space complexity doesn't  matches optimal O(1) solution as in C# you have to read the entire console line at a time (size n) 
                            because it does not have a way to iteratively read space delimited input. If there had been a Scanner like class which exists in Java 
                            then it would have been possible to accomplish the same algorithm in O(1) space complexity.
*/

using System;
using System.Linq;

namespace CSharp.Fundamentals.Algorithms
{
    public class HackerRank_AVeryBigSum
    {
        public static void Main(string[] args)
        {
            /* To make the input data as dynamic
            var count = int.Parse(Console.ReadLine());
            var ar_temp = Console.ReadLine().Split(' ');
            var ar = Array.ConvertAll(ar_temp, long.Parse);
            */

            var testData = new string[] { "1000000001", "1000000002", "1000000003", "1000000004", "1000000005" };
            var ar = testData.Select(x => long.Parse(x)).ToArray();
            Console.WriteLine(SumBigValuesUsingLinq(ar));
        }

        public static long SumBigValuesUsingLinq(long[] number)
        {
            var finalSum = 0L;
            finalSum = number.Sum(x => x);
            return finalSum;
        }

        public static long SumBigValuesUsingForLoop(long[] number, int count)
        {
            var finalSum = 0L;

            for (int i = 0; i < count; i++)
                finalSum += number[i];

            return finalSum;
        }

    }
}
