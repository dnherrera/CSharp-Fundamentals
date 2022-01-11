using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.Basics
{
    public class IEnumerableAndIQueryable
    {
        static void Main(string[] args)
        {
            var students = GetStudents();
            GetStudentsEnumerable(students);

            var studentQueryable = GetStudentsQueryable(students);
            studentQueryable = studentQueryable.Take(1);

            // Displaying data using For Each
            students.ForEach(x => { Console.WriteLine(x.StudentName + " " + x.Gender); });

            // Displaying data using LINQ
            Console.WriteLine(string.Join(", ", students.Select(s => s.StudentName)));


            List<int> testData = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };
            Console.WriteLine(GetGreaterThanFive(testData)); 

            dynamic[] items = { "Dondon", "Jane", "Doe", "Jane", 1, 1, 2, 2, 3, 4, 6, 7, 8, 9, 10 };
            Console.WriteLine(GetUniqueItem(items));
        }

        public static List<Student> GetStudents()
        {
            return Student.GetStudents().Where(x => x.Gender == Genders.Male.ToString()).ToList();
        }

        public static IEnumerable<Student> GetStudentsEnumerable(List<Student> students)
        {
            return students.Where(x => x.StudentName == "Dondon");
        }

        public static IQueryable<Student> GetStudentsQueryable(List<Student> students)
        {
            return students.AsQueryable().Where(x => x.Gender == "Male");
        }

        public static string GetGreaterThanFive(List<int> numbers)
        {
            IEnumerable<int> querySyntax = numbers.Where(x => x > 5);
            return string.Join(",", querySyntax);
        }

        public static string GetUniqueItem(dynamic[] items)
        {
            var uniqueItem = items.Distinct();
            return "Unique items : " + string.Join(", ", uniqueItem);
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }

        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student()
                {
                    StudentId = 1,
                    StudentName = "Don",
                    Gender = Genders.Male.ToString()
                },
                new Student()
                {
                    StudentId = 2,
                    StudentName = "Mara",
                    Gender = Genders.Female.ToString()
                }
            };
        }
    }

    public enum Genders
    {
        Male = 0,
        Female = 1,
        Others
    }
}
