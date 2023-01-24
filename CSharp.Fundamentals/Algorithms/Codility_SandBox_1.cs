using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Fundamentals.Algorithms
{
    public class Codility_SandBox_1
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            string testData = "ahere3 More3 bird Hey";

            Console.WriteLine(CountNumberofAllWords(testData));
            Console.WriteLine(Count2(testData));
            Console.WriteLine(Count3(testData));
            Console.WriteLine(Count4(testData));
            Console.WriteLine(Count5(testData));
            Console.WriteLine(Count6(testData));

            string str = "a";
            int pos = findRepeatFirstN2(str);

            //if (pos == -1)
            //    Console.WriteLine("Not found");
            //else
                Console.WriteLine(str[pos]);
        }

        // Solution
        public static int CountNumberofAllWords(string document)
        {
            var source = document.Split(new char[] { '.', ',', '!', ' ', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            return source.Length;
        }

        public static int Count2(string document)
        {
            var source = document.Split(new char[] { '.', ',', '!', ' ', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            var digits = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var test = source.Select(x => digits.Any(y => x.Contains(y.ToString()))).Count();
            return test;
        }
        public static int Count3(string document)
        {
            var source = document.Split(new char[] { '.', ',', '!', ' ', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            var test = source.Where(x => !string.IsNullOrEmpty(x) && char.IsLower(x[0])).Count();
            return test;
        }
        public static int Count4(string document)
        {
            var source = document.Split(new char[] { '.', ',', '!', ' ', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            var test = source.Where(x => !string.IsNullOrEmpty(x) && char.IsUpper(x[0])).Count();
            return test;
        }

        public static string Count5(string document)
        {
            var source = document.Split(new char[] { '.', ',', '!', ' ', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            return source.OrderByDescending(x => x.Length).FirstOrDefault();
        }

        public static string Count6(string document)
        {
            var source = document.Split(new char[] { '.', ',', '!', ' ', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            return source.OrderBy(x => x.Length).FirstOrDefault();
        }


        static int findRepeatFirstN2(string S)
        {
            // this is O(N^2) method
            int p = -1, i, j;
            for (i = 0; i < S.Length; i++)
            {
                for (j = i + 1; j < S.Length; j++)
                {
                    if (S[i] == S[j])
                    {
                        p = i;
                        break;
                    }
                }
                if (p != -1)
                    break;
            }

            return p;
        }


        public class Stats
        {
            // Total number of all words in the document
            public int NumberOfAllWords { get; set; }

            // Returns number of words that consist only from digits e.g. 13455, 98374
            public int NumberOfWordsThatContainOnlyDigits { get; set; }

            // Returns number of words that start with a lower letter e.g. a, d, z
            public int NumberOfWordsStartingWithSmallLetter { get; set; }

            // Returns number of words that start with a capital letter e.g. A, D, Z
            public int NumberOfWordsStartingWithCapitalLetter { get; set; }

            // Returns the first longest word in the document
            public string TheLongestWord { get; set; }

            // Returns the first shortest word in the document
            public string TheShortestWord { get; set; }
        }
    }
}
