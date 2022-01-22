using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.Basics
{
    class SortFunction
    {
        static void Main(string[] args)
        {
            var testData = new List<dynamic[]>
            {
                new dynamic[]{"aa", "ccc", "bb"}
                //new dynamic[]{1, "ccc", "bb"}, need to implement this
            };

            foreach (var item in testData)
            {
                Console.WriteLine(string.Join(",", SortFunctions(item)));
            }
        }

        static dynamic[] SortFunctions(dynamic[] args)
        {
            var test = args.OrderBy(x => x.Length).ToArray();
            return test;
        }
    }
}
