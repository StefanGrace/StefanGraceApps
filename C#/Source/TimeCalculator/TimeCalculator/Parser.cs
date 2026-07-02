using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCalculator
{
    class Parser
    {
        public static double ParseNumber(string numberString)
        {
            return double.Parse(numberString);
        }


        public static TimeSpan ParseDuration(string durationString)
        {
            // Remove spaces and convert all letters to lowercase
            durationString = durationString.Replace(" ", "").ToLower();

            // Store a copy of the original input string before it gets modified
            string original = durationString;

            // Initialize string for each duration unit as "0"
            string yearString = "0";
            string dayString = "0";
            string hourString = "0";
            string minuteString = "0";
            string secondString = "0";
            string millisecondString = "0";
            string microsecondString = "0";
            string nanosecondString = "0";

            // If the input string is just a number, parse it as seconds
            {
                if (double.TryParse(durationString, out double result))
                {
                    secondString = durationString;
                    durationString = "";
                }
            }

            // If the input string contains colon(s),
            // x:x = min:s
            // x:x:x = h:min:s
            // x:x:x:x = day:h:min:s
            // x:x:x:x:x = year:day:h:min:s
            // > 4 colons (> 5 fields) will throw a FormatException
            if (durationString.Contains(':'))
            {
                string[] durationStringParts = durationString.Split(':');

                // Allow unit notation to precede colon notation (e.g. "1 y 80 d 6:30:24")
                if (double.TryParse(durationStringParts[0], out double result))
                {
                    durationString = "";
                }
                else
                {
                    // If the entire string up to the first colon is not parseable as a number, 
                    // split it into unit notation and first field of colon notation
                    bool isDigit = true;
                    StringBuilder digits = new StringBuilder();
                    StringBuilder restDuration = new StringBuilder();
                    for (int i = durationStringParts[0].Length - 1; i >= 0; i--)
                    {
                        if (!(char.IsDigit(durationStringParts[0][i]) ||
                            durationStringParts[0][i] == '.' ||
                            durationStringParts[0][i] == ',' ||
                            durationStringParts[0][i] == 'e' ||
                            durationStringParts[0][i] == '+' ||
                            durationStringParts[0][i] == '-'))
                        {
                            isDigit = false;
                        }

                        if (isDigit)
                        {
                            digits.Append(durationStringParts[0][i]);
                        }
                        else
                        {
                            restDuration.Append(durationStringParts[0][i]);
                        }
                    }

                    // Characters have been parsed in little endian, reverse them to big endian
                    durationStringParts[0] = new string(digits.ToString().Reverse().ToArray());
                    durationString = new string(restDuration.ToString().Reverse().ToArray());
                }

                secondString = durationStringParts[durationStringParts.Length - 1];
                minuteString = durationStringParts[durationStringParts.Length - 2];
                if (durationStringParts.Length >= 3)
                {
                    hourString = durationStringParts[durationStringParts.Length - 3];
                }
                if (durationStringParts.Length >= 4)
                {
                    dayString = durationStringParts[durationStringParts.Length - 4];
                }
                if (durationStringParts.Length >= 5)
                {
                    yearString = durationStringParts[durationStringParts.Length - 5];
                }
                if (durationStringParts.Length >= 6)
                {
                    throw new FormatException();
                }
            }

            // Parse string in unit format (e.g.: "1 y 80 d 6 h 30 min 24 s")
            // Units can be either just the first letter, the full word, or the first few letters
            // Units are allowed to contain decimal places (e.g. "1.5 h" = 1 h 30 min)
            // Units are allowed to overflow (e.g. "80 min" = 1 h 20 min)
            // Subsecond units are supported down to ns (must be in SI notation, micro can be either "µ" or "u");
            try
            {
                for (int i = 0; i < durationString.Length; i++)
                {
                    switch (durationString[i])
                    {
                        case 'y': // 'y' is year as long as it is not part of "day"
                            if (durationString[i - 1] != 'a') 
                            {
                                yearString = GetDigitsToLeft(durationString, i);
                            }
                            break;

                        case 'd': // 'd' is day as long as it is not part of "second"
                            if (durationString[i - 1] != 'n')
                            {
                                dayString = GetDigitsToLeft(durationString, i);
                            }
                            break;

                        case 'h': // 'h' is hour
                            hourString = GetDigitsToLeft(durationString, i);
                            break;

                        case 'm': // 'm' is minute as long as it is not part of "ms"
                            if (durationString.Length <= i + 1 || durationString[i + 1] != 's')
                            {
                                minuteString = GetDigitsToLeft(durationString, i);
                            }
                            break;

                        case 's': // 's' is second, the letter to the left of it is the prefix if there is one
                            switch (durationString[i - 1])
                            {
                                case 'm':
                                    millisecondString = GetDigitsToLeft(durationString, i - 1);
                                    break;

                                case 'µ':
                                case 'u':
                                    microsecondString = GetDigitsToLeft(durationString, i - 1);
                                    break;

                                case 'n':
                                    nanosecondString = GetDigitsToLeft(durationString, i - 1);
                                    if (nanosecondString == "")
                                    {
                                        nanosecondString = "0";
                                    }
                                    break;

                                default:
                                    if (!char.IsLetter(durationString[i - 1]))
                                    {
                                        secondString = GetDigitsToLeft(durationString, i);
                                    }
                                    break;

                            }
                            break;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                throw new FormatException();
            }

            // Parse each unit as a number
            double year = double.Parse(yearString);
            double day = double.Parse(dayString);
            double hour = double.Parse(hourString);
            double minute = double.Parse(minuteString);
            double second = double.Parse(secondString);
            double millisecond = double.Parse(millisecondString);
            double microsecond = double.Parse(microsecondString);
            double nanosecond = double.Parse(nanosecondString);

            // Convert all units to ticks (100 ns intervals) and add them together
            double ticks =
                (year * 365.2425 * 24 * 60 * 60 * 10_000_000) +
                (day * 24 * 60 * 60 * 10_000_000) +
                (hour * 60 * 60 * 10_000_000) +
                (minute * 60 * 10_000_000) +
                (second * 10_000_000) +
                (millisecond * 10_000) +
                (microsecond * 10) +
                (nanosecond / 100);

            // Create new TimeSpan object from ticks
            TimeSpan duration;
            checked
            {
                duration = new TimeSpan((long)Math.Round(ticks));
            }

            // If the TimeSpan is 0 and the input string does not start with "0", throw a FormatException
            if (duration.Ticks == 0)
            {
                if (!original.StartsWith("0"))
                {
                    throw new FormatException();
                }
            }

            return duration;
        }

        
        private static string GetDigitsToLeft(string inputString, int index)
        {
            // Walk backwards along string from index collecting each character, 
            // stop when you get to a character that is not parseable as a double
            StringBuilder sb = new StringBuilder();
            int countBack = 1;
            if (index - countBack < 0)
            {
                return "";
            }
            while (char.IsDigit(inputString[index - countBack]) ||
                inputString[index - countBack] == '.' ||
                inputString[index - countBack] == ',' ||
                inputString[index - countBack] == 'e' ||
                inputString[index - countBack] == '+' ||
                inputString[index - countBack] == '-')
            {
                sb.Append(inputString[index - countBack]);
                countBack++;
                if (index - countBack < 0)
                {
                    break;
                }
            }

            // Characters have been collected in little endian, reverse them to big endian
            return new string(sb.ToString().Reverse().ToArray());
        }


        public static DateTime ParseDateTime(string dateTimeString)
        {
            return DateTime.Parse(dateTimeString);
        }


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
    }
}
