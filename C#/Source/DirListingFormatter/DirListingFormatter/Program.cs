using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirListingFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            DirListingFormatter dirListingFormatter = new DirListingFormatter();

            string filepath;
            if (args.Length > 0 && args[0].ToLower().EndsWith("txt"))
            {
                filepath = args[0];
            }
            else
            {
                Console.Write("Enter file path: ");
                filepath = Console.ReadLine().Replace("\"", "");
            }

            try
            {
                string[] inputFileLines = System.IO.File.ReadAllLines(filepath);
                string[] outputFileLines = dirListingFormatter.FormatDirListings(inputFileLines);
                System.IO.File.WriteAllLines(@"D:\Temp\Test.txt", outputFileLines);
            }
            catch
            {
                Console.WriteLine("\"" + filepath + "\" does not exist.");
            }
        }

        
    }
}
