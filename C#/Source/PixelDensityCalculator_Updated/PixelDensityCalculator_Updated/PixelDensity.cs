using System;

namespace PixelDensityCalculator_Updated
{
    class PixelDensity
    {
        private double ppi;

        public PixelDensity(double screenSize, double width, double height)
        {
            if (screenSize == 0 || width == 0 || height == 0)
            {
                throw new InvalidInputException();
            }
            ppi = (Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2))) / screenSize;
        }

        public string toString()
        {
            return Math.Round(ppi, 2) + " PPI";
        }
    }
}
