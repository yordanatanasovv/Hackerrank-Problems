using System;

namespace VeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static long VeryBigSum(long[] a)
        {
            long sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
    }
}
