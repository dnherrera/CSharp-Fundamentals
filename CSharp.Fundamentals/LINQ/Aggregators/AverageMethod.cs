using System;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.Aggregators
{
    class AverageMethod
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var MSAverageSalary = EmpleyadoModel.GetAllEmployees()
                                 .Where(emp => emp.Department == "IT")
                                 .Average(emp => emp.Salary);
            //Using Query Syntax
            var QSAverageSalary = (from emp in EmpleyadoModel.GetAllEmployees()
                                   where emp.Department == "IT"
                                   select emp).Average(e => e.Salary);
            Console.WriteLine("IT Department Average Salary = " + MSAverageSalary);
            Console.ReadKey();
        }
    }
}
