using System.Collections.Generic;

namespace CSharp.Fundamentals.LINQ.Models
{
    class UserModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public int DepartmentId { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
        public static List<UserModel> GetAllEmployees()
        {
            return new List<UserModel>()
            {
                new UserModel { ID = 1, Name = "Preety", AddressId = 1, DepartmentId = 10    },
                new UserModel { ID = 2, Name = "Priyanka", AddressId = 2, DepartmentId =20   },
                new UserModel { ID = 3, Name = "Anurag", AddressId = 3, DepartmentId = 30    },
                new UserModel { ID = 4, Name = "Pranaya", AddressId = 4, DepartmentId = 0    },
                new UserModel { ID = 5, Name = "Hina", AddressId = 5, DepartmentId = 0       },
                new UserModel { ID = 6, Name = "Sambit", AddressId = 6, DepartmentId = 0     },
                new UserModel { ID = 7, Name = "Happy", AddressId = 7, DepartmentId = 0      },
                new UserModel { ID = 8, Name = "Tarun", AddressId = 8, DepartmentId = 0      },
                new UserModel { ID = 9, Name = "Santosh", AddressId = 9, DepartmentId = 10   },
                new UserModel { ID = 10, Name = "Raja", AddressId = 10, DepartmentId = 20    },
                new UserModel { ID = 11, Name = "Ramesh", AddressId = 11, DepartmentId = 30  }
            };
        }

        public static List<UserModel> GetGroupByUsers()
        {
            return new List<UserModel>()
            {
                new UserModel { ID = 1001, Name = "Preety", Gender = "Female",
                                             Location = "CSE", Age = 20 },
                new UserModel { ID = 1002, Name = "Snurag", Gender = "Male",
                                             Location = "ETC", Age = 21  },
                new UserModel { ID = 1003, Name = "Pranaya", Gender = "Male",
                                             Location = "CSE", Age = 21  },
                new UserModel { ID = 1004, Name = "Anurag", Gender = "Male",
                                             Location = "CSE", Age = 20  },
                new UserModel { ID = 1005, Name = "Hina", Gender = "Female",
                                             Location = "ETC", Age = 20 },
                new UserModel { ID = 1006, Name = "Priyanka", Gender = "Female",
                                             Location = "CSE", Age = 21 },
                new UserModel { ID = 1007, Name = "santosh", Gender = "Male",
                                             Location = "CSE", Age = 22  },
                new UserModel { ID = 1008, Name = "Tina", Gender = "Female",
                                             Location = "CSE", Age = 20  },
                new UserModel { ID = 1009, Name = "Celina", Gender = "Female",
                                             Location = "ETC", Age = 22 },
                new UserModel { ID = 1010, Name = "Sambit", Gender = "Male",
                                             Location = "ETC", Age = 21 }
            };
        }

    }
}
