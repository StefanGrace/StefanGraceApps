using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedClock
{
    class TimeFormatter
    {
        public string FormatTime(DateTime time, int format, bool showSeconds)
        {
            string second;
            if (showSeconds)
            {
                second = ":" + time.Second.ToString("00");
            }
            else
            {
                second = "";
            }

            if (format < 24)
            {
                int hour = ConvertHour(time.Hour, format);
                if (hour == 0)
                {
                    hour = format;
                }
                return hour.ToString("0") + ":" + time.Minute.ToString("00") + second + " " + FormatMeridian(time.Hour, format);
            }
            else
            {
                return ConvertHour(time.Hour, format).ToString("00") + ":" + time.Minute.ToString("00") + second;
            }
        }

        public DateTime ParseTime(int hour, int minute, int second, int format = 24, int meridian = 0)
        {
            if (hour == format)
            {
                hour = 0;
            }
            return new DateTime(1, 1, 1, (hour % 24) + (meridian * format), minute, second);
        }

        private int ConvertHour(int hour24, int format)
        {
            if (hour24 + 24 < format)
            {
                return hour24 + 24;
            }
            else
            {
                return hour24 % format;
            }
        }

        private string FormatMeridian(int hour24, int format)
        {
            switch (format)
            {
                case 6:
                    if (hour24 < 6)
                    {
                        return "early morning";
                    }
                    else if (hour24 < 12)
                    {
                        return "morning";
                    }
                    else if (hour24 < 18)
                    {
                        return "afternoon";
                    }
                    else
                    {
                        return "evening";
                    }

                case 12:
                    if (hour24 < 12)
                    {
                        return "AM";
                    }
                    else
                    {
                        return "PM";
                    }

                default:
                    return "";

            }
        }

    }
}
