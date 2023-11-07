using System;

namespace TimeFormatConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            while (userInput != "e" && userInput != "x")
            {
                Console.WriteLine("Enter 12-hour or 24-hour time and this program will convert it to the other format. Type \"e\" or \"x\" to exit.");
                userInput = Console.ReadLine().ToLower().Replace(" ", "");

                switch (userInput)
                {
                    case "e":
                    case "x":
                        break;
                    default:
                        Converter converter = new Converter();
                        try
                        {
                            Console.WriteLine(converter.convert(userInput));
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input");
                        }
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
