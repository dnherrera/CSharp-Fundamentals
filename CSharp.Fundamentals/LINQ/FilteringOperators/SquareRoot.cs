using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.LINQ
{
    /*
      Write a program in C# Sharp to find the number of an array and the square of each number. Go to the editor
      Expected Output :
      { Number = 9, SqrNo = 81 }
      { Number = 8, SqrNo = 64 }
      { Number = 6, SqrNo = 36 }
      { Number = 5, SqrNo = 25 }
      */
    public class SquareRoot
    {
        public static void Main(string[] args)
        {
            var testData = new int[] { 9, 8, 6, 5 };
            var result = FindTheSquareRoot(testData);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<dynamic> FindTheSquareRoot(int[] request)
        {
            return from int Number in request
                   let SqrNo = Math.Pow(Number, 2)
                   where SqrNo > 20
                   select new { Number, SqrNo };
        }
    }
}
