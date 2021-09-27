using System;

namespace CSharp.Fundamentals.Basics
{
    public class EvenOrOdd
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
