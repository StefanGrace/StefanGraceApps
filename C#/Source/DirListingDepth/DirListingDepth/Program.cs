using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirListingDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath;
            if (args.Length > 0)
            {
                filepath = args[0];
            }
            else
            {
                Console.Write("Enter path of dir listing TXT file: ");
                filepath = Console.ReadLine();
            }

            filepath = filepath.Replace("\"", "");

            string[] lines = File.ReadAllLines(filepath);

            Console.WriteLine(DirListingReader.GetDepthStats(lines, 1000));

            Console.WriteLine();
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}
