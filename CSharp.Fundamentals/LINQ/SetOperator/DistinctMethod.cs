using System;
using System.Linq;
using CSharp.Fundamentals.LINQ.Models;

namespace CSharp.Fundamentals.LINQ.SetOperator
{
    public class DistinctMethod
    {
        static void Main(string[] args)
        {
            //Creating an instance of StudentComparer
            StudentComparer studentComparer = new StudentComparer();

            //Using Method Syntax
            var MS = StudentModel.GetStudentsDistinct()
                    .Distinct(studentComparer).ToList();

            //Using Query Syntax
            var QS = (from std in StudentModel.GetStudentsDistinct()
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
