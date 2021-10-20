using System;

namespace CSharp.Fundamentals.Overloading
{
    /// <summary>
    /// When we define an optional parameter in the method signature, the compiler treats it as method overloading.
    /// Note: This takes precedence over Implicit conversion.
    /// </summary>
    public class OptionalParameters
    {
        public static void Main(string[] args)
        {
            Add(1);
        }

        public static void Add(int a, int b = 1)
        {
            Console.WriteLine("Int-Int Params"); // Result -  Pass the default value of the optional argument.
        }

        public static void Add(double a)
        {
            Console.WriteLine("Double param."); // implicitly convert the argument to match the method signature
        }
    }
}
