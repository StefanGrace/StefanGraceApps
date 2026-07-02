using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRateCalculator
{
    class DataRateCalc
    {
        public static Tuple<double, string> CalculateDataRate(double inputData, string inputDataUnit, double inputTime, string inputTimeUnit,
            string outputMagnitude, string outputPrefixType, string outputDataUnit, double outputTime, string outputTimeUnit)
        {
            inputTimeUnit = CleanTimeUnit(inputTimeUnit);
            outputDataUnit = CleanDataUnit(outputDataUnit);
            outputTimeUnit = CleanTimeUnit(outputTimeUnit);

            double bitsPerSecond = CalculateBitsPerSecond(inputData, inputDataUnit, inputTime, inputTimeUnit);

            return CalculateDataPerTime(bitsPerSecond, outputMagnitude, outputPrefixType, outputDataUnit, outputTime, outputTimeUnit);
        }

        private static Tuple<double, string> CalculateDataPerTime(double bitsPerSecond, string magnitude, string prefixType, string dataUnit, double time, string timeUnit)
        {
            double dataUnitsPerSecond = bitsPerSecond / BitsInDataUnit(dataUnit);
            double dataUnitsPerTime = dataUnitsPerSecond * time * SecondsInTimeUnit(timeUnit);

            int unitsInMagnitude = UnitsInMagnitude(prefixType);

            if (magnitude.ToLower() == "auto")
            {
                magnitude = CalculateAutoMagnitude(dataUnitsPerTime, unitsInMagnitude);
            }

            double dataPerTime = dataUnitsPerTime / Math.Pow(unitsInMagnitude, Magnitude(magnitude));

            if (magnitude.ToLower() == "unit")
            {
                magnitude = "";
            }
            else if (magnitude == "k/K")
            {
                magnitude = unitsInMagnitude == 1024 ? "K" : "k";
            }

            bool unitPlural = SecondsInTimeUnit(timeUnit) >= SecondsInTimeUnit("day");

            string unit = magnitude + (unitsInMagnitude == 1024 && magnitude != "" ? "i" : "") + dataUnit + "/" +
                (time == 1 ? "" : "(" + time.ToString() + " ") + timeUnit + (time == 1 ? "" : (unitPlural ? "s" : "") + ")");

            return new Tuple<double, string>(dataPerTime, unit);
        }


        private static double CalculateBitsPerSecond(double data, string dataUnit, double time, string timeUnit)
        {
            double bitsInDataUnit = BitsInDataUnit(dataUnit) * Math.Pow(UnitsInMagnitude(dataUnit), Magnitude(dataUnit));
            double bits = data * bitsInDataUnit;

            double seconds = time * SecondsInTimeUnit(timeUnit);

            return bits / seconds;
        }


        private static string CalculateAutoMagnitude(double value, int unitsInMagnitude)
        {
            int magnitude = (int)Math.Floor(Math.Log(value, unitsInMagnitude));

            switch (magnitude)
            {
                case 0:
                    return "";

                case 1:
                    return unitsInMagnitude == 1024 ? "K" : "k";

                case 2:
                    return "M";

                case 3:
                    return "G";

                case 4:
                    return "T";

                case 5:
                    return "P";

                case 6:
                    return "E";

                case 7:
                    return "Z";

                case 8:
                    return "Y";

                case 9:
                    return "R";

                case 10:
                    return "Q";

                default:
                    return magnitude < 0 ? "" : "Q";
            }
        }


        private static int Magnitude(string dataUnit)
        {
            if (dataUnit.Length < 1)
            {
                return 0;
            }

            switch (dataUnit[0])
            {
                case 'k':
                case 'K':
                    return 1;

                case 'M':
                    return 2;

                case 'G':
                    return 3;

                case 'T':
                    return 4;

                case 'P':
                    return 5;

                case 'E':
                    return 6;

                case 'Z':
                    return 7;

                case 'Y':
                    return 8;

                case 'R':
                    return 9;

                case 'Q':
                    return 10;

                default:
                    return 0;
            }
        }

        private static int UnitsInMagnitude(string dataUnit)
        {
            switch (dataUnit.ToLower())
            {
                case "dec":
                case "decimal":
                    return 1000;

                case "bin":
                case "binary":
                    return 1024;

                default:
                    return dataUnit.Contains("i") ? 1024 : 1000;
            }
        }

        private static int BitsInDataUnit(string dataUnit)
        {
            if (dataUnit.EndsWith("b"))
            {
                return 1;
            }
            else if (dataUnit.EndsWith("B"))
            {
                return 8;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid data unit: " + dataUnit);
            }
        }

        private static double SecondsInTimeUnit(string timeUnit)
        {
            switch (timeUnit)
            {
                case "ms":
                    return 0.001;

                case "s":
                    return 1;

                case "min":
                    return 60;

                case "h":
                    return 60 * 60;

                case "day":
                    return 60 * 60 * 24;

                case "week":
                    return 60 * 60 * 24 * 7;

                case "year":
                    return 60 * 60 * 24 * 365.25;

                case "decade":
                    return 60 * 60 * 24 * 365.25 * 10;


                default:
                    throw new ArgumentOutOfRangeException("Invalid time unit: " + timeUnit);

            }
        }

        private static string CleanDataUnit(string dataUnit)
        {
            switch (dataUnit.ToLower())
            {
                case "bit":
                case "bits":
                    return "b";

                case "byte":
                case "bytes":
                    return "B";

                default:
                    return dataUnit;
            }
        }

        private static string CleanTimeUnit(string timeUnit)
        {
            switch (timeUnit.ToLower())
            {
                case "ms":
                case "millisecond":
                case "milliseconds":
                    return "ms";

                case "s":
                case "sec":
                case "secs":
                case "second":
                case "seconds":
                    return "s";

                case "m":
                case "min":
                case "mins":
                case "minute":
                case "minutes":
                    return "min";

                case "h":
                case "hr":
                case "hrs":
                case "hour":
                    return "h";

                case "d":
                case "day":
                case "days":
                    return "day";

                case "w":
                case "wk":
                case "week":
                case "weeks":
                    return "week";

                case "y":
                case "yr":
                case "year":
                case "years":
                    return "year";

                case "decade":
                case "decades":
                    return "decade";

                default:
                    return timeUnit;
            }

        }
    }
}
