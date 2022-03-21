using System;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.JoinOperators
{
    class Union
    {
        static void Main(string[] args)
        {
            string[] dataSource1 = { "India", "USA", "UK", "Canada", "Srilanka" };
            string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan" };
            //Method Syntax
            var MS = dataSource1.Union(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            //Query Syntax
            var QS = (from country in dataSource1
                      select country)
                      .Union(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
