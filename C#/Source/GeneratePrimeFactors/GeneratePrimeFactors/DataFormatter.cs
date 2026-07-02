using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratePrimeFactors
{
    class DataFormatter
    {
        public static string[] MakeCSV(string[,] data)
        {
            string[] csv = new string[data.GetLength(0)];
            for (int i = 0; i < data.GetLength(0); i++)
            {
                StringBuilder row = new StringBuilder();
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    row.Append(data[i, j] + (j < data.GetLength(1) - 1 ? "," : ""));
                }
                csv[i] = row.ToString();
            }
            return csv;
        }
    }
}
