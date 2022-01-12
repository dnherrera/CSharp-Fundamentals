using System;

namespace CSharp.Fundamentals.Basics
{
    /// <summary>
    /// <see cref="https://www.freelancer.com/community/articles/top-16-c-programming-tips-tricks"/>
    /// <seealso cref="https://www.tutorialsteacher.com/csharp/csharp-tuple"/>
    /// </summary>
    public class Tuples
    {
        static void Main(string[] args)
        {
            var person = Tuple.Create(1, "Steve", "Jobs");
            DisplayTuple(person);

            Console.WriteLine(GetPerson());
        }

       
        static void DisplayTuple(Tuple<int, string, string> person)
        {
            Console.WriteLine($"Id = { person.Item1}");
            Console.WriteLine($"First Name = { person.Item2}");
            Console.WriteLine($"Last Name = { person.Item3}");
        }

        static Tuple<int, string, string> GetPerson()
        {
            return Tuple.Create(1, "Bill", "Gates");
        }
    }
}
