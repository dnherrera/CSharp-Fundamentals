using System;
using System.Linq;

namespace CSharp.Fundamentals.Advanced
{
    class FilterElements
    {
        static void Main(string[] args)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            Console.WriteLine("Short digits:");
            foreach (var d in shortDigits)
            {
                Console.WriteLine($"The word {d} is shorter than its value.");
            };

            /*
            The word five is shorter than its value.
            The word six is shorter than its value.
            The word seven is shorter than its value.
            The word eight is shorter than its value.
            */
          
            Console.WriteLine("------------------------------------------------------------");


            int[] vectorA = { 0, 2, 4, 5, 6 };
            int[] vectorB = { 1, 3, 5, 7, 8 };

            var dotProduct = vectorA.Zip(vectorB, (a, b) => a * b).Select(x => x);

            foreach (var item in dotProduct)
            {
                Console.WriteLine($"Dot product: {item}");
            }


            Console.WriteLine("------------------------------------------------------------");

            int[] numbers = { 5, 2, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var textNums = from n in numbers
                           select strings[n];

            Console.WriteLine("Number strings:");
            foreach (var s in textNums)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------------------------------------------------------------");

            int[] nums = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsInPlace = nums.Select((num, index) => (Num: num, InPlace: (num == index)));

            Console.WriteLine("Number: In-place?");
            foreach (var n in numsInPlace)
            {
                Console.WriteLine($"{n.Num}: {n.InPlace}");
            }
        }
    }
}
