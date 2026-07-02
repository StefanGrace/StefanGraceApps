using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SRT_to_TXT
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("This program must be started with the path of the input SRT file as the first argument.");
                Console.Read();
                return;
            }
            string[] inputLines = File.ReadAllLines(args[0]);
            string[] outputLines = Converter.CreateTXT(inputLines);

            string outputFile;
            if (args[0].ToLower().Contains(".srt"))
            {
                outputFile = args[0].Replace("srt", "txt").Replace("SRT", "TXT");
            }
            else
            {
                outputFile = args[0] + ".txt";
            }

            File.WriteAllLines(outputFile, outputLines);
        }
    }
}
