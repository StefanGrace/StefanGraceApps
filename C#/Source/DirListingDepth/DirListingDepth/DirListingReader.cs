using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirListingDepth
{
    class DirListingReader
    {
        public static DepthStats GetDepthStats(string[] dirListings, int bytesInKB)
        {
            int maxFolderDepth = 0;
            int folderHeadingline = -1;
            DepthStats depthStats = new DepthStats();

            for (int i = 0; i < dirListings.Length; i++)
            {
                if (dirListings[i].StartsWith("COMMENT\tLines beginning with \"FOLDER\""))
                {
                    folderHeadingline = i + 2;
                    break;
                }
            }

            string[] folderAttributes = SplitString(dirListings[folderHeadingline].Substring(8), " <TAB> ");


            foreach (string line in dirListings)
            {
                if (line.StartsWith("FOLDER"))
                {
                    string[] currentFolderProperties = SplitString(line.Substring(7), "\t");

                    int currentFolderDepth = 0;
                    for (int i = 0; i < folderAttributes.Length; i++)
                    {
                        switch (folderAttributes[i])
                        {
                            case "Full Name (Path+Folder)":
                                currentFolderDepth = CalculateFolderDepth(currentFolderProperties[i]);
                                if (currentFolderDepth > maxFolderDepth)
                                {
                                    maxFolderDepth = currentFolderDepth;
                                }
                                depthStats.AddFolder(currentFolderDepth);
                                break;

                            case "Number of Files":
                                depthStats.AddFiles(currentFolderDepth, int.Parse(currentFolderProperties[i].Replace(",", "")));
                                break;

                            case "Folder Size":
                                depthStats.AddBytes(currentFolderDepth, ParseSize(currentFolderProperties[i], bytesInKB));
                                break;
                        }
                    }
                }
            }

            depthStats.MaxFolderDepth = maxFolderDepth;

            return depthStats;
        }

        // Calculate the folder depth based on the path, root being 0
        private static int CalculateFolderDepth(string path)
        {
            int backslashesInPath = CountCharInString(path, '\\');
            if (path.EndsWith(@"\"))
            {
                backslashesInPath -= 1;
            }
            return backslashesInPath;
        }

        // Count the number of times a given character appears in a given string 
        private static int CountCharInString(string str, char character)
        {
            return str.Length - str.Replace(character.ToString(), "").Length;
        }

        private static string[] SplitString(string inputString, string seperator)
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

        private static long ParseSize(string sizeText, int inputBytesInKB)
        {
            // String of number of bytes with no unit
            if (long.TryParse(sizeText.Replace(",", ""), out long sizeInBytes))
            {
                return sizeInBytes;
            }

            string[] units = { "bytes", "KB", "MB", "GB", "TB", "PB" };

            for (int i = 0; i < units.Length; i++)
            {
                if (sizeText.EndsWith(units[i]))
                {
                    return (long)(double.Parse(sizeText.Substring(0, sizeText.Length - (units[i].Length + 1))) * Math.Pow(inputBytesInKB, i));
                }
            }

            return 0;
        }

    }
}
