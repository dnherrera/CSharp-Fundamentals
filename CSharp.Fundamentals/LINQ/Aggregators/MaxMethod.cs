using System;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.Aggregators
{
    /// <summary>
    /// This method is used to find the largest value in the collection
    /// </summary>
    public class MaxMethod
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var msHighestSalary = EmpleyadoModel.GetAllEmployees()
                              .Where(emp => emp.Department == "IT")
                              .Max(emp => emp.Salary);
            //Using Query Syntax
            var qsHighestSalary = (from emp in EmpleyadoModel.GetAllEmployees()
                                   where emp.Department == "IT"
                                   select emp).Max(e => e.Salary);

            Console.WriteLine("It Department Highest Salary = " + qsHighestSalary);
            Console.ReadKey();
        }
    }
}
