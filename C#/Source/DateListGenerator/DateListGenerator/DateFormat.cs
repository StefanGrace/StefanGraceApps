using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateListGenerator
{
    public class DateFormat
    {
        private static readonly string[] months = { "", "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        private int dateOrder = 0; // 0 = YMD, 1 = DMY, 2 = MDY
        private int yearFormat = 0; // 0 = 4-digit, 1 = 2-digit
        private int monthFormat = 1; // 0 = number without leading-zero, 1 = number with leading-zero, 2 = 3-letter word, 3 = full word
        private int dayFormat = 1; // 0 = without without leading-zero, 1 = with leading-zero, 2 = ordinal
        private string dateSep = "-";
        private int weekday = 0; // 0 = no, 1 = before date, 2 = after date
        private int weekdayFormat = 0; // 0 = 3-letter, 1 = full
        private string weekdaySep = " ";
        private bool commaAfterDay = true;

        public DateFormat()
        {

        }

        public DateFormat(DateFormat format)
        {
            SetFormat(format);
        }

        public void SetFormat(int dateOrder, int yearFormat, int monthFormat, int dayFormat, string dateSep, int weekday, int weekdayFormat, string weekdaySep, bool commaAfterDay)
        {
            DateOrder = dateOrder;
            YearFormat = yearFormat;
            MonthFormat = monthFormat;
            DayFormat = dayFormat;
            DateSep = dateSep;
            Weekday = weekday;
            WeekdayFormat = weekdayFormat;
            WeekdaySep = weekdaySep;
            CommaAfterDay = commaAfterDay;
        }

        public void SetFormat(DateFormat format)
        {
            SetFormat(format.DateOrder, format.YearFormat, format.MonthFormat, format.DayFormat, format.DateSep,
                format.Weekday, format.WeekdayFormat, format.WeekdaySep, format.CommaAfterDay);
        }

        public string FormatDate(DateTime date)
        {
            // Generate year text
            string yearText = date.Year.ToString().PadLeft(4, '0');
            if (yearFormat == 1)
            {
                yearText = yearText.Substring(2);
            }

            // Generate month text
            string monthText = "";
            switch (monthFormat)
            {
                case 0: monthText = date.Month.ToString(); break;
                case 1: monthText = date.Month.ToString("00"); break;
                case 2: monthText = months[date.Month].Substring(0, 3); break;
                case 3: monthText = months[date.Month]; break;
            }

            // Generate day text
            string dayText = "";
            switch (dayFormat)
            {
                case 0: dayText = date.Day.ToString(); break;
                case 1: dayText = date.Day.ToString("00"); break;
                case 2: dayText = date.Day + Ordinal(date.Day); break;
            }

            // Add comma after the day if the date order is MDY, the month is worded, and seperator is space
            if (commaAfterDay)
            {
                if (dateOrder == 2)
                {
                    if ((monthFormat == 2 || monthFormat == 3) && dateSep == " ")
                    {
                        dayText += ",";
                    }
                }
            }

            // Assemble the elements to form the date
            string dateText = "";
            switch (dateOrder)
            {
                case 0: dateText = yearText + dateSep + monthText + dateSep + dayText; break;
                case 1: dateText = dayText + dateSep + monthText + dateSep + yearText; break;
                case 2: dateText = monthText + dateSep + dayText + dateSep + yearText; break;
            }

            // Return date and weekday
            switch (weekday)
            {
                case 1: return FormatWeekday(date) + weekdaySep + dateText;
                case 2: return dateText + weekdaySep + FormatWeekday(date);
                default: return dateText;
            }
        }

        private string FormatWeekday(DateTime date)
        {
            string weekdayText = date.DayOfWeek.ToString();
            if (weekdayFormat == 0)
            {
                return weekdayText.Substring(0, 3);
            }
            else
            {
                return weekdayText;
            }
        }

        public string Ordinal(int number)
        {
            string ordinal = "th";
            if (number - (number % 10) != 10)
            {
                switch (number % 10)
                {
                    case 1: ordinal = "st"; break;
                    case 2: ordinal = "nd"; break;
                    case 3: ordinal = "rd"; break;
                }
            }
            return ordinal;
        }



        // Getters and Setters

        public int DateOrder
        {
            get => dateOrder;

            set
            {
                if (value >= 0 && value < 3)
                {
                    dateOrder = value;
                }
            }
        }

        public int YearFormat
        {
            get => yearFormat;

            set
            {
                if (value >= 0 && value < 2)
                {
                    yearFormat = value;
                }
            }
        }

        public int MonthFormat
        {
            get => monthFormat;

            set
            {
                if (value >= 0 && value < 4)
                {
                    monthFormat = value;
                }
            }
        }

        public int DayFormat
        {
            get => dayFormat;

            set
            {
                if (value >= 0 && value < 3)
                {
                    dayFormat = value;
                }
            }
        }

        public string DateSep { get => dateSep; set => dateSep = value; }

        public int Weekday
        {
            get => weekday;

            set
            {
                if (value >= 0 && value < 3)
                {
                    weekday = value;
                }
            }
        }

        public int WeekdayFormat
        {
            get => weekdayFormat;

            set
            {
                if (value >= 0 && value < 2)
                {
                    weekdayFormat = value;
                }
            }
        }

        public string WeekdaySep { get => weekdaySep; set => weekdaySep = value; }

        public bool CommaAfterDay { get => commaAfterDay; set => commaAfterDay = value; }

        public static string[] Months => months;
    }
}
