using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Fundamentals.Algorithms
{
    /*
    Write a C# Sharp program to create a new string made of every other character starting with the first from a given string. Go to the editor

    Sample Input:
    "Python"
    "PHP"
    "JS"
    Expected Output:
    Pto
    PP
    J
     */
    public class BasicAlgo_0029
    {
        public static void Main(string[] args)
        {
            string[] testData = { "Python", "PHP", "JS" };

            foreach (var item in testData)
            {
                Console.WriteLine(ProduceNewString(item));
            }
        }

        public static string ProduceNewString(string request)
        {
            var result = string.Empty;
            for (int i = 0; i < request.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += request[i]; // Transform into new string
                }
            }

            return result;
        }
    }
}
