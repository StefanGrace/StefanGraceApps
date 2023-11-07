using System;

namespace RemainderDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    decimal a = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    decimal b = decimal.Parse(Console.ReadLine());
                    if (a >= 0 && b >= 0)
                    {
                        Result result = divide(a, b);
                        Console.WriteLine("Result: " + result.Quotient);
                        if (result.Remainder > 0)
                        {
                            Console.WriteLine("Remainder: " + result.Remainder);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Can't do negitives");
                    }
                }
                catch
                {
                    Console.WriteLine("Must enter a number");
                }
                Console.WriteLine();
            }

        }

        static Result divide(decimal a, decimal b)
        {
            long i = 0;
            while (a - b >= 0)
            {
                a -= b;
                i++;
            }
            return new Result(i, a);
        }
    }

    class Result
    {
        private long quotient;
        private decimal remainder;

        public Result(long quotient, decimal remainder)
        {
            this.quotient = quotient;
            this.remainder = remainder;
        }

        public long Quotient
        {
            get { return quotient; }
        }

        public decimal Remainder
        {
            get { return remainder; }
        }

    }

}
