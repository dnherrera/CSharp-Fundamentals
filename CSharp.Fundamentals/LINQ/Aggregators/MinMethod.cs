using System;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.Aggregators
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var MSLowestSalary = EmpleyadoModel.GetAllEmployees()
                                 .Where(emp => emp.Department == "IT")
                                 .Min(emp => emp.Salary);
            //Using Query Syntax
            var QSLowestSalary = (from emp in EmpleyadoModel.GetAllEmployees()
                                  where emp.Department == "IT"
                                  select emp).Min(e => e.Salary);
            Console.WriteLine("IT Department Lowest Salary = " + QSLowestSalary);
            Console.ReadKey();
        }
    }
}
