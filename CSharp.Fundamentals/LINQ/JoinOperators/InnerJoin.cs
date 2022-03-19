using System;
using System.Linq;
using CSharp.Fundamentals.LINQ.Models;

namespace CSharp.Fundamentals.LINQ.JoinOperators
{
    /// <summary>
    /// An inner join produces a result set in which each element of the first collection appears one time for every matching element in the second collection. 
    /// If an element in the first collection does not have any matching element in the second collection, then it does not appear in the result set
    /// </summary>
    public class InnerJoin
    {
        static void Main(string[] args)
        {
            JoinUsingMq();
        }

        static void JoinUsingMq()
        {
            var JoinUsingMS = UserModel.GetAllEmployees() //Outer Data Source
                           .Join(AddressModel.GetAllAddresses(),  //Inner Data Source
                           employee => employee.AddressId, //Inner Key Selector
                           address => address.ID, //Outer Key selector
                           (employee, address) => new //Projecting the data into a result set
                           {
                               EmployeeName = employee.Name,
                               AddressLine = address.AddressLine
                           }).ToList();

            foreach (var employee in JoinUsingMS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }

            Console.ReadLine();
        }

        static void JoinUsingQuery()
        {
            var JoinUsingQS = (from emp in UserModel.GetAllEmployees()
                               join address in AddressModel.GetAllAddresses()
                               on emp.AddressId equals address.ID
                               select new
                               {
                                   EmployeeName = emp.Name,
                                   AddressLine = address.AddressLine
                               }).ToList();

            foreach (var employee in JoinUsingQS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }
            Console.ReadLine();
        }
    }
}
