using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace InvalidLogBases
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] logBases = {1, 0, -1, -10};

            Console.WriteLine("Real:");
            foreach (int logBase in logBases)
            {
                Console.WriteLine("Log_" + logBase + "(100) = " + Math.Log(100, logBase));
            }

            Console.WriteLine();
            Console.WriteLine("Complex:");
            foreach (int logBase in logBases)
            {
                Console.WriteLine("Log_" + logBase + "(100) = " + Complex.Log(100, logBase));
            }

            Console.Read();
        }
    }
}
