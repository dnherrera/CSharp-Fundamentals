using System;
using System.Linq;
using CSharp.Fundamentals.LINQ.Models;

namespace CSharp.Fundamentals.LINQ.GroupingOperators
{
    /// <summary>
    /// when you are using multiple keys in Group By operator then the data returned is an anonymous type.
    /// </summary>
    class GroupByMultipleKeys
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            var GroupByMultipleKeysMS = UserModel.GetGroupByUsers()
                                        .GroupBy(x => new { x.Location, x.Gender })
                                        .OrderByDescending(g => g.Key.Location).ThenBy(g => g.Key.Gender)
                                        .Select(g => new
                                        {
                                            Branch = g.Key.Location,
                                            Gender = g.Key.Gender,
                                            Students = g.OrderBy(x => x.Name)
                                        });

            //Using Query Syntax
            var GroupByMultipleKeysQS = from student in UserModel.GetGroupByUsers()
                                        group student by new
                                        {
                                            student.Location,
                                            student.Gender
                                        } into stdGroup
                                        orderby stdGroup.Key.Location descending,
                                                stdGroup.Key.Gender ascending
                                        select new
                                        {
                                            Branch = stdGroup.Key.Location,
                                            Gender = stdGroup.Key.Gender,
                                            Students = stdGroup.OrderBy(x => x.Name)
                                        };

            //It will iterate through each group
            foreach (var group in GroupByMultipleKeysQS)
            {
                Console.WriteLine($"Location : {group.Branch} Gender: {group.Gender} No of Students = {group.Students.Count()}");
                
                //It will iterate through each item of a group
                foreach (var student in group.Students)
                {
                    Console.WriteLine($"  ID: {student.ID}, Name: {student.Name}, Age: {student.Age} ");
                }

                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
