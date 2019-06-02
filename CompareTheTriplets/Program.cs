using System;
using System.Collections.Generic;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            List<int> scores = new List<int>();

            int alice = 0;
            int bob = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    alice++;
                }
                else if (a[i] < b[i])
                {
                    bob++;
                }
                
            }

            scores.Add(alice);
            scores.Add(bob);

            return scores;
        }
    }
}
