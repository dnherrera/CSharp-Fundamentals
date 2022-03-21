using System;
using System.Linq;
using CSharp.Fundamentals.LINQ.Models;

namespace CSharp.Fundamentals.LINQ.GroupingOperators
{
    /// <summary>
    /// Linq ToLookup Method in C# exactly does the same thing as the GroupBy Operator does in Linq. 
    /// The only difference between these two methods is the GroupBy method uses deferred execution whereas the execution of the ToLookup method is immediate. 
    /// </summary>
    class ToLookUpOperator
    {
        static void Main(string[] args)
        {
            var GroupByMS = UserModel.GetGroupByUsers().ToLookup(s => s.Gender)
                            .OrderByDescending(c => c.Key)
                            .Select(std => new
                            {
                                Key = std.Key,
                                Students = std.OrderBy(x => x.Name)
                            });

            foreach (var group in GroupByMS)
            {
                Console.WriteLine(group.Key + " : " + group.Students.Count());
                foreach (var student in group.Students)
                {
                    Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Branch :" + student.Location);
                }
            }
            Console.Read();
        }
    }
}
