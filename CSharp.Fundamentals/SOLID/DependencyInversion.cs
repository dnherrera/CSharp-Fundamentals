using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Fundamentals.SOLID
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }

    /// <summary>
    /// Abstraction - does not depend on the details (EmployeeDataAccess)
    /// </summary>
    public interface IEmployeeDataAccess
    {
        Employee GetEmployeeDetails(int id);
    }

    /// <summary>
    /// Low level class (details) depends on the Abstraction  - Repository
    /// </summary>
    /// <seealso cref="CSharp.Fundamentals.SOLID.IEmployeeDataAccess" />
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            // In real time get the employee details from db
            //but here we are hardcoded the employee details
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }

    public class DataAccessFactory
    {
        public static IEmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }

    /// <summary>
    /// High Level Class depends on Abstraction - Manager
    /// </summary>
    public class EmployeeBusinessLogic
    {
        IEmployeeDataAccess _employeeDataAccess;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeBusinessLogic"/> class.
        /// </summary>
        public EmployeeBusinessLogic()
        {
            _employeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public Employee GetEmployeeDetails(int id)
        {
            return _employeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
