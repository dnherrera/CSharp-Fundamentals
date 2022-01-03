using System;
using System.Collections.Generic;

namespace CSharp.Fundamentals.Algorithms
{
    /*
     
    Write a C# Sharp program to create a new string from a give string where a specified character have been removed except starting and ending position of the given string. Go to the editor

    Sample Input:
    "xxHxix", "x"
    "abxdddca", "a"
    "xabjbhtrb", "b"
    Expected Output:
    xHix
    abxdddca
    xajhtrb
    
    */
    public class BasicAlgo_0036_CreateAndRemoveExceptionsInString
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> sampleInput = new Dictionary<string, string> 
            {
                { "xxHxix", "x"},
                { "abxdddca", "a" },
                { "xabjbhtrb", "b" }
            };

            foreach (var item in sampleInput)
            {
                Console.WriteLine(CreateNewString(item.Key, item.Value));
            }
        }

        public static string CreateNewString(string input, string charToRemove)
        {
            for (int i = input.Length - 2; i > 0; i--)
            {
                if (input[i] == charToRemove[0])
                {
                    input = input.Remove(i, 1);
                }
            }
            return input;
        }
    }
}
