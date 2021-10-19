using System;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.
    /// </summary>
    public class BasicAlgo_0002
    {
        public static void Main(string[] args)
        {
            int[] testData = { 53, 30, 51 };

            foreach (var item in testData)
            {
                Console.WriteLine(ComputeAbsDifference(item));
            }
        }

        public static int ComputeAbsDifference(int x)
        {
            return x > 51 ? Math.Abs((x - 51) * 3) : Math.Abs(x - 51);
        }
    }
}
