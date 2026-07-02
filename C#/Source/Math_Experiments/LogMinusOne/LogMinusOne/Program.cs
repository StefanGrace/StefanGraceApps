using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LogMinusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Real: ");
            Console.WriteLine(Math.Log(-1));

            Console.Write("Complex: ");
            Console.WriteLine(Complex.Log(-1));

            Console.Read();
        }
    }
}
