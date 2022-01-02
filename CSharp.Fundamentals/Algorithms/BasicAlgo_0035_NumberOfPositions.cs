using System;

namespace CSharp.Fundamentals.Algorithms
{
    /*
    Write a C# Sharp program to compare two given strings and return the number of the positions where they contain the same length 2 substring. Go to the editor

    Sample Input:
    "abcdefgh", "abijsklm"
    "abcde", "osuefrcd"
    "pqrstuvwx", "pqkdiewx"
    Expected Output:
    1
    1
    2
     */
    public class BasicAlgo_0035_NumberOfPositions
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("abcdefgh", "abijsklm"));
            Console.WriteLine(test("abcde", "osuefrcd"));
            Console.WriteLine(test("pqrstuvwx", "pqkdiewx"));
            Console.ReadLine();
        }

        public static int test(string str1, string str2)
        {
            var ctr = 0;
            for (var i = 0; i < str1.Length - 1; i++)
            {
                var firstString = str1.Substring(i, 2);
                for (var j = 0; j < str2.Length - 1; j++)
                {
                    var secondString = str2.Substring(j, 2);
                    if (firstString.Equals(secondString))
                        ctr++;
                }
            }
            return ctr;
        }
    }
}
