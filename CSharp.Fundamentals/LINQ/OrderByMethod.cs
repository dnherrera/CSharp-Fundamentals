using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.LINQ
{
    /// <summary>
    /// Linq OrderBy method in C# is used to sort the data in ascending order
    /// </summary>
    class OrderByMethod
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>() { "Preety", "Tiwary", "Agrawal", "Priyanka", "Dewangan",
            "Hina","Kumar","Manoj", "Rout", "James"};

            //Using Method Syntax
            var MS = stringList.OrderBy(name => name);

            //Using Query Syntax
            var QS = (from name in stringList
                      orderby name ascending
                      select name).ToList();

            foreach (var item in MS)
            {
                Console.WriteLine(item + " ");
            }

            Console.ReadKey();
        }

    }
}
