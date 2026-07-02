using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TotalDirListings
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath;
            if (args.Length > 0 && args[0].ToLower().EndsWith("txt"))
            {
                filepath = args[0];
            }
            else
            {
                Console.Write("Enter file path: ");
                filepath = Console.ReadLine().Replace("\"", "");
                Console.WriteLine();
            }

            string[] dirListings = File.ReadAllLines(filepath);

            long[] totals = TotalDirListings(dirListings);

            Console.WriteLine("Total size: " + totals[0].ToString("###,###,###,###,##0") + " bytes");
            Console.WriteLine("Total files: " + totals[1].ToString("###,###,###,###,##0"));
            Console.WriteLine("Total folders: " + totals[2].ToString("###,###,###,###,##0"));
            Console.WriteLine();
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }

        static long[] TotalDirListings(string[] dirListings)
        {
            long totalSize = 0;
            long totalFiles = 0;
            long totalFolders = 0;

            string[] fileAttributes = SplitString(dirListings[9].Substring(8), " <TAB> ");

            foreach (string line in dirListings)
            {
                if (line.StartsWith("FOLDER"))
                {
                    totalFolders++;
                }
                else if (line.StartsWith("FILE"))
                {
                    totalFiles++;

                    string[] currentFileProperties = SplitString(line.Substring(5), "\t");
                    for (int i = 0; i < fileAttributes.Length; i++)
                    {
                        if (fileAttributes[i] == "File Size")
                        {
                            totalSize += long.Parse(currentFileProperties[i].Replace(",", ""));
                        }
                    }
                }
            }

            return new long[] { totalSize, totalFiles, totalFolders };
        }

        static string[] SplitString(string inputString, string seperator)
        {
            List<string> outputStrings = new List<string>();
            string currentString = "";

            for (int i = 0; i < inputString.Length; i++)
            {
                if (i + seperator.Length <= inputString.Length && inputString.Substring(i, seperator.Length) == seperator)
                {
                    outputStrings.Add(currentString);
                    i += seperator.Length - 1;
                    currentString = "";
                }
                else
                {
                    currentString += inputString[i];
                }
            }
            outputStrings.Add(currentString);

            return outputStrings.ToArray();
        }
    }
}
