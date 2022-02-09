using System;

namespace CSharp.Fundamentals.LINQ
{
    /// <summary>
    /// Extension methods allow us to add methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. 
    /// </summary>
    class ExtensionMethod
    {
        static void Main(string[] args)
        {
            string sentence = "Welcome to Dotnet Tutorials";

            int wordCount = sentence.GetWordCount();
            Console.WriteLine($"Count : {wordCount}");
            Console.ReadKey();
        }
    }

    public static class ExtensionHelper
    {
        public static int GetWordCount(this string str)
        {
            if (!String.IsNullOrEmpty(str))
                return str.Split(' ').Length;
            return 0;
        }
    }
}
