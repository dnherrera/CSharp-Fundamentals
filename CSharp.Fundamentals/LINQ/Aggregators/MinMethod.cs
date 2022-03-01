using System;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.Aggregators
{
    /// <summary>
    ///  This method is used to find the smallest value in the collection
    /// </summary>
    class MinMethod
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var msLowestSalary = EmpleyadoModel.GetAllEmployees()
                                 .Where(emp => emp.Department == "IT")
                                 .Min(emp => emp.Salary);
            //Using Query Syntax
            var qsLowestSalary = (from emp in EmpleyadoModel.GetAllEmployees()
                                  where emp.Department == "IT"
                                  select emp).Min(e => e.Salary);

            Console.WriteLine("IT Department Lowest Salary = " + qsLowestSalary);
            Console.ReadKey();
        }
    }
}
