using System;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.SetOperator
{
    /// <summary>
    /// LINQ Intersect Method in C# is used to return the common elements from both the collections.
    /// </summary>
    class Intersect
    {
        static void Main(string[] args)
        {
            string[] dataSource1 = { "India", "USA", "UK", "Canada", "Srilanka" };
            string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan" };
            //Method Syntax
            var MS = dataSource1.Intersect(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            //Query Syntax
            var QS = (from country in dataSource1
                      select country)
                      .Intersect(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            foreach (var item in QS)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
