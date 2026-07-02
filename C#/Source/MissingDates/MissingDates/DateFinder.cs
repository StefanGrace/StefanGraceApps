using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingDates
{
    class DateFinder
    {
        public static DateTime[] FindMissingDates(DateTime[] dates)
        {
            DateTime earliestDate = DateTime.MaxValue;
            DateTime latestDate = DateTime.MinValue;

            for (int i = 0; i < dates.Length; i++)
            {
                dates[i] = dates[i].Subtract(dates[i].TimeOfDay);
                if (dates[i] < earliestDate)
                {
                    earliestDate = dates[i];
                }
                if (dates[i] > latestDate)
                {
                    latestDate = dates[i];
                }
            }

            List<DateTime> allDatesInRange = new List<DateTime>();
            int days = 0;
            while (earliestDate.AddDays(days) < latestDate)
            {
                allDatesInRange.Add(earliestDate.AddDays(days));
                days++;
            }

            List<DateTime> missingDates = new List<DateTime>();
            foreach(DateTime date in allDatesInRange)
            {
                if (!DatePresent(dates, date))
                {
                    missingDates.Add(date);
                }
            }

            return missingDates.ToArray();
        }

        private static bool DatePresent(DateTime[] dates, DateTime date)
        {
            foreach (DateTime dateInDates in dates)
            {
                if (dateInDates == date)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
