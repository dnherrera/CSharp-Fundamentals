using System;
using System.Linq;
using CSharp.Fundamentals.LINQ.SelectOperator;

namespace CSharp.Fundamentals.LINQ
{
    /// <summary>
    /// Filtering is nothing but the process to get only those elements from a data source that satisfied the given condition. 
    /// </summary>
    class Filtering
    {
        static void Main(string[] args)
        {
            //Query Syntax
            var QuerySyntax = (from data in EmployeeModel.GetEmployees().Select((Data, index) => new { employee = Data, Index = index })
                               where data.employee.Salary >= 500000 && data.employee.Gender == "Male"
                               select new
                               {
                                   EmployeeName = $"{data.employee.FirstName} {data.employee.LastName}",
                                   Gender = data.employee.Gender,
                                   Salary = data.employee.Salary,
                                   IndexPosition = data.Index
                               }).ToList();
            //Method Syntax
            var MethodSyntax = EmployeeModel.GetEmployees().Select((Data, index) => new { employee = Data, Index = index })
                               .Where(emp => emp.employee.Salary >= 500000 && emp.employee.Gender == "Male")
                               .Select(emp => new
                               {
                                   EmployeeName = $"{emp.employee.FirstName} {emp.employee.LastName}",
                                   Gender = emp.employee.Gender,
                                   Salary = emp.employee.Salary,
                                   IndexPosition = emp.Index
                               })
                               .ToList();
            foreach (var emp in QuerySyntax)
            {
                Console.WriteLine($"Position : {emp.IndexPosition} Name : {emp.EmployeeName}, Gender : {emp.Gender}, Salary : {emp.Salary}");
            }
            Console.ReadKey();
        }
    }
}
