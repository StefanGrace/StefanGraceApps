using System;

namespace FourteenSegmentDisplayGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            if (args.Length > 0)  
            {
                for (int i = 0; i < args.Length; i++)
                {
                    input += args[i] + " ";
                }
                input = input.TrimEnd(' ');
                PrintText(input);
            }
            else
            {
                input = " ";
                while (input != "")
                {
                    Console.Write("Enter text: ");
                    input = Console.ReadLine();
                    PrintText(input);
                } 
            }
        }

        static void PrintText(string text)
        {
            Console.WriteLine();
            DisplayGenerator generator = new DisplayGenerator();
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(generator.GenerateDisplay(text[i]));
                Console.WriteLine();
            }
        }
    }
}
