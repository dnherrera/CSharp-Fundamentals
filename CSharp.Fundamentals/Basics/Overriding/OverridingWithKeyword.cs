using System;

namespace CSharp.Fundamentals.Basics.Overriding
{
    /// <summary>
    /// Implementationg of Overriding with Keywords
    /// </summary>
    public class OverridingWithKeyword // Main Program
    {
        public static void Main(string[] args)
        {
            Fish childClass = new Fish();
            childClass.Swim();
            Console.ReadLine();

            // This example is the same as the without keywords example but this child method is used for reference.
            // Fish is swimming
        }
    }

    public class Swan // base class
    {
        /// <summary>
        /// The method signature of a derived class should be the same as a base class.
        /// Access modifiers (i.e. public) must be the same for virtual methods and override methods.
        /// </summary>
        public virtual void Swim() 
        {
            Console.WriteLine("Swans are swimming");
        }
    }

    public class Fish : Swan // derived class
    {
        public override void Swim() // used as reference
        {
            Console.WriteLine("Fish is swimming");
        }
    }
}
