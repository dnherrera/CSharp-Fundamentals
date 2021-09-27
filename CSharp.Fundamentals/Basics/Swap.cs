using System;

namespace CSharp.Fundamentals.Basics
{
    public class Swap
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;

            a = a * b; //50
            b = a / b; // 5
            a = a / b; //10

            Console.WriteLine($"The Value of A is {a}");
            Console.WriteLine($"The value of B is {b}");
        }
    }
}
