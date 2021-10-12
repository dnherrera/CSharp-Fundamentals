using System;

namespace CSharp.Fundamentals.Algorithms
{
    public class BasicAlgo_0003_Boolean
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsEqualsToThirty(30, 0) + " Should be TRUE");
            Console.WriteLine(IsEqualsToThirty(25, 5) + " Should be TRUE");
            Console.WriteLine(IsEqualsToThirty(20, 30) + " Should be TRUE");
            Console.WriteLine(IsEqualsToThirty(20, 25) + " Should be FALSE");
        }

        public static bool IsEqualsToThirty(int x, int y)
        {
            return x == 30 || y == 30 || (x + y == 30);
        }
    }
}
