using System;

namespace CSharp.Fundamentals.Algorithms
{
    /*
     Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa". Go to the editor
     Sample Input:
     "bbaaccaag"
     "jjkiaaasew"
     "JSaaakoiaaa"
     Expected Output:
     3
     2
     4
     */
    public class BasicAlgo_0027
    {
        public static void Main(string[] args)
        {
            var testData = new string[]
            {
                "bbaaaccgaa",
                "jjkiaaasew",
                "JSaaakoiaaa"
            };

            foreach (var item in testData)
            {
                Console.WriteLine(StringCounter(item));
            }
        }

        public static int StringCounter(string request)
        {
            int ctr_aa = 0;
            for (int i = 0; i < request.Length - 1; i++)
            {
                if (request.Substring(i, 2) == "aa")
                {
                    ctr_aa++;
                }
            }
            return ctr_aa;
        }
    }
}
