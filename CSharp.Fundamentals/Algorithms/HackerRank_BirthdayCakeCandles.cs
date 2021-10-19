/*
    Problem: https://www.hackerrank.com/challenges/birthday-cake-candles/problem
    Thoughts :
    1. Store all the candle heights in an array of length n.
    2. Let the height of tallest candle be ht. Set ht to the height of first candle.
    3. Let the count of all the candles having height ht be c. Set c to 1.
    4. Start iterating the candles in a loop starting from second candle.
    4.1 Let the height of next candle be hn.
    4.2 If hn is equal to ht then increment c by 1.
    4.3 If hn is greater than ht then set ht to hn and c to 1.
    4.4 Repeat steps 4.1 through 4.4 for all the candles in the array except the first candle.
    5. Print c on console.
    Time Complexity:  O(n)
    Space Complexity: O(n) //Space complexity doesn't  match the optimal O(1) solution as in C# you have to read the entire console line at a time (size n), 
                    as it doesn't have a way to iteratively read in space delimited input. If there had been a Scanner like class which exists in Java 
                    then it would have been possible to accomplish the same algorithm in O(1) space complexity.
                
*/

using System;

namespace CSharp.Fundamentals.Algorithms
{
    public class HackerRank_BirthdayCakeCandles
    {
        public static void Main(String[] args)
        {
            /* To make dynamic request 
            Console.ReadLine();
            var height_temp = Console.ReadLine().Split(' ');
            var height = Array.ConvertAll(height_temp, int.Parse);
            */

            int[] testData = { 3, 4, 1, 3 };
            Console.WriteLine(CountTallestCandles(testData));
        }

        public static int CountTallestCandles(int[] candleHeights)
        {
            var maxValue = candleHeights[0];
            var maxValueOccurence = 1;

            for (int i = 1; i < candleHeights.Length; i++)
            {
                if (candleHeights[i] == maxValue)
                {
                    maxValueOccurence++;
                    continue;
                }
                if (candleHeights[i] > maxValue)
                {
                    maxValue = candleHeights[i];
                    maxValueOccurence = 1;
                }
            }

            return maxValueOccurence;
        }
    }
}
