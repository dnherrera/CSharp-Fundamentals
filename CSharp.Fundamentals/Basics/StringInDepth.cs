
/*
Strings are reference types in C#
- strings are reference types while other primitive data types are struct types

String(Capital) vs string(small) in C#
- small - use small string to declare variable ie. string userName = ...
- capital - use Capital String to invoke method ie. String.Concat("")

Strings are immutable in C#
- Mutable means can be changed
    **It will not create a fresh memory location each time the loop executes instead it will use the same memory location and update its value**
- Immutable means can not be changed.
    ** It will create a fresh memory**

Why strings are immutable?
- Each time you assign a new value to the string variable, a new object is created and this is the reason why strings are immutable.
- They made Strings as Immutable for Thread Safety

String Interning in C#
- process that uses the same memory location if the value is the same.

StringBuilder for concatenation
- C# string immutability behavior can be very very dangerous when it comes to string concatenation
Ex. The loop executes the first time, it will create a new memory location and store the value “DotNet Tutorials”. 
For the second time, it creates another fresh memory location (fresh object) and stores the value “DotNet Tutorials DotNet Tutorials” 
and the first memory location will be going for garbage collection and so on.



 */

using System;
using System.Diagnostics;
using System.Text;

namespace CSharp.Fundamentals.Basics
{
    public class StringInDepth
    {
        static void Main(string[] args)
        {
            //string str = "";
            //int ctr = 0;
            StringBuilder stringBuilder = new StringBuilder();


            Console.WriteLine("Loop Started");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 30000000; i++)
            {
                //str = Guid.NewGuid().ToString();
                //ctr = ctr + 1;
                //str = "String with Same Value";
                stringBuilder.Append("DotNet Tutorials");
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds); 
            Console.ReadKey();

            /*
             string : 9674 MS **It will create a new value and assign it to the str variable.
             int : 84 MS **It will not create a fresh memory location each time the loop executes instead it will use the same memory location and update its value
             string with same value : 95 MS **This is because in this case fresh objects are not created each time the loop executes
             StringBuilder : 1093 MS **This is because every time the for loop runs it will not create fresh objects rather than it will use the same memory location.
             */

        }
    }
}
