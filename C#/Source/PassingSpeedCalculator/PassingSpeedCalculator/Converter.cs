using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingSpeedCalculator
{
    class Converter
    {
        public static double ConvertSpeed(double speed, string inputUnit, string outputUnit)
        {

            Dictionary<string, double> unitsInKmph = new Dictionary<string, double>()
            {
                { "km/h", 1 },
                { "mph", 1.6092 },
                { "m/s", 3.6 },
                { "ft/s", 1.09728 }
            };

            return (unitsInKmph[inputUnit] / unitsInKmph[outputUnit]) * speed;

        }
    }
}
