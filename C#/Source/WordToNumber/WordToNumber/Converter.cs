using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordToNumber
{
    class Converter
    {
        private string[] numbers = new string[20];
        private string[] tens = new string[10];
        private string[] toRemove = { " ", ",", ".", "-", "_", "and" };

        // Constructor 
        public Converter()
        {
            numbers[0] = "zero";
            numbers[1] = "one";
            numbers[2] = "two";
            numbers[3] = "three";
            numbers[4] = "four";
            numbers[5] = "five";
            numbers[6] = "six";
            numbers[7] = "seven";
            numbers[8] = "eight";
            numbers[9] = "nine";
            numbers[10] = "ten";
            numbers[11] = "eleven";
            numbers[12] = "twelve";
            numbers[13] = "thirteen";
            numbers[14] = "fourteen";
            numbers[15] = "fifteen";
            numbers[16] = "sixteen";
            numbers[17] = "seventeen";
            numbers[18] = "eighteen";
            numbers[19] = "nineteen";

            tens[2] = "twenty";
            tens[3] = "thirty";
            tens[4] = "forty";
            tens[5] = "fifty";
            tens[6] = "sixty";
            tens[7] = "seventy";
            tens[8] = "eighty";
            tens[9] = "ninety";
        }

        public decimal WordToNumber(string word)
        {
            // Make input string lowercase
            word = word.ToLower();

            // Strip
            foreach (string str in toRemove)
            {
                word = word.Replace(str, "");
            }

            bool negative = StartWord(ref word, "minus") || StartWord(ref word, "negative");

            decimal output = NumberToNumber(ref word);

            if (StartWord(ref word, "point"))
            {
                for (int i = 1; i <= 28; i++)
                {
                    int digit = TensToNumber(ref word);
                    if (digit < 10)
                    {
                        output += (decimal) (digit / Math.Pow(10, i));
                    }
                    else
                    {
                        throw new InvalidInputException();
                    }
                }
            }
                

            if (word.Length > 0)
            {
                throw new InvalidInputException();
            }

            if (negative)
            {
                output = -output;
            }

            return output;
        }


        private decimal NumberToNumber(ref string word)
        {
            decimal output = TensToNumber(ref word);

            if (StartWord(ref word, "hundred"))
            {
                output *= 100;
                output += TensToNumber(ref word);
            }

            if (StartWord(ref word, "thous"))
            {
                output *= 1000;
                output += NumberToNumber(ref word);
            }

            if (StartWord(ref word, "million"))
            {
                output *= 1_000_000;
                output += NumberToNumber(ref word);
            }

            if (StartWord(ref word, "billion"))
            {
                output *= 1_000_000_000;
                output += NumberToNumber(ref word);
            }

            if (StartWord(ref word, "trillion"))
            {
                output *= 1_000_000_000_000;
                output += NumberToNumber(ref word);
            }

            return output;
        }


        private int TensToNumber(ref string word)
        {
            int output = 0;

            // Tens
            int tensNumber = -1;
            for (int i = 2; i < tens.Length; i++)
            {
                if (word.StartsWith(tens[i]))
                {
                    tensNumber = i;
                }
            }
            if (tensNumber >= 0)
            {
                word = word.Remove(0, tens[tensNumber].Length);
                output = tensNumber * 10;
            }

            // Ones
            int onesNumber = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (word.StartsWith(numbers[i]))
                {
                    onesNumber = i;
                }
            }

            if (onesNumber >= 0)
            {
                word = word.Remove(0, numbers[onesNumber].Length);
                output += onesNumber;
            }

            return output;
        }


        private bool StartWord(ref string word, string start)
        {
            if (word.StartsWith(start))
            {
                word = word.Remove(0, start.Length);
                return true;
            }
            return false;
        }
    }
}
