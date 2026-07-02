using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteBaseFractionsToCSV
{
    class Program
    {
        const int upTo = 64;

        static void Main(string[] args)
        {
            // Base row, Fraction col

            string[,] data = new string[upTo, upTo];

            data[0, 0] = "";

            for (int i = 1; i < upTo; i++)
            {
                data[0, i] = "=\"1/" + (i + 1) + "\"";
                data[i, 0] = "=\"Base " + (i + 1) + "\"";
            }

            for (int i = 1; i < upTo; i++)
            {
                for (int j = 1; j < upTo; j++)
                {
                    data[j, i] = "=\"" + BaseConverter.ConvertBase("0.1", i + 1, j + 1) + "\"";
                }
            }

            string[] lines = DataFormatter.MakeCSV(data);

            File.WriteAllLines("BaseFractionsExcel.csv", lines);

            File.WriteAllLines("BaseFractions.csv", RemoveExcelFormating(lines));



            // Fraction row, Base col

            data = new string[upTo, upTo];

            data[0, 0] = "";

            for (int i = 1; i < upTo; i++)
            {
                data[i, 0] = "=\"1/" + (i + 1) + "\"";
                data[0, i] = "=\"Base " + (i + 1) + "\"";
            }

            for (int i = 1; i < upTo; i++)
            {
                for (int j = 1; j < upTo; j++)
                {
                    data[i, j] = "=\"" + BaseConverter.ConvertBase("0.1", i + 1, j + 1) + "\"";
                }
            }

            lines = DataFormatter.MakeCSV(data);

            File.WriteAllLines("FractionBasesExcel.csv", lines);

            File.WriteAllLines("FractionBases.csv", RemoveExcelFormating(lines));
        }

        static string[] RemoveExcelFormating(string[] csvLines)
        {
            for (int i = 0; i < csvLines.Length; i++)
            {
                csvLines[i] = csvLines[i].Replace("\"", "").Replace("=", "");
            }

            return csvLines;
        }
    }
}
