using System;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
    /// </summary>
    public class BasicAlgo_0004_Check_Within_100
    {
        public static void Main(string[] args)
        {
            int[] testData = new int[] { 103, 90, 89 };
            foreach (var item in testData)
            {
                Console.WriteLine(CheckWithin100(item));
            }
        }

        public static bool CheckWithin100(int number)
        {
            if (Math.Abs(number - 100) <= 10 || Math.Abs(number - 200) <= 10)
            {
                return true;
            }
            return false;
        }
    }
}
