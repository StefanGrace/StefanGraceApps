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
            List<string> isos = new List<string>();
            List<string> sampleTimes = new List<string>();
            TimeSpan duration = new TimeSpan();

            foreach (string line in metaText)
            {
                if (line.StartsWith("Duration") && !line.StartsWith("Duration Value"))
                {
                    duration = TimeSpanFromString(line.Substring(34), true);
                }
                else if (line.StartsWith("Sample Time"))
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
                else if (line.StartsWith("ISO"))
                {
                    isos.Add(line.Substring(34));
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
                    TimeSpan endTime;
                    if (sampleTime.Add(new TimeSpan(0, 0, 1)).TotalMilliseconds > duration.TotalMilliseconds)
                    {
                        endTime = duration;
                    }
                    else
                    {
                        endTime = sampleTime.Add(new TimeSpan(0, 0, 1));
                    }
                    outputLines.Add(sampleTime.ToString() + ",000 --> " + endTime.ToString(@"hh\:mm\:ss") + "," + endTime.Milliseconds.ToString("000"));

                    // Date/Time
                    outputLines.Add(timestamps[i].Substring(0, 10).Replace(':', '-') + timestamps[i].Substring(10));

                    // Apature, shutter speed, gain/ISO
                    shutterspeeds[i] = FixIncorrectShutterValues(shutterspeeds[i]);

                    if (isos.Count == 0)
                    {
                        outputLines.Add("f/" + apatures[i] + ", " + shutterspeeds[i] + ", " + gains[i].Replace(".00", ""));
                    }
                    else
                    {
                        outputLines.Add("f/" + apatures[i] + ", " + shutterspeeds[i] + ", ISO " + isos[i]);
                    }

                    // Blank line
                    outputLines.Add("");

                    srtIndex++;
                }
            }

            return outputLines.ToArray();
        }

        static TimeSpan TimeSpanFromString(string s, bool includeSubSeconds = false)
        {
            if (s.Contains("s"))
            {
                double seconds = double.Parse(s.TrimEnd('s'));
                if (includeSubSeconds)
                {
                    return new TimeSpan(0, 0, 0, (int)seconds, (int)((seconds % 1) * 1000));
                }
                else
                {
                    return new TimeSpan(0, 0, (int)seconds);
                }
            }
            else
            {
                return TimeSpan.Parse(s);
            }
        }

        static string FixIncorrectShutterValues(string shutterValue)
        {
            // Fixes incorrect shutterspeed values that some newer Sony cameras report

            string[,] corrections = new string[,]
            {
                { "1/32",   "1/30" },
                { "1/51",   "1/50" },
                { "1/64",   "1/60" },
                { "1/81",   "1/80" },
                { "1/101",  "1/100" },
                { "1/128",  "1/125" },
                { "1/161",  "1/160" },
                { "1/203",  "1/200" },
                { "1/256",  "1/250" },
                { "1/322",  "1/320" },
                { "1/406",  "1/400" },
                { "1/512",  "1/500" },
                { "1/645",  "1/640" },
                { "1/811",  "1/800" },
                { "1/1024", "1/1000" },
                { "1/1289", "1/1250" },
                { "1/1623", "1/1600" },
                { "1/2048", "1/2000" },
                { "1/2578", "1/2500" },
                { "1/3245", "1/3200" },
                { "1/4096", "1/4000" },
                { "1/5156", "1/5000" },
                { "1/6490", "1/6400" },
                { "1/8192", "1/8000" }
            };

            for(int i = 0; i < corrections.GetLength(0); i++)
            {
                if (shutterValue == corrections[i, 0])
                {
                    return corrections[i, 1];
                }
            }

            return shutterValue;
        }
    }
}
