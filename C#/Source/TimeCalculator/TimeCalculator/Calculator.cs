using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCalculator
{
    class Calculator
    {
        public static TimeSpan AddDurations(TimeSpan duration1, TimeSpan duration2)
        {
            return duration1 + duration2;
        }

        public static TimeSpan DifferenceBetweenDurations(TimeSpan duration1, TimeSpan duration2)
        {
            return (duration1 - duration2).Duration();
        }

        public static TimeSpan DurationTimesNumber(TimeSpan duration, double number)
        {
            checked
            {
                return new TimeSpan((long)(duration.Ticks * number));
            }
        }

        public static TimeSpan DurationDividedByNumber(TimeSpan duration, double number)
        {
            checked
            {
                return new TimeSpan((long)(duration.Ticks / number));
            }
        }

        public static DateTime AddDurationToDate(DateTime date, TimeSpan duration)
        {
            return date + duration;
        }

        public static DateTime SubtractDurationFromDate(DateTime date, TimeSpan duration)
        {
            return date - duration;
        }

        public static TimeSpan DifferenceBetweenDates(DateTime date1, DateTime date2)
        {
            return (date1 - date2).Duration();
        }

        public static DateTime AddDurationToCurrentDate(TimeSpan duration)
        {
            return AddDurationToDate(DateTime.Now, duration);
        }

        public static DateTime SubtractDurationFromCurrentDate(TimeSpan duration)
        {
            return SubtractDurationFromDate(DateTime.Now, duration);
        }

        public static TimeSpan DifferenceBetweenDateAndCurrentDate(DateTime date)
        {
            return DifferenceBetweenDates(date, DateTime.Now);
        }

    }
}
