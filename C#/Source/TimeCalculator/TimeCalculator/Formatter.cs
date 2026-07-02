using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCalculator
{
    class Formatter
    {
        private const string singleUnitNumberFormat = "G7";
        private const string unitDecimalFormat = "0.0";
        private const double daysInYear = 365.2425;
        private const double ticksInYear = 10_000_000.0 * 60.0 * 60.0 * 24.0 * daysInYear;

        private string secondDecimalFormat = @"\.fff";
        private bool outputDurationYears = true;

        private static readonly Dictionary<int, string> subPrefixes = new Dictionary<int, string>()
        {
            {  0, "" },
            { -3, "m" },
            { -6, "µ" },
            { -9, "n" },
            {-12, "p" },
            {-15, "f" },
            {-18, "a" },
            {-21, "z" },
            {-24, "y" },
            {-27, "r" },
            {-30, "q" },
        };

        public int DecimalSecondDigits
        {
            set
            {
                if (value < 0 || value > 7)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value == 0)
                {
                    secondDecimalFormat = "";
                }
                else
                {
                    secondDecimalFormat = @"\." + new string('f', value);
                }
            }

            get
            {
                if (secondDecimalFormat == "")
                {
                    return 0;
                }
                else
                {
                    return secondDecimalFormat.Length - 2;
                }
            }
        }

        public bool OutputDurationYears { get => outputDurationYears; set => outputDurationYears = value; }

        public string FormatDuration(TimeSpan duration, string format)
        {
            switch (format)
            {
                case "[[year] day] h:min:s.ms":
                    if (duration.Ticks < Math.Pow(10, 7 - DecimalSecondDigits))
                    {
                        return FormatSubSecondsFromTicks(duration.Ticks);
                    }
                    else if (duration.TotalDays < 1)
                    {
                        return duration.ToString(@"h\:mm\:ss" + secondDecimalFormat);
                    }
                    else if (duration.TotalDays < daysInYear)
                    {
                        return duration.Days + " d " + duration.ToString(@"hh\:mm\:ss" + secondDecimalFormat);
                    }
                    else
                    {
                        TimeSpan durationInYear = GetDurationInYear(duration);

                        return YearsFromTicks(duration.Ticks) + " y " + durationInYear.Days + " d " +
                            durationInYear.ToString(@"hh\:mm\:ss" + secondDecimalFormat);
                    }


                case "[day] h:min:s.ms":
                    if (duration.Ticks < Math.Pow(10, 7 - DecimalSecondDigits))
                    {
                        return FormatSubSecondsFromTicks(duration.Ticks);
                    }
                    else if (duration.TotalDays < 1)
                    {
                        return duration.ToString(@"h\:mm\:ss" + secondDecimalFormat);
                    }
                    else
                    {
                        return duration.Days + " d " + duration.ToString(@"hh\:mm\:ss" + secondDecimalFormat);
                    }

                case "h:min:s.ms":
                    if (duration.Ticks < Math.Pow(10, 7 - DecimalSecondDigits))
                    {
                        return FormatSubSecondsFromTicks(duration.Ticks);
                    }
                    else
                    {
                        return Math.Truncate(duration.TotalHours) + ":" + duration.ToString(@"mm\:ss" + secondDecimalFormat);
                    }

                case "unit + subunit":
                    if (duration.TotalMinutes < 1)
                    {
                        return FormatSubSecondsFromTicks(duration.Ticks);
                    }
                    else if (duration.TotalHours < 1)
                    {
                        return duration.Minutes + " min " + duration.Seconds + " s";
                    }
                    else if (duration.TotalDays < 1)
                    {
                        return duration.Hours + " h " + duration.Minutes + " min";
                    }
                    else if (duration.TotalDays < daysInYear || !OutputDurationYears)
                    {
                        return duration.Days + " d " + duration.Hours + " h";
                    }
                    else
                    {
                        return YearsFromTicks(duration.Ticks) + " y " + (GetDurationInYear(duration).Days) + " d";
                    }

                case "unit + subunits":
                    if (duration.Ticks < Math.Pow(10, 7 - DecimalSecondDigits))
                    {
                        return FormatSubSecondsFromTicks(duration.Ticks);
                    }
                    else if (duration.TotalMinutes < 1)
                    {
                        return FormatSeconds(duration);
                    }
                    else if (duration.TotalHours < 1)
                    {
                        return duration.Minutes + " min " + FormatSeconds(duration);
                    }
                    else if (duration.TotalDays < 1)
                    {
                        return duration.Hours + " h " + duration.Minutes + " min " + FormatSeconds(duration);
                    }
                    else if (duration.TotalDays < daysInYear || !OutputDurationYears)
                    {
                        return duration.Days + " d " + duration.Hours + " h " + duration.Minutes + " min " + FormatSeconds(duration);
                    }
                    else
                    {
                        TimeSpan durationInYear = GetDurationInYear(duration);
                        return YearsFromTicks(duration.Ticks) + " y " + durationInYear.Days + " d " +
                            durationInYear.Hours + " h " + durationInYear.Minutes + " min " + FormatSeconds(durationInYear);
                    }


                case "unit + decimal":
                    if (duration.TotalSeconds < 1)
                    {
                        return FormatSubSecondsFromTicks(duration.Ticks);
                    }
                    else if (duration.TotalMinutes < 1)
                    {
                        return duration.TotalSeconds.ToString(unitDecimalFormat) + " s";
                    }
                    else if (duration.TotalHours < 1)
                    {
                        return duration.TotalMinutes.ToString(unitDecimalFormat) + " min";
                    }
                    else if (duration.TotalDays < 1)
                    {
                        return duration.TotalHours.ToString(unitDecimalFormat) + " h";
                    }
                    else if (duration.TotalDays < daysInYear)
                    {
                        return duration.TotalDays.ToString(unitDecimalFormat) + " d";
                    }
                    else
                    {
                        return (duration.Days / daysInYear).ToString(unitDecimalFormat) + " y";
                    }


                case "ms":
                    return duration.TotalMilliseconds.ToString(singleUnitNumberFormat) + " ms";

                case "s":
                    return duration.TotalSeconds.ToString(singleUnitNumberFormat) + " s";

                case "min":
                    return duration.TotalMinutes.ToString(singleUnitNumberFormat) + " min";

                case "h":
                    return duration.TotalHours.ToString(singleUnitNumberFormat) + " h";

                case "day":
                    return duration.TotalDays.ToString(singleUnitNumberFormat) + " d";

                case "year":
                    return (duration.TotalDays / daysInYear).ToString(singleUnitNumberFormat) + " y";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private string FormatSeconds(TimeSpan duration)
        {
            string output = duration.ToString("ss" + secondDecimalFormat) + " s";
            output = output.TrimStart('0');
            if (output.StartsWith(".") || output == "")
            {
                return "0" + output;
            }
            else
            {
                return output;
            }
        }

        private static int YearsFromTicks(long ticks)
        {
            return (int)(ticks / ticksInYear);
        }

        private static TimeSpan GetDurationInYear(TimeSpan duration)
        {
            return new TimeSpan((long)(duration.Ticks % ticksInYear));
        }

        public static string FormatYearsFromTicks(double ticks)
        {
            double years = ticks / ticksInYear;

            if (double.IsInfinity(years) || double.IsNaN(years))
            {
                return years.ToString();
            }
            else
            {
                return Math.Round(years).ToString(singleUnitNumberFormat) + " y";
            }
        }

        public static string FormatSubSecondsFromTicks(double ticks, int smallestMagnitute = -9)
        {
            double seconds = ticks / 1E7;

            if (smallestMagnitute < -30)
            {
                smallestMagnitute = -30;
            }

            for (int i = 0; i >= smallestMagnitute; i -= 3)
            {
                if (seconds >= Math.Pow(10, i))
                {
                    return FormatNumberDigits(seconds * Math.Pow(10, -i)) + " " + subPrefixes[i] + "s";
                }
            }

            return seconds.ToString("G3") + " s";
        }

        private static string FormatNumberDigits(double number)
        {
            if (number < 10)
            {
                return number.ToString("F2");
            }
            else if (number < 100)
            {
                return number.ToString("F1");
            }
            else
            {
                return number.ToString("F0");
            }
        }

        public static string FormatYear(long year)
        {
            return "Year " + year.ToString("N0");
        }

        public string FormatDate(DateTime date, DateFormat format)
        {
            switch (format)
            {
                case DateFormat.SystemShort:
                    return date.ToShortDateString() + " " + date.ToLongTimeString();

                case DateFormat.SystemLong:
                    return date.ToLongDateString() + " " + date.ToLongTimeString();

                case DateFormat.ISO8601:
                    return date.ToString("yyyy-MM-dd HH:mm:ss" + secondDecimalFormat);

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
