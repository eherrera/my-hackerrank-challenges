using System;
using System.Collections.Generic;

namespace MyHackerrankChallenges.Practice
{
    public enum CalendarType
    {
        Julian,
        Gregorian
    }

    public class DayOfTheProgrammer : IChallenge
    {
        static string solve(int year)
        {
            var monthDays = new Dictionary<string, int>
            {
                {"01", 31},
                {"02", FebruaryDaysCount(year)},
                {"03", 31},
                {"04", 30},
                {"05", 31},
                {"06", 30},
                {"07", 31},
                {"08", 31},
                {"09", 30},
                {"10", 31},
                {"11", 30},
                {"12", 31},
            };

            const int programmerDay = 256;
            var dayCount = 0;
            string day = null;
            string month = null;
            foreach (var monthDay in monthDays)
            {
                if (monthDay.Value + dayCount < programmerDay)
                {
                    dayCount += monthDay.Value;
                }
                else
                {
                    month = monthDay.Key;
                    var diff = programmerDay - dayCount;
                    day = diff.ToString().PadLeft(2, '0');
                    break;
                }
            }

            return $"{day}.{month}.{year}";
        }

        static CalendarType GetRussianCalendarType(int year)
        {
            if (year >= 1700 && year <= 1917)
            {
                return CalendarType.Julian;
            }
            return CalendarType.Gregorian;
        }

        static bool IsLeapYear(int year)
        {
            var calendarType = GetRussianCalendarType(year);
            switch (calendarType)
            {
                case CalendarType.Julian:
                    return year % 4 == 0;
                case CalendarType.Gregorian:
                    return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        static int FebruaryDaysCount(int year)
        {
            var result = IsLeapYear(year) ? 29 : 28;
            if (year == 1918)
            {
                result -= 13;
            }
            return result;
        }

        public void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            string result = solve(year);
            Console.WriteLine(result);
        }
    }
}
