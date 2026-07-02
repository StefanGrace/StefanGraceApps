using System;
using System.Collections.Generic;

namespace UnitConverter
{
    public static class Converter
    {
        private const double speedOfLight = 299_792_458;

        private static readonly Dictionary<string, int> prefixPowers = new Dictionary<string, int>()
        {
            {"q", -30 },
            {"r", -27 },
            {"y", -24 },
            {"z", -21 },
            {"a", -18 },
            {"f", -15 },
            {"p", -12 },
            {"n", -9 },
            {"µ", -6 },
            {"m", -3 },
            {"c", -2 },
            {"d", -1 },
            {"", 0 },
            {"da", 1 },
            {"h", 2 },
            {"k", 3 },
            {"M", 6 },
            {"G", 9 },
            {"T", 12 },
            {"P", 15 },
            {"E", 18 },
            {"Z", 21 },
            {"Y", 24 },
            {"R", 27 },
            {"Q", 30 },
        };

        private static readonly Dictionary<string, double> lengthUnitMeters = new Dictionary<string, double>()
        {
            {"m", 1 },
            {"in", 0.0254 },
            {"ft", 0.3048 },
            {"yd", 0.9144 },
            {"mi", 1609.344 },
            {"NM", 1852},
            {"AU", 149_597_870_700 },
            {"pc", 30_856_775_814_913_673 },
            {"planck length", 1.616255E-35},
            {"twip", 0.0254 / 1440 },
            {"thou",  0.0254 / 1000 },
            {"barleycorn", 0.0254 / 3 },
            {"hand", 0.1016 },
            {"chain", 20.1168 },
            {"furlong", 201.168 },
            {"league", 4828.032 },
            {"fathom", 1.852 },
            {"cable",  185.2},
            {"link", 0.201_168 },
            {"rod", 5.0292 },

        };

        private static readonly Dictionary<string, double> timeUnitSeconds = new Dictionary<string, double>()
        {
            {"s", 1 },
            {"min", 60 },
            {"h", 60 * 60 },
            {"day", 60 * 60 * 24 },
            {"week", 60 * 60 * 24 * 7 },
            {"month (28 day)", 60 * 60 * 24 * 28 },
            {"month (29 day)", 60 * 60 * 24 * 29 },
            {"month (30 day)", 60 * 60 * 24 * 30 },
            {"month (31 day)", 60 * 60 * 24 * 31 },
            {"month (average)", 60 * 60 * 24 * 30.436875 },
            {"month", 60 * 60 * 24 * 30.436875 },
            {"year (non-leap)", 60 * 60 * 24 * 365 },
            {"year (leap)", 60 * 60 * 24 * 366 },
            {"year (average)", 60 * 60 * 24 * 365.2425 },
            {"year", 60 * 60 * 24 * 365.2425 },
            {"decade", 60 * 60 * 24 * 365.2425 * 10 },
            {"century", 60 * 60 * 24 * 365.2425 * 100},
            {"millennium", 60 * 60 * 24 * 365.2425 * 1000 },
            {"planck time", lengthUnitMeters["planck length"] / speedOfLight}
        };

        private static readonly Dictionary<string, double> volumeUnitLiters = new Dictionary<string, double>()
        {
            {"L", 1 },
            {"fl oz (US)", 0.0295735295625 },
            {"fl oz (UK)", 0.0284130625 },
            {"pt (US)", 0.473176473 },
            {"pt (UK)", 0.56826125 },
            {"gal (US)", 3.785411784 },
            {"gal (UK)", 4.54609 },
            {"planck volume", 4.222110975097781375E-102 },
            {"quart (US)", 0.946352946 },
            {"quart (UK)", 1.1365225 },
            {"tsp (US)", 0.00492892159375 },
            {"tsp (UK)", 0.0284130625 / 8 },
            {"tsp (metric)", 0.005 },
            {"Tbsp (US)", 0.0295735295625 / 2 },
            {"Tbsp (UK)", 0.0284130625 / 2 },
            {"Tbsp (Australia)", 0.020 },
            {"Tbsp (metric)", 0.015 },
            {"cup (US)", 0.2365882365 },
            {"cup (US legal)", 0.24 },
            {"cup (UK)", 0.0284130625 * 6 },
            {"cup (metric)", 0.25 },
            {"breakfast cup", 0.2273045 },
            {"oil barrel", 159 }
        };

