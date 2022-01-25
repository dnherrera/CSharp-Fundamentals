using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.Basics
{
    class SortFunction
    {
        static void Main(string[] args)
        {
            var testData = new List<object[]>
            {
                new object[]{"aa", "ccc", "bb"},
                new object[]{2, "ccc", "bb"},
            };

            foreach (var item in testData)
            {
                Console.WriteLine(string.Join(",", SortFunctions(item)));
            }
        }

        static object[] SortFunctions(object[] args)
        {
            var arrString = args.Select(x => x.ToString()).ToArray();
            var sorted = arrString.OrderBy(x => x.Length).ToArray();

            return sorted;
        }
    }
}
