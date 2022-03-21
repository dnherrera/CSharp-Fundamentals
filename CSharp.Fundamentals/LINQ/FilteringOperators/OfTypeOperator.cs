using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.FilteringOperators
{
    /// <summary>
    /// OfType Operator in LINQ is used to filter specific type data from a data source based on the data type we passed to this operator.
    /// </summary>
    class OfTypeOperator
    {
        static void Main(string[] args)
        {
            List<object> dataSource = new List<object>()
            {
                "Tom", "Mary", 50, "Prince", "Jack", 10, 20, 30, 40, "James"
            };
            //Using Method Syntax
            var intData = dataSource.OfType<int>().Where(num => num > 30).ToList();
            foreach (int number in intData)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            //Using Qyery Syntax
            var stringData = (from name in dataSource
                              where name is string && name.ToString().Length > 3
                              select name).ToList();
            foreach (string name in stringData)
            {
                Console.Write(name + " ");
            }

            Console.ReadKey();
        }
    }
}