        private static readonly Dictionary<string, double> massUnitGrams = new Dictionary<string, double>()
        {
            {"g", 1 },
            {"oz", 28.349523125 },
            {"lb", 453.59237 },
            {"st", 6_350.29318 },
            {"tn (US)", 907_184.74 },
            {"tn (UK)", 1_016_046.9088 },
            {"t", 1_000_000 },
            {"solar mass", 1.988416E+33 },
            {"planck mass", 2.176434E-5 }
        };

        private static readonly Dictionary<string, double[]> temperatureKelvin = new Dictionary<string, double[]>()
        {
            {"K", new double[] {1, 0} },
            {"°C", new double[] {1, 273.15} },
            {"°F", new double[] {1/1.8, 459.67} },
            {"°R", new double[] {1/1.8, 0} },
            {"planck temperature", new double[] { 1.416784E+32, 0} },
        };

        private static readonly Dictionary<string, double> dataUnitBits = new Dictionary<string, double>()
        {
            {"b", 1 },
            {"B", 8 },
        };

        private static readonly Dictionary<string, double> energyUnitJoules = new Dictionary<string, double>()
        {
            {"J", 1 },
            {"Wh", 3600 },
            {"cal", 4.184 },
            {"BTU", 1055.056 },
            {"eV", 1.602176634E-19 },
            {"planck energy", 1.9561E+9 },
        };

        private static readonly Dictionary<string, double> areaUnitSquareMeters = new Dictionary<string, double>()
        {
            {"acre",  4046.8564224},
        };

        private static readonly Dictionary<string, double> angleUnitsInTurn = new Dictionary<string, double>()
        {
            {"deg", 360 },
            {"rad", Math.PI * 2 },
            {"grad", 400 },
            {"turn", 1 },
            {"arcmin", 360 * 60 },
            {"arcsec", 360 * 60 * 60 },
        };


        // Prefixes

        private static double GetPrefixMultiplier(string inputPrefix, string outputPrefix)
        {
            return Math.Pow(10, prefixPowers[inputPrefix] - prefixPowers[outputPrefix]);
        }

        private static double GetPrefixMultiplier(string prefix)
        {
            return Math.Pow(10, prefixPowers[prefix]);
        }

        private static double GetBinaryPrefixMultiplier(string prefix)
        {
            if (prefix.EndsWith("i"))
            {
                char prefixLetter = prefix[0];
                if (prefixLetter == 'K')
                {
                    prefixLetter = 'k';
                }

                return Math.Pow(2, (prefixPowers[prefixLetter.ToString()] / 3) * 10);
            }
            else
            {
                return GetPrefixMultiplier(prefix);
            }
        }

        public static Tuple<double, string> AutoPrefix(double value, bool c = false, bool d = false, bool da = false, bool h = false)
        {
            int powerOf10 = double.IsInfinity(value) ? int.MaxValue : (int)Math.Floor(Math.Log10(Math.Abs(value)));

            if (d && powerOf10 == -1)
            {
                // Do nothing
            }
            else if (c && (powerOf10 == -2 || powerOf10 == -1))
            {
                powerOf10 = -2;
            }
            else if (h && powerOf10 == 2)
            {
                // Do nothing
            }
            else if (da && (powerOf10 == 1 || powerOf10 == 2))
            {
                powerOf10 = 1;
            }
            else
            {
                powerOf10 = (int)(Math.Floor((double)powerOf10 / 3) * 3);
            }

            if (powerOf10 > 30)
            {
                powerOf10 = 30;
            }
            else if (powerOf10 < -30)
            {
                powerOf10 = -30;
            }

            double outputValue = value / Math.Pow(10, powerOf10);

            foreach (KeyValuePair<string, int> prefixPower in prefixPowers)
            {
                if (prefixPower.Value == powerOf10)
                {
                    return new Tuple<double, string>(outputValue, prefixPower.Key);
                }
            }

            throw new InvalidOperationException();
        }

        public static Tuple<double, string> AutoNonNegativePrefix(double inputValue)
        {
            if (Math.Abs(inputValue) < 1 || double.IsNaN(inputValue))
            {
                return new Tuple<double, string>(inputValue, "");
            }
            else
            {
                return AutoPrefix(inputValue);
            }
        }

