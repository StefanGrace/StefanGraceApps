// Converter.cs
// Stefan Grace
// Created: 2022-12-18
// Modified: 2022-12-20

using System;

namespace NumberWords
{
    class Converter
    {
        private string[] numbers = new string[20];
        private string[] tens = new string[10];
        private string hundred = "hundred";
        private string thousand = "thousand";
        private string million = "million";
        private string billion = "billion";
        private string trillion = "trillion";
        private string and = "and";
        private string point = "point";
        private string minus = "minus";
        private string oh = "oh";

        private int letterCasing = 0;
        private bool includeAnd = true;
        private bool commas = true;
        private bool zeroBeforePoint = true;
        private bool negativeMinus = false;
        private bool shortHand = false;

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

        // Set Variables
        public void SetVariables(int letterCasing, bool includeAnd, bool commas, bool zeroBeforePoint, bool negativeMinus, bool shortHand)
        {
            this.letterCasing = letterCasing;
            this.includeAnd = includeAnd;
            this.commas = commas;
            this.zeroBeforePoint = zeroBeforePoint;
            this.negativeMinus = negativeMinus;
            this.shortHand = shortHand;
            if (negativeMinus)
            {
                minus = "negative";
            }
            else
            {
                minus = "minus";
            }
            for (byte i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Capitalize(numbers[i], letterCasing);
            }
            for (byte i = 2; i < tens.Length; i++)
            {
                tens[i] = Capitalize(tens[i], letterCasing);
            }
            hundred = Capitalize(hundred, letterCasing);
            thousand = Capitalize(thousand, letterCasing);
            million = Capitalize(million, letterCasing);
            billion = Capitalize(billion, letterCasing);
            trillion = Capitalize(trillion, letterCasing);
            and = Capitalize(and, letterCasing);
            point = Capitalize(point, letterCasing);
            minus = Capitalize(minus, letterCasing);
            oh = Capitalize(oh, letterCasing);
        }

        // Capitalize the first of (or un-capitalize) a given string
        private string Capitalize(string input, int letterCase)
        {
            switch (letterCase)
            {
                case 0:
                case 1:
                case 3:
                   return input.ToLower();
                case 2:
                   string firstLetter = input[0].ToString().ToUpper();
                   return firstLetter + input.Substring(1);
                default:
                    return input;
            } 
        }

        // Count to number
        public string NumbersToWords(long number, bool includeZero)
        {
            if (includeZero)
            {
                return NumbersToWords(0, number);
            }
            else
            {
                if (number > 0)
                {
                    return NumbersToWords(1, number);
                }
                else if (number < 0)
                {
                    return NumbersToWords(-1, number);
                }
                else
                {
                    return "";
                }
            }
        }

        // Range
        public string NumbersToWords(long start, long end)
        {
            return NumbersToWords(start, end, 1);
        }

        // Range with interval
        public string NumbersToWords(decimal start, decimal end, decimal interval)
        {
            if (interval <= 0)
            {
                throw new NonPositiveIntervalException();
            }
            string output = "";
            if (start <= end)
            {
                for (decimal i = start; i <= end; i += interval)
                {
                    output += NumberToWord(i) + "\n";
                }
            }
            else
            {
                for (decimal i = start; i >= end; i -= interval)
                {
                    output += NumberToWord(i) + "\n";
                }
            }
            return output.Remove(output.Length - 1);
        }

