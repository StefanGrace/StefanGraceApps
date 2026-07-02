using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroPointOnePlusZeroPointTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("64-bit binary float:");
            Console.WriteLine("0.1 + 0.2 = " + (0.1 + 0.2).ToString("G17"));
            Console.WriteLine("0.1 + 0.2 == 0.3? " + (0.1 + 0.2 == 0.3));
            Console.WriteLine();
            Console.WriteLine("32-bit binary float:");
            Console.WriteLine("0.1 + 0.2 = " + (0.1f + 0.2f).ToString("G17"));
            Console.WriteLine("0.1 + 0.2 == 0.3? " + (0.1f + 0.2f == 0.3f));
            Console.WriteLine();
            Console.WriteLine("Decimal:");
            Console.WriteLine("0.1 + 0.2 = " + (0.1m + 0.2m).ToString("G17"));
            Console.WriteLine("0.1 + 0.2 == 0.3? " + (0.1m + 0.2m == 0.3m));
            Console.WriteLine();

            Console.Read();
        }
    }
}
