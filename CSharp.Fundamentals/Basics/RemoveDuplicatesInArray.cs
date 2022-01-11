using System;
using System.Linq;

namespace CSharp.Fundamentals.Basics
{
    public class RemoveDuplicatesInArray
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 4, 4, 3 };
            int[] arr2 = { 1, 2, 5, 4, 3 };

            Console.WriteLine(string.Join(", ", arr1.Concat(arr2).Distinct()));
        }
    }
}
