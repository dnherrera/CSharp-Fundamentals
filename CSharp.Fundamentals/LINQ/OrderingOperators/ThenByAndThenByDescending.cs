using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.OrderingOperators
{
    /// <summary>
    /// ThenBy Method in C# is used to sort the data in ascending order from the second level onwards.
    /// ThenByDescending Method in C# is used to sort the data in descending order also from the second level onwards.
    /// </summary>
    class ThenByAndThenByDescending
    {
        static void Main(string[] args)
        {
            //Method Syntax
            var MS = Estudiante.GetAllEstudiantes()
                              .OrderBy(x => x.FirstName)
                              .ThenByDescending(y => y.LastName)
                              .ToList();

            foreach (var student in MS)
            {
                Console.WriteLine("First Name :" + student.FirstName + ", Last Name : " + student.LastName);
            }
            Console.ReadKey(); // Jarin will come first followed by Herrera in the name of Sam using ThenByDescending
        }
    }

    public class Estudiante
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Branch { get; set; }
        public static List<Estudiante> GetAllEstudiantes()
        {
            List<Estudiante> listEstudiantes = new List<Estudiante>()
            {
                new Estudiante{ID= 101,FirstName = "Sam",LastName = "Jarin",Branch = "CSE"},
                new Estudiante{ID= 102,FirstName = "Sam",LastName = "Herrera",Branch = "ETC"},
                new Estudiante{ID= 103,FirstName = "Sally",LastName = "Tabing",Branch = "ETC"},
                new Estudiante{ID= 104,FirstName = "Jose",LastName = "Herrera",Branch = "ETC"},
                new Estudiante{ID= 105,FirstName = "Charm",LastName = "Monzon",Branch = "CSE"},
            };
            return listEstudiantes;
        }
    }
}
