using System;
using System.Text;

namespace Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stair(n);

        }

        public static void Stair(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i - 1; j >= 0; j--)
                {
                    Console.Write(' ');
                }
                Console.WriteLine(new string('#', i));
            }

        }
    }
}
