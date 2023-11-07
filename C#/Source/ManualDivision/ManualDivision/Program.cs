using System;

namespace ManualDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + divide(a, b));
                Console.WriteLine();
            }

        }

        static int divide(int a, int b)
        {
            int i = 0;
            while (a > 0)
            {
                a -= b;
                i++;
            }
            return i;
        }
    }
}

