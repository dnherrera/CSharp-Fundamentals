using System;

namespace CSharp.Fundamentals.Basics.Overloading
{
    /// <summary>
    /// When the number and type of arguments are the same, but the order in which they are passed differs.
    /// </summary>
    public class DifferentOrderOfParams
    {
        public static void Main(string[] args)
        {
            Add(1, 10.1);
        }

        public static void Add(int a, double b)
        {
            Console.WriteLine("Add Int-Double"); // Result
        }

        public static void Add(double a, int b)
        {
            Console.WriteLine("Add Double-Int");
        }
    }
}
