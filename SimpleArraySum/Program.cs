using System;
using System.Linq;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int sum = 0;

            string[] input = Console.ReadLine()
                .Split();
                

            for (int i = 0; i < count; i++)
            {
                sum += int.Parse(input[i]);
            }

            Console.WriteLine(sum);
        }
    }
}
