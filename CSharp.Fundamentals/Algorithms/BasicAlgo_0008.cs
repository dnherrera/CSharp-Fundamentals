using System;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. 
    /// If the given string length is less than 2 return the original string.
    /// </summary>
    public class BasicAlgo_0008
    {
        public static void Main(string[] args)
        {
            string[] testData = { "C Sharp", "JS", "b" };
            foreach (var item in testData)
            {
                Console.WriteLine(CreateNewString(item));
            }
        }

        public static string CreateNewString(string request)
        {
            return request.Length < 2 ? request : request.Substring(0, 2) + request.Substring(0, 2) + request.Substring(0, 2) + request.Substring(0, 2);
        }
    }
}
