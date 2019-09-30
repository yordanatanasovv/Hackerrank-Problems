using System;
using System.Collections.Generic;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> grades = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                grades.Add(num);
            }

            GradingStudents(grades);

            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine(grades[i]);
            }


        }

        public static List<int> GradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                int roundedNumber = grades[i] % 10;
                int difference;

                if (grades[i] >= 38)
                {
                    if (roundedNumber <= 5)
                    {
                        difference = 5 - roundedNumber;

                        if (difference < 3)
                        {
                            grades[i] += difference;
                        }
                    }
                    else if (roundedNumber > 5 && roundedNumber <= 10)
                    {
                        difference = 10 - roundedNumber;

                        if (difference < 3)
                        {
                            grades[i] += difference;
                        }
                    }
                }
            }

            return grades;
        }
    }
}
