using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingSpeedCalculator
{
    class Calculator
    {
        public static double[] CalculateSpeeds(double bicycleSpeed, double carSpeed)
        {
            double sameDirPassSpeed = carSpeed - bicycleSpeed;

            double otherDirPassSpeed = carSpeed + bicycleSpeed;

            double dirRatio = Math.Abs(otherDirPassSpeed) / Math.Abs(sameDirPassSpeed);

            return new double[] { sameDirPassSpeed, otherDirPassSpeed, dirRatio };
        }
    }
}
