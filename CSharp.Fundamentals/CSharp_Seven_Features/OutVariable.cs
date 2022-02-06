using System;

namespace CSharp.Fundamentals.CSharp_Seven_Features
{
    class OutVariable
    {
        static void Main()
        {
            GetEmployeeDetails(out var EmployeeName, out var Gender, out var Salary, out var Department);
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name: {0}, Gender: {1}, Salary: {2}, Department: {3}",
            EmployeeName, Gender, Salary, Department);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void GetEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Department)
        {
            EmployeeName = "Pranaya Rout";
            Gender = "Male";
            Salary = 20000;
            Department = "IT";
        }
    }
}
