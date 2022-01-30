using System;

namespace CSharp.Fundamentals.AccessModifiers
{
    public class PrivateModifier
    {
        static void Main(string[] args)
        {
            GetNumber num = new GetNumber();
            //Console.WriteLine(num.number); // number variable can only accessible within its class.
        }
    }

    public class GetNumber
    {
        private int number = 10;
    }
}
