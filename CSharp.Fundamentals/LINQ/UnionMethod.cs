using System;
using System.Collections.Generic;
using System.Linq;
using CSharp.Fundamentals.LINQ.Models;

namespace CSharp.Fundamentals.LINQ
{
    /// <summary>
    /// LINQ Union Method in C# is used to combine the multiple data sources into one data source by removing the duplicate elements.
    /// </summary>
    class UnionMethod
    {
        static void Main(string[] args)
        {
            List<StudentModel> StudentModelCollection1 = new List<StudentModel>()
            {
                new StudentModel {ID = 101, Name = "Preety" },
                new StudentModel {ID = 102, Name = "Sambit" },
                new StudentModel {ID = 105, Name = "Hina"},
                new StudentModel {ID = 106, Name = "Anurag"},
            };
            List<StudentModel> StudentModelCollection2 = new List<StudentModel>()
            {
                new StudentModel {ID = 105, Name = "Hina"},
                new StudentModel {ID = 106, Name = "Anurag"},
                new StudentModel {ID = 107, Name = "Pranaya"},
                new StudentModel {ID = 108, Name = "Santosh"},
            };
            //Method Syntax
            var MS = StudentModelCollection1.Select(x => x.Name)
                     .Union(StudentModelCollection2.Select(y => y.Name)).ToList();
            //Query Syntax
            var QS = (from std in StudentModelCollection1
                      select std.Name)
                      .Union(StudentModelCollection2.Select(y => y.Name)).ToList();
            foreach (var name in MS)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
