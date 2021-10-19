using System;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to create a new string with the 
    /// last char added at the front and back of a given string of length 1 or more.
    /// </summary>
    public class BasicAlgo_0009
    {
        public static void Main(string[] args)
        {
            string[] testData = { "Red", "Green", "1" };
            foreach (var item in testData)
            {
                Console.WriteLine(AddLastCharToFirstAndLast(item));
            }
        }

        public static string AddLastCharToFirstAndLast(string request)
        {
            var lastChar = request.Substring(request.Length - 1);
            return $"{lastChar}{request}{lastChar}";
        }
    }
}
