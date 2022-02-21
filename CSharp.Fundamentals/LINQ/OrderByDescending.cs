using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.LINQ
{
    class OrderByDescending
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>() { "Preety", "Tiwary", "Agrawal", "Priyanka", "Dewangan",
            "Hina","Kumar","Manoj", "Rout", "James"};
            //Using Method Syntax
            var MS = stringList.OrderByDescending(name => name);
            //Using Query Syntax
            var QS = (from name in stringList
                      orderby name descending
                      select name).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadKey();
        }
    }
}
