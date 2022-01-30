using System;

namespace CSharp.Fundamentals.AccessModifiers
{
    public class ProtectedModifier
    {
        static void Main(string[] args)
        {
            void Display()
            {
                ParentClass num = new ParentClass();
                //Console.WriteLine(num.number); // Cannot access because the Protected Modifier class is not inherit from the Parent Class.
            }
        }
    }

    class ParentClass
    {
        protected int number = 10; //we can access this variable inside this class
    }

    class ChildClass : ParentClass 
    {
        void Display()
        {
            Console.WriteLine(number); //we can access it in this class as well because it inherit from the Parent class
        }
    }
}
