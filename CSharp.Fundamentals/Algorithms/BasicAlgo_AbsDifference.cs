using System;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.
    /// </summary>
    public class BasicAlgo_AbsDifference
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ComputeAbsDifference(53));
            Console.WriteLine(ComputeAbsDifference(30));
            Console.WriteLine(ComputeAbsDifference(51));
        }

        public static int ComputeAbsDifference(int x)
        {
            return x > 51 ? Math.Abs((x - 51) * 3) : Math.Abs(x - 51);
        }

    }
}
