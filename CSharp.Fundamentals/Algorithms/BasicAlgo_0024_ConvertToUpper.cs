using System;

namespace CSharp.Fundamentals.Algorithms
{
    /*
    Write a C# Sharp program to convert the last 3 characters of a given string in upper case. 
    If the length of the string has less than 3 then uppercase all the characters. Go to the editor

    Sample Input:
    "Python"
    "Javascript"
    "js"
    "PHP"
    Expected Output:
    PytHON
    JavascrIPT
    JS
    PHP
    */
    /// </summary>
    public class BasicAlgo_0024_ConvertToUpper
    {
        public static void Main(string[] args)
        {
            var testData = new string[] { "Python", "Javascript", "js", "PHP" };
            foreach (var item in testData)
            {
                Console.WriteLine(ConvertStringToUpper(item));
            }
        }

        public static string ConvertStringToUpper(string request)
        {
            return request.Length < 3 ? request.ToUpper() : request.Remove(request.Length - 3) + request.Substring(request.Length - 3, 3).ToUpper();
        }
    }
}
