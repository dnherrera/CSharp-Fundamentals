using System;
using System.Collections.Generic;
using System.Linq;
using CSharp.Fundamentals.LINQ.Models;

namespace CSharp.Fundamentals.LINQ.ProjectionOperators
{
    class SelectOperator
    {
        static void Main(string[] args)
        {
            //Query Syntax
            IEnumerable<EmployeeModel> selectQuery = (from emp in EmployeeModel.GetEmployees()
                                                 select new EmployeeModel()
                                                 {
                                                     FirstName = emp.FirstName,
                                                     LastName = emp.LastName,
                                                     Salary = emp.Salary
                                                 });

            foreach (var emp in selectQuery)
            {
                Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
            }

            //Method Syntax
            List<EmployeeModel> selectMethod = EmployeeModel.GetEmployees().
                                          Select(emp => new EmployeeModel()
                                          {
                                              FirstName = emp.FirstName,
                                              LastName = emp.LastName,
                                              Salary = emp.Salary
                                          }).ToList();

            foreach (var emp in selectMethod)
            {
                Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
            }
            Console.ReadKey();
        }
    }
}
