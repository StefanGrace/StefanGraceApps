using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeFactorization;
using System.IO;

namespace GeneratePrimeFactorizationList
{
    class Program
    {
        static void Main(string[] args)
        {
            int upTo;
            PrimeFactorizer pf;

            // Collect user input
            if (args.Length > 0)
            {
                try
                {
                    upTo = ValidateInput(args[0]);
                }
                catch
                {
                    Console.WriteLine("Must be an integer 2 or larger.");
                    return;
                }
            }
            else
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Enter number to generate up to: ");
                        string input = Console.ReadLine();
                        if (input == "")
                        {
                            return;
                        }
                        upTo = ValidateInput(input);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Must be an integer 2 or larger.");
                        Console.WriteLine();
                    }
                }
            }

            if (args.Length > 1)
            {
                try
                {
                    pf = GetExpNotation(args[1]);
                }
                catch
                {
                    Console.WriteLine("Invalid choice: " + args[1]);
                    return;
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Exponential notion?");
                    Console.WriteLine("0 - No");
                    Console.WriteLine("1 - Yes (^)");
                    Console.WriteLine("2 - Yes (superscript)");
                    Console.Write("Enter choice: ");
                    string userChoice = Console.ReadLine();
                    if (userChoice == "")
                    {
                        return;
                    }
                    try
                    {
                        pf = GetExpNotation(userChoice);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid choice: " + userChoice);
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Generating list of prime factorization...");

            // Generate data 

            string[] lines = new string[upTo - 1];

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = (i + 2) + ": " + pf.GeneratePrimeFactorsString((uint)i + 2);
            }

            File.WriteAllLines("PrimeFactorizationUpTo" + upTo + ".txt", lines);

            Console.WriteLine("Prime factorization list has been written to PrimeFactorizationUpTo" + upTo + ".txt");
        }

        static PrimeFactorizer GetExpNotation(string choice)
        {
            string[] validChoices = { "0", "1", "2" };
            if (!validChoices.Contains(choice))
            {
                throw new ArgumentOutOfRangeException();
            }

            return new PrimeFactorizer()
            {
                Seperator = " × ",
                ExpNotation = choice != "0",
                SuperScript = choice == "2",
            };

        }

        static int ValidateInput(string input)
        {
            int value = int.Parse(input);
            if (value < 2)
            {
                throw new ArgumentOutOfRangeException();
            }
            return value;
        }
    }
}
