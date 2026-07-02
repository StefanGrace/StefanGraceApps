using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWordLengthChainLengthGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            long startNumber = -1;
            long endNumber = -1;

            if (args.Length >= 2)
            {
                try
                {
                    startNumber = long.Parse(args[0]);
                    endNumber = long.Parse(args[1]);
                    if (endNumber < startNumber)
                    {
                        throw new Exception();
                    }
                }
                catch { }
            }

            while (startNumber < 0)
            {
                Console.Write("Start number: ");
                try
                {
                    startNumber = long.Parse(Console.ReadLine());
                    if (startNumber < 0)
                    {
                        Console.WriteLine("Can't be negitive");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            while (endNumber < 0)
            {
                Console.Write("End number: ");
                try
                {
                    endNumber = long.Parse(Console.ReadLine());
                    if (endNumber < 0)
                    {
                        Console.WriteLine("Can't be negitive");
                    }
                    if (endNumber < startNumber)
                    {
                        endNumber = -1;
                        Console.WriteLine("End number can't be smaller than start number");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input!");
                }
                
            }

            ChainLengthGenerator clg = new ChainLengthGenerator();

            try
            {
                clg.GenerateChainLengths(startNumber, endNumber);
            }
            catch (NumberOutOfRangeException)
            {
                Console.WriteLine("Number must be smaller than 10^15");
            }

        }
    }
}
