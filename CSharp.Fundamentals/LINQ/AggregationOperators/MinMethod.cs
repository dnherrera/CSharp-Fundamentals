using System;
using System.Linq;
using CSharp.Fundamentals.LINQ.Models;

namespace CSharp.Fundamentals.LINQ.AggregationOperators
{
    /// <summary>
    ///  This method is used to find the smallest value in the collection
    /// </summary>
    class MinMethod
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var msLowestSalary = CustomerModel.GetAllEmployees()
                                 .Where(emp => emp.Department == "IT")
                                 .Min(emp => emp.Salary);
            //Using Query Syntax
            var qsLowestSalary = (from emp in CustomerModel.GetAllEmployees()
                                  where emp.Department == "IT"
                                  select emp).Min(e => e.Salary);

            Console.WriteLine("IT Department Lowest Salary = " + qsLowestSalary);
            Console.ReadKey();
        }
    }
}
