using System;

namespace CSharp.Fundamentals.Basics
{
    /// <summary>
    /// Type-safe function pointer that holds reference of a method then calls the method for execution
    /// </summary>
    public delegate void SampleDelegate();

    class Delegates
    {
        static void Main()
        {
            // In this example del is a multicast delegate. You use += operator 
            // to chain delegates together and -= operator to remove.
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;
            del += SampleMethodThree;
            del -= SampleMethodTwo;
            del();
        }


        public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }

        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }

    }
}
