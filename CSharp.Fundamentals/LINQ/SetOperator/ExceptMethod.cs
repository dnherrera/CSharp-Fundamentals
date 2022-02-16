using System;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.SetOperator
{
    /// <summary>
    ///  used to return the elements which are present in the first data source but not in the second data source
    /// </summary>
    class ExceptMethod
    {
        static void Main(string[] args)
        {
            string[] dataSource1 = { "India", "USA", "UK", "Canada", "Srilanka" };
            string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan" };
            //Method Syntax
            var MS = dataSource1.Except(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();

            //Query Syntax
            var QS = (from country in dataSource1
                      select country)
                      .Except(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey(); // USA, SriLanka
        }
    }
}
