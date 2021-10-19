using System;
using System.Linq;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
    /// </summary>
    public class BasicAlgo_0007
    {
        public static void Main(string[] args)
        {
            string[] testData = { "abc", "a", "xyz" };

            var convertedData = testData.Select(x => ReverseString(x));
            
            foreach (var item in convertedData)
            {
                Console.WriteLine(item);
            }
        }

        public static char[] ReverseString(string request)
        {
            var stringToChar = request.ToCharArray();
            Array.Reverse(stringToChar);

            return stringToChar;
        }

        public static string ReverseStringSecondMethod(string str)
        {
            string revstr = ""; // var to store the reverse string
            
            var length = str.Length - 1; // Get the index of last character         

            while (length >= 0)                
            {
                revstr = revstr + str[length];  // reverse a string based on the length
                length--;
            }

            return revstr;
        }
    }
}
