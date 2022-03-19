using System;
using System.Linq;
using CSharp.Fundamentals.LINQ.Models;

namespace CSharp.Fundamentals.LINQ.AggregationOperators
{
    /// <summary>
    /// This method is used to calculate the average value of the numeric type of the collection.
    /// </summary>
    class AverageMethod
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var msAverageSalary = CustomerModel.GetAllEmployees()
                                 .Where(emp => emp.Department == "IT")
                                 .Average(emp => emp.Salary);
            //Using Query Syntax
            var qsAverageSalary = (from emp in CustomerModel.GetAllEmployees()
                                   where emp.Department == "IT"
                                   select emp).Average(e => e.Salary);

            Console.WriteLine("IT Department Average Salary = " + msAverageSalary);
            Console.ReadKey();
        }
    }
}
