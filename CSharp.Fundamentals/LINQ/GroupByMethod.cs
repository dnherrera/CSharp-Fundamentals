using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.LINQ
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
            var groupUserByLocation = GroupByMethodUser.GetGroupByUsers().GroupBy(s => s.Location);

            //Using Query Syntax
            IEnumerable<IGrouping<string, GroupByMethodUser>> GroupByQS = from std in GroupByMethodUser.GetGroupByUsers()
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
            var groupByMS = GroupByMethodUser.GetGroupByUsers().GroupBy(s => s.Gender)
                            //First sorting the data based on key in Descending Order
                            .OrderByDescending(c => c.Key)
                            .Select(std => new
                            {
                                Key = std.Key,
                                //Sorting the data based on name in descending order
                                Users = std.OrderBy(x => x.Name)
                            });

            //Using Query Syntax
            var groupByQS = from std in GroupByMethodUser.GetGroupByUsers()
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

        public class GroupByMethodUser
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Location { get; set; }
            public int Age { get; set; }

            public static List<GroupByMethodUser> GetGroupByUsers()
            {
                return new List<GroupByMethodUser>()
            {
                new GroupByMethodUser { ID = 1001, Name = "Preety", Gender = "Female",
                                             Location = "CSE", Age = 20 },
                new GroupByMethodUser { ID = 1002, Name = "Snurag", Gender = "Male",
                                             Location = "ETC", Age = 21  },
                new GroupByMethodUser { ID = 1003, Name = "Pranaya", Gender = "Male",
                                             Location = "CSE", Age = 21  },
                new GroupByMethodUser { ID = 1004, Name = "Anurag", Gender = "Male",
                                             Location = "CSE", Age = 20  },
                new GroupByMethodUser { ID = 1005, Name = "Hina", Gender = "Female",
                                             Location = "ETC", Age = 20 },
                new GroupByMethodUser { ID = 1006, Name = "Priyanka", Gender = "Female",
                                             Location = "CSE", Age = 21 },
                new GroupByMethodUser { ID = 1007, Name = "santosh", Gender = "Male",
                                             Location = "CSE", Age = 22  },
                new GroupByMethodUser { ID = 1008, Name = "Tina", Gender = "Female",
                                             Location = "CSE", Age = 20  },
                new GroupByMethodUser { ID = 1009, Name = "Celina", Gender = "Female",
                                             Location = "ETC", Age = 22 },
                new GroupByMethodUser { ID = 1010, Name = "Sambit", Gender = "Male",
                                             Location = "ETC", Age = 21 }
            };
            }
        }
    }
}
