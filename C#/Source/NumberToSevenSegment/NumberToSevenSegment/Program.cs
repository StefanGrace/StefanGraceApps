using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToSevenSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(converter.digitToSevenSegment(i));
                Console.WriteLine();
            }
            

            Console.ReadKey();
        }

    }
}