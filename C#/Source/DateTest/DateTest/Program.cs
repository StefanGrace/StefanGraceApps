using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime latestDate = new DateTime(9999, 12, 31, 23, 59, 59, 999);
            Console.WriteLine(latestDate);
            DateTime earliestDate = new DateTime(0001, 01, 01, 00, 00, 00, 000);
            Console.WriteLine(earliestDate);
            Console.Read();
        }
    }
}
