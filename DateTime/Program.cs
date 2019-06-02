using System;
using System.Web;
using System.Globalization;

namespace DateTimeInf
{
    class Program
    {
        static void Main(string[] args)
        {
            string testTime = "07:05:45AM";
            string expected = "07:05:45";

            Console.WriteLine($"Input is {testTime}");
            Console.WriteLine($"Expected result is {expected}");
            Console.WriteLine($"What we have is: {TimeConvertion(testTime)}");
        }

        public static string TimeConvertion(string time)
        {
            string[] input = time
                .Split(":");

            string modifiedTime = "";
            string hours = input[0];
            string minutes = input[1];
            string seconds = input[2];

            if (hours == "12")
            {
                hours = "00";
            }

            if (time.Contains("AM"))
            {
                seconds = seconds.Replace("AM", string.Empty);
            }
            else if (time.Contains("PM"))
            {
                int modifiedHours = int.Parse(hours) + 12;
                hours = modifiedHours.ToString();

                seconds = seconds.Replace("PM", string.Empty);
            }

            modifiedTime = hours + ':' + minutes + ':' + seconds;

            return modifiedTime;
        }
    }
}
