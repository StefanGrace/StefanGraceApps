using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocalLengthCalculator
{
    class Converter
    {
        public static double ConvertFocalLength(double focalLength_mm, double inputSensorWidth_mm, double outputSensorWidth_mm)
        {
            return focalLength_mm / (inputSensorWidth_mm / outputSensorWidth_mm);
        }

        public static double FocalLengthToDegrees(double focualLength_mm, double sensorWidth_mm)
        {
            double radians =  2 * Math.Atan(sensorWidth_mm / (focualLength_mm * 2));

            return radians / (Math.PI / 180);
        }
    }
}
