using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilepath;
            if (args.Length > 0)
            {
                inputFilepath = args[0];
            }
            else
            {
                Console.Write("Enter path of TXT file that contains list of dates: ");
                inputFilepath = Console.ReadLine().Replace("\"", "");
            }

            DateTimeParser.FindAndWriteMissingDatesToFile(inputFilepath);
        }
    }
}
