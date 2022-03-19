using System.Collections.Generic;

namespace CSharp.Fundamentals.LINQ.Models
{
    public class StudentModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int TotalMarks { get; set; }
        public List<string> Programming { get; set; }

        public static List<StudentModel> GetStudents()
        {
            return new List<StudentModel>()
            {
                new StudentModel(){ID = 1, Name = "James", Email = "James@j.com", Programming = new List<string>() { "C#", "Jave", "C++"} },
                new StudentModel(){ID = 2, Name = "Sam", Email = "Sara@j.com", Programming = new List<string>() { "WCF", "SQL Server", "C#" }},
                new StudentModel(){ID = 3, Name = "Patrik", Email = "Patrik@j.com", Programming = new List<string>() { "MVC", "Jave", "LINQ"} },
                new StudentModel(){ID = 4, Name = "Sara", Email = "Sara@j.com", Programming = new List<string>() { "ADO.NET", "C#", "LINQ" } }
            };
        }

        public static List<StudentModel> GetStudentsDistinct()
        {
            List<StudentModel> students = new List<StudentModel>()
            {
                new StudentModel {ID = 101, Name = "Preety" },
                new StudentModel {ID = 102, Name = "Sambit" },
                new StudentModel {ID = 103, Name = "Hina"},
                new StudentModel {ID = 104, Name = "Anurag"},
                new StudentModel {ID = 102, Name = "Sambit"},
                new StudentModel {ID = 103, Name = "Hina"},
                new StudentModel {ID = 101, Name = "Preety" },
            };
            return students;
        }

        public static List<StudentModel> GetStudentList()
        {
            return new List<StudentModel>()
            {
                new StudentModel(){ID = 1, Name = "James", Gender = "Male"},
                new StudentModel(){ID = 2, Name = "Sara", Gender = "Female"},
                new StudentModel(){ID = 3, Name = "Steve", Gender = "Male"},
                new StudentModel(){ID = 4, Name = "Pam", Gender = "Female"}
            };
        }
    }
}
