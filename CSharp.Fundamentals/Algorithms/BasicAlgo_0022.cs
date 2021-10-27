using System;
using System.Linq;

namespace CSharp.Fundamentals.Algorithms
{
    /*
     Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character. Go to the editor
     Sample Input:
     "frizz"
     "zane"
     "Zazz"
     "false"
     Expected Output:
     True
     False
     True
     False
     */
    public class BasicAlgo_0022
    {
        public static void Main(string[] args)
        {
            var testData = new string[] { "frizz", "zane", "Zazz", "false" };

            foreach (var item in testData)
            {
                Console.WriteLine(StringCharacterChecker(item));
            }
        }

        public static bool StringCharacterChecker(string request)
        {
            var test = request.ToCharArray();
            var isContain = test.Where(x => x == 'z' || x == 'Z').Count();
            return isContain >= 2 && isContain <= 4 ;
        }
    }
}
