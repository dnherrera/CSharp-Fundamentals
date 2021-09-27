using System;

namespace CSharp.Fundamentals.Basics
{
    class RightTriangle
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 10; j >= i; j--)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }
}
