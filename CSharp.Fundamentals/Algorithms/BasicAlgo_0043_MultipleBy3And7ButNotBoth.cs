using System;

namespace CSharp.Fundamentals.Algorithms
{
    public class BasicAlgo_0043_MultipleBy3And7ButNotBoth
    {
        static void Main(string[] args)
        {
            int[] testData = { 3, 7, 21 };
            foreach (var item in testData)
            {
                Console.WriteLine(CheckMultipleButNotBoth(item));
            }
        }

        static bool CheckMultipleButNotBoth(int args)
        {
            var test = args % 3 == 0 && args % 7 == 0;
            return !test;
        }

        public static bool test(int n)
        {
            return n % 3 == 0 ^ n % 7 == 0;
        }
    }
}
