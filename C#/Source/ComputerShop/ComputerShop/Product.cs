using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public abstract class Product
    {
        protected string name;
        protected decimal price;
        protected bool inStock;

        public Product(string name, decimal price, bool inStock)
        {
            this.name = name;
            this.price = price;
            this.inStock = inStock;
        }

        private string FormatValue(ulong value, string unit)
        {
            const int maxDigits = 3;
            if (value == 0)
            {
                return value + " " + unit;
            }
            int magnitude = (int)Math.Floor(Math.Log10(value));
            int thouMag = (int)Math.Floor(magnitude / 3.0);
            double outValue = value / Math.Pow(1000, thouMag);
            string prefix = "";
            switch (thouMag)
            {
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
            int tenMag = (int)Math.Log10(outValue);
            if (tenMag > (maxDigits - 1))
            {
                tenMag = 2;
            }
            outValue = Math.Round(outValue, (maxDigits - 1) - Math.Abs(tenMag));
            return outValue + " " + prefix + unit;
        }

        protected string FormatBytes(ulong bytes)
        {
            return FormatValue(bytes, "B");
        }

        protected string FormatFrequency(ulong hertz)
        {
            return FormatValue(hertz, "Hz");
        }

        public abstract string GetHTML();

        public static string[] SortingOptions
        {
            get
            {
                return new string[] { "Name", "Price" };
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
        }

        public bool InStock
        {
            get
            {
                return inStock;
            }
        }
    }

}
