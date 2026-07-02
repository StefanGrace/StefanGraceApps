using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextCharAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath;
            if (args.Length > 0)
            {
                filepath = args[0];
            }
            else
            {
                Console.Write("Enter filepath: ");
                filepath = Console.ReadLine().Replace("\"", "");
                Console.WriteLine();
            }

            Encoding encoding = AskEncoding();
            Console.WriteLine();

            string text = encoding == null ? File.ReadAllText(filepath) : File.ReadAllText(filepath, encoding);

            Tuple<string, int>[] stats = TextAnalyser.AnalyseText(text);

            const string numberFormat = "N0";
            const string percentFormat = "P2";

            string[] tableHeadings = new string[] { "Char type", "Count", "Percent" };
            bool[] columAlignment = new bool[] { false, true, true };
            string[,] data = new string[stats.Length - 1, 3];
            string[] footer = new string[3];

            int row = 0;
            foreach (Tuple<string, int> stat in stats)
            {
                if (stat.Item2 == -1)
                {
                    data[row, 0] = "";
                    data[row, 1] = "";
                    data[row, 2] = "";
                }
                else if (stat.Item1 == "Total")
                {
                    footer[0] = stat.Item1;
                    footer[1] = stat.Item2.ToString(numberFormat);
                    footer[2] = "";
                }
                else
                {
                    double portion = (double)stat.Item2 / stats[stats.Length - 1].Item2;

                    data[row, 0] = stat.Item1;
                    data[row, 1] = stat.Item2.ToString(numberFormat);
                    data[row, 2] = portion.ToString(percentFormat);
                }

                row++;
            }

            string[] table = DataFormatter.MakeTable(tableHeadings, data, columAlignment, true, footer);

            foreach (string line in table)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.Write("Press W to write chars to file, any other key to exit...");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.W)
            {
                Console.WriteLine();
                Console.WriteLine();
                FileWriter.FilterAndWriteText(text, filepath, encoding);
            }
        }


        static Encoding AskEncoding()
        {
            Console.WriteLine("Select encoding:");
            Console.WriteLine("0 - Auto-detect");
            Console.WriteLine("1 - ANSI");
            Console.WriteLine("2 - UTF-8");
            Console.WriteLine("3 - UTF-16 BE");
            Console.WriteLine("4 - UTF-16 LE");
            Console.WriteLine("5 - Other");
            Console.WriteLine();
            Console.Write("Enter choice: ");

            string userChoice = Console.ReadLine();

            switch (userChoice.ToLower())
            {
                case "0":
                case "auto":
                case "auto-detect":
                case "":
                    return null;

                case "1":
                case "ansi":
                    return Encoding.Default;

                case "2":
                case "utf-8":
                    return Encoding.UTF8;

                case "3":
                case "utf-16 be":
                    return Encoding.BigEndianUnicode;

                case "4":
                case "utf-16 le":
                    return Encoding.Unicode;

                case "5":
                case "other":

                    EncodingInfo[] encodings = Encoding.GetEncodings();

                    string[] encodingTableHeadings = new string[] { "Code page", "Name", "Display name" };
                    bool[] encodingTableAlignment = new bool[] { true, false, false };
                    string[,] encodingTableData = new string[encodings.Length, 3];

                    for (int i = 0; i < encodings.Length; i++)
                    {
                        encodingTableData[i, 0] = encodings[i].CodePage.ToString();
                        encodingTableData[i, 1] = encodings[i].Name;
                        encodingTableData[i, 2] = encodings[i].DisplayName;
                    }

                    string[] encodingsTable = DataFormatter.MakeTable(encodingTableHeadings, encodingTableData, encodingTableAlignment, true);

                    foreach (string line in encodingsTable)
                    {
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.Write("Enter code page or name: ");
                    string userCustomChoice = Console.ReadLine();
                    try
                    {
                        return Encoding.GetEncoding(int.Parse(userCustomChoice));
                    }
                    catch
                    {
                        try
                        {
                            return Encoding.GetEncoding(userCustomChoice);
                        }
                        catch
                        {
                            Console.WriteLine("Invalid choice.");
                            Console.WriteLine();
                            return AskEncoding();
                        }
                    }

                default:
                    Console.WriteLine("Invalid choice.");
                    Console.WriteLine();
                    return AskEncoding();
            }        
        }
    }
}
