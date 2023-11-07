using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroDividedByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Int: ");
            int zero = 0;
            try
            {
                Console.WriteLine(zero / zero);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Write("Float: ");
            Console.WriteLine(0.0 / 0.0);
            

            Console.Read();
        }
    }
}
