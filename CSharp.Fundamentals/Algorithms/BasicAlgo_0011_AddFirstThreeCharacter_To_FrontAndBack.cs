using System;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to create a new string taking the first 3 characters of a given string and return the string with the 3 characters added at both the front and back. 
    /// If the given string length is less than 3, use whatever characters are there.
    /// </summary>
    public class BasicAlgo_0011_AddFirstThreeCharacter_To_FrontAndBack
    {
        public static void Main(string[] args)
        {
            string[] testData = { "Python", "JS", "Code" };
            foreach (var item in testData)
            {
                Console.WriteLine(AddFirstThreeCharacterToFrontAndBack(item));
            }
        }

        public static string AddFirstThreeCharacterToFrontAndBack(string request)
        {
            return request.Length < 3 ? $"{request}{request}{request}" : $"{request.Substring(0, 3)}{request}{request.Substring(0, 3)}";
        }
    }
}
