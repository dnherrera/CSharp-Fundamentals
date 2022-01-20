using System;

namespace CSharp.Fundamentals.Pillars
{
    /// <summary>
    /// behaving in different ways depending on the input received, ability to take more than one form
    /// defining multiple behaviors to a method.
    /// code refinement technique.
    /// </summary>
    class Polymorphism
    {
        /// <summary>
        /// Constructor overloading
        /// </summary>
        class ConstructorOverloading
        {
            int x, y, z;

            /// <summary>
            /// Initializes a new instance of the <see cref="ConstructorOverloading"/> class.
            /// </summary>
            /// <param name="x">The x.</param>
            public ConstructorOverloading(int x)
            {
                this.x = 10;
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="ConstructorOverloading"/> class.
            /// </summary>
            /// <param name="x">The x.</param>
            /// <param name="y">The y.</param>
            public ConstructorOverloading(int x, int y)
            {
                this.x = x;
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="ConstructorOverloading"/> class.
            /// </summary>
            /// <param name="x">The x.</param>
            /// <param name="y">The y.</param>
            /// <param name="z">The z.</param>
            public ConstructorOverloading(int x, int y, int z)
            {
                this.x = x;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                ADD2 obj = new ADD2();
                obj.add(10, 20);
                obj.add(10.5f, 20.5f);
                obj.add("pranaya", "kumar");
                Console.WriteLine("Press any key to exist.");
                Console.ReadKey();

                ConstructorOverloading obj1 = new ConstructorOverloading(10);
                ConstructorOverloading obj2 = new ConstructorOverloading(10, 20);
                ConstructorOverloading obj3 = new ConstructorOverloading(10, 20, 30);
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Parent
        /// </summary>
        class ADD1
        {
            public void add(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            public void add(float x, float y)
            {
                Console.WriteLine(x + y);
            }
        }

        /// <summary>
        /// Child - Inheritance-Based Overloading
        /// </summary>
        /// <seealso cref="CSharp.Fundamentals.Pillars.Polymorphism.ADD1" />
        class ADD2 : ADD1
        {
            public void add(string s1, string s2)
            {
                Console.WriteLine(s1 + s2);
            }
        }
       
    }
}
