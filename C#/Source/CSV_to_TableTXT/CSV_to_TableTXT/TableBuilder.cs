using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_to_TableTXT
{
    enum ColummAlignment
    {
        Auto, Left, Right, Manual
    }

    enum IndividualColummAlignment
    {
        Auto, Left, Right
    }

    enum AutoAlignment
    {
        FirstDataRow, Majority_HalfIsLeft, Majority_HalfIsRight, OneHasToBeNumber, AllHaveToBeNumber
    }

    class TableBuilder
    {
        private ColummAlignment colAlign = ColummAlignment.Auto;
        private IndividualColummAlignment[] manualColAlign;
        private AutoAlignment autoAlignment = AutoAlignment.Majority_HalfIsLeft;
        private bool lastRowIsFooter = false;
        private int[] maxWidths;
        private int maxWidth;
        private bool topBottomBorders = true;

        internal ColummAlignment ColAlign { get => colAlign; set => colAlign = value; }
        internal IndividualColummAlignment[] ManualColAlign { get => manualColAlign; set => manualColAlign = value; }
        internal AutoAlignment AutoAlignment { get => autoAlignment; set => autoAlignment = value; }
        public bool LastRowIsFooter { get => lastRowIsFooter; set => lastRowIsFooter = value; }
        public int[] MaxWidths { get => maxWidths; set => maxWidths = value; }
        public int MaxWidth { get => maxWidth; set => maxWidth = value; }
        public bool TopBottomBorders { get => topBottomBorders; set => topBottomBorders = value; }


        public string[] BuildTable(string[,] data)
        {
            string[] headings = new string[data.GetLength(1)];
            bool[] rightAlign = new bool[headings.Length];
            string[,] tableData = new string[data.GetLength(0) - 1, headings.Length];

            for (int i = 0; i < data.GetLength(1); i++)
            {
                headings[i] = data[0, i];
            }

            for (int i = 0; i < tableData.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    tableData[i, j] = data[i + 1, j];
                }
            }

            switch (colAlign)
            {
                case ColummAlignment.Auto:
                    for (int i = 0; i < headings.Length; i++)
                    {
                        rightAlign[i] = AutoAlign(tableData, i);
                    }
                    break;

                case ColummAlignment.Left:
                    for (int i = 0; i < rightAlign.Length; i++)
                    {
                        rightAlign[i] = false;
                    }
                    break;

                case ColummAlignment.Right:
                    for (int i = 0; i < rightAlign.Length; i++)
                    {
                        rightAlign[i] = true;
                    }
                    break;

                case ColummAlignment.Manual:
                    if (manualColAlign.Length == headings.Length)
                    {
                        for (int i = 0; i < headings.Length; i++)
                        {
                            switch (manualColAlign[i])
                            {
                                case IndividualColummAlignment.Auto:
                                    rightAlign[i] = AutoAlign(tableData, i);
                                    break;

                                case IndividualColummAlignment.Left:
                                    rightAlign[i] = false;
                                    break;

                                case IndividualColummAlignment.Right:
                                    rightAlign[i] = true;
                                    break;
                            }
                        }
                    }
                    else
                    {
                        throw new MissingFieldException("Alingment settings do not match number of columns.");
                    }
                    break;
            }

            return MakeTable(headings, tableData, rightAlign, topBottomBorders);
        }

        private bool AutoAlign(string[,] data, int colNumber)
        {
            double value;
            switch (autoAlignment)
            {
                case AutoAlignment.FirstDataRow:
                    return double.TryParse(data[0, colNumber], out value);

                case AutoAlignment.Majority_HalfIsLeft:
                    int numbers = 0;
                    int nonNumbers = 0;
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        if (double.TryParse(data[i, colNumber], out value))
                        {
                            numbers++;
                        }
                        else
                        {
                            nonNumbers++;
                        }
                    }
                    return numbers > nonNumbers;

                case AutoAlignment.Majority_HalfIsRight:
                    numbers = 0;
                    nonNumbers = 0;
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        if (double.TryParse(data[i, colNumber], out value))
                        {
                            numbers++;
                        }
                        else
                        {
                            nonNumbers++;
                        }
                    }
                    return numbers >= nonNumbers;

                case AutoAlignment.OneHasToBeNumber:
                    bool rightAlign = false;
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        if (double.TryParse(data[i, colNumber], out value))
                        {
                            rightAlign = true;
                            break;
                        }
                    }
                    return rightAlign;

                case AutoAlignment.AllHaveToBeNumber:
                    rightAlign = true;
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        if (!double.TryParse(data[i, colNumber], out value))
                        {
                            rightAlign = false;
                            break;
                        }
                    }
                    return rightAlign;
                    
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

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
