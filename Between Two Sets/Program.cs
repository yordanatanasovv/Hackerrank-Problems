using System;
using System.Collections.Generic;
using System.Linq;

namespace Between_Two_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayCounts = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(getTotalX(firstArray,secondArray));
        }

        public static int getTotalX(int[] a, int[] b)
        {
            List<int> validNumbers = new List<int>();
            List<int> validNumberAfterScond = new List<int>();
            int count = 0;

            for (int i = a.Max(); i <= b.Min(); i++)
            {
                if (IsValidFirstArrayNumber(i, a))
                {
                    validNumbers.Add(i);
                }
            }

            for (int i = 0; i < validNumbers.Count; i++)
            {
                if (IsValidSecondArrayNumber(validNumbers[i], b))
                {
                    count++;
                    validNumberAfterScond.Add(validNumbers[i]);
                }
            }

            return count;
        }

        public static bool IsValidFirstArrayNumber(int number, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (number % array[i] != 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsValidSecondArrayNumber(int number, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % number != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
