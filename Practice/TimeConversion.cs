using System;

namespace MyHackerrankChallenges.Practice
{
    public class TimeConversion : IChallenge
    {
        public void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static string timeConversion(string s)
        {
            // Complete this function
            var time12hParts = s.Split(':');
            var time12hHour = time12hParts[0];
            var time12hSecs = time12hParts[2];
            var pm = time12hSecs.Substring(2) == "PM";
            var hourMilitary = time12hHour;
            if (pm)
            {
                var intHourMilitary = int.Parse(hourMilitary);
                if (intHourMilitary < 12)
                {
                    intHourMilitary += 12;
                }
                hourMilitary = intHourMilitary.ToString();
            }
            else
            {
                if (hourMilitary == "12")
                {
                    hourMilitary = "00";
                }
            }

            return string.Join(":", hourMilitary, time12hParts[1], time12hSecs.Substring(0, 2));
        }
    }
}
