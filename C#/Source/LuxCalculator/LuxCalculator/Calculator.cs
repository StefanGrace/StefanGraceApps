using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuxCalculator
{
    class Calculator
    {

        public static double CalculateLux(double fNumber, double shutterSpeed, double iso)
        {
            double ev = Math.Log(Math.Pow(fNumber, 2) / shutterSpeed, 2);

            double ev100 = ev - Math.Log(iso / 100, 2);

            double lux = 2.5 * Math.Pow(2, ev100);

            return lux;
        }

    }
}
