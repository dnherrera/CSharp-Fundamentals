using System;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.Aggregators
{
    /// <summary>
    /// To get the max value
    /// </summary>
    public class MaxMethod
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var MSHighestSalary = EmpleyadoModel.GetAllEmployees()
                              .Where(emp => emp.Department == "IT")
                              .Max(emp => emp.Salary);
            //Using Query Syntax
            var QSHighestSalary = (from emp in EmpleyadoModel.GetAllEmployees()
                                   where emp.Department == "IT"
                                   select emp).Max(e => e.Salary);
            Console.WriteLine("It Department Highest Salary = " + QSHighestSalary);
            Console.ReadKey();
        }
    }
}
