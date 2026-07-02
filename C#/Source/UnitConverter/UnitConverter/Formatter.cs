using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Formatter
    {
        public const string outputNumberFormat = "G8";

        public static string FormatToFeetAndInches(double inputValue, string inputPrefix, string inputUnit)
        {
            Tuple<double, double> feetAndInches = Converter.ConvertToFeetAndInches(inputValue, inputPrefix, inputUnit);

            if (Math.Abs(feetAndInches.Item2) < 0.01 && feetAndInches.Item2 != 0 && feetAndInches.Item1 == 0)
            {
                return feetAndInches.Item2.ToString(outputNumberFormat) + "\"";
            }
            else if (Math.Abs(feetAndInches.Item1) < 1E+9)
            {
                return feetAndInches.Item1.ToString() + "' " + feetAndInches.Item2.ToString("0.##") + "\"";
            }
            else
            {
                return Converter.ConvertLength(inputValue, inputPrefix, inputUnit, "", "ft").ToString(outputNumberFormat) + "'";
            }
        }

        public static string FormatToPoundsAndOunces(double inputValue, string inputPrefix, string inputUnit)
        {
            Tuple<double, double> poundsAndOunces = Converter.ConvertToPoundsAndOunces(inputValue, inputPrefix, inputUnit);

            if (poundsAndOunces.Item2 < 0.01 && poundsAndOunces.Item2 != 0 && poundsAndOunces.Item1 == 0)
            {
                return poundsAndOunces.Item2.ToString(outputNumberFormat) + " oz";
            }
            else if (poundsAndOunces.Item1 < 1E+9)
            {
                return poundsAndOunces.Item1.ToString() + ":" + poundsAndOunces.Item2.ToString("0.##");
            }
            else
            {
                return Converter.ConvertMass(inputValue, inputPrefix, inputUnit, "", "lb").ToString(outputNumberFormat) + " lb";
            }
        }

        public static string FormatToStonePoundsAndOunces(double inputValue, string inputPrefix, string inputUnit)
        {
            Tuple<double, double, double> stonePoundsAndOunces =
                Converter.ConvertToStonePoundsAndOunces(inputValue, inputPrefix, inputUnit);

            if (Math.Abs(stonePoundsAndOunces.Item3) < 0.01 &&
                stonePoundsAndOunces.Item3 != 0 &&
                stonePoundsAndOunces.Item2 == 0 &&
                stonePoundsAndOunces.Item1 == 0)
            {
                return stonePoundsAndOunces.Item3.ToString(outputNumberFormat) + " oz";
            }
            else if (Math.Abs(stonePoundsAndOunces.Item1) < 1E+9)
            {
                return 
                    stonePoundsAndOunces.Item1.ToString() + ":" + 
                    stonePoundsAndOunces.Item2.ToString() + ":" + 
                    stonePoundsAndOunces.Item3.ToString("0.##");
            }
            else
            {
                return Converter.ConvertMass(inputValue, inputPrefix, inputUnit, "", "st").ToString(outputNumberFormat) + " st";
            }
        }

        public static string FormatToHoursMinutesAndSeconds(double inputValue, string inputPrefix, string inputUnit)
        {
            Tuple<double, double, double> hoursMinutesSeconds = Converter.ConvertToHoursMinutesAndSeconds(inputValue, inputPrefix, inputUnit);

            if (Math.Abs(hoursMinutesSeconds.Item3) < 0.001 &&
                hoursMinutesSeconds.Item3 != 0 &&
                hoursMinutesSeconds.Item2 == 0 &&
                hoursMinutesSeconds.Item1 == 0)
            {
                return hoursMinutesSeconds.Item3.ToString(outputNumberFormat) + " s";
            }
            else if (Math.Abs(hoursMinutesSeconds.Item1) < 1E+8)
            {
                return
                    hoursMinutesSeconds.Item1.ToString() + ":" +
                    hoursMinutesSeconds.Item2.ToString("00") + ":" +
                    hoursMinutesSeconds.Item3.ToString("00.###");
            }
            else
            {
                return Converter.ConvertTime(inputValue, inputPrefix, inputUnit, "", "h").ToString(outputNumberFormat) + " h";
            }
        }

        public static string FormatToDaysHoursMinutesAndSeconds(double inputValue, string inputPrefix, string inputUnit)
        {
            Tuple<double, double, double, double> daysHoursMinutesSeconds =
                            Converter.ConvertToDaysHoursMinutesAndSeconds(inputValue, inputPrefix, inputUnit);

            if (Math.Abs(daysHoursMinutesSeconds.Item4) < 0.001 &&
                daysHoursMinutesSeconds.Item4 != 0 &&
                daysHoursMinutesSeconds.Item3 == 0 &&
                daysHoursMinutesSeconds.Item2 == 0 &&
                daysHoursMinutesSeconds.Item1 == 0)
            {
                return daysHoursMinutesSeconds.Item4.ToString(outputNumberFormat) + " s";
            }
            else if (Math.Abs(daysHoursMinutesSeconds.Item1) < 1E+7)
            {
                return
                    daysHoursMinutesSeconds.Item1.ToString() + ":" +
                    daysHoursMinutesSeconds.Item2.ToString("00") + ":" +
                    daysHoursMinutesSeconds.Item3.ToString("00") + ":" +
                    daysHoursMinutesSeconds.Item4.ToString("00.###");
            }
            else
            {
                return Converter.ConvertTime(inputValue, inputPrefix, inputUnit, "", "day").ToString("G7") + " day";
            }
        }


        public static string FormatToDegreesArcminutesArcseconds(double inputValue, string inputPrefix, string inputUnit)
        {
            Tuple<double, double, double> DegreesArcminsArcSecs =
                Converter.ConvertToDegreesArcminutesArcseconds(inputValue, inputPrefix, inputUnit);

            if (Math.Abs(DegreesArcminsArcSecs.Item3) < 0.01 &&
                DegreesArcminsArcSecs.Item3 != 0 &&
                DegreesArcminsArcSecs.Item2 == 0 &&
                DegreesArcminsArcSecs.Item1 == 0)
            {
                return DegreesArcminsArcSecs.Item3.ToString(outputNumberFormat) + "\"";
            }
            else if (Math.Abs(DegreesArcminsArcSecs.Item1) < 1E+6)
            {
                return
                    DegreesArcminsArcSecs.Item1.ToString() + "° " +
                    DegreesArcminsArcSecs.Item2.ToString("00") + "' " +
                    DegreesArcminsArcSecs.Item3.ToString("00.##") + "\"";
            }
            else
            {
                return Converter.ConvertAngle(inputValue, inputPrefix, inputUnit, "", "deg").ToString(outputNumberFormat) + "°";
            }
        }
    }
}
