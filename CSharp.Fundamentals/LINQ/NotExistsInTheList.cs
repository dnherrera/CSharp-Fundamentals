using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.LINQ
{
    class NotExistsInTheList
    {
        static void Main(string[] args)
        {
            var statuses = new List<string>
            {
                "Success",
                "Failed",
                "Cancelled"
            };

            var statusToCheck = "Pending";
            var isExists = statuses.Select(x => x.ToLower()).Contains(statusToCheck.ToLower());

            if (isExists)
            {
                Console.WriteLine($"Status {statusToCheck} is in the list.");
            }
            else
            {
                Console.WriteLine($"Status {statusToCheck} is not the list.");
            }
        }
    }
}
