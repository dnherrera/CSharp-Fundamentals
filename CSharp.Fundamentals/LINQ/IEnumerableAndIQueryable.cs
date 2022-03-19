using System;
using System.Collections.Generic;
using System.Linq;
using CSharp.Fundamentals.LINQ.Models;

/// <summary>
/// IEnumerable is an interface that is available in System.Collection namespace.
/// The IEnumerable interface is a type of iteration design pattern
/// All the collection classes (both generic and non-generic) implements the IEnumerable interface.
/// 
/// 
/// IQueryable is an interface and it is available in System.Linq namespace.
/// The IQueryable interface is a child of the IEnumerable interface.
/// The IQuerable interface has a property called Provider which is of type IQueryProvider interface.
/// this is the best choice for other data providers such as Linq to SQL, Linq to Entities, etc.
/// </summary>
/// 
/*IEnumerable:
1. IEnumerable is an interface that is available in the System.Collections namespace.
2. While querying the data from the database, the IEnumerable executes the “select statement” on the server-side(i.e.on the database), loads data into memory on the client-side, and then only applied the filters on the retrieved data.
3. So you need to use the IEnumerable when you need to query the data from in-memory collections like List, Array, and so on.
4. The IEnumerable is mostly used for LINQ to Object and LINQ to XML queries.
5. The IEnumerable collection is of type forward only. That means it can only move in forward, it can’t move backward and between the items.
6. IEnumerable supports deferred execution.
7. It doesn’t support custom queries.
8. The IEnumerable doesn’t support lazy loading. Hence, it is not suitable for paging like scenarios.

IQueryable:
1. The IQueryable is an interface that exists in the System.Linq Namespace.
2. While querying the data from a database, the IQueryable executes the “select query” with the applied filter on the server-side i.e.on the database, and then retrieves data.
3. So you need to use the IQueryable when you want to query the data from out-memory such as remote database, service, etc.
4. IQueryable is mostly used for LINQ to SQL and LINQ to Entities queries.
5. The collection of type IQueryable can move only forward, it can’t move backward and between the items.
6. IQueryable supports deferred execution.
7. It also supports custom queries using CreateQuery and Executes methods.
8. IQueryable supports lazy loading and hence it is suitable for paging like scenarios.*/

namespace CSharp.Fundamentals.LINQ
{
    class IEnumerableAndIQueryable
    {
        static void Main(string[] args)
        {
            var studentList = StudentModel.GetStudentList();

            //Linq Query to Fetch all students with Gender Male
            IEnumerable<StudentModel> querySyntax = from std in studentList
                                               where std.Gender == "Male"
                                               select std;
            //Iterate through the collection
            foreach (var student in querySyntax)
            {
                Console.WriteLine($"ID : {student.ID}  Name : {student.Name}");
            }
            Console.ReadKey();

            //-------------------------------------------------------------------------------------------------

            //Linq Query to Fetch all students with Gender Male
            IQueryable<StudentModel> methodSyntax = studentList.AsQueryable()
                                .Where(std => std.Gender == "Male");

            //Iterate through the collection
            foreach (var student in methodSyntax)
            {
                Console.WriteLine($"ID : {student.ID}  Name : {student.Name}");
            }
            Console.ReadKey();
        }
    }
}
