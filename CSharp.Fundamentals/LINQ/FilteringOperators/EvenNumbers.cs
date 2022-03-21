using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.FilteringOperators
{
    /*
     Write a program in C# Sharp to shows how the three parts of a query operation execute. Go to the editor
     Expected Output:
     The numbers which produce the remainder 0 after divided by 2 are :
     0 2 4 6 8
     */
    public class EvenNumbers
    {
        public static void Main(string[] args)
        {
            // First - Data Source
            int[] testData = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Second - Query Creation
            var collection1 = GetEvenNumberByLambda(testData);
            
            // Third - Query Execution
            foreach(var item in collection1)
            {
                Console.Write("{0} ", item);
            }

            Console.Write("\n\n");

            var collection2 = GetEvenNumberByMethod(testData);
            foreach (int num in collection2)
            {
                Console.Write("{0} ", num);
            }
        }

        public static IEnumerable<int> GetEvenNumberByMethod(int[] request)
        {
            return from num in request
                   where (num % 2) == 0
                   select num;
        }

        public static IEnumerable<int> GetEvenNumberByLambda(int[] request)
        {
            return request.Where(x => x % 2 == 0);
        }
    }
}
