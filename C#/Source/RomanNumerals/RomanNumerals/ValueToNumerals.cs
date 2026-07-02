using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class ValueToNumerals
    {
        private static readonly Dictionary<int, char> ValueNumerals = new Dictionary<int, char>()
        {
            [1] = 'I',
            [5] = 'V',
            [10] = 'X',
            [50] = 'L',
            [100] = 'C',
            [500] = 'D',
            [1000] = 'M',
        };

        private static readonly Dictionary<int, char> FractionSymbols = new Dictionary<int, char>()
        {
            [2] = 'S',
            [12] = '·',
        };

        private bool lowercase;

        public bool Lowercase { get => lowercase; set => lowercase = value; }

        public ValueToNumerals(bool lowercase = false)
        {
            this.lowercase = lowercase;
        }

        public string NumeralFromValue(double value)
        {
            // Round value to the nearest 1/12

            value = Math.Round(value * 12) / 12;

            // Range checks 

            if (value >= 4000)
            {
                throw new ArgumentOutOfRangeException("", "Roman numerals cannot be ≥ 4000.");
            }

            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("", "Roman numerals cannot be negative.");
            }


            // Interger digits

            int[] digits = GetFourDigitsBE((int)value);

            StringBuilder numerals = new StringBuilder();

            for (int i = 0; i < digits.Length; i++)
            {
                switch (digits[i])
                {
                    case 1:
                    case 2:
                    case 3:
                        numerals.Append(new string(ValueNumerals[(int)Math.Pow(10, digits.Length - (i + 1))], digits[i]));
                        break;

                    case 4:
                        numerals.Append(new string(ValueNumerals[(int)Math.Pow(10, digits.Length - (i + 1))], 1));
                        numerals.Append(new string(ValueNumerals[(int)Math.Pow(10, digits.Length - (i + 1)) * 5], 1));
                        break;

                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        numerals.Append(new string(ValueNumerals[(int)Math.Pow(10, digits.Length - (i + 1)) * 5], 1));
                        numerals.Append(new string(ValueNumerals[(int)Math.Pow(10, digits.Length - (i + 1))], digits[i] - 5));
                        break;

                    case 9:
                        numerals.Append(new string(ValueNumerals[(int)Math.Pow(10, digits.Length - (i + 1))], 1));
                        numerals.Append(new string(ValueNumerals[(int)Math.Pow(10, digits.Length - (i + 1)) * 10], 1));
                        break;
                }
            }


            // Fraction

            double fraction = value % 1;

            int twelths = (int)Math.Round(fraction * 12);

            if (twelths < 6)
            {
                numerals.Append(new string(FractionSymbols[12], twelths));
            }
            else
            {
                numerals.Append(new string(FractionSymbols[2], 1));
                numerals.Append(new string(FractionSymbols[12], twelths - 6));
            }

            if (lowercase)
            {
                return numerals.ToString().ToLower();
            }
            else
            {
                return numerals.ToString();
            } 
        }

        private int[] GetFourDigitsBE(int value)
        {
            if (value > 9999 || value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int[] digits = new int[4];

            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = GetDigit(value, digits.Length - (i + 1));
            }

            return digits;
        }

        private int GetDigit(int number, int digit)
        {
            return (number % (int)Math.Pow(10, digit + 1)) / (int)Math.Pow(10, digit);
        }

    }
}
