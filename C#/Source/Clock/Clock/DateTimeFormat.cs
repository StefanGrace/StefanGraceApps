using System;

namespace Clock
{
    class DateTimeFormat
    {
        
        private string[] customMonths = new string[12];
        private string[] customWeekdays = new string[7]; // [0] = Monday, [6] = Sunday

        private int showDateTime; // 0 = Date then time, 1 = Time then date, 2 = Date only, 3 = Time only
        private string dateTimeSep;

        private string dateOrder; // "YMD", "DMY", or "MDY"
        private int yearDigits;
        private int monthFormat; // 0 = Without leading-zero, 1 = With leading-zero, 2 = 3-letter, 4 = Full, 5 = custom
        private int dayFomrat; // 0 = Without leading-zero, 1 = With leading-zero, 2 = Ordinal
        private string dateSep1;
        private bool dateSep1sameAsDateSep2;
        private string dateSep2;
        private string dateEndChar;
        private int weekday; // 0 = Don't show, 1 = Before date, 2 = After date
        private int weekdayFormat; // 0 = 3-letter, 1 = Full, 2 = Custom
        private string weekdaySep;

        private int timeFormat; // 0 = 0-23, 1 = 1-24, 2 = 0-11 AM/PM first, 3 = 0-11 AM/PM last, 4 = 1-12 AM/PM first, 5 = 1-12 AM/PM last
        private bool zeroPadHour;
        private bool showSeconds;
        private string amFormat;
        private string pmFormat;
        private string hourMinSep;
        private bool minSecSepSameAsHourMinSep;
        private string minSecSep;
        private string timeAmPmSep;


        // Constructors

        public DateTimeFormat(int showDateTime, string dateTimeSep, string dateOrder, int yearDigits, int monthFormat, int dayFomrat, string dateSep1, bool dateSep1sameAsDateSep2, string dateSep2, string dateEndChar, int weekday, int weekdayFormat, string weekdaySep, int timeFormat, bool zeroPadHour, bool showSeconds, string amFormat, string pmFormat, string hourMinSep, bool minSecSepSameAsHourMinSep, string minSecSep, string timeAmPmSep)
        {
            ShowDateTime = showDateTime;
            DateTimeSep = dateTimeSep ?? throw new ArgumentNullException(nameof(dateTimeSep));
            DateOrder = dateOrder ?? throw new ArgumentNullException(nameof(dateOrder));
            YearDigits = yearDigits;
            MonthFormat = monthFormat;
            DayFomrat = dayFomrat;
            DateSep1 = dateSep1 ?? throw new ArgumentNullException(nameof(dateSep1));
            DateSep1sameAsDateSep2 = dateSep1sameAsDateSep2;
            DateSep2 = dateSep2 ?? throw new ArgumentNullException(nameof(dateSep2));
            DateEndChar = dateEndChar ?? throw new ArgumentNullException(nameof(dateEndChar));
            Weekday = weekday;
            WeekdayFormat = weekdayFormat;
            WeekdaySep = weekdaySep ?? throw new ArgumentNullException(nameof(weekdaySep));
            TimeFormat = timeFormat;
            ZeroPadHour = zeroPadHour;
            ShowSeconds = showSeconds;
            AmFormat = amFormat ?? throw new ArgumentNullException(nameof(amFormat));
            PmFormat = pmFormat ?? throw new ArgumentNullException(nameof(pmFormat));
            HourMinSep = hourMinSep ?? throw new ArgumentNullException(nameof(hourMinSep));
            MinSecSepSameAsHourMinSep = minSecSepSameAsHourMinSep;
            MinSecSep = minSecSep ?? throw new ArgumentNullException(nameof(minSecSep));
            TimeAmPmSep = timeAmPmSep ?? throw new ArgumentNullException(nameof(timeAmPmSep));
        }

        public DateTimeFormat(string[] lines)
        {
            ShowDateTime = int.Parse(lines[0]);
            DateTimeSep = lines[1];
            DateOrder = lines[2];
            YearDigits = int.Parse(lines[3]);
            MonthFormat = int.Parse(lines[4]);
            DayFomrat = int.Parse(lines[5]);
            DateSep1 = lines[6];
            DateSep1sameAsDateSep2 = bool.Parse(lines[7]);
            DateSep2 = lines[8];
            DateEndChar = lines[9];
            Weekday = int.Parse(lines[10]);
            WeekdayFormat = int.Parse(lines[11]);
            WeekdaySep = lines[12];
            TimeFormat = int.Parse(lines[13]);
            ZeroPadHour = bool.Parse(lines[14]);
            ShowSeconds = bool.Parse(lines[15]);
            AmFormat = lines[16];
            PmFormat = lines[17];
            HourMinSep = lines[18];
            MinSecSepSameAsHourMinSep = bool.Parse(lines[19]);
            MinSecSep = lines[20];
            TimeAmPmSep = lines[21];

            if (bool.Parse(lines[22])) // Is there custom months?
            {
                for (int i = 0; i < customMonths.Length; i++)
                {
                    customMonths[i] = lines[i + 23];
                }
            }

            if (bool.Parse(lines[35])) // Is there custom weekdays?
            {
                for (int i = 0; i < customWeekdays.Length; i++)
                {
                    customWeekdays[i] = lines[i + 36];
                }
            }
        }


