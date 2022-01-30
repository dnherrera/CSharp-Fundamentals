using System;

namespace CSharp.Fundamentals.AccessModifiers
{
    //First Project - CSharp Fundamentals
    public class InternalModifier
    {
        static void Main(string[] args)
        {
            GetClassInFirstProject num = new GetClassInFirstProject();
            Console.WriteLine(num.number); // can access the variable within its assembly
        }
    }
    public class GetClassInFirstProject
    {
        internal int number = 10; //we can access this variable inside this class
    }

   
}
