using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.FilteringOperators
{
    /// <summary>
    /// Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query
    /// The numbers within the range of 1 to 11 are :
    /// Expected : 1 3 6 9 10
    /// </summary>
    public class PositiveValue
    {
        public static void Main(string[] args)
        {
            int[] testData = { 0, 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var actualResult = GetPositiveValue(testData);

            Console.WriteLine("The numbers within the range of 1 to 11 are :");
            foreach (var item in actualResult)
            {
                Console.Write("{0} ", item);
            }
        }

        public static IEnumerable<int> GetPositiveValue(int[] request)
        {
            var res = request.Where(x => x > 0 && x >= 1 && x <= 11);
            return res;
        }
    }
}
