using System;
using System.Collections.Generic;

namespace CSharp.Fundamentals.Basics
{
    /// <summary>
    /// Use yield in temporary list
    /// </summary>
    /// <see cref="https://www.freelancer.com/community/articles/top-16-c-programming-tips-tricks"/>
    public class Yield
    {
        static void Main(string[] args)
        {
            var tempData = new List<int>()
            {
                1,2,3,4, 101, 102
            };

            var enumerableReturn = GetValuesGreaterThan100(tempData);

            foreach (var item in enumerableReturn)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");

            var listReturn = GetValuesGreaterThan100List(tempData);
            listReturn.ForEach(x => { Console.WriteLine(x); });
        }

        public static IEnumerable<int> GetValuesGreaterThan100(List<int> masterCollection)
        {
            foreach (var value in masterCollection)
                if (value > 100)
                    yield return value;
        }

        public static List<int> GetValuesGreaterThan100List(List<int> masterCollection)
        {
            List<int> tempResult = new List<int>();

            foreach (var value in masterCollection)

                if (value > 100)
                    tempResult.Add(value);

            return tempResult;
        }
    }
}
