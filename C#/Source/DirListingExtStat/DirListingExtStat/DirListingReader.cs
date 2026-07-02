using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirListingExtStat
{
    class DirListingReader
    {
        public static bool IsPathInDirListings(string[] dirListings, string path)
        {
            foreach (string line in dirListings)
            {
                if (line.ToLower().Contains(path.ToLower()))
                {
                    return true;
                }
            }

            return false;
        }

        public static List<FileType> GetExtStats(string[] dirListings, bool caseSensitive, int bytesInKB, string path = "")
        {
            List<FileType> extStats = new List<FileType>();

            string[] fileAttributes = SplitString(dirListings[9].Substring(8), " <TAB> ");

            int folderHeadingline = -1;
            for (int i = 0; i < dirListings.Length; i++)
            {
                if (dirListings[i].StartsWith("COMMENT\tLines beginning with \"FOLDER\""))
                {
                    folderHeadingline = i + 2;
                    break;
                }
            }
            string[] folderAttributes = null;
            if (folderHeadingline != -1)
            {
                folderAttributes = SplitString(dirListings[folderHeadingline].Substring(8), " <TAB> ");
            }

            bool includeCurrentFolder = true;

            foreach (string line in dirListings)
            {
                if (line.StartsWith("FOLDER"))
                {
                    string[] currentFolderProperties = SplitString(line.Substring(7), "\t");
                    for (int i = 0; i < folderAttributes.Length; i++)
                    {
                        if (folderAttributes[i] == "Full Name (Path+Folder)")
                        {
                            includeCurrentFolder = currentFolderProperties[i].ToLower().StartsWith(path.ToLower());
                        }
                    }
                }

                else if (line.StartsWith("FILE") && includeCurrentFolder)
                {
                    string extention = "";
                    long bytes = 0;

                    string[] currentFileProperties = SplitString(line.Substring(5), "\t");
                    for (int i = 0; i < fileAttributes.Length; i++)
                    {
                        if (fileAttributes[i] == "File Name")
                        {
                            extention = SeperateExtenion(currentFileProperties[i])[1];
                        }
                        else if(fileAttributes[i] == "Full Name (Path+File)")
                        {
                            string filename = SeperateFileFromPath(currentFileProperties[i])[1];
                            extention = SeperateExtenion(filename)[1];
                        }
                        else if (fileAttributes[i] == "File Size")
                        {
                            try
                            {
                                bytes = long.Parse(currentFileProperties[i].Replace(",", ""));
                            }
                            catch
                            {
                                if (currentFileProperties[i].EndsWith("bytes"))
                                {
                                    bytes = long.Parse(currentFileProperties[i].Substring(0, currentFileProperties[i].Length - 6));
                                }
                                else if (currentFileProperties[i].EndsWith("KB"))
                                {
                                    bytes = (long)(double.Parse(currentFileProperties[i].Substring(0, currentFileProperties[i].Length - 3)) * bytesInKB);
                                }
                                else if (currentFileProperties[i].EndsWith("MB"))
                                {
                                    bytes = (long)(double.Parse(currentFileProperties[i].Substring(0, currentFileProperties[i].Length - 3)) * Math.Pow(bytesInKB, 2));
                                }
                                else if (currentFileProperties[i].EndsWith("GB"))
                                {
                                    bytes = (long)(double.Parse(currentFileProperties[i].Substring(0, currentFileProperties[i].Length - 3)) * Math.Pow(bytesInKB, 3));
                                }
                                else if (currentFileProperties[i].EndsWith("TB"))
                                {
                                    bytes = (long)(double.Parse(currentFileProperties[i].Substring(0, currentFileProperties[i].Length - 3)) * Math.Pow(bytesInKB, 4));
                                }
                                else if (currentFileProperties[i].EndsWith("PB"))
                                {
                                    bytes = (long)(double.Parse(currentFileProperties[i].Substring(0, currentFileProperties[i].Length - 3)) * Math.Pow(bytesInKB, 5));
                                }
                            }
                        }
                    }

                    if (!caseSensitive)
                    {
                        extention = extention.ToUpper();
                    }

                    bool found = false;
                    foreach (FileType extStat in extStats)
                    {
                        
                        if (extStat.Extention == extention)
                        {
                            extStat.Files++;
                            extStat.Bytes += bytes;
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        extStats.Add(new FileType(extention, 1, bytes));
                    }
                }
            }

            return extStats;
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

        private static string[] SeperateExtenion(string filenameWithExtention)
        {
            return SeperateByLastInstance(filenameWithExtention, '.');
        }

        private static string[] SeperateFileFromPath(string filenameWithPath)
        {
            return SeperateByLastInstance(filenameWithPath, '\\');
        }

        private static string[] SeperateByLastInstance(string text, char seperator)
        {
            string firstPart;
            string lastPart;

            int indexOfChar = text.LastIndexOf(seperator);

            if (indexOfChar > -1)
            {
                firstPart = text.Substring(0, indexOfChar);
                lastPart = text.Substring(indexOfChar + 1);
            }
            else
            {
                firstPart = text;
                lastPart = "";
            }

            return new string[] { firstPart, lastPart };
        }
    }
}
