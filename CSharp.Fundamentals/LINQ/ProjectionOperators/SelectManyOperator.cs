using System;
using System.Collections.Generic;
using System.Linq;
using CSharp.Fundamentals.LINQ.Models;

namespace CSharp.Fundamentals.LINQ.SelectOperator
{
    /// <summary>
    /// SelectMany in LINQ is used to project each element of a sequence to an IEnumerable<T> and then flatten the resulting sequences into one sequence
    /// </summary>
    public class SelectManyOperator
    {
        static void Main(string[] args)
        {
            DisplayNameWithProgrammingLanguage();
            DisplayProgrammingLanguageUnique();
        }

        /// <summary>
        /// Displays the name with programming language.
        /// </summary>
        static void DisplayNameWithProgrammingLanguage()
        {
            //Using Method Syntax
            var MethodSyntax = StudentModel.GetStudents()
                                        .SelectMany(std => std.Programming,
                                             (student, program) => new
                                             {
                                                 StudentName = student.Name,
                                                 ProgramName = program
                                             }
                                             )
                                        .ToList();
            //Using Query Syntax
            var QuerySyntax = (from std in StudentModel.GetStudents()
                               from program in std.Programming
                               select new
                               {
                                   StudentName = std.Name,
                                   ProgramName = program
                               }).ToList();

            //Printing the values
            foreach (var item in QuerySyntax)
            {
                Console.WriteLine(item.StudentName + " => " + item.ProgramName);
            }
            Console.ReadKey();
        }


        /// <summary>
        /// Displays the programming language unique.
        /// </summary>
        static void DisplayProgrammingLanguageUnique()
        {
            //Using Method Syntax
            List<string> MethodSyntax = StudentModel.GetStudents()
                                        .SelectMany(std => std.Programming)
                                        .Distinct()
                                        .ToList();
            //Using Query Syntax
            IEnumerable<string> QuerySyntax = (from std in StudentModel.GetStudents()
                                               from program in std.Programming
                                               select program).Distinct().ToList();
            //Printing the values
            foreach (string program in QuerySyntax)
            {
                Console.WriteLine(program);
            }
            Console.ReadKey();
        }
    }
}
