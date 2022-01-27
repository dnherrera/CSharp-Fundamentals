using System;
using System.Collections.Generic;

namespace CSharp.Fundamentals.Basics
{
    class Test_A
    {
        static void Main(string[] args)
        {
            var testData = new int[] { 1, 3, 6, 4, 1, 2 };

            Console.WriteLine(Function(testData));
        }

        static int Function(int[] args)
        {
            var found = new HashSet<int>();

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] > 0)
                {
                    found.Add(args[i]);
                }
            }

            int result = 1;
            while (found.Contains(result))
            {
                result++;
            }

            return result;
        }
    }
}
