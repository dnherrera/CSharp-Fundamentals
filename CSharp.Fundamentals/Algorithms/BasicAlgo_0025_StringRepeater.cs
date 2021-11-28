using System;
using System.Collections.Generic;

namespace CSharp.Fundamentals.Algorithms
{
    /*
    Write a C# Sharp program to create a new string which is 
    n (non-negative integer) copies of a given string. Go to the editor

    Sample Input:
    "JS", 2
    "JS", 3
    "JS", 1
    Expected Output:
    JSJS
    JSJSJS
    JS
     */
    public class BasicAlgo_0025_StringRepeater
    {
        public static void Main(string[] args)
        {
            var testData = new Dictionary<string, int>()
            {
                { "JS", 2 },
                { "PY", 1 },
                { "PS", 3 }
            };

            foreach (var item in testData)
            {
                Console.WriteLine(StringRepeater(item.Key, item.Value));
            }
        }

        public static string StringRepeater(string x, int y)
        {
            string result = String.Empty;
            for (int i = 0; i < y; i++)
            {
                result = result + x;
            }
            return result;
        }
    }
}
