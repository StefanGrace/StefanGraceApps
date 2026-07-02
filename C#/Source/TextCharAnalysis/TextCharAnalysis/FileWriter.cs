using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextCharAnalysis
{
    class FileWriter
    {
        public static void FilterAndWriteText(string text, string inputFilepath, Encoding inputFileEncoding)
        {
            const string outputDir = "TextCharAnalysis";
            Encoding outputFileEncoding = Encoding.UTF8;

            Directory.CreateDirectory(outputDir);

            Console.WriteLine("Select character filter:");
            Console.WriteLine("0 - All (no filter)");
            Console.WriteLine("1 - ASCII");
            Console.WriteLine("2 - ASCII non-control");
            Console.WriteLine("3 - Non-ASCII");
            Console.WriteLine("4 - Two-byte UTF-8");
            Console.WriteLine("5 - Three-byte UTF-8");
            Console.WriteLine("6 - Non-BMP");
            Console.WriteLine("7 - Lines with non-ASCII");
            Console.WriteLine("8 - Lines with two-byte UTF-8");
            Console.WriteLine("9 - Lines with three-byte UTF-8");
            Console.WriteLine("10 - Lines with non-BMP");
            Console.WriteLine("11 - Lines question mark or non-ASCII");
            Console.WriteLine("12 - Lines with question mark");
            Console.WriteLine();
            Console.Write("Enter choice: ");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    File.WriteAllText(outputDir + @"\" + "AllText.txt", text, outputFileEncoding);
                    break;

                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                    string outputFilename = "FilteredText";
                    StringBuilder sb = new StringBuilder();
                    foreach (char character in text)
                    {
                        switch (userChoice)
                        {
                            case "1":
                                outputFilename = "AsciiChars";
                                if (character < 128)
                                {
                                    sb.Append(character);
                                }
                                break;

                            case "2":
                                outputFilename = "AsciiNonCtrlChars";
                                if (character < 127 || character >= 32)
                                {
                                    sb.Append(character);
                                }
                                break;

                            case "3":
                                outputFilename = "NonAsciiChars";
                                if (character >= 128)
                                {
                                    sb.Append(character);
                                }
                                break;

                            case "4":
                                outputFilename = "TwoByteUTF8Chars";
                                if (character >= 128 && character < 2048)
                                {
                                    sb.Append(character);
                                }
                                break;

                            case "5":
                                outputFilename = "ThreeByteUTF8Chars";
                                if (character >= 2048 && !char.IsSurrogate(character))
                                {
                                    sb.Append(character);
                                }
                                break;

                            case "6":
                                outputFilename = "NonBMPChars";
                                if (char.IsSurrogate(character))
                                {
                                    sb.Append(character);
                                }
                                break;
                        }
                    }

                    File.WriteAllText(outputDir + @"\" + outputFilename + ".txt", sb.ToString(), outputFileEncoding);
                    break;

                case "7":
                case "8":
                case "9":
                case "10":
                case "11":
                case "12":
                    outputFilename = "FilteredLines";
                    string[] lines;
                    if (inputFileEncoding == null)
                    {
                        lines = File.ReadAllLines(inputFilepath);
                    }
                    else
                    {
                        lines = File.ReadAllLines(inputFilepath, inputFileEncoding);
                    }
                    
                    List<string> filteredLines = new List<string>();
                    foreach (string line in lines)
                    {
                        bool charFound = false;
                        foreach (char character in line)
                        {
                            switch (userChoice)
                            {
                                case "7":
                                    outputFilename = "NonAsciiLines";
                                    if (character >= 128)
                                    {
                                        filteredLines.Add(line);
                                        charFound = true;
                                    }
                                    break;

                                case "8":
                                    outputFilename = "TwoByteUTF8Lines";
                                    if (character >= 128 && character < 2048)
                                    {
                                        filteredLines.Add(line);
                                        charFound = true;
                                    }
                                    break;

                                case "9":
                                    outputFilename = "ThreeByteUTF8Lines";
                                    if (character >= 2048 && !char.IsSurrogate(character))
                                    {
                                        filteredLines.Add(line);
                                        charFound = true;
                                    }
                                    break;

                                case "10":
                                    outputFilename = "NoneBMPLines";
                                    if (char.IsSurrogate(character))
                                    {
                                        filteredLines.Add(line);
                                        charFound = true;
                                    }
                                    break;

                                case "11":
                                    outputFilename = "QmarkOrNonAsciiLines";
                                    if (character >= 128 || character == '?')
                                    {
                                        filteredLines.Add(line);
                                        charFound = true;
                                    }
                                    break;

                                case "12":
                                    outputFilename = "QmarkLines";
                                    if (character == '?')
                                    {
                                        filteredLines.Add(line);
                                        charFound = true;
                                    }
                                    break;
                            }

                            if (charFound)
                            {
                                break;
                            }
                        }
                    }

                    File.WriteAllLines(outputDir + @"\" + outputFilename + ".txt", filteredLines, outputFileEncoding);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    Console.WriteLine();
                    FilterAndWriteText(text, inputFilepath, inputFileEncoding);
                    break;
            }
        }
    }
}
