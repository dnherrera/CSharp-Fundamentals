using System;

namespace CSharp.Fundamentals.Pillars
{
    /// <summary>
    /// to take something that is already made
    /// </summary>
    class Inheritance
    {
        class Program
        {
            static void Main(string[] args)
            {
                Employee obj1 = new Employee();
                obj1.GetBranchData();
                obj1.GetEmployeeData();
                obj1.DisplayBranchData();
                obj1.DisplayEmployeeData();
                Console.WriteLine("Press any key to exist.");
                Console.ReadKey();


                EmployeeProtected obj2 = new EmployeeProtected();
                //Here we cannot access the Branch class method as they are now protected
                // obj1.GetBranchData(); //Will give Compile time error
                obj2.GetEmployeeData();
                // obj1.DisplayBranchData(); // will give compile time error
                obj2.DisplayEmployeeData();
                Console.WriteLine("Press any key to exist.");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Parent
        /// </summary>
        class Branch
        {
            int BranchCode;
            string BranchName, BranchAddress;
            public void GetBranchData()
            {
                Console.WriteLine("ENTER BRANCH DETAILS:");
                Console.WriteLine("ENTER BRANCH CODE");
                BranchCode = int.Parse(Console.ReadLine());
                Console.WriteLine("ENTER BRANCH NAME");
                BranchName = Console.ReadLine();
                Console.WriteLine("ENTER BRANCH ADDRESS");
                BranchAddress = Console.ReadLine();
            }
            public void DisplayBranchData()
            {
                Console.WriteLine("BRANCH CODE IS : " + BranchCode);
                Console.WriteLine("BRANCH NAME IS : " + BranchName);
                Console.WriteLine("BRANCH ADDRESS IS : " + BranchAddress);
            }
        }

        /// <summary>
        /// Child 
        /// </summary>
        /// <seealso cref="CSharp.Fundamentals.Pillars.Inheritance.Branch" />
        class Employee : Branch
        {
            int EmployeeId, EmployeeAge;
            string EmployeeName, EmployeeAddress;
            public void GetEmployeeData()
            {
                Console.WriteLine("ENTER EMPLYEE DETAILS:");
                Console.WriteLine("ENTER EMPLOYEE ID");
                EmployeeId = int.Parse(Console.ReadLine());
                Console.WriteLine("ENTER EMPLOYEE AGE");
                EmployeeAge = int.Parse(Console.ReadLine());
                Console.WriteLine("ENTER EMPLOYEE NAME");
                EmployeeName = Console.ReadLine();
                Console.WriteLine("ENTER EMPLOYEE ADDRESS");
                EmployeeAddress = Console.ReadLine();
            }
            public void DisplayEmployeeData()
            {
                Console.WriteLine("EMPLOYEE ID IS : " + EmployeeId);
                Console.WriteLine("EMPLOYEE NAME IS : " + EmployeeName);
                Console.WriteLine("EMPLOYEE ADDRESS IS : " + EmployeeAddress);
                Console.WriteLine("EMPLOYEE AGE IS : " + EmployeeAge);
            }
        }

        class BranchProtected
        {
            int BranchCode;
            string BranchName, BranchAddress;
            protected void GetBranchData()
            {
                Console.WriteLine("ENTER BRANCH DETAILS:");
                Console.WriteLine("ENTER BRANCH CODE");
                BranchCode = int.Parse(Console.ReadLine());
                Console.WriteLine("ENTER BRANCH NAME");
                BranchName = Console.ReadLine();
                Console.WriteLine("ENTER BRANCH ADDRESS");
                BranchAddress = Console.ReadLine();
            }
            protected void DisplayBranchData()
            {
                Console.WriteLine("BRANCH CODE IS : " + BranchCode);
                Console.WriteLine("BRANCH NAME IS : " + BranchName);
                Console.WriteLine("BRANCH ADDRESS IS : " + BranchAddress);
            }
        }

        /// <summary>
        /// The only class that can access the protected base class is the Child inherited to it
        /// </summary>
        /// <seealso cref="CSharp.Fundamentals.Pillars.Inheritance.BranchProtected" />
        class EmployeeProtected : BranchProtected
        {
            int EmployeeId, EmployeeAge;
            string EmployeeName, EmployeeAddress;
            public void GetEmployeeData()
            {
                //to call the base class method use base keyword
                base.GetBranchData();
                Console.WriteLine("ENTER EMPLYEE DETAILS:");
                Console.WriteLine("ENTER EMPLOYEE ID");
                EmployeeId = int.Parse(Console.ReadLine());
                Console.WriteLine("ENTER EMPLOYEE AGE");
                EmployeeAge = int.Parse(Console.ReadLine());
                Console.WriteLine("ENTER EMPLOYEE NAME");
                EmployeeName = Console.ReadLine();
                Console.WriteLine("ENTER EMPLOYEE ADDRESS");
                EmployeeAddress = Console.ReadLine();
            }
            public void DisplayEmployeeData()
            {
                base.DisplayBranchData();
                Console.WriteLine("EMPLOYEE ID IS : " + EmployeeId);
                Console.WriteLine("EMPLOYEE NAME IS : " + EmployeeName);
                Console.WriteLine("EMPLOYEE ADDRESS IS : " + EmployeeAddress);
                Console.WriteLine("EMPLOYEE AGE IS : " + EmployeeAge);
            }
        }

    }
}
