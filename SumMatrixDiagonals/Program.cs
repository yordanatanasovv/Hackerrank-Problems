using System;

namespace SumMatrixDiagonals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int DiagonalDifference(int[][] arr)
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum1 += arr[i][i];
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum2 += arr[i][arr.GetLength(0) - i];
            }

            return Math.Abs(sum1 - sum2);
        }
    }
}
