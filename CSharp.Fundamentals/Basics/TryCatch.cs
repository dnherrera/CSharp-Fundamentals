using System;

namespace CSharp.Fundamentals.Basics
{
    public class TryCatch
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(DivideByZero(10));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static int DivideByZero(int x)
        {
            int y = 0;
            return x / y;
        }
    }
}
