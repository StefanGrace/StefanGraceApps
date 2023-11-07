using System;

namespace Tetration
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            string userInput = "";
            while (userInput != "0")
            {
                Console.WriteLine("0 - Exit\n" +
                    "1 - Tetration left\n" +
                    "2 - Tetration right\n" +
                    "3 - Pentation left\n" +
                    "4 - Pentation right\n" +
                    "5 - Hexation left\n" +
                    "6 - Hexation right\n" +
                    "7 - Tetration Log (rounds up)\n" +
                    "8 - Pentation Log (rounds up)\n" +
                    "9 - Hexation Log (rounds up)");
                Console.Write("Enter choice: ");
                userInput = Console.ReadLine();
                double a = double.NaN;
                double b = double.NaN;
                switch (userInput)
                {
                    case "0": // Exit
                        break;

                    case "1": // Tetration left
                        while (double.IsNaN(a))
                        {
                            Console.Write("Enter base (any number): ");
                            try
                            {
                                a = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a number");
                            }
                        }
                        while (double.IsNaN(b))
                        {
                            Console.Write("Enter index (positive integer): ");
                            try
                            {
                                b = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a positive integer");
                            }
                            if (b % 1 > 0 || b <= 0)
                            {
                                Console.WriteLine("Must be an positive integer");
                                b = double.NaN;
                            }
                        }
                        Console.WriteLine(calc.tetrationLeft(a, b));
                        break;

                    case "2": //Tetration right
                        while (double.IsNaN(a))
                        {
                            Console.Write("Enter base (any number): ");
                            try
                            {
                                a = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a number");
                            }
                        }
                        while (double.IsNaN(b))
                        {
                            Console.Write("Enter index (non-negitive integer): ");
                            try
                            {
                                b = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a non-negitive integer");
                            }
                            if (b % 1 > 0 || b < 0)
                            {
                                Console.WriteLine("Must be a non-negitive integer");
                                b = double.NaN;
                            }
                        }
                        Console.WriteLine(calc.tetrationRight(a, b));
                        break;

                    case "3": // Pentation left
                        while (double.IsNaN(a))
                        {
                            Console.Write("Enter index (positive integer): ");
                            try
                            {
                                a = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a positive integer");
                            }
                            if (a % 1 > 0 || a <= 0)
                            {
                                Console.WriteLine("Must be an positive integer");
                                a = double.NaN;
                            }
                        }
                        while (double.IsNaN(b))
                        {
                            Console.Write("Enter index (positive integer): ");
                            try
                            {
                                b = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a positive integer");
                            }
                            if (b % 1 > 0 || b <= 0)
                            {
                                Console.WriteLine("Must be an positive integer");
                                b = double.NaN;
                            }
                        }
                        Console.WriteLine(calc.pentationLeft(a, b));
                        break;

                    case "4": // Pentation right
                        while (double.IsNaN(a))
                        {
                            Console.Write("Enter index (non-negitive integer): ");
                            try
                            {
                                a = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a non-negitive integer");
                            }
                            if (a % 1 > 0 || a < 0)
                            {
                                Console.WriteLine("Must be a non-negitive integer");
                                a = double.NaN;
                            }
                        }
                        while (double.IsNaN(b))
                        {
                            Console.Write("Enter index (non-negitive integer): ");
                            try
                            {
                                b = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a non-negitive integer");
                            }
                            if (b % 1 > 0 || b < 0)
                            {
                                Console.WriteLine("Must be a non-negitive integer");
                                b = double.NaN;
                            }
                        }
                        Console.WriteLine(calc.pentationRight(a, b));
                        break;

                    case "5": // Hexation left
                        while (double.IsNaN(a))
                        {
                            Console.Write("Enter index (positive integer): ");
                            try
                            {
                                a = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a positive integer");
                            }
                            if (a % 1 > 0 || a <= 0)
                            {
                                Console.WriteLine("Must be an positive integer");
                                a = double.NaN;
                            }
                        }
                        while (double.IsNaN(b))
                        {
                            Console.Write("Enter index (positive integer): ");
                            try
                            {
                                b = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a positive integer");
                            }
                            if (b % 1 > 0 || b <= 0)
                            {
                                Console.WriteLine("Must be an positive integer");
                                b = double.NaN;
                            }
                        }
                        Console.WriteLine(calc.hexationLeft(a, b));
                        break;

                    case "6": // Hexation right
                        while (double.IsNaN(a))
                        {
                            Console.Write("Enter index (non-negitive integer): ");
                            try
                            {
                                a = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a non-negitive integer");
                            }
                            if (a % 1 > 0 || a < 0)
                            {
                                Console.WriteLine("Must be a non-negitive integer");
                                a = double.NaN;
                            }
                        }
                        while (double.IsNaN(b))
                        {
                            Console.Write("Enter index (non-negitive integer): ");
                            try
                            {
                                b = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a non-negitive integer");
                            }
                            if (b % 1 > 0 || b < 0)
                            {
                                Console.WriteLine("Must be a non-negitive integer");
                                b = double.NaN;
                            }
                        }
                        Console.WriteLine(calc.hexationRight(a, b));
                        break;

                    case "7": // Tetration Log
                        while (double.IsNaN(a))
                        {
                            Console.Write("Enter base (any number): ");
                            try
                            {
                                a = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a number");
                            }
                        }
                        while (double.IsNaN(b))
                        {
                            Console.Write("Enter vale (any number): ");
                            try
                            {
                                b = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a number");
                            }
                        }
                        Console.WriteLine(calc.tetrationLog(a, b));
                        break;

                    case "8": // Pentation Log
                        while (double.IsNaN(a))
                        {
                            Console.Write("Enter base (any number): ");
                            try
                            {
                                a = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a number");
                            }
                        }
                        while (double.IsNaN(b))
                        {
                            Console.Write("Enter vale (any number): ");
                            try
                            {
                                b = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a number");
                            }
                        }
                        Console.WriteLine(calc.pentationLog(a, b));
                        break;

                    case "9": // Hexation Log
                        while (double.IsNaN(a))
                        {
                            Console.Write("Enter base (any number): ");
                            try
                            {
                                a = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a number");
                            }
                        }
                        while (double.IsNaN(b))
                        {
                            Console.Write("Enter vale (any number): ");
                            try
                            {
                                b = double.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Must be a number");
                            }
                        }
                        Console.WriteLine(calc.hexationLog(a, b));
                        break;

                    default: // Invalid Input
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
