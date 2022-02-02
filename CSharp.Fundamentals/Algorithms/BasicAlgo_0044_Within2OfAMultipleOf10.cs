using System;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to check whether a given number is within 2 of a multiple of 10.
    /// </summary>
    public class BasicAlgo_0044_Within2OfAMultipleOf10
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(3));
            Console.WriteLine(test(7));
            Console.WriteLine(test(8));
            Console.WriteLine(test(21));
            Console.ReadLine();
        }
        public static bool test(int n)
        {
            return n % 10 <= 2 || n % 10 >= 8;
        }
    }
}
