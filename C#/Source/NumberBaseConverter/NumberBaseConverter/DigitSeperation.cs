using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberBaseConverter
{
    class DigitSeperation
    {
        private bool useSeperator;
        private bool integer;
        private bool fraction;
        private char seperator;
        private int digits;

        public DigitSeperation(bool useSeperator, bool integer, bool fraction, char seperator, int digits)
        {
            UseSeperator = useSeperator;
            Integer = integer;
            Fraction = fraction;
            Seperator = seperator;
            Digits = digits;
        }

        public bool UseSeperator { get => useSeperator; set => useSeperator = value; }
        public bool Integer { get => integer; set => integer = value; }
        public bool Fraction { get => fraction; set => fraction = value; }
        public char Seperator { get => seperator; set => seperator = value; }
        public int Digits
        {
            get => digits;

            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
       
                digits = value;
            }

        }

        
    }
}
