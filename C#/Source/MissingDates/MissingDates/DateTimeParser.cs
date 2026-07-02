using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MissingDates
{
    class DateTimeParser
    {
        public static string[] ReadDatesFromFile(string filepath)
        {
            return File.ReadAllLines(filepath);
        }

        public static void FindAndWriteMissingDatesToFile(string[] missingDates, string outputFilename = "MissingDates.txt")
        {
            File.WriteAllLines(outputFilename, FindMissingDates(missingDates));
        }

        public static void FindAndWriteMissingDatesToFile(string inputFilepath, string outputFilename = "MissingDates.txt")
        {
            FindAndWriteMissingDatesToFile(ReadDatesFromFile(inputFilepath), outputFilename);
        }

        public static string[] FindMissingDates(string[] datesStrings)
        {
            DateTime[] dates = ParseDates(datesStrings);
            DateTime[] missingDates = DateFinder.FindMissingDates(dates);

            string[] missingDateStrings = new string[missingDates.Length];

            for (int i = 0; i < missingDates.Length; i++)
            {
                missingDateStrings[i] = missingDates[i].ToString("d");
            }

            return missingDateStrings;

        }

        private static DateTime[] ParseDates(string[] dateStrings)
        {
            DateTime[] dates = new DateTime[dateStrings.Length];

            for (int i = 0; i < dateStrings.Length; i++)
            {
                dates[i] = DateTime.Parse(dateStrings[i]);
            }

            return dates;
        }
    }
}
