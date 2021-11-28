using System;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to check whether a given positive number is a multiple of 3 or a multiple of 7.
    /// </summary>
    public class BasicAlgo_0010_IsMultipleBy3Or7
    {
        public static void Main(string[] args)
        {
            int[] testData = { 3, 14, 12, 37 };
            foreach (var item in testData)
            {
                Console.WriteLine(IsMultipleByThreeOrSeven(item));
            }
        }

        public static bool IsMultipleByThreeOrSeven(int request)
        {
            return request % 3 == 0 || request % 7 == 0;
        }
    }
}
