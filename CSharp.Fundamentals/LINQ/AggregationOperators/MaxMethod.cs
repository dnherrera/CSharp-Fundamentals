using System;
using System.Linq;
using CSharp.Fundamentals.LINQ.Models;

namespace CSharp.Fundamentals.LINQ.AggregationOperators
{
    /// <summary>
    /// This method is used to find the largest value in the collection
    /// </summary>
    public class MaxMethod
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var msHighestSalary = CustomerModel.GetAllEmployees()
                              .Where(emp => emp.Department == "IT")
                              .Max(emp => emp.Salary);
            //Using Query Syntax
            var qsHighestSalary = (from emp in CustomerModel.GetAllEmployees()
                                   where emp.Department == "IT"
                                   select emp).Max(e => e.Salary);

            Console.WriteLine("It Department Highest Salary = " + qsHighestSalary);
            Console.ReadKey();
        }
    }
}
