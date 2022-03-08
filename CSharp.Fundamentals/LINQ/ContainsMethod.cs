using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.LINQ
{
    class ContainsMethod
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
                        {
                            new Student(){ID = 101, Name = "Priyanka", TotalMarks = 275 },
                            new Student(){ID = 102, Name = "Preety", TotalMarks = 375 }
                        };

            //Using Method Syntax
            var IsExistsMS = students.Contains(new Student() { ID = 101, Name = "Priyanka", TotalMarks = 275 });
            var student1 = new Student() { ID = 101, Name = "Priyanka", TotalMarks = 275 };

            //Using Query Syntax
            var IsExistsQS = (from num in students
                              select num).Contains(student1);

            Console.WriteLine(IsExistsMS);
            Console.ReadKey();
        }
    }
}
