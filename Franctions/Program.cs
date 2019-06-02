using System;
using System.Linq;

namespace Franctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            FractionCount(numbers);
        }

        public static void FractionCount(int[] arr)
        {
            int positiveCount = 0;
            int negativeCount = 0;
            int zerosCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positiveCount++;
                }
                else if (arr[i] < 0)
                {
                    negativeCount++;
                }
                else if (arr[i] == 0)
                {
                    zerosCount++;
                }
            }

            decimal firstNum = (decimal)positiveCount / (decimal)arr.Length;
            decimal secondNum = (decimal)negativeCount / (decimal)arr.Length;
            decimal thirdNum = (decimal)zerosCount / (decimal)arr.Length;

            Console.WriteLine($"{firstNum:F6}");
            Console.WriteLine($"{secondNum:F6}");
            Console.WriteLine($"{thirdNum:F6}");
        }
    }
}
