using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class Resolution
    {
        private uint x;
        private uint y;

        public Resolution(uint width, uint height)
        {
            x = width;
            y = height;
        }

        public override string ToString()
        {
            return x + " × " + y;
        }

        public uint Width
        {
            get
            {
                return x;
            }
        }

        public uint Height
        {
            get
            {
                return y;
            }
        }

        public ulong TotalPixelCount
        {
            get
            {
                return (ulong)x * y;
            }
        }
    }


}
