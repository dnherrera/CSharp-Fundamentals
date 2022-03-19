using System.Collections.Generic;

namespace CSharp.Fundamentals.LINQ.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }
        public static List<EmployeeModel> GetEmployees()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>
            {
                new EmployeeModel {ID = 101, FirstName = "Preety", LastName = "Tiwary", Salary = 60000, Gender = "Male" },
                new EmployeeModel {ID = 102, FirstName = "Priyanka", LastName = "Dewangan", Salary = 70000,  Gender = "Female" },
                new EmployeeModel {ID = 103, FirstName = "Hina", LastName = "Sharma", Salary = 80000,  Gender = "Male" },
                new EmployeeModel {ID = 104, FirstName = "Anurag", LastName = "Mohanty", Salary = 90000,  Gender = "Male" },
                new EmployeeModel {ID = 105, FirstName = "Sambit", LastName = "Satapathy", Salary = 100000,  Gender = "Female" },
                new EmployeeModel {ID = 106, FirstName = "Sushanta", LastName = "Jena", Salary = 160000,  Gender = "Male" }
            };
            return employees;
        }
    }
}
