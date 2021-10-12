using System;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to compute the sum of the two given integer values. 
    /// If the two values are the same, then return triple their sum.
    /// </summary>
    public class BasicAlgo_Addition
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(SumFunc(1, 2));
            Console.WriteLine(SumFunc(1, 3));
            Console.WriteLine(SumFunc(2, 2));
            Console.ReadLine();
        }

        public static int SumFunc(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}
