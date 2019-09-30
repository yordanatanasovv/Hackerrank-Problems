using System;
using System.Collections.Generic;
using System.Linq;

namespace BreakingTheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string points = Console.ReadLine();

            int[] scores = points
                .Split()
                .Select(int.Parse)
                .ToArray();

            scores = BreakingRecords(scores);

            Console.WriteLine(string.Join(" ", scores));

        }

        public static int[] BreakingRecords(int[] scores)
        {
            int highestScore = scores[0];
            int highestScoreCount = 0;
            int lowestScoreCount = 0;
            int lowestScore = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > highestScore)
                {
                    highestScore = scores[i];
                    highestScoreCount++;
                }
                else if (scores[i] < lowestScore)
                {
                    lowestScore = scores[i];
                    lowestScoreCount++;
                }
            }

            int[] result = new int[]
            {
                highestScoreCount,
                lowestScoreCount
            };

            return result;
        }
    }
}