        // Methods

        public string[] ToStringArray()
        {
            string[] output = new string[43];

            output[0] = showDateTime.ToString();
            output[1] = dateTimeSep;
            output[2] = dateOrder;
            output[3] = yearDigits.ToString();
            output[4] = monthFormat.ToString();
            output[5] = dayFomrat.ToString();
            output[6] = dateSep1;
            output[7] = dateSep1sameAsDateSep2.ToString();
            output[8] = dateSep2;
            output[9] = dateEndChar;
            output[10] = weekday.ToString();
            output[11] = weekdayFormat.ToString();
            output[12] = weekdaySep;
            output[13] = timeFormat.ToString();
            output[14] = zeroPadHour.ToString();
            output[15] = showSeconds.ToString();
            output[16] = amFormat;
            output[17] = pmFormat;
            output[18] = hourMinSep;
            output[19] = minSecSepSameAsHourMinSep.ToString();
            output[20] = minSecSep;
            output[21] = timeAmPmSep;

            output[22] = (customMonths[0] != null).ToString(); // Is there custom months?
            for (int i = 0; i < customMonths.Length; i++)
            {
                output[i + 23] = customMonths[i];
            }

            output[35] = (customWeekdays[0] != null).ToString();  // Is there custom weekdays?
            for (int i = 0; i < customWeekdays.Length; i++)
            {
                output[i + 36] = customWeekdays[i];
            }

            return output;
        }


        // Static properties

        public static DateTimeFormat ISO8601withSpace
        {
            get => new DateTimeFormat(0, " ", "YMD", 4, 1, 1, "-", true, "-", "", 0, 0, " ", 0, true, true, "AM", "PM", ":", true, ":", " ");
        }

        public static DateTimeFormat ISO8601withT
        {
            get => new DateTimeFormat(0, "T", "YMD", 4, 1, 1, "-", true, "-", "", 0, 0, " ", 0, true, true, "AM", "PM", ":", true, ":", " ");
        }

        public static DateTimeFormat SuitableForFilenames
        {
            get => new DateTimeFormat(0, "_", "YMD", 4, 1, 1, "-", true, "-", "", 0, 0, "_", 0, true, true, "AM", "PM", "-", true, "-", " ");
        }

        public static DateTimeFormat EuropeanShort
        {
            get => new DateTimeFormat(0, " ", "DMY", 2, 0, 0, ".", true, ".", "", 0, 0, " ", 0, true, false, "AM", "PM", ":", true, ":", " ");
        }

        public static DateTimeFormat EuropeanNumerical
        {
            get => new DateTimeFormat(0, " ", "DMY", 4, 1, 1, ".", true, ".", "", 0, 0, " ", 0, true, true, "AM", "PM", ":", true, ":", " ");
        }

        public static DateTimeFormat BritishMedium
        {
            get => new DateTimeFormat(0, " ", "DMY", 4, 2, 1, " ", true, " ", "", 0, 0, " ", 0, true, false, "AM", "PM", ":", true, ":", " ");
        }
        public static DateTimeFormat BritishFull
        {
            get => new DateTimeFormat(0, ", ", "DMY", 4, 3, 0, " ", true, " ", "", 1, 1, ", ", 0, true, true, "AM", "PM", ":", true, ":", " ");
        }

        public static DateTimeFormat AmericanShort
        {
            get => new DateTimeFormat(0, " ", "MDY", 2, 0, 0, "/", true, "/", "", 0, 0, " ", 5, false, false, "AM", "PM", ":", true, ":", " ");
        }

        public static DateTimeFormat AmericanNumerical
        {
            get => new DateTimeFormat(0, " ", "MDY", 4, 1, 1, "/", true, "/", "", 0, 0, " ", 5, false, true, "AM", "PM", ":", true, ":", " ");
        }

        public static DateTimeFormat AmericanMedium
        {
            get => new DateTimeFormat(0, " ", "MDY", 4, 2, 0, " ", false, ", ", "", 0, 0, ", ", 5, false, false, "AM", "PM", ":", true, ":", " ");
        }

        public static DateTimeFormat AmericanFull
        {
            get => new DateTimeFormat(0, ", ", "MDY", 4, 3, 0, " ", false, ", ", "", 1, 1, ", ", 5, false, true, "AM", "PM", ":", true, ":", " ");
        }

        public static DateTimeFormat Chinese
        {
            get => new DateTimeFormat(0, "", "YMD", 4, 0, 0, "年", false, "月", "日", 2, 2, "", 4, false, true, "上午", "下午", "时", false, "分", "");
        }