        // Single number
        public string NumberToWord(decimal number)
        {
            // If the number is larger than or equal to 10^15, or smaller than or equal to -(10^15), thow an exeption
            if (number >= (decimal)Math.Pow(10, 15) || number <= -((decimal)Math.Pow(10, 15)))
            {
                throw new NumberOutOfRangeException();
            }

            // Split +/- sign and absolute number into seperate varialbles
            bool negative = number < 0;
            number = Math.Abs(number);

            // Split whole number and fraction into seperate varialbles
            long wholeNumber = (long)Math.Floor(number);
            decimal fraction = number % 1;

            // Separate various digits into separate variables
            byte ones = (byte)(wholeNumber % 10); // Create 8-bit int of the ones digit
            byte tens = (byte)(wholeNumber % 100); // Create 8-bit int of tens and ones digits
            byte hundreds = (byte)(((wholeNumber % 1000) - tens) / 100); // Create 8-bit int of hundreds digit
            short thousands = (short)((((wholeNumber % 1_000_000) - (wholeNumber % 1000)) / 1000)); // Create 16-bit int of thousands, ten-thousands, and hundred-thousands digits
            short millions = (short)((((wholeNumber % 1_000_000_000) - (wholeNumber % 1_000_000)) / 1_000_000)); // Create 16-bit int of millions, ten-millions, and hundred-millions digits
            short billions = (short)((((wholeNumber % 1_000_000_000_000) - (wholeNumber % 1_000_000_000)) / 1_000_000_000)); // Create 16-bit int of billions, ten-billions, and hundred-billions digits
            short trillions = (short)((((wholeNumber % 1_000_000_000_000_000) - (wholeNumber % 1_000_000_000_000)) / 1_000_000_000_000)); // Create 16-bit int of trillions, ten-trillions, and hundred-trillions digits

            string output = "";

            if (negative)
            {
                output = minus + " ";
            }

            // Generate text for trillions
            if (trillions > 0)
            {
                output += NumberToWord(trillions) + " " + trillion;
                if (billions > 0 || millions > 0 || thousands > 0 || hundreds > 0)
                {
                    if (commas)
                    {
                        output += ",";
                    }
                    output += " ";
                }
                else if (tens > 0)
                {
                    output += " ";
                    if (includeAnd)
                    {
                        output += and + " ";
                    }
                }
            }

            // Generate text for billions
            if (billions > 0)
            {
                output += NumberToWord(billions) + " " + billion;
                if (millions > 0 || thousands > 0 || hundreds > 0)
                {
                    if (commas)
                    {
                        output += ",";
                    }
                    output += " ";
                }
                else if (tens > 0)
                {
                    output += " ";
                    if (includeAnd)
                    {
                        output += and + " ";
                    }
                }
            }

            // Generate text for millions
            if (millions > 0)
            {
                output += NumberToWord(millions) + " " + million;
                if (thousands > 0 || hundreds > 0)
                {
                    if (commas)
                    {
                        output += ",";
                    }
                    output += " ";
                }
                else if (tens > 0)
                {
                    output += " ";
                    if (includeAnd)
                    {
                        output += and + " ";
                    }
                }
            }

            // Generate text for thousands
            if (thousands > 0)
            {
                output += NumberToWord(thousands) + " " + thousand;
                if (hundreds > 0)
                {
                    if (commas)
                    {
                        output += ",";
                    }
                    output += " ";
                }
                else
                {
                    if (tens > 0)
                    {
                        output += " ";
                        if (includeAnd)
                        {
                            output += and + " ";
                        }   
                    }
                }
            }

            // Generate text for hundreds
            if (hundreds > 0)
            {
                output += numbers[hundreds] + " " + hundred;
                if (tens > 0)
                {
                    output += " ";
                    if (includeAnd)
                    {
                        output += and + " ";
                    }
                }
            }

            /* If "short-hand" is enabled (e.g. "twenty fifteen" instead of "two thousand and fifteen"),
            and the number is between larger than 100 and smaller than 10,000, and the hundreds and tens digits are not zero,
            clear the output string and re-generate it in shorthand */
            if (shortHand && wholeNumber > 100 && wholeNumber < 10_000 && (hundreds > 0 || Math.Floor(tens / 10d) > 0))
            {
                output = "";
                if (negative)
                {
                    output = minus + " ";
                }
                byte twoDigitHundreds = (byte)Math.Floor(wholeNumber / 100d); // Create 8-bit int of thousands and hundreds digits
                output += NumberToWord(twoDigitHundreds) + " ";
                // If the tens and ones digits are both zero, add the word "hundred" to the end
                if (tens == 0)
                {
                    output += hundred;
                }
                // If the tens digit is zero, add the word "oh" before the ones
                else if (tens < 10)
                {
                    output += oh + " ";
                }
            }

            // Generate text for tens and ones
            if (tens > 0 || wholeNumber == 0)
            {
                if (tens < 20)
                {
                    if (wholeNumber > 0 || fraction == 0 || zeroBeforePoint)
                    {
                        output += numbers[tens];
                    }      
                }
                else
                {
                    output += this.tens[(tens - ones) / 10];
                    if (ones > 0)
                    {
                        output += "-" + numbers[ones];
                    }
                }
            }

            // Generate text for decimal places
            if (fraction > 0)
            {
                if (wholeNumber > 0 || zeroBeforePoint)
                {
                    output += " ";
                }
                output += point;
                for (int i = 1; i < 28; i++)
                {
                    long multiplier = (long)Math.Pow(10, i);
                    if ((fraction * multiplier) % 10 > 0)
                    {
                        output += " " + numbers[(int)Math.Floor((fraction * multiplier) % 10)];
                    }
                }
            }

            // Retrun the generated string in the correct case
            switch (letterCasing)
            {
                case 1:
                    return Capitalize(output.ToLower(), 2);
                case 3:
                    return output.ToUpper();
                default:
                    return output;
            }
        }


        // Properties

        public int LetterCasing
        {
            get
            {
                return letterCasing;
            }
        }

        public bool IncludeAnd
        {
            get
            {
                return includeAnd;
            }
        }

        public bool Commas
        {
            get
            {
                return commas;
            }
        }

        public bool ZeroBeforePoint
        {
            get
            {
                return zeroBeforePoint;
            }
        }
        
        public bool NegativeMinus
        {
            get
            {
                return negativeMinus;
            }
        }

        public bool ShortHand
        {
            get
            {
                return shortHand;
            }
        }
    }
}
