using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorization
{
    class PrimeFactorizer
    {
        private bool seperateLines = false;
        private bool expNotation = false;
        private bool showExp1 = false;
        private bool superScript = false;
        private string seperator = ", ";

        public bool SeperateLines { get => seperateLines; set => seperateLines = value; }
        public bool ExpNotation { get => expNotation; set => expNotation = value; }
        public bool ShowExp1 { get => showExp1; set => showExp1 = value; }
        public string Seperator { get => seperator; set => seperator = value; }
        public bool SuperScript { get => superScript; set => superScript = value; }

        public string GeneratePrimeFactorsString(uint number)
        {
            if (number == 1 || number == 0)
            {
                return "1 and 0 do not have prime factorization.";
            }

            uint[] primeFactors = GeneratePrimeFactors(number);
            string primeFactorsString = "";

            for (int i = 0; i <= primeFactors.Length; i++)
            {
                if (expNotation)
                {
                    int exponent = 1;
                    while (i >= 1 && i < primeFactors.Length && primeFactors[i] == primeFactors[i - 1])
                    {
                        exponent++;
                        i++;
                    }
                    if ((exponent > 1 || showExp1) && i > 0)
                    {
                        int lastDigitIndex = 0;
                        for (int j = 0; j < primeFactorsString.Length; j++)
                        {
                            if (Char.IsDigit(primeFactorsString[j]))
                            {
                                lastDigitIndex = j;
                            }
                        }

                        if (superScript)
                        {
                            primeFactorsString = primeFactorsString.Insert(lastDigitIndex + 1, exponent.ToString()
                                .Replace('0', '⁰')
                                .Replace('1', '¹')
                                .Replace('2', '²')
                                .Replace('3', '³')
                                .Replace('4', '⁴')
                                .Replace('5', '⁵')
                                .Replace('6', '⁶')
                                .Replace('7', '⁷')
                                .Replace('8', '⁸')
                                .Replace('9', '⁹'));
                        }
                        else
                        {
                            primeFactorsString = primeFactorsString.Insert(lastDigitIndex + 1, "^" + exponent);
                        }
                        
                    }
                }

                if (i < primeFactors.Length)
                {
                    primeFactorsString += primeFactors[i];

                    if (i < primeFactors.Length - 1)
                    {
                        if (seperateLines)
                        {
                            primeFactorsString += "\n";
                        }
                        else
                        {
                            primeFactorsString += seperator;
                        }
                    }
                }
            }


            return primeFactorsString.TrimEnd(seperator.ToCharArray()).TrimEnd('\n');
        }


        public uint[] GeneratePrimeFactors(uint number)
        {
            uint[] primesBelowNumber = GeneratePrimes(number);

            List<uint> primeFactors = new List<uint>();

            int i = 0;

            while (number > 1)
            {
                if (((double)number / primesBelowNumber[i]) % 1 == 0)
                {
                    primeFactors.Add(primesBelowNumber[i]);
                    number /= primesBelowNumber[i];
                }
                else
                {
                    i++;
                }
            }

            return primeFactors.ToArray();
        }


        private uint[] GeneratePrimes(uint number)
        {
            List<uint> primes = new List<uint>();
            for (uint i = 2; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes.ToArray();
        }

        private bool IsPrime(uint number)
        {
            double sqrt = Math.Sqrt(number);
            for (uint i = 2; i <= sqrt; i++)
            {
                if (((double)number / i) % 1 == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
