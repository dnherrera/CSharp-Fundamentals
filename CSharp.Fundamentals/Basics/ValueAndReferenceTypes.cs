/*
 In C# types are divided into 2 broad categories
 Value Types = int, float, double, structs, enums, etc.
 bool
 byte
 char
 decimal
 double
 enum
 float
 int
 long
 sbyte
 short
 struct
 uint
 ulong
 ushort

 Reference Types = Interface, Class, Delegates, Arrays, string, etc.

 Nullable types bridge the differences between C# types and Database types.
 Default : 
     Value Types are non-nullable. 
     Reference Type Variable is Null
 */

using System;


public class ValueAndReferenceTypes
{
    static void Main()
    {
        // Nullable
        Console.WriteLine("Nullable");

        int? ticketOnSale = null;

        int availableTickets;

        if (ticketOnSale == null)
        {
            availableTickets = 0;
        }
        else
        {
            availableTickets = (int)ticketOnSale;
        }

        Console.WriteLine("Available Tickets = {0}", availableTickets);
        Console.WriteLine("-------------------------------------------");


        // Passing Value Type Variables
        Console.WriteLine("Passing Value Type Variables");

        int i = 100;

        Console.WriteLine(i);   // result : 100
        ChangeValue(i);         // result : 200
        Console.WriteLine(i);   // result : 100 - it wouldn't affect the variable in another method

        Console.WriteLine("-------------------------------------------");


        // Passing Reference Type Variable
        Console.WriteLine("Passing Reference Type Variables");

        Student std1 = new Student();
        std1.StudentName = "Bill";
        ChangeReferenceType(std1);
        Console.WriteLine(std1.StudentName); // result: Steve - it will also be reflected in the calling method

        Console.WriteLine("-------------------------------------------");

        // Passing String
        // String is a reference type, but it is immutable.It means once we assigned a value, it cannot be changed.
        Console.WriteLine("Passing String");

        string name = "Bill";
        ChangeReferenceType(name);
        Console.WriteLine(name); //result : Bill

        Console.WriteLine("-------------------------------------------");
    }

    static void ChangeValue(int x)
    {
        x = 200;
        Console.WriteLine(x);
    }

    static void ChangeReferenceType(Student student)
    {
        student.StudentName = "Steve";
    }

    static void ChangeReferenceType(string student)
    {
        student = "Steve";
    }
}

class Student
{
    public string StudentName { get; set; }
}

