using System.Collections.Generic;

namespace CSharp.Fundamentals.LINQ.SetOperator
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student {ID = 101, Name = "Preety" },
                new Student {ID = 102, Name = "Sambit" },
                new Student {ID = 103, Name = "Hina"},
                new Student {ID = 104, Name = "Anurag"},
                new Student {ID = 102, Name = "Sambit"},
                new Student {ID = 103, Name = "Hina"},
                new Student {ID = 101, Name = "Preety" },
            };
            return students;
        }
    }
}
