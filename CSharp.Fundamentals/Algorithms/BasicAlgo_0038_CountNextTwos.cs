using System;

namespace CSharp.Fundamentals.Algorithms
{
    /*Write a C# Sharp program to count the number of two 5's are next to each other in an array of integers. Also count the situation where the second 5 is actually a 6. Go to the editor

    Sample Input:
    { 5, 5, 2 }
    { 5, 5, 2, 5, 5 }
    { 5, 6, 2, 9}
    Expected Output:
    1
    2
    1*/
    class BasicAlgo_0038_CountNextTwos
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 5, 2 }));
            Console.WriteLine(test(new[] { 5, 5, 2, 5, 5 }));
            Console.WriteLine(test(new[] { 5, 6, 2, 9 }));
            Console.ReadLine();
        }
        public static int test(int[] numbers)
        {
            var ctr = 0;
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i].Equals(5) && (numbers[i + 1].Equals(5) || numbers[i + 1].Equals(6))) ctr++;
            }
            return ctr;
        }
    }
}
