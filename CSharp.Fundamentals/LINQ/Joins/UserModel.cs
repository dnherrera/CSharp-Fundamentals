using System.Collections.Generic;

namespace CSharp.Fundamentals.LINQ.Joins
{
    class UserModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public static List<UserModel> GetAllEmployees()
        {
            return new List<UserModel>()
            {
                new UserModel { ID = 1, Name = "Preety", AddressId = 1 },
                new UserModel { ID = 2, Name = "Priyanka", AddressId = 2 },
                new UserModel { ID = 3, Name = "Anurag", AddressId = 3 },
                new UserModel { ID = 4, Name = "Pranaya", AddressId = 4 },
                new UserModel { ID = 5, Name = "Hina", AddressId = 5 },
                new UserModel { ID = 6, Name = "Sambit", AddressId = 6 },
                new UserModel { ID = 7, Name = "Happy", AddressId = 7},
                new UserModel { ID = 8, Name = "Tarun", AddressId = 8 },
                new UserModel { ID = 9, Name = "Santosh", AddressId = 9 },
                new UserModel { ID = 10, Name = "Raja", AddressId = 10},
                new UserModel { ID = 11, Name = "Sudhanshu", AddressId = 11}
            };
        }
    }
}
