using System;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to check if a given string starts with 'C#' or not. 
    /// </summary>
    public class BasicAlgo_0012
    {
        public static void Main(string[] args)
        {
            string[] testData = { "C# Sharp", "C#", "C++" };
            foreach (var item in testData)
            {
                Console.WriteLine(IsStartsWithCSharp(item));
            }
        }

        public static bool IsStartsWithCSharp(string request)
        {
            return request.StartsWith("C#");
        }

        public static bool IsStartsWithCSharp2(string str)
        {
            return (str.Length < 3 && str.Equals("C#")) || (str.StartsWith("C#") && str[2] == ' ');
        }
    }
}