        public static Tuple<double, string> AutoBinaryPrefix(double value)
        {
            if (Math.Abs(value) < 1024)
            {
                return new Tuple<double, string>(value, "");
            }

            int powerOf1024 = double.IsInfinity(value) ? int.MaxValue : (int)Math.Floor(Math.Log(Math.Abs(value), 1024));

            if (powerOf1024 > 10)
            {
                powerOf1024 = 10;
            }

            double outputValue = value / Math.Pow(1024, powerOf1024);

            foreach (KeyValuePair<string, int> prefixPower in prefixPowers)
            {
                if (prefixPower.Value / 3 == powerOf1024)
                {
                    return new Tuple<double, string>(outputValue, prefixPower.Key.ToUpper() + "i");
                }
            }

            return new Tuple<double, string>(value, "");
        }


        // Length

        public static double ConvertLength(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            return inputValue * GetPrefixMultiplier(inputPrefix, outputPrefix) * (lengthUnitMeters[inputUnit] / lengthUnitMeters[outputUnit]);
        }

        public static double ConvertLightTimeToMeters(double inputValue, string inputPrefix, string inputUnit)
        {
            return inputValue * speedOfLight * GetPrefixMultiplier(inputPrefix) * timeUnitSeconds[inputUnit];
        }

        public static double ConvertMetersToLightTime(double meters, string timePrefix, string timeUnit)
        {
            return (meters / speedOfLight) / (timeUnitSeconds[timeUnit] * GetPrefixMultiplier(timePrefix));
        }

        public static Tuple<double, string, string> ConvertMetersToLightTime(double meters, bool weeks, bool months)
        {
            double lightSeconds = meters / speedOfLight;

            List<string> units = new List<string> { "year" };
            if (months)
            {
                units.Add("month");
            }
            if (weeks)
            {
                units.Add("week");
            }
            units.AddRange(new string[] { "day", "h", "min", "s" });

            string timeUnit = "s";

            foreach (string unit in units)
            {
                if (lightSeconds >= timeUnitSeconds[unit])
                {
                    timeUnit = unit;
                    break;
                }
            }

            if (timeUnit == "s")
            {
                Tuple<double, string> valueAndPrefix = AutoPrefix(lightSeconds);
                return new Tuple<double, string, string>(valueAndPrefix.Item1, valueAndPrefix.Item2, "s");
            }
            else
            {
                return new Tuple<double, string, string>(lightSeconds / timeUnitSeconds[timeUnit], "", timeUnit);
            }
        }

        public static Tuple<double, double> ConvertToFeetAndInches(double inputValue, string inputPrefix, string inputUnit)
        {
            double totalInches = ConvertLength(inputValue, inputPrefix, inputUnit, "", "in");
            double inches = totalInches % 12;
            double feet = Math.Truncate(totalInches / 12);
            return new Tuple<double, double>(feet, inches);
        }

        public static double ConvertFromFeetAndInches(double feet, double inches, string outputPrefix, string outputUnit)
        {
            return ConvertLength(feet, "", "ft", outputPrefix, outputUnit) + ConvertLength(inches, "", "in", outputPrefix, outputUnit);
        }

        public static Tuple<double, string> AutoImperialFromMeters(double meters)
        {
            string[] units = { "mi", "yd", "ft", "in" };
            string outputUnit = units[units.Length - 1];

            foreach (string unit in units)
            {
                if (Math.Abs(ConvertLength(meters, "", "m", "", unit)) >= 1)
                {
                    outputUnit = unit;
                    break;
                }
            }

            double outputValue = ConvertLength(meters, "", "m", "", outputUnit);

            return new Tuple<double, string>(outputValue, outputUnit);
        }

