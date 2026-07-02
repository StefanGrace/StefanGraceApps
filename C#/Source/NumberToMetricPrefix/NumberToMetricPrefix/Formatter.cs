using System;

namespace NumberToMetricPrefix
{
    class Formatter
    {
        private bool binary = false;
        private bool use_c = false;
        private bool use_d = false;
        private bool use_da = false;
        private bool use_h = false;
        private int maxDigits = 3;
        private bool limitDigits = true;
        private bool decimalPlaces = false;

        public string FormatValue(double value, string unit)
        {
            if (value == 0)
            {
                return value + " " + unit;
            }

            bool negative = value < 0;
            value = Math.Abs(value);

            int magnitude = (int)Math.Floor(Math.Log10(value));

            int thouMag;
            if (binary)
            {
                thouMag = (int)Math.Floor(Math.Log(value, 1024));
            }
            else
            {
                thouMag = (int)Math.Floor(magnitude / 3.0);
            }

            if (thouMag >= 11)
            {
                if (negative)
                {
                    return "Value too small";
                }
                return "Value too large";
            }
            else if (thouMag < -10)
            {
                return "Value too close to zero";
            }

            if (binary)
            {
                value = value / Math.Pow(1024, thouMag);
            }
            else
            {
                value = value / Math.Pow(1000, thouMag);
            }

            // Make prefixes for powers of 1000 or 1024
            string prefix = "";
            switch (thouMag)
            {
                case -10: prefix = "q"; break;
                case -9: prefix = "r"; break;
                case -8: prefix = "y"; break;
                case -7: prefix = "z"; break;
                case -6: prefix = "a"; break;
                case -5: prefix = "f"; break;
                case -4: prefix = "p"; break;
                case -3: prefix = "n"; break;
                case -2: prefix = "µ"; break;
                case -1: prefix = "m"; break;
                case 0: prefix = ""; break;
                case 1: prefix = "k"; break;
                case 2: prefix = "M"; break;
                case 3: prefix = "G"; break;
                case 4: prefix = "T"; break;
                case 5: prefix = "P"; break;
                case 6: prefix = "E"; break;
                case 7: prefix = "Z"; break;
                case 8: prefix = "Y"; break;
                case 9: prefix = "R"; break;
                case 10: prefix = "Q"; break;
            }
            if (binary)
            {
                if (prefix != "")
                {
                    prefix += "i";
                }
            }

            // Non-thousand powers of 10 (c, d, da, h)
            if (!binary)
            {
                double outputValue = value;
                if (use_c && (magnitude == -1 || magnitude == -2))
                {
                    outputValue = value / 10;
                    prefix = "c";
                }
                if (use_d && magnitude == -1)
                {
                    outputValue = value / 100;
                    prefix = "d";
                }
                if (use_da && (magnitude == 2 || magnitude == 1))
                {
                    outputValue = value / 10;
                    prefix = "da";
                }
                if (use_h && magnitude == 2)
                {
                    outputValue = value / 100;
                    prefix = "h";
                }
                value = outputValue;
            }

            // Limit digits or decimal places
            if (limitDigits)
            {
                // Limit decimal places
                if (decimalPlaces)
                {
                    value = Math.Round(value, maxDigits);
                }
                // Limit digits
                else
                {
                    int tenMag = (int)Math.Log10(value);
                    if (tenMag > (maxDigits - 1))
                    {
                        tenMag = 2;
                    }
                    value = Math.Round(value, (maxDigits - 1) - Math.Abs(tenMag));
                }
            }

            string minus = "";
            if (negative)
            {
                minus = "-";
            }
            return minus + value + " " + prefix + unit;
        }


        // Setters

        public bool Binary
        {
            set
            {
                binary = value;
            }
        }

        public bool Use_c
        {
            set
            {
                use_c = value;
            }
        }

        public bool Use_d
        {
            set
            {
                use_d = value;
            }
        }

        public bool Use_da
        {
            set
            {
                use_da = value;
            }
        }

        public bool Use_h
        {
            set
            {
                use_h = value;
            }
        }

        public int MaxDigits
        {
            set
            {
                maxDigits = value;
            }
        }

        public bool LimitDigits
        {
            set
            {
                limitDigits = value;
            }
        }

        public bool DecimalPlaces
        {
            set
            {
                decimalPlaces = value;
            }
        }
    }
}
