using System;

namespace CSharp.Fundamentals.Algorithms
{
    /*Write a C# Sharp program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string. Go to the editor

    Sample Input:
    "Python"
    "JavaScript"
    "HTML"
    Expected Output:
    Pyon
    JaScpt
    HT*/
    class BasicAlgo_0037_CreateStringFromIndexes
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("JavaScript"));
            Console.WriteLine(test("HTML"));
            Console.ReadLine();
        }

        public static string test(string str1)
        {
            var result = string.Empty;
            for (var i = 0; i < str1.Length; i += 4)
            {
                var c = i + 2;
                var n = 0;
                n += c > str1.Length ? 1 : 2;
                result += str1.Substring(i, n);
            }
            return result;
        }
    }
}