        public static Tuple<double, string, string> AutoLengthFromMeters(double meters, MeasurmentSystem measurmentSystem,
            bool cm = false, bool dm = false, bool dam = false, bool hm = false)
        {
            switch (measurmentSystem)
            {
                case MeasurmentSystem.Metric:
                    Tuple<double, string> valueAndPrefix = AutoPrefix(meters, cm, dm, dam, hm);
                    return new Tuple<double, string, string>(valueAndPrefix.Item1, valueAndPrefix.Item2, "m");

                case MeasurmentSystem.Imperial:
                    Tuple<double, string> valueAndUnit = AutoImperialFromMeters(meters);
                    return new Tuple<double, string, string>(valueAndUnit.Item1, "", valueAndUnit.Item2);

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }


        // Volume

        public static double ConvertVolume(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            return inputValue * GetPrefixMultiplier(inputPrefix, outputPrefix) * (volumeUnitLiters[inputUnit] / volumeUnitLiters[outputUnit]);
        }

        public static double ConvertCublicLengthToLiters(double inputValue, string inputPrefix, string inputUnit)
        {
            return inputValue * Math.Pow(ConvertLength(1, inputPrefix, inputUnit, "", "m"), 3) * 1000;
        }

        public static double ConvertLitersToCubicLength(double liters, string lengthPrefix, string lengthUnit)
        {
            double meters = ConvertLength(1, lengthPrefix, lengthUnit, "", "m");
            double inputCublicMeters = liters / 1000;
            double outputCublicMeters = Math.Pow(meters, 3);
            return inputCublicMeters / outputCublicMeters;
        }

        public static Tuple<double, string, string> ConvertLitersToCubicLength(double liters, MeasurmentSystem measurmentSystem)
        {
            double cublicMeters = liters / 1000;

            switch (measurmentSystem)
            {
                case MeasurmentSystem.Metric:
                    int[] powers = new int[prefixPowers.Count];
                    string[] prefixes = new string[prefixPowers.Count];
                    int index = prefixPowers.Count - 1;
                    foreach (KeyValuePair<string, int> prefixPower in prefixPowers)
                    {
                        powers[index] = prefixPower.Value;
                        prefixes[index] = prefixPower.Key;
                        index--;
                    }

                    string prefix = prefixes[prefixes.Length - 1];
                    for (int i = 0; i < powers.Length; i++)
                    {
                        double roundingCorrection;
                        if (powers[i] > 0)
                        {
                            roundingCorrection = 1.00000000001;
                        }
                        else
                        {
                            roundingCorrection = 0.9999999999;
                        }

                        if (Math.Log(Math.Abs(cublicMeters), 10) * roundingCorrection >= powers[i] * 3)
                        {
                            prefix = prefixes[i];
                            break;
                        }
                    }

                    double value = cublicMeters / Math.Pow(10, prefixPowers[prefix] * 3);
                    return new Tuple<double, string, string>(value, prefix, "m");

                case MeasurmentSystem.Imperial:
                    string[] units = { "mi", "yd", "ft", "in" };

                    string outputUnit = units[units.Length - 1];
                    foreach (string unit in units)
                    {
                        if (Math.Abs(cublicMeters) >= Math.Pow(ConvertLength(1, "", unit, "", "m"), 3))
                        {
                            outputUnit = unit;
                            break;
                        }
                    }

                    value = cublicMeters / Math.Pow(ConvertLength(1, "", outputUnit, "", "m"), 3);
                    return new Tuple<double, string, string>(value, "", outputUnit);

                default:
                    throw new ArgumentOutOfRangeException();

            }
        }

        public static double ConvertSidesOfCubeToVolume(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            double meters = ConvertLength(inputValue, inputPrefix, inputUnit, "", "m");

            double cubicMeters = Math.Pow(meters, 3);

            return ConvertVolume(cubicMeters, "k", "L", outputPrefix, outputUnit);
        }

        public static double ConvertRadiusOfSphereToVolume(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            double meters = ConvertLength(inputValue, inputPrefix, inputUnit, "", "m");

            double cubicMeters = (4.0 / 3.0) * Math.PI * Math.Pow(meters, 3);

            return ConvertVolume(cubicMeters, "k", "L", outputPrefix, outputUnit);
        }

        public static double ConvertDiameterOfSphereToVolume(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            return ConvertRadiusOfSphereToVolume(inputValue / 2, inputPrefix, inputUnit, outputPrefix, outputUnit);
        }

            public static double ConvertLitersToSidesOfCube(double liters, string lengthPrefix, string lengthUnit)
        {
            double cubicMeters = liters / 1000;

            double cubeSidesMeters = Math.Pow(cubicMeters, 1.0 / 3.0);

            return ConvertLength(cubeSidesMeters, "", "m", lengthPrefix, lengthUnit);
        }

        public static double ConvertLitersToRadiusOfSphere(double liters, string lengthPrefix, string lengthUnit)
        {
            double cubicMeters = liters / 1000;

            double sphereRadiusMeters = Math.Pow(3.0 * (cubicMeters / (Math.PI * 4)), 1.0 / 3.0);

            return ConvertLength(sphereRadiusMeters, "", "m", lengthPrefix, lengthUnit);
        }

        public static double ConvertLitersToDiameterOfSphere(double liters, string lengthPrefix, string lengthUnit)
        {
            return ConvertLitersToRadiusOfSphere(liters, lengthPrefix, lengthUnit) * 2;
        }

        public static Tuple<double, string, string> ConvertLitersToSidesOfCube(double liters, MeasurmentSystem measurmentSystem,
            bool cm, bool dm, bool dam, bool hm)
        {
            double cubeSidesMeters = ConvertLitersToSidesOfCube(liters, "", "m");

            return AutoLengthFromMeters(cubeSidesMeters, measurmentSystem, cm, dm, dam, hm);
        }

        public static Tuple<double, string, string> ConvertLitersToRadiusOfSphere(double liters, MeasurmentSystem measurmentSystem,
            bool cm, bool dm, bool dam, bool hm)
        {
            double cubeSidesMeters = ConvertLitersToRadiusOfSphere(liters, "", "m");

            return AutoLengthFromMeters(cubeSidesMeters, measurmentSystem, cm, dm, dam, hm);
        }

        public static Tuple<double, string, string> ConvertLitersToDiamerOfSphere(double liters, MeasurmentSystem measurmentSystem,
            bool cm, bool dm, bool dam, bool hm)
        {
            double cubeSidesMeters = ConvertLitersToDiameterOfSphere(liters, "", "m");

            return AutoLengthFromMeters(cubeSidesMeters, measurmentSystem, cm, dm, dam, hm);
        }

        public static double ConvertLengthXYZToVolume(double xValue, string xPrefix, string xUnit, 
            double yValue, string yPrefix, string yUnit, double zValue, string zPrefix, string zUnit,
            string volumePreifx, string volumeUnit)
        {
            double xMeters = ConvertLength(xValue, xPrefix, xUnit, "", "m");
            double yMeters = ConvertLength(yValue, yPrefix, yUnit, "", "m");
            double zMeters = ConvertLength(zValue, zPrefix, zUnit, "", "m");

            double cublicMeters = xMeters * yMeters * zMeters;

            return ConvertVolume(cublicMeters, "k", "L", volumePreifx, volumeUnit);
        }

        public static double ConvertLengthXYVolumeToLengthZ(double liters, double xValue, string xPrefix, string xUnit,
            double yValue, string yPrefix, string yUnit, string outputPrefix, string outputUnit)
        {
            double cublicMeters = liters / 1000;

            double area = ConvertLength(xValue, xPrefix, xUnit, "", "m") * ConvertLength(yValue, yPrefix, yUnit, "", "m");

            double zMeters = cublicMeters / area;

            return ConvertLength(zMeters, "", "m", outputPrefix, outputUnit);
        }



        // Mass

        public static double ConvertMass(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            return inputValue * GetPrefixMultiplier(inputPrefix, outputPrefix) * (massUnitGrams[inputUnit] / massUnitGrams[outputUnit]);
        }

        public static Tuple<double, double> ConvertToPoundsAndOunces(double inputValue, string inputPrefix, string inputUnit)
        {
            double totalOunces = ConvertMass(inputValue, inputPrefix, inputUnit, "", "oz");
            double ounces = totalOunces % 16;
            double pounds = Math.Truncate(totalOunces / 16);
            if (Math.Abs(ounces) > 15.99999)
            {
                ounces = 0;
                if (totalOunces >= 0)
                {
                    pounds++;
                }
                else
                {
                    pounds--;
                }
            }
            return new Tuple<double, double>(pounds, ounces);
        }

        public static Tuple<double, double, double> ConvertToStonePoundsAndOunces(double inputValue, string inputPrefix, string inputUnit)
        {
            Tuple<double, double> poundsAndOunces = ConvertToPoundsAndOunces(inputValue, inputPrefix, inputUnit);
            double pounds = poundsAndOunces.Item1 % 14;
            double stone = Math.Truncate(poundsAndOunces.Item1 / 14);
            return new Tuple<double, double, double>(stone, pounds, poundsAndOunces.Item2);
        }

        public static double ConvertFromPoundsAndOunces(double pounds, double ounces, string outputPrefix, string outputUnit)
        {
            return ConvertFromStonePoundsAndOunces(0, pounds, ounces, outputPrefix, outputUnit);
        }

        public static double ConvertFromStonePoundsAndOunces(double stone, double pounds, double ounces, string outputPrefix, string outputUnit)
        {
            return ConvertMass(stone, "", "st", outputPrefix, outputUnit) + ConvertMass(pounds, "", "lb", outputPrefix, outputUnit)
                + ConvertLength(ounces, "", "oz", outputPrefix, outputUnit);
        }

        public static double MassOfWaterVolume(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            double grams;
            if (inputUnit.EndsWith("³"))
            {
                grams = ConvertCublicLengthToLiters(inputValue, inputPrefix, inputUnit.Replace("³", "")) * 1000;
            }
            else
            {
                grams = ConvertVolume(inputValue, inputPrefix, inputUnit, "", "L") * 1000;
            }
            return ConvertMass(grams, "", "g", outputPrefix, outputUnit);
        }

        public static double VolumeOfWaterMass(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            double liters = ConvertMass(inputValue, inputPrefix, inputUnit, "", "g") / 1000;
            if (outputUnit.EndsWith("³"))
            {
                return ConvertLitersToCubicLength(liters, outputPrefix, outputUnit.Replace("³", ""));
            }
            else
            {
                return ConvertVolume(liters, "", "L", outputPrefix, outputUnit);
            }
        }

        public static Tuple<double, string, string> VolumeOfWaterMass(double inputValue, string inputPrefix, string inputUnit, VolumeUnitType outputUnitType)
        {
            double liters = VolumeOfWaterMass(inputValue, inputPrefix, inputUnit, "", "L");
            switch (outputUnitType)
            {
                case VolumeUnitType.Metric:
                    Tuple<double, string> valueAndPrefix = AutoPrefix(liters);
                    double value = valueAndPrefix.Item1;
                    string prefix = valueAndPrefix.Item2;

                    double clampedLiters;
                    if (Math.Abs(liters) > 1E+30)
                    {
                        clampedLiters = 1E+30;
                    }
                    else if (Math.Abs(liters) < 1E-30)
                    {
                        clampedLiters = 1E-30;
                    }
                    else
                    {
                        clampedLiters = Math.Abs(liters);
                    }
                    Tuple<double, string, string> cublicLength = ConvertLitersToCubicLength(clampedLiters, MeasurmentSystem.Metric);

                    string outputUnit = Math.Abs(cublicLength.Item1) < 1000 && Math.Abs(cublicLength.Item1) > 0.999999 ?
                        "L (" + cublicLength.Item2 + cublicLength.Item3 + "³)" : "L";

                    return new Tuple<double, string, string>(value, prefix, outputUnit);

                case VolumeUnitType.ImperialVolumeUS:
                case VolumeUnitType.ImperialVolumeUK:
                    string[] units = outputUnitType == VolumeUnitType.ImperialVolumeUS ?
                        new string[] { "fl oz (US)", "pt (US)", "gal (US)" } :
                        new string[] { "fl oz (UK)", "pt (UK)", "gal (UK)" };

                    outputUnit = units[0];

                    foreach (string unit in units)
                    {
                        if (Math.Abs(liters) >= volumeUnitLiters[unit])
                        {
                            outputUnit = unit;
                        }
                    }

                    return new Tuple<double, string, string>(ConvertVolume(liters, "", "L", "", outputUnit), "", outputUnit);

                case VolumeUnitType.ImperialCubicLength:
                    cublicLength = ConvertLitersToCubicLength(liters, MeasurmentSystem.Imperial);
                    return new Tuple<double, string, string>(cublicLength.Item1, cublicLength.Item2, cublicLength.Item3 + "³");

                default:
                    throw new ArgumentOutOfRangeException();

            }
        }


        // Time

        public static double ConvertTime(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            return inputValue * GetPrefixMultiplier(inputPrefix, outputPrefix) * (timeUnitSeconds[inputUnit] / timeUnitSeconds[outputUnit]);
        }

        public static Tuple<double, double, double> ConvertToHoursMinutesAndSeconds(double inputValue, string inputPrefix, string inputUnit)
        {
            double totalSeconds = ConvertTime(inputValue, inputPrefix, inputUnit, "", "s");
            double totalMinutes = Math.Truncate(totalSeconds / 60);
            double hours = Math.Truncate(totalMinutes / 60);
            double minutes = totalMinutes % 60;
            double seconds = totalSeconds % 60;
            return new Tuple<double, double, double>(hours, minutes, seconds);
        }

        public static Tuple<double, double, double, double> ConvertToDaysHoursMinutesAndSeconds(double inputValue, string inputPrefix, string inputUnit)
        {
            Tuple<double, double, double> hoursMinutesSeconds = ConvertToHoursMinutesAndSeconds(inputValue, inputPrefix, inputUnit);
            double days = Math.Truncate(hoursMinutesSeconds.Item1 / 24);
            double hours = hoursMinutesSeconds.Item1 % 24;
            return new Tuple<double, double, double, double>(days, hours, hoursMinutesSeconds.Item2, hoursMinutesSeconds.Item3);
        }

        public static double ConvertFromDaysHoursMinutesAndSeconds(double days, double hours, double minutes, double seconds,
            string outputPrefix, string outputUnit)
        {
            return ConvertTime(days, "", "day", outputPrefix, outputUnit) + ConvertTime(hours, "", "h", outputPrefix, outputUnit) +
                ConvertTime(minutes, "", "min", outputPrefix, outputUnit) + ConvertTime(seconds, "", "s", outputPrefix, outputUnit);
        }

        public static double ConvertFromHoursMinutesAndSeconds(double hours, double minutes, double seconds,
            string outputPrefix, string outputUnit)
        {
            return ConvertFromDaysHoursMinutesAndSeconds(0, hours, minutes, seconds, outputPrefix, outputUnit);
        }


        // Speed

        public static double ConvertSpeed(double inputDistance, string inputDistancePrefix, string inputDistanceUnit,
            string inputTimePrefix, string inputTimeUnit,
            string outputDistancePrefix, string outputDistanceUnit, string outputTimePrefix, string outputTimeUnit)
        {
            return ConvertLength(inputDistance, inputDistancePrefix, inputDistanceUnit, outputDistancePrefix, outputDistanceUnit) /
                ConvertTime(1, inputTimePrefix, inputTimeUnit, outputTimePrefix, outputTimeUnit);
        }

        public static double ConvertSpeedOfLightToSpeed(double value, string outputDistancePrefix, string outputDistanceUnit,
            string outputTimePrefix, string outputTimeUnit)
        {
            return value * ConvertSpeed(speedOfLight, "", "m", "", "s", outputDistancePrefix, outputDistanceUnit, outputTimePrefix, outputTimeUnit);
        }

        public static double ConvertSpeedToSpeedOfLight(double inputDistance, string inputDistancePrefix, string inputDistanceUnit,
            string inputTimePrefix, string inputTimeUnit)
        {
            return ConvertSpeed(inputDistance, inputDistancePrefix, inputDistanceUnit, inputTimePrefix, inputTimeUnit, "", "m", "", "s") / speedOfLight;
        }


        // Temperature

        public static double ConvertTemperature(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            double inputAbsolute = (inputValue * Math.Pow(10, prefixPowers[inputPrefix])) + temperatureKelvin[inputUnit][1];
            double outputAbsolute = inputAbsolute * (temperatureKelvin[inputUnit][0] / temperatureKelvin[outputUnit][0]);
            return (outputAbsolute - temperatureKelvin[outputUnit][1]) / Math.Pow(10, prefixPowers[outputPrefix]);
        }


        // Data

        public static double ConvertData(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            double prefixMultiplier = GetBinaryPrefixMultiplier(inputPrefix) / GetBinaryPrefixMultiplier(outputPrefix);
            return inputValue * prefixMultiplier * (dataUnitBits[inputUnit] / dataUnitBits[outputUnit]);
        }


        // Energy

        public static double ConvertEnergy(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            return inputValue * GetPrefixMultiplier(inputPrefix, outputPrefix) * (energyUnitJoules[inputUnit] / energyUnitJoules[outputUnit]);
        }

        public static double ConvertWattTimeToEnergy(double watts, string inputPrefix, string timeUnit, string outputPrefix, string outputUnit)
        {
            double joules = watts * ConvertTime(1, "", timeUnit, "", "s");
            return ConvertEnergy(joules, inputPrefix, "J", outputPrefix, outputUnit);
        }

        public static double ConvertAmpHourToEnergy(double ampHours, double voltage, string inputPrefix, string outputPrefix, string outputUnit)
        {
            return ConvertEnergy(ampHours * voltage, inputPrefix, "Wh", outputPrefix, outputUnit);
        }


        // Area

        public static double ConvertSquareLength(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            double inputMultiplier = Math.Pow(GetPrefixMultiplier(inputPrefix) * lengthUnitMeters[inputUnit], 2);
            double outputMultiplier = Math.Pow(GetPrefixMultiplier(outputPrefix) * lengthUnitMeters[outputUnit], 2);
            return inputValue * (inputMultiplier / outputMultiplier);
        }

        public static double ConvertArea(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            return inputValue * GetPrefixMultiplier(inputPrefix, outputPrefix) * (areaUnitSquareMeters[inputUnit] / areaUnitSquareMeters[outputUnit]);
        }

        public static double ConvertSquareLengthToArea(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            double squareMeters = ConvertSquareLength(inputValue, inputPrefix, inputUnit, "", "m");
            return squareMeters / (GetPrefixMultiplier(outputPrefix) * areaUnitSquareMeters[outputUnit]);
        }

        public static double ConvertAreaToSquareLength(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            double squareMeters = inputValue * GetPrefixMultiplier(inputPrefix) * areaUnitSquareMeters[inputUnit];
            return ConvertSquareLength(squareMeters, "", "m", outputPrefix, outputUnit);
        }

        public static double ConvertLengthXYToSquareMeters(double xValue, string xPrefix, string xUnit, double yValue, string yPrefix, string yUnit)
        {
            return ConvertLength(xValue, xPrefix, xUnit, "", "m") * ConvertLength(yValue, yPrefix, yUnit, "", "m");
        }

        public static double ConvertSideLengthOfSqueareToSquareMeters(double sidesLength, string inputPrefix, string inputUnit)
        {
            double sidesMeters = ConvertLength(sidesLength, inputPrefix, inputUnit, "", "m");
            return Math.Pow(sidesMeters, 2);
        }

        public static double ConvertSquareLengthToSideLengthOfSquare(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            return Math.Sqrt(ConvertSquareLength(inputValue, inputPrefix, inputUnit, outputPrefix, outputUnit));
        }

        public static Tuple<double, string> ConvertSquareLengthToSquarePrefixMeters(double inputValue, string inputPrefix, string inputUnit, 
            bool cm2 = false, bool dm2 = false, bool dam2 = false, bool hm2 = false)
        {
            double squareMeters = ConvertSquareLength(inputValue, inputPrefix, inputUnit, "", "m");

            return new Tuple<double, string>(0, "");

        }


        // Angle

        public static double ConvertAngle(double inputValue, string inputPrefix, string inputUnit, string outputPrefix, string outputUnit)
        {
            return inputValue * GetPrefixMultiplier(inputPrefix, outputPrefix) *
                ((1 / angleUnitsInTurn[inputUnit]) / (1 / angleUnitsInTurn[outputUnit]));
        }

        public static Tuple<double, double, double> ConvertToDegreesArcminutesArcseconds(double inputValue, string inputPrefix, string inputUnit)
        {
            double totalArcseconds = ConvertAngle(inputValue, inputPrefix, inputUnit, "", "arcsec");
            double totalArcminutes = Math.Truncate(totalArcseconds / 60);

            double degrees = Math.Truncate(totalArcminutes / 60);
            double arcMinutes = totalArcminutes % 60;
            double arcSeconds = totalArcseconds % 60;

            return new Tuple<double, double, double>(degrees, arcMinutes, arcSeconds);
        }

        public static double ConvertFromDegreesArcminutesArcseconds(double degrees, double arcminutes, double arcseconds, 
            string outputPrefix, string outputUnit)
        {
            return ConvertAngle(degrees, "", "deg", outputPrefix, outputUnit) +
                ConvertAngle(arcminutes, "", "arcmin", outputPrefix, outputUnit) +
                ConvertAngle(arcseconds, "", "arcsec", outputPrefix, outputUnit);
        }

    }
}
