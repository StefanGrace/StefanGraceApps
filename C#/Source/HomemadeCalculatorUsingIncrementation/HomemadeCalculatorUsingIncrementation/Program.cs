using System;

namespace HomemadeCalculatorUsingIncrementation
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "0")
            {
                Console.WriteLine("0 - Exit\n" +
                    "1 - Add\n" +
                    "2 - Minus\n" +
                    "3 - Multiply\n" +
                    "4 - Divide\n" +
                    "5 - Power\n" +
                    "6 - Log\n" +
                    "7 - Tetration\n" +
                    "8 - Super-log");
                Console.Write("Enter choice: ");
                choice = Console.ReadLine();

                int a = 0;
                int b = 0;
                switch (choice)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                        try
                        {
                            Console.Write("Enter first number: ");
                            a = int.Parse(Console.ReadLine());
                            if (a < 0)
                            {
                                Console.WriteLine("Can't do negatives");
                                choice = "E";
                                break;
                            }
                            Console.Write("Enter second number: ");
                            b = int.Parse(Console.ReadLine());
                            if (b < 0)
                            {
                                Console.WriteLine("Can't do negatives");
                                choice = "E";
                                break;
                            }

                        }
                        catch
                        {
                            Console.WriteLine("Must enter an integer");
                            choice = "E";
                        }
                        break;
                }

                Calculator calc = new Calculator();
                int result = 0;

                switch (choice)
                {
                    case "E": break;
                    case "0": Console.WriteLine("Goodbye"); break;
                    case "1": result = calc.add(a, b); break;
                    case "2": result = calc.minus(a, b); break;
                    case "3": result = calc.multiply(a, b); break;
                    case "4": result = calc.divide(a, b); break;
                    case "5": result = calc.power(a, b); break;
                    case "6": result = calc.log(a, b); break;
                    case "7": result = calc.tetration(a, b); break;
                    case "8": result = calc.superLog(a, b); break;
                    default: Console.WriteLine("Invalid choice: " + choice); break;
                }

                switch (choice)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                        Console.WriteLine("Result: " + result);
                        break;
                }

                Console.WriteLine();
            }
        }
    }

}
