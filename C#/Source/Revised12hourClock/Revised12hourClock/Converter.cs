using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revised12hourClock
{
    class Converter
    {
        public string convertToCompact(int hour)
        {
            return convertToCompact(hour, -1);
        }

        public string convertToCompact(int hour, int minute)
        {
            return convertToCompact(hour, minute, -1);
        }

        public string convertToCompact(int hour, int minute, int second)
        {
            char letter;
            if (hour > 23 || minute > 59 || second > 60)
            {
                return "Invalid";
            }
            if (hour < 10)
            {
                letter = 'A';
            }
            else if (hour < 12) 
            {
                letter = 'B';
            }
            else if (hour < 22)
            {
                letter = 'P';
            }
            else
            {
                letter = 'Q';
            }
            int hour12compact = (hour % 12) % 10;
            return letter.ToString() + hour12compact + minuteSecondFormat(minute) + minuteSecondFormat(second);
        }

        public string convertToCompact(int hour, bool pm)
        {
            return convertToCompact(hour, -1, pm);
        }

        public string convertToCompact(int hour, int minute, bool pm)
        {
            return convertToCompact(hour, minute, -1, pm);
        }

        public string convertToCompact(int hour, int minute, int second, bool pm)
        {
            char letter;
            if (hour > 12 || hour < 1 || minute > 59 || second > 60)
            {
                return "Invalid";
            }
            if (hour == 12)
            {
                hour = 0;
            }
            if (!pm)
            {
                if (hour < 10)
                {
                    letter = 'A';
                }
                else
                {
                    letter = 'B';
                }
            }
            else
            {
                if (hour < 10)
                {
                    letter = 'P';
                }
                else
                {
                    letter = 'Q';
                }
            }
            int hour12long = hour % 10;
            return letter.ToString() + hour12long + minuteSecondFormat(minute) + minuteSecondFormat(second);
        }

        public string convertToLong(int hour)
        {
            return convertToLong(hour, -1);
        }

        public string convertToLong(int hour, int minute)
        {
            return convertToLong(hour, minute, -1);
        }

        public string convertToLong(int hour, int minute, int second)
        {
            if (hour > 23 || minute > 59 || second > 60)
            {
                return "Invalid";
            }
            char letter;
            if (hour < 12)
            {
                letter = 'A';
            }
            else
            {
                letter = 'P';
            }
            hour %= 12;
            return letter.ToString() + hour.ToString().PadLeft(2, '0') + minuteSecondFormat(minute) + minuteSecondFormat(second);
        }

        public string convertToLong(int hour, bool pm)
        {
            return convertToLong(hour, -1, pm);
        }

        public string convertToLong(int hour, int minute, bool pm)
        {
            return convertToLong(hour, minute, -1, pm);
        }

        public string convertToLong(int hour, int minute, int second, bool pm)
        {
            if (hour > 12 || hour < 1 || minute > 59 || second > 60)
            {
                return "Invalid";
            }
            if (hour == 12)
            {
                hour = 0;
            }
            char letter;
            if (pm)
            {
                letter = 'P';
            }
            else
            {
                letter = 'A';
            }

            return letter.ToString() + hour.ToString().PadLeft(2, '0') + minuteSecondFormat(minute) + minuteSecondFormat(second);
        }

        private string minuteSecondFormat(int minuteSecond)
        {
            string minuteSecondString = "" + minuteSecond;
            minuteSecondString = minuteSecondString.PadLeft(2, '0');
            minuteSecondString = ":" + minuteSecondString;
            if (minuteSecond == -1)
            {
                minuteSecondString = "";
            }
            return minuteSecondString;
        }
    }
}
