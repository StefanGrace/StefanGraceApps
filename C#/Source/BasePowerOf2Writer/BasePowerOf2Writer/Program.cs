using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BasePowerOf2Writer
{
    class Program
    {
        const int maxPower2 = 62;
        const int maxNegPower2 = 62;
        const int maxBase = 64;

        static void Main(string[] args)
        {
            // Positive powers of 2
            {
                string[,] data = new string[maxPower2 + 2, maxBase];

                for (int i = 1; i < maxBase; i++)
                {
                    data[0, i] = "=\"Base " + (i + 1) + "\"";
                }

                for (int i = 1; i < maxPower2 + 2; i++)
                {
                    data[i, 0] = "=\"2^" + (i - 1) + "\""; ;
                }

                long value = 1;
                for (int i = 1; i < maxPower2 + 2; i++)
                {
                    for (int j = 1; j < maxBase; j++)
                    {
                        data[i, j] = "=\"" + BaseConveter.ValueToString(value, j + 1) + "\"";
                    }

                    value *= 2;
                }

                string[] lines = DataFormatter.MakeCSV(data);

                File.WriteAllLines("BasePowersOf2Excel.csv", lines);
                File.WriteAllLines("BasePowersOf2.csv", RemoveExcelFormating(lines));
            }

            // Negitive powers of 2
            {
                string[,] data = new string[maxPower2 + 2, maxBase];

                for (int i = 1; i < maxBase; i++)
                {
                    data[0, i] = "=\"Base " + (i + 1) + "\"";
                }

                for (int i = 1; i < maxPower2 + 2; i++)
                {
                    data[i, 0] = "=\"2^-" + (i - 1) + "\""; ;
                }

                double value = 1;
                for (int i = 1; i < maxPower2 + 2; i++)
                {
                    for (int j = 1; j < maxBase; j++)
                    {
                        if (i - 1 == 0)
                        {
                            data[i, j] = "=\"1\"";
                        }
                        else if (i - 1 <= FactorsOf2(j + 1) * BaseConveter.NumDigits(j + 1) || (j + 1) % 2 != 0)
                        {
                            string fractionString = BaseConveter.FractionToString(value, j + 1);
                            if (fractionString.Length > 0)
                            {
                                data[i, j] = "=\"0." + fractionString + "\"";
                            }
                        }
                    }

                    value /= 2;
                }

                string[] lines = DataFormatter.MakeCSV(data);

                File.WriteAllLines("BaseNegativePowersOf2Excel.csv", lines);
                File.WriteAllLines("BaseNegativePowersOf2.csv", RemoveExcelFormating(lines));
            }
        }

        static int FactorsOf2(int number)
        {
            double dividedNumber = number;

            for (int i = 0; i < 64; i++)
            {
                dividedNumber /= 2;
                if (dividedNumber % 1 > 0)
                {
                    return i;
                }
            }

            return 64;
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
