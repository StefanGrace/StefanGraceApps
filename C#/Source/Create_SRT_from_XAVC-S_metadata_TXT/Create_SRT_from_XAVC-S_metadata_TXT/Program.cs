using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_SRT_from_XAVC_S_metadata_TXT
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string outputFile = args.Length < 2 ? args[0].Substring(0, args[0].LastIndexOf('.')) + ".srt" : args[1];
                System.IO.File.WriteAllLines(outputFile, MetaToSRT(System.IO.File.ReadAllLines(args[0])));
            }
            catch
            {
                Console.WriteLine("To use this program, enter the input TXT file as the first parameter, and the output SRT file as the second parameter");
            }
        }

        static string[] MetaToSRT(string[] metaText)
        {
            List<string> timestamps = new List<string>();
            List<string> apatures = new List<string>();
            List<string> shutterspeeds = new List<string>();
            List<string> gains = new List<string>();
            List<string> sampleTimes = new List<string>();

            foreach (string line in metaText)
            {      
                if (line.StartsWith("Sample Time"))
                {
                    sampleTimes.Add(line.Substring(34));
                }
                else if (line.StartsWith("F Number"))
                {
                    apatures.Add(line.Substring(34));
                }
                else if (line.StartsWith("Exposure Time"))
                {
                    shutterspeeds.Add(line.Substring(34));
                }
                else if (line.StartsWith("Master Gain Adjustment"))
                {
                    gains.Add(line.Substring(34));
                }
                else if (line.StartsWith("Date Time"))
                {
                    timestamps.Add(line.Substring(34));
                }
            }

            int srtIndex = 0;
            List<string> outputLines = new List<string>();

            for (int i = 0; i < timestamps.Count; i++)
            {
                if (i == 0 || TimeSpanFromString(sampleTimes[i]) != TimeSpanFromString(sampleTimes[i - 1]))
                {
                    // Subtitle number
                    outputLines.Add((srtIndex + 1).ToString());

                    // Subtitle time
                    TimeSpan sampleTime = TimeSpanFromString(sampleTimes[i]);
                    outputLines.Add(sampleTime.ToString() + ",000 --> " + sampleTime.Add(new TimeSpan(0, 0, 1)).ToString() + ",000");

                    // Date/Time
                    outputLines.Add(timestamps[i].Substring(0, 10).Replace(':', '-') + timestamps[i].Substring(10));

                    // Apature, shutter speed, gain
                    outputLines.Add("f/" + apatures[i] + ", " + shutterspeeds[i] + ", " + gains[i]);

                    // Blank line
                    outputLines.Add("");

                    srtIndex++;
                }
            }

            return outputLines.ToArray();
        }

        static TimeSpan TimeSpanFromString(string s)
        {
            if (s.Contains("s"))
            {
                double seconds = double.Parse(s.TrimEnd('s'));
                return new TimeSpan(0, 0, (int)seconds);
            }
            else
            {
                return TimeSpan.Parse(s);
            }
        }
    }
}
