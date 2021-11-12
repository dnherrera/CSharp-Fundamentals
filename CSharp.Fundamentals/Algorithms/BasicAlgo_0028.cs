using System;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a". Go to the editor
    /// Sample Input:
    /// "caabb"
    /// "babaaba"
    /// "aaaaa"
    /// Expected Output:
    /// True
    /// False
    /// True
    /// </summary>
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

        public static bool IsStartsWithAFollowedByA(string str)
        {
            var counter = 0;
            for (var i = 0; i < str.Length - 1; i++)
            {
                if (str[i].Equals('a')) counter++;
                if (str.Substring(i, 2).Equals("aa") && counter < 2)
                    return true;
            }
            return false;
        }
    }
}
