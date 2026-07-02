using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter_CLI
{
    class UserInterface
    {
        private bool showExtendedUnits = false;

        public void Run(string[] args)
        {
            if (args.Length > 0)
            {
                HandleInput(string.Join(" ", args));
            }
            else
            {
                Console.WriteLine("CLI Unit Converter by Stefan Grace");
                Console.WriteLine("For help on how to use this program, type \"help\".");
                Console.WriteLine();

                bool exit = false;

                while (!exit)
                {
                    Console.Write("Input: ");
                    string userInput = Console.ReadLine();
                    exit = HandleInput(userInput);
                }
            }
        }

        private bool HandleInput(string input)
        {
            switch (input.ToLower())
            {
                case "":
                case "exit":
                    return true;

                case "unit":
                case "units":
                    break;

                case "help":
                    DisplayHelp();
                    break;

                case "ext":
                    showExtendedUnits = !showExtendedUnits;
                    break;

                default:
                    ConvertUnit(input);
                    break;
            }

            return false;
        }


        private void DisplayHelp()
        {

        }

        private void ConvertUnit(string input)
        {
            string[] inputParts = input.Split(' ');

            string inputWithoutValue;

            if (double.TryParse(inputParts[0], out double value))
            {
                List<string> inputPartsList = inputParts.ToList();
                inputPartsList.RemoveAt(0);
                inputWithoutValue = string.Join(" ", inputPartsList);
            }
            else
            {
                value = 1;
                inputWithoutValue = input;
            }

            string[] units = inputWithoutValue.Split(new string[] { " to " }, StringSplitOptions.None);


            Console.WriteLine("Value: " + value);
            Console.WriteLine(string.Join("\n", units));
        }
    }
}
