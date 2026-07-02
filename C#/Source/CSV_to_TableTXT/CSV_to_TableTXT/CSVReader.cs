using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_to_TableTXT
{
    class CSVReader
    {
        public static string[,] ReadCSV(string[] lines)
        {
            

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace(char.MinValue.ToString(), "");
                bool inQuotes = false;
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (lines[i][j] == '"')
                    {
                        inQuotes = !inQuotes;
                    }
                    if (inQuotes)
                    {
                        if(lines[i][j] == ',')
                        {
                            lines[i] = lines[i].Remove(j, 1);
                            lines[i] = lines[i].Insert(j, char.MinValue.ToString());
                        }
                    }
                }
            }
            

            string[,] data = new string[lines.Length, lines[0].Split(',').Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] currentRow = lines[i].Split(',');
                for (int j = 0; j < currentRow.Length; j++)
                {
                    data[i, j] = currentRow[j];
                    data[i, j] = data[i, j].Replace(char.MinValue, ',');
                    data[i, j] = data[i, j].Replace("\"", "");
                    data[i, j] = data[i, j].TrimStart(' ').TrimEnd(' ');
                }
            }

            return data;
        }
    }
}
