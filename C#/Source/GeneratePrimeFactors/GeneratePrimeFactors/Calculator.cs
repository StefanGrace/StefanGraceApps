using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratePrimeFactors
{
    class Calculator
    {
        public static int[] GeneratePrimesUpTo(int number)
        {
            List<int> primes = new List<int>();
            for (int i = 2; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes.ToArray();
        }

        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            double sqrt = Math.Sqrt(number);
            for (int i = 2; i <= sqrt; i++)
            {
                if (((double)number / i) % 1 == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int CountFactor(int number, int factor)
        {
            double dividedNumber = number;

            for (int i = 0; i < 64; i++)
            {
                dividedNumber /= factor;
                if (dividedNumber % 1 > 0)
                {
                    return i;
                }
            }

            throw new ArithmeticException();
        }
    }
}
