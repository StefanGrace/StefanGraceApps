using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DashcamFilenamesToSRT
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath;

            if (args.Length > 0)
            {
                inputFilePath = args[0];
            }
            else
            {
                Console.Write("Enter path of TXT file: ");
                inputFilePath = Console.ReadLine().Replace("\"", "");
            }

            string[] lines = File.ReadAllLines(inputFilePath);

            foreach (string line in lines)
            {
                try
                {
                    SRTCreator.CreateSRTFromFilename(line);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }



    }
}
