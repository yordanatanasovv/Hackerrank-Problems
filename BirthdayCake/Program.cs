using System;
using System.Linq;

namespace BirthdayCake
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(birthdayCakeCandles(arr));
        }

        public static int birthdayCakeCandles(int[] ar)
        {
            int max = ar[0];
            int count = 0;
            for (int i = 0; i < ar.Length - 1; i++)
            {
                if (ar[i] > max)
                {
                    max = ar[i];
                }
            }

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == max)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
