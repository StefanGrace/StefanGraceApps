using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasePowerOf2Writer
{
    class BaseConveter
    {
        public static string ValueToString(long value, int numberBase)
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

        public static string FractionToString(double fraction, int numberBase)
        {
            StringBuilder sb = new StringBuilder();

            int numDigits = NumDigits(numberBase);

            for (int i = 0; i < numDigits; i++)
            {
                int digitValue = (int)((fraction * Math.Pow(numberBase, i + 1)) % numberBase);

                sb.Append(ValueToDigit(digitValue));
            }

            return sb.ToString().TrimEnd('0');
        }

        public static int NumDigits(int numberBase)
        {
            return (int)Math.Log(Math.Pow(2, 53), numberBase);
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
        
    }
}
