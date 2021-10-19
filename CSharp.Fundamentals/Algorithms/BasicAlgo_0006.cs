using System;
using System.Collections.Generic;

namespace CSharp.Fundamentals.Algorithms
{
    /// <summary>
    /// Write a C# Sharp program to remove the character in a given position of a given string. The given position will be in the range 0...string length -1 inclusive.
    /// </summary>
    public class BasicAlgo_0006
    {
        public static void Main(string[] args)
        {
            IDictionary<string, int> testData = new Dictionary<string, int>()
            {
                { "Dondon", 1 },
                { "Philippines", 3 },
                { "Canada", 4 }
            };

            foreach (var item in testData)
            {
                Console.WriteLine(CharacterRemover(item.Key, item.Value));
            }
        }

        public static string CharacterRemover(string request, int startIndex)
        {
            var numberOfCharTobeDeleted = 1;
            var test = request.Remove(startIndex, numberOfCharTobeDeleted);
            return test;
        }
    }
}
