using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickerSafeShutterCalculator
{
    class Calculator
    {
        private int shutterUnit; // 0 = speed, 1 = angle, 2 = both

        public Calculator(int shutterUnit)
        {
            this.shutterUnit = shutterUnit;
        }

        public int ShutterUnit
        {
            set
            {
                shutterUnit = value;
            }
        }

        public string[] CalculateSafeShutters(double fps, double frequency)
        {
            if (fps < 1 || frequency < 1)
            {
                throw new Exception();
            }

            // if the frame rate is a divisor of the flicker freqency, return "<any>"
            if ((frequency / fps) % 1 < 0.01 || (frequency / fps) % 1 > 0.99)
            {
                return new string[] { "<any>" };
            }

            double[] safeShutterSpeeds = CalculateSafeShutterSpeeds(fps, frequency);

            // if there are no flicker-safe shutter speeds, return "<none>"
            if (safeShutterSpeeds.Length == 0)
            {
                return new string[] { "<none>" };
            }

            // format the `double` array of shutter speeds into a `string` array of "1/x" shutter speeds and/or shuter angles (°)
            string[] safeShutters = new string[safeShutterSpeeds.Length];
            for (int i = 0; i < safeShutterSpeeds.Length; i++)
            {
                switch (shutterUnit)
                {
                    case 0:
                        safeShutters[i] = "1/" + safeShutterSpeeds[i].ToString("0.##");
                        break;

                    case 1:
                        safeShutters[i] = CalculateShutterAngle(fps, safeShutterSpeeds[i]).ToString("0.##") + "°";
                        break;

                    default:
                        safeShutters[i] = "1/" + safeShutterSpeeds[i].ToString("0.##")
                            + " (" + CalculateShutterAngle(fps, safeShutterSpeeds[i]).ToString("0.##") + "°)";
                        break;
                }
            }

            return safeShutters;
        }

        private double[] CalculateSafeShutterSpeeds(double fps, double frequency)
        {
            List<double> safeShutterSpeeds = new List<double>();

            int fraction = 1;
            while (frequency / fraction >= fps)
            {
                safeShutterSpeeds.Add(frequency / fraction);
                fraction++;
            }

            safeShutterSpeeds.Reverse();

            return safeShutterSpeeds.ToArray();
        }

        private double CalculateShutterAngle(double fps, double shutterSpeed)
        {
            return (fps / shutterSpeed) * 360;
        }
    }
}
