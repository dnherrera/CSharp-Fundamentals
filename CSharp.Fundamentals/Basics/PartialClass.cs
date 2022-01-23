using System;

namespace CSharp.Fundamentals.Basics
{
    /// <summary>
    ///  class whose definition is present in 2 or more files
    /// </summary>
    class PartialClass
    {
        public static void Main()
        {
            Student StudentObject = new Student();
            StudentObject.Study();
            StudentObject.Play();
        }
    }

    public partial class Student
    {
        public void Study()
        {
            Console.WriteLine("I am studying");
        }
    }
    public partial class Student
    {
        public void Play()
        {
            Console.WriteLine("I am Playing");
        }
    }
}
