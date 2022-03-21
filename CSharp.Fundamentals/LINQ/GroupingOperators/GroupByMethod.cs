using System;
using System.Collections.Generic;
using System.Linq;
using CSharp.Fundamentals.LINQ.Models;

namespace CSharp.Fundamentals.LINQ.GroupingOperators
{
    /// <summary>
    /// Linq GroupBy in C# belongs to the Grouping Operators category and exactly does the same thing as the Group By clause does in SQL Query. 
    /// This method takes a flat sequence of elements and then organizes the elements into groups (i.e. IGrouping<TKey, TSource>) based on a given key.
    /// </summary>
    class GroupByMethod
    {
        static void Main(string[] args)
        {
            GroupByLocation();
            GroupByGender();
        }

        /// <summary>
        /// Users with the same location will be stored in the same group where each group having a key and an inner collection. 
        /// Here, the key will be location and the collection will be the user belongs to that particular location.
        /// </summary>
        static void GroupByLocation()
        {
            //Using Method Syntax
            var groupUserByLocation = UserModel.GetGroupByUsers().GroupBy(s => s.Location);

            //Using Query Syntax
            IEnumerable<IGrouping<string, UserModel>> GroupByQS = from std in UserModel.GetGroupByUsers()
                                                                          group std by std.Location;
            //It will iterate through each groups
            foreach (var group in groupUserByLocation)
            {
                Console.WriteLine(group.Key + " : " + group.Count());

                //Iterate through each user of a group
                foreach (var user in group)
                {
                    Console.WriteLine("  Name :" + user.Name + ", Age: " + user.Age + ", Gender :" + user.Gender);
                }
            }
            Console.Read();
        }

        /// <summary>
        /// In the following example, we get the users by Gender. 
        /// But here we first sort the data by Gender in descending order and then sort the user by their name in ascending order.
        /// </summary>
        static void GroupByGender()
        {
            //Using Method Syntax
            var groupByMS = UserModel.GetGroupByUsers().GroupBy(s => s.Gender)
                            //First sorting the data based on key in Descending Order
                            .OrderByDescending(c => c.Key)
                            .Select(std => new
                            {
                                Key = std.Key,
                                //Sorting the data based on name in descending order
                                Users = std.OrderBy(x => x.Name)
                            });

            //Using Query Syntax
            var groupByQS = from std in UserModel.GetGroupByUsers()
                            group std by std.Gender into stdGroup
                            orderby stdGroup.Key descending
                            select new
                            {
                                Key = stdGroup.Key,
                                Users = stdGroup.OrderBy(x => x.Name)
                            };

            //It will iterate through each groups
            foreach (var group in groupByQS)
            {
                Console.WriteLine(group.Key + " : " + group.Users.Count());

                //Iterate through each user of a group
                foreach (var user in group.Users)
                {
                    Console.WriteLine("  Name :" + user.Name + ", Age: " + user.Age + ", Branch :" + user.Location);
                }
            }
            Console.Read();
        }

        
    }
}
