using System;

namespace CSharp.Fundamentals.Basics
{
    public class EvenOrOdd
    {
        public static void Main(string[] args)
        {
            var testData = new int[] { 1, -1, 0, 2 };

            foreach (var item in testData)
            {
                Console.WriteLine(IsEvenOrOdd(item));
            }
        }

        static string IsEvenOrOdd(int number)
        {
            if (number % 2 == 0)
                return $"{number} is even";

            else if (number % 1 == 0)
                return $"{number} is odd";

            else
                return $"{number} undentified";
        }
    }
}
