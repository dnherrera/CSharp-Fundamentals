using System;

namespace CSharp.Fundamentals.Pillars
{
    /// <summary>
    /// multiple methods with the same name and with the same signature.
    /// not possible in the same class, must be performed under the child classes.
    /// changing the behavior of a method.
    /// code replacement technique
    /// use virtual keyword - base class, override in the child to implement overriding
    /// </summary>
    class Polymorphism___Overriding
    {
        /// <summary>
        /// superclas
        /// </summary>
        class Class1
        {
            public virtual void show()
            {
                Console.WriteLine("Super class show method");
            }
        }

        /// <summary>
        /// sub class
        /// </summary>
        /// <seealso cref="CSharp.Fundamentals.Pillars.Polymorphism___Overriding.Class1" />
        class Class2 : Class1
        {
            public override void show()
            {
                Console.WriteLine("Sub class override show method");
            }
        }

        class ClassA
        {
            public virtual void show()
            {
                Console.WriteLine("Super class show method");
            }
        }
        class ClassB : ClassA
        {
            // override- allowing to extend the virtual implementation of an inherited method
            public override void show()
            {
                base.show(); // base class - separate method
                Console.WriteLine("Sub class override show method");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Class2 obj = new Class2();
                obj.show(); // Sub class override show method
                Console.ReadKey();

                // Parent class reference holds the child class object reference
                // First: compiler will search for show() in the Class 1 then at Run Time, the CLR --> check the show() in Class2 since the ref var obj holds the Class2 object ref
                Class1 obj2 = new Class2();
                obj2.show(); // Sub class override show method
                Console.ReadKey();

                ClassB objA = new ClassB();
                objA.show(); // Superclass show method, Sub class override method
                Console.ReadKey();
            }
        }
    }
}
