using System;
using System.Linq;

namespace Kangoroo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kangorooArgs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int x1 = kangorooArgs[0];
            int v1 = kangorooArgs[1];
            int x2 = kangorooArgs[2];
            int v2 = kangorooArgs[3];

            Console.WriteLine(Kangaroo(x1,v1,x2,v2));

        }

        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            if (x1 < x2 && v1 < v2)
            {
                return "NO";
            }
            else if (x1 < 0 || x2 < 0)
            {
                return "NO";
            }
            else if (v1 <  1 || v2 < 1)
            {
                return "NO";
            }
            else
            {
                for (int i = 0; i <= 10000; i++)
                {
                    x1 += v1;
                    x2 += v2;

                    if (x1 == x2)
                    {
                        return "YES";
                    }   
                }               
            }

            return "NO";

        }
    }
}
