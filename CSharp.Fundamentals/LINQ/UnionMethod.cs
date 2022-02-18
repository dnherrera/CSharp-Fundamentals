using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.LINQ
{
    /// <summary>
    /// LINQ Union Method in C# is used to combine the multiple data sources into one data source by removing the duplicate elements.
    /// </summary>
    class UnionMethod
    {
        static void Main(string[] args)
        {
            List<Student> StudentCollection1 = new List<Student>()
            {
                new Student {ID = 101, Name = "Preety" },
                new Student {ID = 102, Name = "Sambit" },
                new Student {ID = 105, Name = "Hina"},
                new Student {ID = 106, Name = "Anurag"},
            };
            List<Student> StudentCollection2 = new List<Student>()
            {
                new Student {ID = 105, Name = "Hina"},
                new Student {ID = 106, Name = "Anurag"},
                new Student {ID = 107, Name = "Pranaya"},
                new Student {ID = 108, Name = "Santosh"},
            };
            //Method Syntax
            var MS = StudentCollection1.Select(x => x.Name)
                     .Union(StudentCollection2.Select(y => y.Name)).ToList();
            //Query Syntax
            var QS = (from std in StudentCollection1
                      select std.Name)
                      .Union(StudentCollection2.Select(y => y.Name)).ToList();
            foreach (var name in MS)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
