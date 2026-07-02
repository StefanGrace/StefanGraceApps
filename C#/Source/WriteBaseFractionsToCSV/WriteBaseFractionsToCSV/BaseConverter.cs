using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteBaseFractionsToCSV
{
    class BaseConverter
    {
        public static string ConvertBase(string input, int inputBase, int outputBase)
        {
            // If the input string starts with "-", the number is negative
            bool negative = input.StartsWith("-");

            // Strip formatting characters from input
            input = input.Replace(",", "").Replace("-", "").Replace(" ", "").Replace("'", "").Replace("_", "");

            // Integer
            string[] integerAndFraction = input.Split('.');
            string integerString = integerAndFraction[0];
            long value = IntegerStringToValue(integerString, inputBase);
            string integerOutputString = ValueToString(value, outputBase);

            // Fraction
            string fractionOutputString = "";
            if (integerAndFraction.Length > 1)
            {
                string fractionString = integerAndFraction[1];
                double fractionValue = FractionStringToValue(fractionString, inputBase);
                fractionOutputString = FractionToString(fractionValue, outputBase);
            }

            // If the number is negative, add "-" to the start of the output
            string minus = negative ? "-" : "";

            // Add dot if fractional part exists
            if (fractionOutputString.Length > 0)
            {
                fractionOutputString = "." + fractionOutputString;
            }

            // Compile output
            return minus + integerOutputString + fractionOutputString;
        }

        private static string AddSeperators(string input, char seperator, int digits)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                
                if (i % digits == 0 && i != 0)
                {
                    sb.Append(seperator);
                }

                sb.Append(input[i]);
            }

            return sb.ToString();
        }

        private static long IntegerStringToValue(string integerString, int numberBase)
        {
            integerString = new string(integerString.Reverse().ToArray());

            long value = 0;

            checked
            {
                for (int i = 0; i < integerString.Length; i++)
                {
                    int digitValue = DigitToValue(integerString[i]);
                    if (digitValue >= numberBase)
                    {
                        throw new FormatException();
                    }
                    value += digitValue * (long)Math.Pow(numberBase, i);
                }
            }

            return value;
        }

        private static double FractionStringToValue(string fractionString, int numberBase)
        {
            double value = 0;

            for (int i = 0; i < fractionString.Length; i++)
            {
                int digitValue = DigitToValue(fractionString[i]);
                if (digitValue >= numberBase)
                {
                    throw new FormatException();
                }
                value += digitValue * (Math.Pow(numberBase, -(i + 1)));
            }

            return value;
        }

        private static string ValueToString(long value, int numberBase)
        {
            StringBuilder sb = new StringBuilder();

            int numDigits = 1 + (int)Math.Log(value, numberBase);

            for (int i = 0; i < numDigits; i++)
            {
                int digitValue = (int)((value % (long)Math.Pow(numberBase, i + 1)) / (long)Math.Pow(numberBase, i));

                sb.Append(ValueToDigit(digitValue));
            }

            string output = new string(sb.ToString().Reverse().ToArray());

            if (output == "")
            {
                return "0";
            }
            else
            {
                return output;
            }
        }

        private static string FractionToString(double fraction, int numberBase)
        {
            StringBuilder sb = new StringBuilder();

            int numDigits = (int)Math.Log(Math.Pow(2, 53), numberBase);

            for (int i = 0; i < numDigits; i++)
            {
                int digitValue = (int)((fraction * Math.Pow(numberBase, i + 1)) % numberBase);

                sb.Append(ValueToDigit(digitValue));
            }

            return sb.ToString().TrimEnd('0');
        }



        private static int DigitToValue(char digit)
        {
            if (char.IsDigit(digit))
            {
                return digit - 48;
            }
            else if (char.IsUpper(digit))
            {
                return (digit - 65) + 10;
            }
            else if (char.IsLower(digit))
            {
                return (digit - 97) + 36;
            }
            else if (digit == '+')
            {
                return 62;
            }
            else if (digit == '/')
            {
                return 63;
            }
            else
            {
                throw new FormatException();
            }
        }

        private static char ValueToDigit(int value)
        {
            if (value < 10)
            {
                return (char)(value + 48);
            }
            else if (value < 36)
            {
                return (char)((value - 10) + 65);
            }
            else if (value < 62)
            {
                return (char)((value - 36) + 97);
            }
            else if (value == 62)
            {
                return '+';
            }
            else if (value == 63)
            {
                return '/';
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        
        public static string[] GetKeys(int start = 0, int length = 64)
        {
            if (start < 0 || start >= 64 || length < 0 || length > 64)
            {
                throw new ArgumentOutOfRangeException();
            }

            string[] keys = new string[length];

            for (int i = 0; i < length; i++)
            {
                keys[i] = ValueToDigit(i + start) + " = " + (i + start);
            }

            return keys;
        }

    }
}
