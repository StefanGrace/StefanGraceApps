using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXT_to_SRT
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile;
            int durationMills = 1000;
            string outputFile;

            switch (args.Length)
            {
                case 1:
                    inputFile = args[0];
                    outputFile = args[0].Contains('.') ? args[0].Substring(0, args[0].LastIndexOf('.')) + ".srt" : outputFile = args[0] + ".srt";
                    break;

                case 2:
                    inputFile = args[0];
                    try
                    {
                        durationMills = int.Parse(args[1]);
                    }
                    catch
                    {
                        Console.WriteLine("Second argument must be a duration in milliseconds.");
                        return;
                    }
                    outputFile = args[0].Contains('.') ? args[0].Substring(0, args[0].LastIndexOf('.')) + ".srt" : outputFile = args[0] + ".srt";
                    break;

                case 3:
                    inputFile = args[0];
                    try
                    {
                        durationMills = int.Parse(args[1]);
                    }
                    catch
                    {
                        Console.WriteLine("Second argument must be a duration in milliseconds.");
                        return;
                    }
                    outputFile = args[2];
                    break;

                default:
                    Console.WriteLine("This program takes the following arguments: input file path, [subtitle duration in miliseconds], [output file path].");
                    return;
            }

            string[] txtLines;

            try
            {
                txtLines = System.IO.File.ReadAllLines(inputFile);
            }
            catch
            {
                Console.WriteLine("Cannot open \"" + inputFile + "\".");
                return;
            }

            string[] srtLines = TXTtoSRT(txtLines, durationMills);

            try
            {
                System.IO.File.WriteAllLines(outputFile, srtLines);
            }
            catch
            {
                Console.WriteLine("Cannot write to \"" + outputFile + "\".");
                return;
            }
            
        }


        static string[] TXTtoSRT(string[] txtLines, int durationMills)
        {
            TimeSpan time = new TimeSpan();

            List<string> srtLines = new List<string>();

            for (int i = 0; i < txtLines.Length; i++)
            {
                // Subtitle number
                srtLines.Add((i + 1).ToString());

                // Timestamp
                string timeStamp = time.ToString(@"hh\:mm\:ss\,fff") + " --> ";
                time = time.Add(new TimeSpan(durationMills * 10_000));
                timeStamp += time.ToString(@"hh\:mm\:ss\,fff");
                srtLines.Add(timeStamp);

                // Text
                srtLines.Add(txtLines[i]);

                // Blank line
                srtLines.Add("");
            }

            return srtLines.ToArray();
        }
    }
}
