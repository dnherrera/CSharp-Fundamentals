using System;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.SetOperator
{
    public class DistinctOperator
    {
        static void Main(string[] args)
        {
            //Creating an instance of StudentComparer
            StudentComparer studentComparer = new StudentComparer();

            //Using Method Syntax
            var MS = Student.GetStudents()
                    .Distinct(studentComparer).ToList();

            //Using Query Syntax
            var QS = (from std in Student.GetStudents()
                      select std)
                      .Distinct(studentComparer).ToList();
            foreach (var item in QS)
            {
                Console.WriteLine($"ID : {item.ID} , Name : {item.Name} ");
            }
            Console.ReadKey();
        }
    }
}
