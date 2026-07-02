using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferTime
{
    class DataAmount
    {
        private double value;
        private string prefix;
        private string unit;

        private static readonly Dictionary<string, int> prefixPowers = new Dictionary<string, int>()
        {
            {"", 0 },
            {"k", 1 },
            {"K", 1 },
            {"M", 2 },
            {"G", 3 },
            {"T", 4 },
            {"P", 5 },
            {"E", 6 },
            {"Z", 7 },
            {"Y", 8 },
            {"R", 9 },
            {"Q", 10 },
        };

        private static readonly Dictionary<string, int> unitBits = new Dictionary<string, int>()
        {
            {"b", 1 },
            {"B", 8 },
        };


        public DataAmount(double value, string prefix, string unit)
        {
            if (!prefixPowers.ContainsKey(prefix.Replace("i", "")) || !unitBits.ContainsKey(unit))
            {
                throw new ArgumentOutOfRangeException();
            }

            this.value = Math.Abs(value);
            this.prefix = prefix;
            this.unit = unit;
        }

        public double Value { get => value; }
        public string Prefix { get => prefix; }
        public string Unit { get => unit; }

        public double Bits
        {
            get
            {
                return value * getPrefixMultiplier(prefix) * unitBits[unit];
            }
        }

        public override string ToString()
        {
            return value + " " + prefix + unit;
        }

        private static double getPrefixMultiplier(string prefix)
        {
            if (prefix.EndsWith("i"))
            {
                return Math.Pow(1024, prefixPowers[prefix.Replace("i", "")]);
            }
            else
            {
                return Math.Pow(1000, prefixPowers[prefix]);
            }
        }
    }
}
