/*
 Overriding is the re-implementation of a base class method in a derived class.
 The base class method is overriden in the child.
 The derived/child class method has the same name and signature as base class method.

 Keywords:
 1. virtual - used with a base class which signifies that the method of a base class can be overriden
 2. override - used with a derived class which signifies that derived class overrides a method of a base class.
 3. base - used in a derivced class to call the class base method.

 Rules:
 1. The method signature of a derived class should be the same as a base class.
 2. Overriding is not possible in the same class.
 3. Access modifiers must be the same for virtual methods and override methods.
 4. The virtual keyword is used in the base class method and Override is used in a derived class method.
 5. The base class method should not be static.
 
 */

using System;

namespace CSharp.Fundamentals.Overriding
{
    /// <summary>
    /// Implementation of Overriding without Virtual or Override Keywords
    /// </summary>
    public class WithoutKeywords // Main Program
    {
        public static void Main(string[] args)
        {
            Bird baseClass = new Peacock();
            baseClass.fly();
            Console.ReadLine();

            // Result: So in this case when no keyword is used, the parent method is called instead of a child method.
            // Birds are flying.
        }
    }

    public class Bird // base class
    {
        public void fly() // base class method
        {
            Console.WriteLine("Birds are flying");
        }
    }

    public class Peacock : Bird // derived class
    {
        public new void fly()
        {
            Console.WriteLine("Peacock is flying");
        }
    }
}
