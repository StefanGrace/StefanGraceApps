using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DashcamFilenamesToSRT
{
    class SRTCreator
    {
        public static void CreateSRTFromFilename(string filename)
        {
            CreateSRTFromFilename(filename, new TimeSpan(0, 1, 0));
        }

        public static void CreateSRTFromFilename(string filename, TimeSpan duration)
        {
            DateTime startTime = ParseDateTime(filename);
            DateTime dateAndTime = startTime;

            TimeSpan subTime = new TimeSpan();
            int subNum = 1;

            List<string> srt = new List<string>();

            while (dateAndTime.Ticks < startTime.Ticks + duration.Ticks)
            {
                srt.Add(subNum.ToString());
                srt.Add(subTime.ToString() + ",000 --> " + subTime.Add(new TimeSpan(0, 0, 1)).ToString() + ",000");
                srt.Add(dateAndTime.ToString("yyyy-MM-dd HH:mm:ss"));
                srt.Add("");

                subNum++;
                subTime = subTime.Add(new TimeSpan(0, 0, 1));
                dateAndTime = dateAndTime.AddSeconds(1);
            }

            string outputFilename = filename.Replace(".MP4", "").Replace(".mp4", "") + ".srt";
            File.WriteAllLines(outputFilename, srt);

        }

        private static DateTime ParseDateTime(string filename)
        {
            // Assumes filename is formatted YYYY_MMDD_HHmmss...

            int year = int.Parse(filename.Substring(0, 4));
            int month = int.Parse(filename.Substring(5, 2));
            int day = int.Parse(filename.Substring(7, 2));
            int hour = int.Parse(filename.Substring(10, 2));
            int minute = int.Parse(filename.Substring(12, 2));
            int second = int.Parse(filename.Substring(14, 2));

            return new DateTime(year, month, day, hour, minute, second);
        }
    }
}
