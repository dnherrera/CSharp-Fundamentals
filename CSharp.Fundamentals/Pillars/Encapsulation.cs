using System;

namespace CSharp.Fundamentals.Pillars
{
    /// <summary>
    /// by hiding its internal data members from outside the class and accessing those internal data members only through publicly exposed methods (setter and getter methods)
    /// </summary>
    class Encapsulation
    {
        public class Example
        {
            private int x; // internal data member
            public int getX() // public method
            {
                return x;
            }
            public void setX(int x)
            {
                if (x > 0)
                {
                    this.x = x;
                }
                else
                {
                    Console.WriteLine("Please Pass a positive value");
                }
            }
        }
        class Sample
        {
            public static void Main()
            {
                Example e = new Example();
                //We cannot use the variable directly here
                // e.x = 50; //Compile time errr
                // Console.WriteLine(e.x); //Compile time errr
                e.setX(10);
                Console.WriteLine(e.getX());
                e.setX(-50);
                Console.WriteLine(e.getX());
                Console.WriteLine("Press any key to exist");
                Console.ReadKey();
            }
        }
    }
}
