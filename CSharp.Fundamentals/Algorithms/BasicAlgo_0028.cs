using System;

namespace CSharp.Fundamentals.Algorithms
{
    public class BasicAlgo_0028
    {
        public static void Main(string[] args)
        {
            var testData = new string[]
            {
                "caabb",
                "babaaba",
                "aaaaa"
            };

            foreach (var item in testData)
            {
                Console.WriteLine(IsStartsWithAFollowedByA(item));
            }
        }

        public static int IsStartsWithAFollowedByA(string s)
        {
            int ctr_aa = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s.Substring(i, 2) == "aa")
                {
                    ctr_aa++;
                }
            }
            return ctr_aa;
        }
    }
}
