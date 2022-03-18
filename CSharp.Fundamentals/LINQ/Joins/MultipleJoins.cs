using System;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.Joins
{
    class MultipleJoins
    {
        static void Main(string[] args)
        {
            var JoinMultipleDSUsingQS = (//Data Source1
                                         from emp in UserModel.GetAllEmployees()
                                             //Joining with Address Data Source (Data Source2)
                                         join adrs in AddressModel.GetAllAddresses()
                                         on emp.AddressId equals adrs.ID
                                         //Joining with Department Data Source (Data Source3)
                                         join dept in DepartmentModel.GetAllDepartments()
                                         on emp.DepartmentId equals dept.ID
                                         //Projecting the result set
                                         select new
                                         {
                                             ID = emp.ID,
                                             EmployeeName = emp.Name,
                                             DepartmentName = dept.Name,
                                             AddressLine = adrs.AddressLine
                                         }).ToList();
            foreach (var employee in JoinMultipleDSUsingQS)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.EmployeeName}, Department = {employee.DepartmentName}, Addres = {employee.AddressLine}");
            }
            Console.ReadLine();
        }
    }
}