        public static DateTimeFormat Hungarian
        {
            get => new DateTimeFormat(0, " ", "YMD", 4, 4, 0, ". ", false, " ", "", 2, 2, "., ", 0, true, true, "AM", "PM", ":", true, ":", " ");
        }

        public static DateTimeFormat Vietnamese
        {
            get => new DateTimeFormat(0, " ", "DMY", 4, 0, 0, " tháng ", false, " năm ", "", 1, 2, ", ", 0, true, true, "sáng", "chiều", ":", true, ":", " "); 
        }


        public static string[] ChineseWeekdayNames
        {
            get => new string[] { "周一", "周二", "周三", "周四", "周五", "周六", "周日" };
        }

        public static string[] HungarianMonthNames
        {
            get => new string[] { "január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december" };
        }

        public static string[] HungarianWeekdayNames
        {
            get => new string[] { "hétfő", "kedd", "szerda", "csütörtök", "péntek", "szombat", "vasárnap" };
        }

        public static string[] VietnameseWeekdayNames
        {
            get => new string[] { "thứ hai", "thứ ba", "thứ tư", "thứ năm", "thứ sáu", "thứ bảy", "chủ nhật" };
        }



        // Getters/setters

        public int ShowDateTime
        {
            get => showDateTime;
            set
            {
                if (value < 0 || value > 3)
                {
                    throw new InvalidDateTimeFormatOptionException();
                }
                else
                {
                    showDateTime = value;
                }
            }
        }

        public string DateTimeSep { get => dateTimeSep; set => dateTimeSep = value; }

        public string DateOrder
        {
            get => dateOrder;
            set
            {
                string valueCapital = value.ToUpper();
                if (value == "YMD" || value == "DMY" || value == "MDY")
                {
                    dateOrder = valueCapital;
                }
                else
                {
                    throw new InvalidDateTimeFormatOptionException();
                }
            }
        }

        public int YearDigits
        {
            get => yearDigits;
            set
            {
                if (value == 2 || value == 4)
                {
                    yearDigits = value;
                }
                else
                {
                    throw new InvalidDateTimeFormatOptionException();
                }
            }
        }

        public int MonthFormat
        {
            get => monthFormat;
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new InvalidDateTimeFormatOptionException();
                }
                else
                {
                    monthFormat = value;
                }
            }
        }

        public int DayFomrat
        {
            get => dayFomrat;
            set
            {
                if (value < 0 || value > 2)
                {
                    throw new InvalidDateTimeFormatOptionException();
                }
                else
                {
                    dayFomrat = value;
                }
            }
        }

        public string DateSep1 { get => dateSep1; set => dateSep1 = value; }

        public bool DateSep1sameAsDateSep2 { get => dateSep1sameAsDateSep2; set => dateSep1sameAsDateSep2 = value; }

        public string DateSep2 { get => dateSep2; set => dateSep2 = value; }

        public string DateEndChar { get => dateEndChar; set => dateEndChar = value; }

        public int Weekday
        {
            get => weekday;
            set
            {
                if (value < 0 || value > 2)
                {
                    throw new InvalidDateTimeFormatOptionException();
                }
                else
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
                if (value < 0 || value > 2)
                {
                    throw new InvalidDateTimeFormatOptionException();
                }
                else
                {
                    weekdayFormat = value;
                }
            }
        }

        public string WeekdaySep { get => weekdaySep; set => weekdaySep = value; }

        public int TimeFormat
        {
            get => timeFormat;
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new InvalidDateTimeFormatOptionException();
                }
                else
                {
                    timeFormat = value;
                }
            }
        }

        public bool ZeroPadHour { get => zeroPadHour; set => zeroPadHour = value; }

        public bool ShowSeconds { get => showSeconds; set => showSeconds = value; }

        public string AmFormat { get => amFormat; set => amFormat = value; }

        public string PmFormat { get => pmFormat; set => pmFormat = value; }

        public string HourMinSep { get => hourMinSep; set => hourMinSep = value; }

        public bool MinSecSepSameAsHourMinSep { get => minSecSepSameAsHourMinSep; set => minSecSepSameAsHourMinSep = value; }

        public string MinSecSep { get => minSecSep; set => minSecSep = value; }

        public string TimeAmPmSep { get => timeAmPmSep; set => timeAmPmSep = value; }

        public string[] CustomMonths
        {
            get => customMonths;
            set
            {
                if (value.Length == 12)
                {
                    customMonths = value;
                }
                else
                {
                    throw new InvalidDateTimeFormatOptionException();
                }
            }
        }

        public string[] CustomWeekdays
        {
            get => customWeekdays;
            set
            {
                if (value.Length == 7)
                {
                    customWeekdays = value;
                }
                else
                {
                    throw new InvalidDateTimeFormatOptionException();
                }
            }
        }
    }
}
