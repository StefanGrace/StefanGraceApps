using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCharAnalysis
{
    class DataFormatter
    {
        public static string[] MakeTable(string[] headings, string[,] data, bool[] rightAlign, bool topBottomBorders, string[] footer = null)
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
    }
}
