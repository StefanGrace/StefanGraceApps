using System;

namespace Clock
{
    class Formatter
    {
        private DateTimeFormat format;
        private static readonly string[] months = { "", "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        // Constructor
        public Formatter(DateTimeFormat format)
        {
            this.format = format ?? throw new ArgumentNullException(nameof(format));
        }

        // Getters/Setters
        public DateTimeFormat Format { get => format; set => format = value; }
        public static string[] Months { get => months; }

        // Assembles the (date and weekday) and time
        public string FormatDateTime(DateTime dateTime)
        {
            switch (format.ShowDateTime)
            {
                case 0: return FormatDateAndWeekday(dateTime) + format.DateTimeSep + FormatTime(dateTime); // Date then time
                case 1: return FormatTime(dateTime) + format.DateTimeSep + FormatDateAndWeekday(dateTime); // Time then date
                case 2: return FormatDateAndWeekday(dateTime); // Date only
                case 3: return FormatTime(dateTime); // Time only
                default: throw new InvalidDateTimeFormatException(format);
            }
        }

        // Assembles the date and weekday
        private string FormatDateAndWeekday(DateTime date)
        {
            switch (format.Weekday)
            {
                case 0: return FormatDate(date); // Don't show weekday
                case 1: return FormatWeekday(date) + format.WeekdaySep + FormatDate(date); // Weekday before date
                case 2: return FormatDate(date) + format.WeekdaySep + FormatWeekday(date); // Weekday after date
                default: throw new InvalidDateTimeFormatException(format);
            }
        }

        // Generates formatted date text from date
        private string FormatDate(DateTime date)
        {
            // Generate year text
            string yearText;
            switch (format.YearDigits)
            {
                case 4: yearText = date.Year.ToString("0000"); break; // 4-digit year
                case 2: yearText = (date.Year % 100).ToString("00"); break; // 2-digit year
                default: throw new InvalidDateTimeFormatException(format);
            }

            // Generate month text
            string monthText;
            switch (format.MonthFormat)
            {
                case 0: monthText = date.Month.ToString(); break; // Number without leading-zero
                case 1: monthText = date.Month.ToString("00"); break; // Number with leading-zero
                case 2: monthText = months[date.Month].Substring(0, 3); break; // 3-letter English word
                case 3: monthText = months[date.Month]; break; // Full English world
                case 4: monthText = format.CustomMonths[date.Month - 1]; break; // Custom
                default: throw new InvalidDateTimeFormatException(format);
            }

            // Generate day text
            string dayText;
            switch (format.DayFomrat)
            {
                case 0: dayText = date.Day.ToString(); break; // Without leading-zero
                case 1: dayText = date.Day.ToString("00"); break; // With leading-zero
                case 2: dayText = date.Day + Ordinal(date.Day); break; // Ordinal
                default: throw new InvalidDateTimeFormatException(format);
            }

            // Assembes year, month, and day into date and returns it
            string dateSep2 = format.DateSep1sameAsDateSep2 ? format.DateSep1 : format.DateSep2;
            switch (format.DateOrder)
            {
                case "YMD": return yearText + format.DateSep1 + monthText + dateSep2 + dayText + format.DateEndChar; // Year-Month-Day
                case "DMY": return dayText + format.DateSep1 + monthText + dateSep2 + yearText + format.DateEndChar; // Day-Month-Year
                case "MDY": return monthText + format.DateSep1 + dayText + dateSep2 + yearText + format.DateEndChar; // Month-Day-Year
                default: throw new InvalidDateTimeFormatException(format);
            }
        }

        // Generates formatted weekday text from date
        private string FormatWeekday(DateTime date)
        {
            date.DayOfWeek.ToString();
            switch (format.WeekdayFormat)
            {
                case 0: // 3-letter
                    if (date.DayOfWeek.ToString().Length > 3)
                    {
                        return date.DayOfWeek.ToString().Substring(0, 3);
                    }
                    else
                    {
                        return date.DayOfWeek.ToString();
                    }
                case 1: // Full
                    return date.DayOfWeek.ToString();
                case 2: // Custom
                    switch (date.DayOfWeek)
                    {
                        case DayOfWeek.Monday: return format.CustomWeekdays[0];
                        case DayOfWeek.Tuesday: return format.CustomWeekdays[1];
                        case DayOfWeek.Wednesday: return format.CustomWeekdays[2];
                        case DayOfWeek.Thursday: return format.CustomWeekdays[3];
                        case DayOfWeek.Friday: return format.CustomWeekdays[4];
                        case DayOfWeek.Saturday: return format.CustomWeekdays[5];
                        case DayOfWeek.Sunday: return format.CustomWeekdays[6];
                        default: throw new InvalidDateTimeFormatException(format);
                    }
                default:
                    throw new InvalidDateTimeFormatException(format);
            }
        }

        // Generates formatted time text from date
        private string FormatTime(DateTime time)
        {
            // Generate hour number
            int hour;
            switch (format.TimeFormat)
            {
                case 0: // 24-hour (0 - 23)
                    hour = time.Hour;
                    break;
                case 1: // 24-hour (1 - 24)
                    hour = time.Hour == 0 ? 24 : time.Hour;
                    break;
                case 2: // 12-hour (0 - 11) AM/PM first
                case 3: // 12-hour (0 - 11) AM/PM last
                    hour = time.Hour % 12;
                    break;
                case 4: // 12-hour (1 - 12) AM/PM first
                case 5: // 12-hour (1 - 12) AM/PM last
                    int _12hour = time.Hour % 12;
                    hour = _12hour == 0 ? 12 : _12hour;
                    break;
                default:
                    throw new InvalidDateTimeFormatException(format);
            }

            // Format hour number into text
            string hourText = format.ZeroPadHour ? hour.ToString("00") : hour.ToString();

            // Generate minute text
            string minText = time.Minute.ToString("00");

            // Generate seconds text
            string minSecSep = format.MinSecSepSameAsHourMinSep ? format.HourMinSep : format.MinSecSep;
            string secSepAndText = format.ShowSeconds ? minSecSep + time.Second.ToString("00") : "";

            // Generate AM/PM text
            string amPm = time.Hour < 12 ? format.AmFormat : format.PmFormat;

            // Assembele hour, minute second, and AM/PM, and return it
            switch (format.TimeFormat)
            {
                // 24-hour
                case 0:
                case 1:
                    return hourText + format.HourMinSep + minText + secSepAndText;
                // 12-hour AM/PM first
                case 2:
                case 4:
                    return amPm + format.TimeAmPmSep + hourText + format.HourMinSep + minText + secSepAndText;
                // 12-hour AM/PM last
                case 3:
                case 5:
                    return hourText + format.HourMinSep + minText + secSepAndText + format.TimeAmPmSep + amPm;
                default:
                    throw new InvalidDateTimeFormatException(format);
            }
        }

        // Generates ordinal (st/nd/rd/th) based on number
        private string Ordinal(int number)
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
    }
}
