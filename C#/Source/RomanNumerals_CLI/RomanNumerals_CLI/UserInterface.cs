using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanNumerals;

namespace RomanNumerals_CLI
{
    class UserInterface
    {
        ValueToNumerals valueToNumerals = new ValueToNumerals();
        NumeralsToValue numeralsToValue = new NumeralsToValue();

        public void Run(string[] args)
        {
            if (args.Length > 0)
            {
                foreach (string arg in args)
                {
                    HandleInput(arg);
                }
            }
            else
            {
                bool exit = false;

                while (!exit)
                {
                    Console.Write("Enter decimal or Roman numeral: ");
                    string userInput = Console.ReadLine();
                    exit = HandleInput(userInput);
                    Console.WriteLine();
                }
            }
        }

        private bool HandleInput(string input)
        {
            switch (input.ToLower())
            {
                case "exit":
                    return true;

                case "help":
                    DisplayHelp();
                    break;

                default:
                    if (double.TryParse(input, out double value))
                    {
                        // Parse input as decimal
                        try
                        {
                            Console.WriteLine(valueToNumerals.NumeralFromValue(value).Replace('·', '.'));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.Replace("≥", ">="));
                        }
                    }
                    else
                    {
                        // Parse input as Roman numeral
                        try
                        {
                            Console.WriteLine(numeralsToValue.ValueFromNumerals(input));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    break;
            }

            return false;
        }

        private void DisplayHelp()
        {
            Console.WriteLine("Numerals:");
            Console.WriteLine("I = 1");
            Console.WriteLine("V = 5");
            Console.WriteLine("X = 10");
            Console.WriteLine("L = 50");
            Console.WriteLine("C = 100");
            Console.WriteLine("D = 500");
            Console.WriteLine("M = 1000");
            Console.WriteLine("");
            Console.WriteLine("Subtractive notation:");
            Console.WriteLine("IV = 4");
            Console.WriteLine("IX = 9");
            Console.WriteLine("XL = 40");
            Console.WriteLine("XC = 90");
            Console.WriteLine("CD = 400");
            Console.WriteLine("CM = 900");
            Console.WriteLine("");
            Console.WriteLine("Fractions:");
            Console.WriteLine(". = 1/12");
            Console.WriteLine("S = 1/2");
        }
    }
}
