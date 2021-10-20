using System;

namespace CSharp.Fundamentals.Overloading
{
    /// <summary>
    /// The first and the simplest category of method overloading is when the methods have a different number of parameters in their signatures.
    /// </summary>
    public class DifferentNumberOfParams
    {
        public static void Main(string[] args)
        {
            Func(10);
        }

        public static void Func(int a)
        {
            Console.WriteLine("Single Parameter");
        }

        public static void Func(int a, string b)
        {
            Console.WriteLine("Multiple Parameters");
        }
    }
}
