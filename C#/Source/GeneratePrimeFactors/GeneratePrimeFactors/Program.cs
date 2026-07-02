using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GeneratePrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            int upTo;

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


            // Generate data 

            int[] primes = Calculator.GeneratePrimesUpTo(upTo);

            string[,] data = new string[upTo, primes.Length + 1];

            for (int i = 1; i < data.GetLength(0); i++)
            {
                data[i, 0] = (i + 1).ToString();
            }

            for (int i = 1; i < data.GetLength(1); i++)
            {
                data[0, i] = primes[i - 1].ToString();
            }

            for (int i = 1; i < data.GetLength(0); i++)
            {
                for (int j = 1; j < data.GetLength(1); j++)
                {
                    data[i, j] = Calculator.CountFactor(i + 1, primes[j - 1]).ToString("#");
                }
            }


            // Write data to CSV

            string[] lines = DataFormatter.MakeCSV(data);

            File.WriteAllLines("PrimeFactorizationUpTo" + upTo + ".csv", lines);


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
