using System;
using System.Collections.Generic;

namespace CSharp.Fundamentals.Algorithms
{
    /*
     Write a C# Sharp program that accept two integers and return true if either one is 5 or their sum or difference is 5. Go to the editor
     Sample Input:
     5, 4
     4, 3
     1, 4
     Expected Output:
     True
     False
     True
     */
    public class BasicAlgo_0041_SumAndBooleanCondition
    {
        static void Main(string[] args)
        {
            var testData = new Dictionary<int, int>()
            {
                { 5, 4 },
                { 4, 3 },
                { 1, 4 }
            };

            foreach (var item in testData)
            {
                Console.WriteLine(ComputeTheSum(item.Key, item.Value));
            }
        }

        static bool ComputeTheSum(int num1, int num2)
        {
            return num1 + num2 == 5 || Math.Abs(num1 - num2) == 5 || num1 == 5 || num2 == 5;
        }
    }
}
