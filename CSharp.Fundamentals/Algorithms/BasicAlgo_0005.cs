using System;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. 
    /// If the string already begins with 'if', return the string unchanged
    /// </summary>
    public class BasicAlgo_0005
    {
        public static void Main(string[] args)
        {
            string[] testData = { "if else", "else" };

            for (int i = 0; i < testData.Length; i++)
            {
                Console.WriteLine(StringIfChecker(testData[i]));
            }
        }

        public static string StringIfChecker(string oldString)
        {
            if (oldString.StartsWith("if"))
                return oldString;

            return $"if { oldString }";
        }
    }
}
