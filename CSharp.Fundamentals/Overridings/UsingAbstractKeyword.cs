using System;

namespace CSharp.Fundamentals.Overriding
{
    public class UsingAbstractKeyword // Main Class
    {
        public static void Main(string[] args) // Main Method
        {
            Values values = new Values(1, 10);
            int a = values.Sum();
            Console.WriteLine(a);
            Console.ReadLine();

            // In the example, an abstract method is used. An abstract class is implemented by the derived class which contains an abstract method.
            // 11
        }
    }

    public abstract class Calculate // Abstract Class
    {
        public abstract int Sum();
    }

    public class Values : Calculate // Derived Class
    {
        int val1;
        int val2;

        /// <summary>
        /// Initializes a new instance of <see cref="Values"/> class.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Values(int a = 0, int b = 0) // Constuctor
        {
            val1 = a;
            val2 = b;
        }

        public override int Sum() // Override Method
        {
            Console.WriteLine("Sum of two values: ");
            return (val1 + val2);
        }
    }
}
