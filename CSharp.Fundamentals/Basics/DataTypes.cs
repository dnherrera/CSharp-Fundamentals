/*
 Data Types
 - Data type in C# specifies the type of data that a variable can store such as integer, floating, character, string, etc
 
1. Value - Data type which stores the value directly
2. Reference - Used to store the reference of a variable
3. Pointer - Locator or indicator that points to an address of the value

Value DT

    Predefined Data Types – Example includes Integer, Boolean, Float, etc.
    User-defined Data Types – Example includes Structure, Enumerations, etc.

Reference DT

    Predefined Types – Examples include Objects, String, and dynamic.
    User-defined Types – Examples include Classes, Interface.

Escape Sequence in C#

    Verbatim Literal is a string with an @ symbol prefix, as in @“Hello”.
    
    Without Verbatim Literal: “C:\\Pranaya\\DotNetTutorials\\Csharp” – Less Readable
    With Verbatim Literal: @“C:\Pranaya\ DotNetTutorials\Csharp” – Better Readable

 */

using System;

namespace CSharp.Fundamentals.Basics
{
    public class DataTypes
    {
        static void Main(string[] args)
        {
            // Displaying double quotes in c#
            string Name = "\"Dotnettutorials\"";
            Console.WriteLine(Name);

            // Displaying new line character in c#
            Name = "One\nTwo\nThree";
            Console.WriteLine(Name);

            // Displaying new line character in c#
            Name = "c:\\Pranaya\\Dotnettutorials\\Csharp";
            Console.WriteLine(Name);

            // C# verbatim literal
            Name = @"c:\Pranaya\Dotnettutorials\Csharp";
            Console.WriteLine(Name);
            Console.ReadKey();
        }
    }
}
