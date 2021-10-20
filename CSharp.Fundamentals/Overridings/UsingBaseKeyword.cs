using System;

namespace CSharp.Fundamentals.Overriding
{
    /// <summary>
    /// Implementation of Overriding with base keyword
    /// </summary>
    public class UsingBaseKeyword // Main method
    {
        public static void Main(string[] args)
        {
            Airplane childClass = new Airplane();
            childClass.Start();
            Console.ReadLine();

            // In the below example, the base is used in a derived class to call the base class method. So in this base method is called first and then the derived method.
            // Car is starting
            // Airplane is starting
        }
    }

    public class Car // Base Class
    {
        public virtual void Start() // Base Class Method
        {
            Console.WriteLine("Car is starting.");
        }
    }

    public class Airplane : Car // Derived class
    {
        public override void Start() // Derived class method.
        {
            base.Start(); // base is used to call parent method
            Console.WriteLine("Airplane is starting");
        }
    }
}
