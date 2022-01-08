using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Fundamentals.Algorithms
{
    /*Write a C# Sharp program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30. Go to the editor
    Sample Input:
    12, 17
    2, 17
    22, 17
    20, 0
    Expected Output:
    29
    30
    39
    30*/
    public class BasicAlgo_0040_SumAndRange
    {
        static void Main(string[] args)
        {
            var testData = new List<int[]>
            {
                new int[] { 12, 17 },
                new int[] { 2, 17 },
                new int[] { 22, 17 },
                new int[] { 20, 0 }
            };

            foreach (var item in testData)
            {
                Console.WriteLine(ComputeTheSum(item));
            }
        }

        static int ComputeTheSum(int[] request)
        {
            var sumTotal = request.Sum();
            if (sumTotal >= 10 && sumTotal <= 20)
            {
                return 30;
            }

            return sumTotal;
        }
    }
}
