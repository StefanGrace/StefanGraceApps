using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutterAngleCalculator
{
    class Calculator
    {
        private double angleUnit = 360;

        public double AngleUnit
        {
            set
            {
                angleUnit = value;
            }
        }


        public double ShutterSpeedToAngle(double fps, double shutterSpeed)
        {
            return (fps / shutterSpeed) * angleUnit;
        }

        public double ShutterAngleToSpeed(double fps, double shutterAngle)
        {
            return fps / (shutterAngle / angleUnit);
        }

    }
}
