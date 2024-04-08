using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateListGenerator
{
    class DateGenerator
    {
        public static DateTime[] GenerateDates(DateTime startDate, DateTime endDate, int listToGenerate, int numDates, bool duplicates, DateFilter filter)
        {
            List<DateTime> allDates = new List<DateTime>();
            for (DateTime date = startDate; date.Ticks <= endDate.Ticks; date = date.AddDays(1))
            {
                allDates.Add(date);
            }
            allDates = FilterDates(allDates, filter);

            List<DateTime> dates = new List<DateTime>();

            switch (listToGenerate)
            {
                case 0: // Generate specified number of random dates
                    dates = PickRandomDates(allDates, numDates, duplicates);
                    break;

                case 1: // Generate all dates in random order
                    dates = PickRandomDates(allDates, allDates.Count, false);
                    break;

                case 2: // Generate all dates in chronological order
                    dates = allDates;
                    break;
            }

            return dates.ToArray();
        }

        private static List<DateTime> PickRandomDates(List<DateTime> allDates, int numDates, bool duplicates)
        {
            List<DateTime> dates = new List<DateTime>();
            Random rand = new Random();

            if (numDates > allDates.Count && !duplicates)
            {
                throw new DateRangeSmallerThanNumDatesException();
            }

            int i = 0;
            while (i < numDates)
            {
                DateTime date = allDates[rand.Next(allDates.Count)];
                if (duplicates || !dates.Contains(date))
                {
                    dates.Add(date);
                    i++;
                }
            }

            return dates;
        }

        private static List<DateTime> FilterDates(List<DateTime> allDates, DateFilter filter)
        {
            List<DateTime> filteredDates = new List<DateTime>();

            foreach (DateTime date in allDates)
            {
                DayOfWeek weekday = date.DayOfWeek;
                int weekdayNumber;
                switch (weekday)
                {
                    case DayOfWeek.Monday: weekdayNumber = 1; break;
                    case DayOfWeek.Tuesday: weekdayNumber = 2; break;
                    case DayOfWeek.Wednesday: weekdayNumber = 3; break;
                    case DayOfWeek.Thursday: weekdayNumber = 4; break;
                    case DayOfWeek.Friday: weekdayNumber = 5; break;
                    case DayOfWeek.Saturday: weekdayNumber = 6; break;
                    case DayOfWeek.Sunday: weekdayNumber = 7; break;
                    default: throw new Exception("Invalid weekday");
                }
                if (filter.Weekdays[weekdayNumber - 1] && filter.Months[date.Month - 1] && date.Day >= filter.MinDay && date.Day <= filter.MaxDay)
                {
                    filteredDates.Add(date);
                } 
            }

            return filteredDates;
        }
    }
}
