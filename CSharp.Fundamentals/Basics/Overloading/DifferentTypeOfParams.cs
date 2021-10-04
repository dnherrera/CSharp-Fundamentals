using System;

namespace CSharp.Fundamentals.Basics.Overloading
{
    /// <summary>
    /// In the example below, both methods expect a single argument. So, based on the type of the argument passed during the method call,
    /// the compiler binds the appropriate method definition.
    /// </summary>
    public class DifferentTypeOfParams
    {
        public static void Main(string[] args)
        {
            Create("Create!!!");
        }

        public static void Create(string a)
        {
            Console.WriteLine("String Create.");
        }

        public static void Create(int b)
        {
            Console.WriteLine("Integer Create.");
        }
    }

    /*
     Now, let us give the compiler something to think. We would overload a double and a float type method. 
     We know that an integer can always be implicitly converted into a float type as well as a double type.

     When we pass an integer argument, the compiler checks for implicit conversion and finds that the best possible conversion is an integer to float. 
     Hence, the float method is called.
     */
}
