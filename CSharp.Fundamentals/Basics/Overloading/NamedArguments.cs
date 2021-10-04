using System;

namespace CSharp.Fundamentals.Basics.Overloading
{
    /// <summary>
    /// C# has another feature of passing in the name of the arguments while calling the method. 
    /// This helps in method overloading as well. 
    /// Developers can choose to call a particular method even if the argument passed would have by default called another method. 
    /// Although, the overloaded methods must differ in the signature.
    /// </summary>
    public class NamedArguments
    {
        public static void Main(string[] args)
        {
            Add(b: 10);
        }

        public static void Add(int a)
        {
            Console.WriteLine("Integer Param");
        }

        public static void Add(double b)
        {
            Console.WriteLine("Double Param"); // Result
        }
    }
}
