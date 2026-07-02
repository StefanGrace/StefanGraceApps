using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class NumeralsToValue
    {
        private static readonly Dictionary<char, int> NumeralValues = new Dictionary<char, int>()
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000,
        };

        private static readonly Dictionary<char, int> SymbolFractions = new Dictionary<char, int>()
        {
            ['S'] = 2,
            ['·'] = 12,
            ['.'] = 12,
        };


        public double ValueFromNumerals(string numerals)
        {
            string orginalCaseNumerals = numerals.Replace(" ", "");
            numerals = orginalCaseNumerals.ToUpper();

            double value = 0;

            for (int i = 0; i < numerals.Length; i++)
            {
                if (!NumeralValues.ContainsKey(numerals[i]) && !SymbolFractions.ContainsKey(numerals[i]))
                {
                    throw new FormatException("'" + orginalCaseNumerals[i] + "' is not a valid Roman numeral.");
                }
            }

            for(int i = 0; i < numerals.Length; i++)
            {
                if (SymbolFractions.ContainsKey(numerals[i]))
                {
                    value += 1.0 / SymbolFractions[numerals[i]];
                }
                else if (NumeralValues.ContainsKey(numerals[i]))
                {
                    if (i < numerals.Length - 1 && !SymbolFractions.ContainsKey(numerals[i + 1]) &&
                        NumeralValues[numerals[i]] * 5 == NumeralValues[numerals[i + 1]])
                    {
                        value += NumeralValues[numerals[i]] * 4;
                    }
                    else if (i < numerals.Length - 1 && !SymbolFractions.ContainsKey(numerals[i + 1]) &&
                        NumeralValues[numerals[i]] * 10 == NumeralValues[numerals[i + 1]])
                    {
                        value += NumeralValues[numerals[i]] * 9;
                    }
                    else if (i < numerals.Length - 1 && !SymbolFractions.ContainsKey(numerals[i + 1]) &&
                        NumeralValues[numerals[i]] < NumeralValues[numerals[i + 1]])
                    {
                        throw new FormatException("Subtractive notation is only allowed if the first numeral is 1/5th or 1/10th of the second numeral.");
                    }
                    else if (i > 0 && SymbolFractions.ContainsKey(numerals[i - 1]))
                    {
                        throw new FormatException("Numerals come before fractions.");
                    }
                    else if (i == 0 || 
                        (NumeralValues[numerals[i - 1]] * 5 != NumeralValues[numerals[i]] &&
                        NumeralValues[numerals[i - 1]] * 10 != NumeralValues[numerals[i]]))
                    {
                        for (int j = i; j < numerals.Length; j++)
                        {
                            if (!SymbolFractions.ContainsKey(numerals[j]) && NumeralValues[numerals[i]] < NumeralValues[numerals[j]])
                            {
                                throw new FormatException("Can't have multiple subtractive numerals in a row.");
                            }
                        }

                        value += NumeralValues[numerals[i]];
                    }
                }
            }

            return value;
        }
    }
}
