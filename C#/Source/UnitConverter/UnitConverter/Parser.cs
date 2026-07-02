using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Parser
    {
        public static double ParseFeetAndInchesToMeters(string feetInches)
        {
            double feet = 0;
            double inches = 0;
            if (feetInches.Contains("'"))
            {
                string[] feetAndInches = feetInches.Replace(" ", "").Replace("\"", "").Split('\'');
                feet = double.Parse(feetAndInches[0]);
                inches = double.Parse(feetAndInches[1]);
            }
            else if (feetInches.Contains("\""))
            {
                inches = double.Parse(feetInches.Replace("\"", ""));
            }
            else if (feetInches.Contains(":"))
            {
                string[] feetAndInches = feetInches.Replace(" ", "").Replace("\"", "").Split(':');
                feet = double.Parse(feetAndInches[0]);
                inches = double.Parse(feetAndInches[1]);
            }
            else
            {
                feet = double.Parse(feetInches);
            }

            return  Converter.ConvertFromFeetAndInches(feet, inches, "", "m");
        }

        public static double ParseHoursMinutesSecondsToSeconds(string hoursMinutesSeconds)
        {
            double hours = 0;
            double minutes = 0;
            double seconds = 0;

            string[] hoursMinutesAndSeconds = hoursMinutesSeconds.Split(':');
            hours = double.Parse(hoursMinutesAndSeconds[0]);
            if (hoursMinutesAndSeconds.Length >= 2)
            {
                minutes = double.Parse(hoursMinutesAndSeconds[1]);
            }
            if (hoursMinutesAndSeconds.Length >= 3)
            {
                seconds = double.Parse(hoursMinutesAndSeconds[2]);
            }

            return Converter.ConvertFromHoursMinutesAndSeconds(hours, minutes, seconds, "", "s");
        }
    }
}
