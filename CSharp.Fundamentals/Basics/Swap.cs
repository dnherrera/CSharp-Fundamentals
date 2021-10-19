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

            int x = 10, y = 90;
            var xy = (x, y) = (y, x);

            Console.WriteLine($"The value of x now is : {xy.x}");
            Console.WriteLine($"The value of y now is : {xy.y}");
        }
    }
}
