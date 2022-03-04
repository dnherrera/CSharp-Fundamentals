using System;
using System.Linq;

namespace CSharp.Fundamentals.LINQ
{
    /// <summary>
    /// Linq All Operator in C# is used to check whether all the elements of a data source satisfy a given condition or not.
    /// </summary>
    class AllOperator
    {
        static void Main(string[] args)
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };
            var Result = IntArray.All(x => x > 10);
            Console.WriteLine("Is All Numbers are greater than 10 : " + Result);
            Console.ReadKey();
        }
    }
}
