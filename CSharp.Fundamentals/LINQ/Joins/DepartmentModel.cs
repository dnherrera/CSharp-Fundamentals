using System.Collections.Generic;

namespace CSharp.Fundamentals.LINQ.Joins
{
    public class DepartmentModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<DepartmentModel> GetAllDepartments()
        {
            return new List<DepartmentModel>()
                {
                    new DepartmentModel { ID = 10, Name = "IT"       },
                    new DepartmentModel { ID = 20, Name = "HR"       },
                    new DepartmentModel { ID = 30, Name = "Payroll"  },
                };
        }
    }
}
