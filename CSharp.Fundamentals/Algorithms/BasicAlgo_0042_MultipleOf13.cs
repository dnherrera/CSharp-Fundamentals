using System;

namespace CSharp.Fundamentals.Algorithms
{
    /*Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13. Go to the editor
    Sample Input:
    13
    14
    27
    41
    Expected Output:
    True
    True
    True
    False*/
    public class BasicAlgo_0042_MultipleOf13
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(13));
            Console.WriteLine(test(14));
            Console.WriteLine(test(27));
            Console.WriteLine(test(41));
            Console.ReadLine();
        }
        public static bool test(int n)
        {
            return n % 13 == 0 || n % 13 == 1;
        }
    }
}
