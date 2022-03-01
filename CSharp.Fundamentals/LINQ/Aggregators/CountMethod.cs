using System;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.Aggregators
{
    /// <summary>
    /// This method is used to count the number of elements present in the collection.
    /// </summary>
    class CountMethod
    {
        static void Main(string[] args)
        {
            int[] intNumbers = new int[] { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };

            //Using Method Syntax
            int msCount = intNumbers.Where(num => num > 40).Count();

            //Using Query Syntax
            var qsCount = (from num in intNumbers
                           where num > 40
                           select num).Count();

            Console.WriteLine("No of Elements = " + msCount);
            Console.ReadKey();
        }
    }
}
