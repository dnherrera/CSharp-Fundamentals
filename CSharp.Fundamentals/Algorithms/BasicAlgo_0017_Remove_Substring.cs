using System;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. 
    /// If it appears return a string without 'yt' otherwise return the original string
    /// </summary>
    public class BasicAlgo_0017_Remove_Substring
    {
        public static void Main(string[] args)
        {
            string[] testData = { "Python", "ytade", "jsues" };
            foreach (var item in testData)
            {
                Console.WriteLine(CharactersRemover(item, 1, 2));
                Console.WriteLine(CharactersRemover2(item));
            }
        }

        public static string CharactersRemover(string request, int startIndex, int charNumToBeDeleted)
        {
            if (request.Substring(startIndex, charNumToBeDeleted) == "yt")
            {
                return request.Remove(startIndex, charNumToBeDeleted);
            }
            return request;
        }

        public static string CharactersRemover2(string str)
        {
            return str.Substring(1, 2).Equals("yt") ? str.Remove(1, 2) : str;
        }
    }
}
