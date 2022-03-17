using System.Collections.Generic;

namespace CSharp.Fundamentals.LINQ.Joins
{
    class AddressModel
    {
        public int ID { get; set; }
        public string AddressLine { get; set; }
        public static List<AddressModel> GetAllAddresses()
        {
            return new List<AddressModel>()
            {
                new AddressModel { ID = 1, AddressLine = "AddressLine1"},
                new AddressModel { ID = 2, AddressLine = "AddressLine2"},
                new AddressModel { ID = 3, AddressLine = "AddressLine3"},
                new AddressModel { ID = 4, AddressLine = "AddressLine4"},
                new AddressModel { ID = 5, AddressLine = "AddressLine5"},
                new AddressModel { ID = 9, AddressLine = "AddressLine9"},
                new AddressModel { ID = 10, AddressLine = "AddressLine10"},
                new AddressModel { ID = 11, AddressLine = "AddressLine11"},
            };
        }
    }
}
