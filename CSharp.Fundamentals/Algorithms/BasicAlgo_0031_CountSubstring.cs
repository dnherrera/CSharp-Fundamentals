using System;
using System.Linq;

namespace CSharp.Fundamentals.Algorithms
{
    /*
    Write a C# Sharp program to count a substring of length 2 appears in a given string and also 
    as the last 2 characters of the string. Do not count the end substring. Go to the editor
    Sample Input:
    "abcdsab"
    "abcdabab"
    "abcabdabab"
    "abcabd"
    Expected Output:
    1
    2
    3
    0
    */
    public class BasicAlgo_0031_CountSubstring
    {
        public static void Main(string[] args)
        {
            var testData = new string[]
            {
                "abcdsab",
                "abcdabab",
                "abcabdabab",
                "abcabd"
            };

            foreach (var item in testData)
            {
                Console.WriteLine(CountSubstring(item));
            }
        }

        public static int CountSubstring(string request)
        {
            var counter = 0;
            var lastChars = request.Substring(request.Count()-2, 2);
            for (int i = 0; i < request.Count()-2; i++)
            {
                var twoChar = $"{request[i]}{request[i+1]}";
                if (twoChar == lastChars)
                {
                    counter++;
                }
            }
            return counter;
        }

        /// <summary>
        /// Tests the specified string.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public static int test(string str)
        {
            var last_two_char = str.Substring(str.Length - 2);
            var ctr = 0;

            for (var i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 2).Equals(last_two_char)) ctr++;
            }
            return ctr;
        }
    }
}
