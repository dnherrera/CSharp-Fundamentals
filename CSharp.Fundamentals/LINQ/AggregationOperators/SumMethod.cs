using System;
using System.Linq;
using CSharp.Fundamentals.LINQ.Models;

namespace CSharp.Fundamentals.LINQ.AggregationOperators
{
    /// <summary>
    /// This method is used to calculate the total(sum) value of the collection.
    /// </summary>
    public class SumMethod
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var TotalSalaryMS = CustomerModel.GetAllEmployees()
                              .Where(emp => emp.Department == "IT")
                              .Sum(emp => emp.Salary);
            
            //Using Query Syntax
            var TotalSalaryQS = (from emp in CustomerModel.GetAllEmployees()
                                 where emp.Department == "IT"
                                 select emp).Sum(e => e.Salary);

            Console.WriteLine("IT Department Total Salary = " + TotalSalaryQS);
            Console.ReadKey();
        }
    }
}
