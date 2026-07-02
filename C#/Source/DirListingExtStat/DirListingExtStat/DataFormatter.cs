using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirListingExtStat
{
    class DataFormatter
    {
        public static string[] MakeExtStatTable(List<FileType> extStats, string numberFormat, bool totals, int maxExtLength, int maxItems = int.MaxValue, bool showTypes = false)
        {
            ExtStatData extStatData = MakeExtStatData(extStats, numberFormat, totals, maxExtLength, maxItems, showTypes);
            return MakeTable(extStatData.Headings, extStatData.Data, extStatData.RightAlign, true, extStatData.Footer);
        }

        public static ExtStatData MakeExtStatData(List<FileType> extStats, string numberFormat, bool totals, int maxExtLength, int maxItems = int.MaxValue, bool showTypes = false)
        {
            // Set heading names
            string[] headings = { showTypes ? "Type" : "Ext", "Files", "% files", "Size (bytes)", "% bytes", "Bytes per file" };
            bool[] rightAlign = { false, true, true, true, true, true };

            // Calculate totals
            long totalFiles = 0;
            long totalBytes = 0;
            for (int i = 0; i < extStats.Count; i++)
            {
                totalFiles += extStats[i].Files;
                totalBytes += extStats[i].Bytes;
            }

            // Format data
            int dataRows = Math.Min(extStats.Count, maxItems);
            bool showOther = maxItems < extStats.Count;
            int extraRows = showOther ? 1 : 0;
            string[,] data = new string[dataRows + extraRows, headings.Length];
            for (int i = 0; i < dataRows; i++)
            {
                if (extStats[i].Extention.Length <= maxExtLength)
                {
                    data[i, 0] = extStats[i].Extention;
                }
                else
                {
                    data[i, 0] = extStats[i].Extention.Substring(0, maxExtLength - 2) + "..";
                }
                data[i, 1] = extStats[i].Files.ToString(numberFormat);
                data[i, 2] = FormatPercent(extStats[i].Files, totalFiles);
                data[i, 3] = extStats[i].Bytes.ToString(numberFormat);
                data[i, 4] = FormatPercent(extStats[i].Bytes, totalBytes);
                data[i, 5] = extStats[i].BytesPerFile.ToString(numberFormat);
            }

            // Add "Other" row if there's other extensions that are not shown
            if (showOther)
            {
                long otherFiles = 0;
                long otherBytes = 0;
                for (int i = dataRows; i < extStats.Count; i++)
                {
                    otherFiles += extStats[i].Files;
                    otherBytes += extStats[i].Bytes;
                }
                data[data.GetLength(0) - 1, 0] = "Other";
                data[data.GetLength(0) - 1, 1] = otherFiles.ToString(numberFormat);
                data[data.GetLength(0) - 1, 2] = FormatPercent(otherFiles, totalFiles);
                data[data.GetLength(0) - 1, 3] = otherBytes.ToString(numberFormat);
                data[data.GetLength(0) - 1, 4] = FormatPercent(otherBytes, totalBytes);
                data[data.GetLength(0) - 1, 5] = ((double)otherBytes / otherFiles).ToString(numberFormat);
            }

            // Add totals row
            if (totals && extStats.Count != 1)
            {
                string[] footer = new string[headings.Length];
                footer[0] = "Total";
                footer[1] = totalFiles.ToString(numberFormat);
                footer[2] = "";
                footer[3] = totalBytes.ToString(numberFormat);
                footer[4] = "";
                footer[5] = ((double)totalBytes / totalFiles).ToString(numberFormat);
                return new ExtStatData(headings, data, rightAlign, footer);
            }

            // Make table
            return new ExtStatData(headings, data, rightAlign);
        }

        public static string[] MakeExtStatCSV(List<FileType> extStats, bool totals, int maxItems = int.MaxValue, bool showTypes = false)
        {
            string[,] extStatData = MakeExtStatDataCSV(extStats, totals, maxItems, showTypes);
            return MakeCSV(extStatData);
        }

        public static string[,] MakeExtStatDataCSV(List<FileType> extStats, bool totals, int maxItems = int.MaxValue, bool showTypes = false)
        {
            bool showTotals = totals && extStats.Count != 1;
            bool showOther = extStats.Count > maxItems;

            // Calculate row count
            int extraRows = 1;
            if (showOther)
            {
                extraRows++;
            }
            if (showTotals)
            {
                extraRows++;
            }
            int dataRows = Math.Min(extStats.Count, maxItems);
            int totalRows = dataRows + extraRows;

            // Initalize array
            string[,] data = new string[totalRows, 6];

            // Set headings
            data[0, 0] = showTypes ? "Type" : "Ext";
            data[0, 1] = "Files";
            data[0, 2] = "Portion of total files";
            data[0, 3] = "Size (bytes)";
            data[0, 4] = "Portion of total bytes";
            data[0, 5] = "Bytes per file";

            // Calculate totals
            long totalFiles = 0;
            long totalBytes = 0;
            for (int i = 0; i < extStats.Count; i++)
            {
                totalFiles += extStats[i].Files;
                totalBytes += extStats[i].Bytes;
            }

            // Format data
            for (int i = 0; i < dataRows; i++)
            {
                data[i + 1, 0] = extStats[i].Extention != "" ? extStats[i].Extention : "<no ext>";
                data[i + 1, 1] = extStats[i].Files.ToString("0");
                data[i + 1, 2] = ((double)extStats[i].Files / totalFiles).ToString("0.0000");
                data[i + 1, 3] = extStats[i].Bytes.ToString("0");
                data[i + 1, 4] = ((double)extStats[i].Bytes / totalBytes).ToString("0.0000");
                data[i + 1, 5] = extStats[i].BytesPerFile.ToString("0");
            }

            // "Other" row
            if (showOther)
            {
                int otherRow = showTotals ? totalRows - 2 : totalRows - 1;
                long otherFiles = 0;
                long otherBytes = 0;
                for (int i = dataRows; i < extStats.Count; i++)
                {
                    otherFiles += extStats[i].Files;
                    otherBytes += extStats[i].Bytes;
                }
                data[otherRow, 0] = "Other";
                data[otherRow, 1] = otherFiles.ToString("0");
                data[otherRow, 2] = ((double)otherFiles / totalFiles).ToString("0.0000");
                data[otherRow, 3] = otherBytes.ToString("0");
                data[otherRow, 4] = ((double)otherBytes / totalBytes).ToString("0.0000");
                data[otherRow, 5] = ((double)otherBytes / otherFiles).ToString("0");
            }

            // Toals row
            if (showTotals)
            {
                data[totalRows - 1, 0] = "Total";
                data[totalRows - 1, 1] = totalFiles.ToString("0");
                data[totalRows - 1, 2] = "";
                data[totalRows - 1, 3] = totalBytes.ToString("0");
                data[totalRows - 1, 4] = "";
                data[totalRows - 1, 5] = ((double)totalBytes / totalFiles).ToString("0");
            }

            
            return data;
        }

        private static string[] MakeTable(string[] headings, string[,] data, bool[] rightAlign, bool topBottomBorders, string[] footer = null)
        {
            // Throw an exeption if the heading, data, and right align have different numbers of colums
            if ((headings.Length != data.GetLength(1)) || (headings.Length != rightAlign.Length) || (footer != null && headings.Length != footer.Length))
            {
                throw new ArgumentException();
            }

            List<string> table = new List<string>();

            // Calculate column widths
            int[] columnWidths = new int[headings.Length];
            for (int i = 0; i < headings.Length; i++)
            {
                columnWidths[i] = headings[i].Length;
            }
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (columnWidths[j] < data[i, j].Length)
                    {
                        columnWidths[j] = data[i, j].Length;
                    }
                }
            }
            if (footer != null)
            {
                for (int i = 0; i < footer.Length; i++)
                {
                    if (columnWidths[i] < footer[i].Length)
                    {
                        columnWidths[i] = footer[i].Length;
                    }
                }
            }

            // Row border text
            string rowBorder = "+";
            for (int i = 0; i < columnWidths.Length; i++)
            {
                rowBorder += "".PadRight(columnWidths[i] + 2, '-') + "+";
            }

            // Top border
            if (topBottomBorders)
            {
                table.Add(rowBorder);
            }

            // Header
            string header = "|";
            for (int i = 0; i < headings.Length; i++)
            {
                if (rightAlign[i])
                {
                    header += " " + headings[i].PadLeft(columnWidths[i]) + " |";
                }
                else
                {
                    header += " " + headings[i].PadRight(columnWidths[i]) + " |";
                }
            }
            table.Add(header);
            table.Add(rowBorder);

            // Data
            for (int i = 0; i < data.GetLength(0); i++)
            {
                string row = "|";
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (rightAlign[j])
                    {
                        row += " " + data[i, j].PadLeft(columnWidths[j]) + " |";
                    }
                    else
                    {
                        row += " " + data[i, j].PadRight(columnWidths[j]) + " |";
                    }
                }
                table.Add(row);
            }

            // Footer
            if (footer != null)
            {
                table.Add(rowBorder);
                string footerString = "|";
                for (int i = 0; i < footer.Length; i++)
                {
                    if (rightAlign[i])
                    {
                        footerString += " " + footer[i].PadLeft(columnWidths[i]) + " |";
                    }
                    else
                    {
                        footerString += " " + footer[i].PadRight(columnWidths[i]) + " |";
                    }
                }
                table.Add(footerString);
            }

            // Bottom border
            if (topBottomBorders)
            {
                table.Add(rowBorder);
            }

            return table.ToArray();
        }

        private static string[] MakeCSV(string[,] data)
        {
            string[] csv = new string[data.GetLength(0)];
            for (int i = 0; i < data.GetLength(0); i++)
            {
                string row = "";
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    row += data[i, j] + (j < data.GetLength(1) - 1 ? "," : "");
                }
                csv[i] = row;
            }
            return csv;
        }

        private static string FormatPercent(long quantity, long outOf)
        {
            return FormatPercent((double)quantity / outOf);
        }

        private static string FormatPercent(double value)
        {
            return (value * 100).ToString("##0.00") + "%";
        }
    }
}
