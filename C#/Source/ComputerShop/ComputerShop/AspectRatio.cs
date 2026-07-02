using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class AspectRatio
    {
        private uint x;
        private uint y;

        public AspectRatio(uint width, uint height)
        {
            uint i = 1;
            uint newX = width;
            uint newY = height;
            while (i < width && i < height)
            {
                if (IsCleanDivison(width, i) && IsCleanDivison(height, i))
                {
                    newX = width / i;
                    newY = height / i;
                }
                i++;
            }
            if (IsEven(newX) && IsEven(newY))
            {
                newX /= 2;
                newY /= 2;
            }
            if (newX == 8 && newY == 5)
            {
                x = 16;
                y = 10;
            }
            else if (newX == 683 && newY == 384)
            {
                x = 16;
                y = 9;
            }
            else
            {
                x = newX;
                y = newY;
            }
        }

        private bool IsCleanDivison(uint a, uint b)
        {
            return Convert.ToDouble(a) / Convert.ToDouble(b) % 1 == 0;
        }

        private bool IsEven(uint a)
        {
            return a % 2 == 0;
        }

        public override string ToString()
        {
            return x + ":" + y;
        }

        public double Ratio
        {
            get
            {
                return (double)x / y;
            }
        }
    }
}
