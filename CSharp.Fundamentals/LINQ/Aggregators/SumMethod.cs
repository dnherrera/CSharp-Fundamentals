using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.Aggregators
{
    /// <summary>
    /// This method is used to calculate the total(sum) value of the collection.
    /// </summary>
    public class SumMethod
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var TotalSalaryMS = EmpleyadoModel.GetAllEmployees()
                              .Where(emp => emp.Department == "IT")
                              .Sum(emp => emp.Salary);
            
            //Using Query Syntax
            var TotalSalaryQS = (from emp in EmpleyadoModel.GetAllEmployees()
                                 where emp.Department == "IT"
                                 select emp).Sum(e => e.Salary);

            Console.WriteLine("IT Department Total Salary = " + TotalSalaryQS);
            Console.ReadKey();
        }
    }
}
