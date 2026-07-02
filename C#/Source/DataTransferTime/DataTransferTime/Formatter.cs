using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferTime
{
    class Formatter
    {
        private const string singleUnitNumberFormat = "G7";
        private const string unitDecimalFormat = "0.0";
        private const double daysInYear = 365.2425;
        private const double ticksInYear = 10_000_000.0 * 60.0 * 60.0 * 24.0 * daysInYear;

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

        public static TimeSpan CreateTimeSpan(string timeUnit)
        {
            switch (timeUnit)
            {
                case "ms":
                    return new TimeSpan(0, 0, 0, 0, 1);

                case "s":
                    return new TimeSpan(0, 0, 1);

                case "min":
                    return new TimeSpan(0, 1, 0);

                case "h":
                    return new TimeSpan(1, 0, 0);

                case "day":
                    return new TimeSpan(1, 0, 0, 0);

                case "year":
                    return new TimeSpan(365, 5, 49, 12);

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static string FormatTransferTime(TimeSpan trasferTime, string format)
        {
            switch (format)
            {
                case "[[year] day] h:min:s.ms":
                    if (trasferTime.TotalMilliseconds < 1)
                    {
                        return FormatSubSecondsFromTicks(trasferTime.Ticks);
                    }
                    else if (trasferTime.TotalDays < 1)
                    {
                        return trasferTime.ToString(@"h\:mm\:ss\.fff");
                    }
                    else if (trasferTime.TotalDays < daysInYear)
                    {
                        return trasferTime.Days + " d " + trasferTime.ToString(@"hh\:mm\:ss\.fff");
                    }
                    else
                    {
                        return YearsFromTicks(trasferTime.Ticks) + " y " +
                            GetDurationInYear(trasferTime).Days + " d " +
                            GetDurationInYear(trasferTime).ToString(@"hh\:mm\:ss\.fff");
                    }


                case "[day] h:min:s.ms":
                    if (trasferTime.TotalMilliseconds < 1)
                    {
                        return FormatSubSecondsFromTicks(trasferTime.Ticks);
                    }
                    else if (trasferTime.TotalDays < 1)
                    {
                        return trasferTime.ToString(@"h\:mm\:ss\.fff");
                    }
                    else
                    {
                        return trasferTime.Days + " d " + trasferTime.ToString(@"hh\:mm\:ss\.fff");
                    }

                case "h:min:s.ms":
                    if (trasferTime.TotalMilliseconds < 1)
                    {
                        return FormatSubSecondsFromTicks(trasferTime.Ticks);
                    }
                    else
                    {
                        return Math.Truncate(trasferTime.TotalHours) + ":" + trasferTime.ToString(@"mm\:ss\.fff");
                    }

                case "unit + subunit":
                    if (trasferTime.TotalMinutes < 1)
                    {
                        return FormatSubSecondsFromTicks(trasferTime.Ticks);
                    }
                    else if (trasferTime.TotalHours < 1)
                    {
                        return trasferTime.Minutes + " min " + trasferTime.Seconds + " s";
                    }
                    else if (trasferTime.TotalDays < 1)
                    {
                        return trasferTime.Hours + " h " + trasferTime.Minutes + " min";
                    }
                    else if (trasferTime.TotalDays < daysInYear)
                    {
                        return trasferTime.Days + " d " + trasferTime.Hours + " h";
                    }
                    else
                    {
                        return YearsFromTicks(trasferTime.Ticks) + " y " + GetDurationInYear(trasferTime).Days + " d";
                    }


                case "unit + decimal":
                    if (trasferTime.TotalSeconds < 1)
                    {
                        return FormatSubSecondsFromTicks(trasferTime.Ticks);
                    }
                    else if (trasferTime.TotalMinutes < 1)
                    {
                        return trasferTime.TotalSeconds.ToString(unitDecimalFormat) + " s";
                    }
                    else if (trasferTime.TotalHours < 1)
                    {
                        return trasferTime.TotalMinutes.ToString(unitDecimalFormat) + " min";
                    }
                    else if (trasferTime.TotalDays < 1)
                    {
                        return trasferTime.TotalHours.ToString(unitDecimalFormat) + " h";
                    }
                    else if (trasferTime.TotalDays < daysInYear)
                    {
                        return trasferTime.TotalDays.ToString(unitDecimalFormat) + " d";
                    }
                    else
                    {
                        return (trasferTime.Days / daysInYear).ToString(unitDecimalFormat) + " y";
                    }


                case "ms":
                    return trasferTime.TotalMilliseconds.ToString(singleUnitNumberFormat) + " ms";

                case "s":
                    return trasferTime.TotalSeconds.ToString(singleUnitNumberFormat) + " s";

                case "min":
                    return trasferTime.TotalMinutes.ToString(singleUnitNumberFormat) + " min";

                case "h":
                    return trasferTime.TotalHours.ToString(singleUnitNumberFormat) + " h";

                case "day":
                    return trasferTime.TotalDays.ToString(singleUnitNumberFormat) + " d";

                case "year":
                    return (trasferTime.TotalDays / daysInYear).ToString(singleUnitNumberFormat) + " y";

                default:
                    throw new ArgumentOutOfRangeException();
            }
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

        private static int YearsFromTicks(long ticks)
        {
            return (int)(ticks / ticksInYear);
        }

        private static TimeSpan GetDurationInYear(TimeSpan duration)
        {
            return new TimeSpan((long)(duration.Ticks % ticksInYear));
        }
    }
}
