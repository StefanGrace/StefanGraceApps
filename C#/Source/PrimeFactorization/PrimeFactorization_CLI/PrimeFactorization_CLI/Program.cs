using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorization
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeFactorizer pf = new PrimeFactorizer();

            Console.WriteLine("Enter `-` to toggle signle/seperate lines");
            Console.WriteLine("Enter `^` to toggle exponential notation");
            Console.WriteLine("Leave black to exit");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter number: ");
                string userInput = Console.ReadLine();

                if (userInput == "")
                {
                    break;
                }
                else if (userInput == "^")
                {
                    pf.ExpNotation = !pf.ExpNotation;
                    if (pf.ExpNotation)
                    {
                        Console.WriteLine("Exponential notation is now turned on.");
                        if (!pf.ShowExp1)
                        {
                            Console.WriteLine("Enter `^1` to also display exponents that are 1");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Exponential notation is now turned off.");
                    }
                }
                else if (userInput == "-")
                {
                    pf.SeperateLines = !pf.SeperateLines;
                    if (pf.SeperateLines)
                    {
                        Console.WriteLine("Each prime factor will now be shown on a seperate lines.");
                    }
                    else
                    {
                        Console.WriteLine("All prime factors will now be shown on the same line.");
                    }
                }
                else if (userInput == "^1")
                {
             
                    if (pf.ExpNotation)
                    {
                        pf.ShowExp1 = !pf.ShowExp1;
                        if (pf.ShowExp1)
                        {
                            Console.WriteLine("Exponents that are 1 will now be also shown.");
                        }
                        else
                        {
                            Console.WriteLine("Exponents that are 1 will no longer be shown.");
                        }
                    }
                    else
                    {
                        pf.ExpNotation = true;
                        pf.ShowExp1 = true;
                        Console.WriteLine("Exponential notation is now turned on.");
                        Console.WriteLine("Exponents that are 1 will now be also shown.");
                    }
                }
                else
                {
                    try
                    {
                        uint number = uint.Parse(userInput);
                        Console.WriteLine(pf.GeneratePrimeFactorsString(number));
                    }
                    catch
                    {
                        Console.WriteLine("Invaid input! Number must be a positive integer.");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
