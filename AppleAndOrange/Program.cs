using System;
using System.Linq;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houseRange = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int s = houseRange[0];
            int t = houseRange[1];

            int[] treeValues = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int a = treeValues[0];
            int b = treeValues[1];

            int[] fruitsPerTree = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int m = fruitsPerTree[0];
            int n = fruitsPerTree[1];

            int[] apples = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] oranges = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            CountApplesAndOranges(s, t, a, b, apples, oranges);
        }

        public static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int[] applesFinal = new int[apples.Length];
            int[] orangesFinal = new int[oranges.Length];

            int applesCount = 0;
            int orangesCount = 0;

            for (int i = 0; i < apples.Length; i++)
            {
                applesFinal[i] = a + apples[i];
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                orangesFinal[i] = b + oranges[i];
            }

            for (int i = 0; i < applesFinal.Length; i++)
            {
                if (applesFinal[i] >= s && applesFinal[i] <= t)
                {
                    applesCount++;
                }
            }

            for (int i = 0; i < orangesFinal.Length; i++)
            {
                if (orangesFinal[i] >= s && orangesFinal[i] <= t)
                {
                    orangesCount++;
                }
            }

            Console.WriteLine(applesCount);
            Console.WriteLine(orangesCount);

        }
    }
}
