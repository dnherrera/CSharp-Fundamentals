using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.OrderingOperators
{
    /// <summary>
    /// LINQ Reverse method is used to reverse the data stored in a data source
    /// </summary>
    class ReverseMethod
    {
        static void Main(string[] args)
        {
            ReverseUsingCollectionGeneric();
            ReverseUsingLinq();
            ReverseList();
            ReverseUsingQuerySyntax();
        }

        static void ReverseList()
        {
            List<string> stringList = new List<string>() { "Preety", "Tiwary", "Agrawal", "Priyanka", "Dewangan" };
            Console.WriteLine("Before Reverse the Data");
            foreach (var name in stringList)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            IEnumerable<string> ReverseData1 = stringList.AsEnumerable().Reverse();
            IQueryable<string> ReverseData2 = stringList.AsQueryable().Reverse();
            Console.WriteLine("After Reverse the Data");
            foreach (var name in ReverseData1)
            {
                Console.Write(name + " ");
            }
            Console.ReadKey();
        }

        static void ReverseUsingCollectionGeneric()
        {
            List<string> stringList = new List<string>() { "Preety", "Tiwary", "Agrawal", "Priyanka", "Dewangan" };

            Console.WriteLine("Before Reverse the Data");
            foreach (var name in stringList)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            //You cannot store the data like below as this method belongs to
            //System.Collections.Generic namespace whose return type is void
            //IEnumerable<int> ArrayReversedData = stringList.Reverse();
            stringList.Reverse();
            Console.WriteLine("After Reverse the Data");
            foreach (var name in stringList)
            {
                Console.Write(name + " ");
            }
            Console.ReadKey();
        }

        static void ReverseUsingQuerySyntax()
        {
            int[] intArray = new int[] { 10, 30, 50, 40, 60, 20, 70, 100 };
            Console.WriteLine("Before Reverse the Data");
            foreach (var number in intArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            IEnumerable<int> ArrayReversedData = (from num in intArray
                                                  select num).Reverse();
            Console.WriteLine("After Reverse the Data");
            foreach (var number in ArrayReversedData)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }

        static void ReverseUsingLinq()
        {
            int[] intArray = new int[] { 10, 30, 50, 40, 60, 20, 70, 100 };
            Console.WriteLine("Before Reverse the Data");
            foreach (var number in intArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            IEnumerable<int> ArrayReversedData = intArray.Reverse();
            Console.WriteLine("After Reverse the Data");
            foreach (var number in ArrayReversedData)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }
    }
}
