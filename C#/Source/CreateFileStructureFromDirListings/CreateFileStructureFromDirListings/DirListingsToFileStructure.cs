using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFileStructureFromDirListings
{
    class DirListingsToFileStructure
    {
        private int addFileSizeToName = 0; // 0 = no, 1 = start, 2 = end
        private int addFolderSizeToName = 0; // 0 = no, 1 = start, 2 = end
        private char invalidCharReplacement = '#';
        private string sizeUnit = "bytes";
        private int inputBytesInKB = 1000;
        private bool terminate = false;

        public void CreateFileStructure(string[] dirListings, string outputDir, bool includeFiles, IProgress<int> progress)
        {
            terminate = false;

            string[] folderAttributes = SplitString(dirListings[13].Substring(8), " <TAB> ");
            string[] fileAttributes = SplitString(dirListings[9].Substring(8), " <TAB> ");

            string currentFolderPath = "";

            int currentLine = 0;
            foreach (string line in dirListings)
            {
                if (line.StartsWith("FOLDER"))
                {
                    string[] currentFolderProperties = SplitString(line.Substring(7), "\t");

                    long folderSizeBytes = -1;
                    DateTime dateModified = new DateTime();
                    DateTime dateCreated = new DateTime();

                    for (int i = 0; i < folderAttributes.Length; i++)
                    {
                        switch (folderAttributes[i])
                        {
                            case "Full Name (Path+Folder)":
                                currentFolderPath = outputDir.TrimEnd('\\') +
                                    currentFolderProperties[i].Substring(2).Replace('?', invalidCharReplacement);
                                break;
                            case "Folder Size":
                                if (addFolderSizeToName != 0)
                                {
                                    folderSizeBytes = ParseSize(currentFolderProperties[i], inputBytesInKB);
                                }
                                break;
                            case "Date Last Modified":
                                dateModified = DateTime.Parse(currentFolderProperties[i]);
                                break;
                            case "Date Created":
                                dateCreated = DateTime.Parse(currentFolderProperties[i]);
                                break;
                        }
                    }

                    try
                    {
                        System.IO.Directory.CreateDirectory(currentFolderPath);

                        if (dateModified != new DateTime())
                        {
                            System.IO.Directory.SetLastWriteTime(currentFolderPath.TrimEnd('\\'), dateModified);
                        }
                        if (dateCreated != new DateTime())
                        {
                            System.IO.Directory.SetCreationTime(currentFolderPath.TrimEnd('\\'), dateCreated);
                        }
                    }
                    catch (System.IO.PathTooLongException)
                    {
                        currentFolderPath = "";
                    }

                }

                else if (line.StartsWith("FILE") && includeFiles && currentFolderPath != "")
                {
                    string[] currentFileProperties = SplitString(line.Substring(5), "\t");

                    string filename = "";
                    DateTime dateModified = new DateTime();
                    DateTime dateCreated = new DateTime();
                    long fileSizeBytes = -1;

                    for (int i = 0; i < fileAttributes.Length; i++)
                    {
                        switch (fileAttributes[i])
                        {
                            case "File Name":
                                filename = currentFileProperties[i].Replace('?', invalidCharReplacement);
                                break;
                            case "Date Last Modified":
                                dateModified = DateTime.Parse(currentFileProperties[i]);
                                break;
                            case "Date Created":
                                dateCreated = DateTime.Parse(currentFileProperties[i]);
                                break;
                            case "File Size":
                                if (addFileSizeToName != 0)
                                { 
                                    fileSizeBytes = ParseSize(currentFileProperties[i], inputBytesInKB);
                                }
                                break;
                        }
                    }

                    if (addFileSizeToName != 0)
                    {
                        long fileSize = ConvertSizeUnit(fileSizeBytes);

                        switch (addFileSizeToName)
                        {
                            case 1:
                                filename = "(" + fileSize + " " + sizeUnit + ") " + filename;
                                break;
                            case 2:
                                filename = SeperateExtenion(filename)[0] + " (" + fileSize.ToString("###,##0") + " " + sizeUnit + ")" +
                                    "." + SeperateExtenion(filename)[1];
                                break;
                        }
                    }
                    
                    try
                    {
                        System.IO.FileStream file = System.IO.File.Create(currentFolderPath + filename);
                        file.Close();

                        if (dateModified != new DateTime())
                        {
                            System.IO.File.SetLastWriteTime(currentFolderPath + filename, dateModified);
                        }
                        if (dateCreated != new DateTime())
                        {
                            System.IO.File.SetCreationTime(currentFolderPath + filename, dateCreated);
                        }
                    }
                    catch (System.IO.PathTooLongException) { }
                }

                currentLine++;
                progress.Report(currentLine);

                if (terminate)
                {
                    return;
                }
            }

        }

        private string[] SplitString(string inputString, string seperator)
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


        private string[] SeperateExtenion(string filenameWithExtention)
        {
            string filename;
            string extenion;

            int indexOfDot = filenameWithExtention.LastIndexOf('.');

            if (indexOfDot > -1)
            {
                filename = filenameWithExtention.Substring(0, indexOfDot);
                extenion = filenameWithExtention.Substring(indexOfDot + 1).ToUpper();
            }
            else
            {
                filename = filenameWithExtention;
                extenion = "";
            }

            return new string[] { filename, extenion };
        }

        private long ConvertSizeUnit(long bytes)
        {
            switch (sizeUnit)
            {
                case "kB":
                    return (long)Math.Ceiling((double)bytes / 1000);
                case "KiB":
                    return (long)Math.Ceiling((double)bytes / 1024);
                default:
                    return bytes;
            }
        }

        private long ParseSize(string sizeText, int inputBytesInKB)
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
                    return (long) (double.Parse(sizeText.Substring(0, sizeText.Length - (units[i].Length + 1))) * Math.Pow(inputBytesInKB, i));
                }
            }

            return 0;
        }

        public void Terminate()
        {
            terminate = true;
        }


        public int AddFileSizeToName
        {
            set
            {
                addFileSizeToName = value;
            }
        }

        public int AddFolderSizeToName
        {
            set
            {
                addFileSizeToName = value;
            }
        }

        public char InvalidCharReplacement
        {
            set
            {
                invalidCharReplacement = value;
            }
        }

        public string SizeUnit
        {
            set
            {
                sizeUnit = value;
            }
        }

        public int InputBytesInKB
        {
            set
            {
                inputBytesInKB = value;
            }
        }

    }
}
