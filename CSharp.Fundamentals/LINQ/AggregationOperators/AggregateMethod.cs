using System;
using System.Linq;
using CSharp.Fundamentals.LINQ.Models;

namespace CSharp.Fundamentals.LINQ.AggregationOperators
{
    /// <summary>
    /// This method is used to Performs a custom aggregation operation on the values of a collection.
    /// </summary>
    public class AggregateMethod
    {
        static void Main(string[] args)
        {
            GetCommaSeparatedString();
            ProductIntegerNumber();
            AggregateWithSeedParam();
            AddEmployeeSalary();
            GetNamesWithEmployeeNameSeed();
            AggregateMethodWithResultSelector();
        }

        static void GetCommaSeparatedString()
        {
            string[] skills = { "C#.NET", "MVC", "WCF", "SQL", "LINQ", "ASP.NET" };
            string result = skills.Aggregate((s1, s2) => s1 + ", " + s2);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        static void ProductIntegerNumber()
        {
            int[] intNumbers = { 3, 5, 7, 9 };
            int result = intNumbers.Aggregate((n1, n2) => n1 * n2);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static void AggregateWithSeedParam()
        {
            int[] intNumbers = { 3, 5, 7, 9 };
            int result = intNumbers.Aggregate((n1, n2) => n1 * n2);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static void AddEmployeeSalary()
        {
            int salary = CustomerModel.GetAllEmployees()
                           .Aggregate<CustomerModel, int>(0,
                           (TotalSalary, emp) => TotalSalary += emp.Salary);

            Console.WriteLine(salary);
            Console.ReadKey();
        }

        static void GetNamesWithEmployeeNameSeed()
        {
            string commaSeparatedEmployeeNames = CustomerModel.GetAllEmployees().Aggregate<CustomerModel, string>(
                                       "Employee Names : ",  // seed value
                                       (employeeNames, employee) => employeeNames = employeeNames + employee.Name + ", ");
            int LastIndex = commaSeparatedEmployeeNames.LastIndexOf(",");
            commaSeparatedEmployeeNames = commaSeparatedEmployeeNames.Remove(LastIndex);
            Console.WriteLine(commaSeparatedEmployeeNames);
            Console.ReadKey();
        }

        static void AggregateMethodWithResultSelector()
        {
            string commaSeparatedEmployeeNames = CustomerModel.GetAllEmployees().Aggregate<CustomerModel, string, string>(
                                        "Employee Names : ",  // seed value
                                        (employeeNames, employee) => employeeNames = employeeNames + employee.Name + ",",
                                        employeeNames => employeeNames.Substring(0, employeeNames.Length - 1));

            Console.WriteLine(commaSeparatedEmployeeNames);
            Console.ReadKey();
        }
        
    }
}
