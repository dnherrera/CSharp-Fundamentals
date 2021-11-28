using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Fundamentals.Algorithms
{
    /*
    Write a C# Sharp program to create a new string which is n (non-negative integer) copies of the
    first 3 characters of a given string. If the length of the given string is less than 3 then return n copies of the string. 
    Sample Input:
    "Python", 2
    "Python", 3
    "JS", 3
    Expected Output:
    PytPyt
    PytPytPyt
    JSJSJS
     */
    public class BasicAlgo_0026_ThreeLetterRepeater
    {
        public static void Main(string[] args)
        {
            var testData = new Dictionary<string, int>()
            {
                { "Python", 2 },
                { "Dondon", 3 },
                { "JS", 3 }
            };

            foreach (var item in testData)
            {
                Console.WriteLine(ThreeLetterRepeater(item.Key, item.Value));
            }
        }

        public static string ThreeLetterRepeater(string x, int y)
        {
            string result = string.Empty;
            for (int i = 0; i < y; i++)
            {
                if (x.Length <= 3)
                {
                    result = result + x;
                }
                else
                {
                    result = result + x.Substring(0, 3);
                }
            }
            return result;
        }
    }

}
