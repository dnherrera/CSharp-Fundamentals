using System;
using System.Collections.Generic;
using System.Linq;
using CSharp.Fundamentals.LINQ.Models;

namespace CSharp.Fundamentals.LINQ.QuantifierOperators
{
    class ContainsMethod
    {
        static void Main(string[] args)
        {
            List<StudentModel> students = new List<StudentModel>()
                        {
                            new StudentModel(){ID = 101, Name = "Priyanka", TotalMarks = 275 },
                            new StudentModel(){ID = 102, Name = "Preety", TotalMarks = 375 }
                        };

            //Using Method Syntax
            var IsExistsMS = students.Contains(new StudentModel() { ID = 101, Name = "Priyanka", TotalMarks = 275 });
            var student1 = new StudentModel() { ID = 101, Name = "Priyanka", TotalMarks = 275 };

            //Using Query Syntax
            var IsExistsQS = (from num in students
                              select num).Contains(student1);

            Console.WriteLine(IsExistsMS);
            Console.ReadKey();
        }
    }
}
