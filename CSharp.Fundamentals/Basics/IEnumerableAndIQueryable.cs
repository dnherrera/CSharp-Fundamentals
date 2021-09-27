using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.Basics
{
    public class IEnumerableAndIQueryable
    {
        static void Main(string[] args)
        {
            var students = Student.GetStudents().Where(x => x.Gender == Genders.Male.ToString()).ToList();
            IEnumerable<Student> studentEnumerable = students.Where(x => x.StudentName == "Dondon");

            IQueryable<Student> studentQueryable = students.AsQueryable().Where(x => x.Gender == "Male");
            studentQueryable = studentQueryable.Take(1);

            students.ForEach(x =>
            {
                Console.WriteLine(x.StudentName + " " + x.Gender);
            });

            Console.WriteLine(string.Join(", ", students.Select(s => s.StudentName.ToString())));

            List<int> itemNums = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            IEnumerable<int> querySyntax = itemNums.Where(x => x > 5);
            Console.WriteLine(string.Join(",", querySyntax));

            //Unique Items
            int[] numbers = { 1, 2, 2, 3, 4, 6, 7, 8, 9, 10 };
            IEnumerable<int> uniqueNumbers = numbers.Distinct<int>();
            Console.WriteLine("Unique numbers : " + string.Join(",", uniqueNumbers));

            string[] names = { "Dondon", "Jane", "Doe", "Jane" };
            IEnumerable<string> uniqnames = names.Distinct<string>();
            Console.WriteLine("Unique names : " + string.Join(", ", uniqnames));
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
