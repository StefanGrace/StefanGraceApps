using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class Calculator
    {
        public string calculateBMI(string weight, string height, string weightUnit, string heightUnit)
        {
            double weightD;
            double heightD;
            try
            {
                weightD = double.Parse(weight);
                heightD = double.Parse(height);
            }
            catch
            {
                return "";
            }

            double height_m;
            double weight_kg;

            // Convert all weight units to kg
            switch (weightUnit)
            {
                case "g":
                    weight_kg = weightD / 1000;
                    break;

                case "oz":
                    weight_kg = weightD * 0.02835;
                    break;

                case "lb":
                    weight_kg = weightD * 0.453592;
                    break;

                case "st":
                    weight_kg = weightD * 6.350293;
                    break;

                default:
                    weight_kg = weightD;
                    break;
            }

            // Convert all height units to m
            switch (heightUnit)
            {
                case "mm":
                    height_m = heightD / 1000;
                    break;

                case "cm":
                    height_m = heightD / 100;
                    break;

                case "dm":
                    height_m = heightD / 10;
                    break;

                case "in":
                    height_m = heightD * 0.0254;
                    break;

                case "ft":
                    height_m = heightD * 0.3048;
                    break;

                case "yd":
                    height_m = heightD * 0.9144;
                    break;

                default:
                    height_m = heightD;
                    break;
            }

            return calculateBMI(weight_kg, height_m);
        }

        public string calculateBMI(double weight, double height)
        {
            double bmi;
            bmi = weight / Math.Pow(height, 2);
            return bmi.ToString("N1") + " BMI";
        }
    }
}
