using System;
using System.Linq;

namespace CSharp.Fundamentals.LINQ.QuantifierOperators
{
    /// <summary>
    /// C# Linq Any Operator is used to check whether at least one of the elements of a data source satisfies a given condition or not. 
    /// </summary>
    class AnyOperator
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "James", "Sachin", "Sourav", "Pam", "Sara" };

            //Method Syntax
            var ResultMS = stringArray.Any(name => name.Length > 5);

            //Query Syntax
            var ResultQS = (from name in stringArray
                            select name).Any(name => name.Length > 5);

            Console.WriteLine("Is Any name with length  greater than 5 Characters : " + ResultMS);
            Console.ReadKey();
        }
    }
}
