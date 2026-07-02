using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class Form1 : Form
    {
        private UnitTextBox[] lengthUnitTextBoxes;
        private UnitTextBox[] volumeUnitTextBoxes;
        private UnitTextBox[] massUnitTextBoxes;
        private UnitTextBox[] timeUnitTextBoxes;
        private SpeedUnitTextBox[] speedUnitTextBoxes;
        private UnitTextBox[] temperatureUnitTextBoxes;

        private ComboBox[] lengthComboboxInputs;
        private ComboBox[] lengthComboboxOutputs;
        private ComboBox[] timeComboboxInputs;
        private ComboBox[] timeComboboxOutputs;
        private ComboBox[] volumeComboboxInputs;
        private ComboBox[] volumeComboboxOutputs;

        private TextBox[] lengthXYZTextBoxes;
        private ComboBox[] lengthXYZComboBoxes;
        private Dictionary<TextBox, ComboBox> lengthXYZTextBoxComboboxes;

        private VolumeLengthFunction volumeLengthFunction = VolumeLengthFunction.SidesOfCube;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lengthUnitTextBoxes = new UnitTextBox[]
            {
                new UnitTextBox(textBox_inches, "in"),
                new UnitTextBox(textBox_feet, "ft"),
                new UnitTextBox(textBox_yards, "yd"),
                new UnitTextBox(textBox_miles, "mi"),
                new UnitTextBox(textBox_nauticalMiles, "NM"),
                new UnitTextBox(textBox_millimeters, "m", "m"),
                new UnitTextBox(textBox_centimeters, "m", "c"),
                new UnitTextBox(textBox_meters, "m"),
                new UnitTextBox(textBox_killometers, "m", "k"),
                new UnitTextBox(textBox_astronomicalUnits, "AU"),
                new UnitTextBox(textBox_parsecs, "pc"),
                new UnitTextBox(textBox_planckLength, "planck length"),
            };

            volumeUnitTextBoxes = new UnitTextBox[]
            {
                new UnitTextBox(textBox_fluidOuncesUS, "fl oz (US)"),
                new UnitTextBox(textBox_fluidOuncesUK, "fl oz (UK)"),
                new UnitTextBox(textBox_pintesUS, "pt (US)"),
                new UnitTextBox(textBox_pintesUK, "pt (UK)"),
                new UnitTextBox(textBox_gallonsUS, "gal (US)"),
                new UnitTextBox(textBox_gallonsUK, "gal (UK)"),
                new UnitTextBox(textBox_mililiters, "L", "m"),
                new UnitTextBox(textBox_liters, "L"),
                new UnitTextBox(textBox_planckVolume, "planck volume"),
            };

            massUnitTextBoxes = new UnitTextBox[]
            {
                new UnitTextBox(textBox_ounces, "oz"),
                new UnitTextBox(textBox_pounds, "lb"),
                new UnitTextBox(textBox_stone, "st"),
                new UnitTextBox(textBox_tonesUS, "tn (US)"),
                new UnitTextBox(textBox_tonesUK, "tn (UK)"),
                new UnitTextBox(textBox_milligrams, "g", "m"),
                new UnitTextBox(textBox_grams, "g"),
                new UnitTextBox(textBox_killograms, "g", "k"),
                new UnitTextBox(textBox_tonnes, "t"),
                new UnitTextBox(textBox_solarMass, "solar mass"),
                new UnitTextBox(textBox_planckMass, "planck mass")
            };

            timeUnitTextBoxes = new UnitTextBox[]
            {
                new UnitTextBox(textBox_milliseconds, "s", "m"),
                new UnitTextBox(textBox_seconds, "s"),
                new UnitTextBox(textBox_minutes, "min"),
                new UnitTextBox(textBox_hours, "h"),
                new UnitTextBox(textBox_days, "day"),
                new UnitTextBox(textBox_weeks, "week"),
                new UnitTextBox(textBox_months28, "month (28 day)"),
                new UnitTextBox(textBox_months29, "month (29 day)"),
                new UnitTextBox(textBox_months30, "month (30 day)"),
                new UnitTextBox(textBox_months31, "month (31 day)"),
                new UnitTextBox(textBox_monthsAverage, "month (average)"),
                new UnitTextBox(textBox_yearsNonLeap, "year (non-leap)"),
                new UnitTextBox(textBox_yearsLeap, "year (leap)"),
                new UnitTextBox(textBox_yearsAverage, "year (average)"),
                new UnitTextBox(textBox_planckTime, "planck time"),
            };

            speedUnitTextBoxes = new SpeedUnitTextBox[]
            {
                new SpeedUnitTextBox(textBox_killometersPerHour, "m", "h", "k"),
                new SpeedUnitTextBox(textBox_milesPerHour, "mi", "h"),
                new SpeedUnitTextBox(textBox_metersPerSecond, "m", "s"),
                new SpeedUnitTextBox(textBox_feetPerSecond, "ft", "s"),
                new SpeedUnitTextBox(textBox_knots, "NM", "h"),
            };

            temperatureUnitTextBoxes = new UnitTextBox[]
            {
                new UnitTextBox(textBox_celcius, "°C"),
                new UnitTextBox(textBox_fahrenheit, "°F"),
                new UnitTextBox(textBox_kelvin, "K"),
                new UnitTextBox(textBox_rankin, "°R"),
                new UnitTextBox(textBox_planckTemperature, "planck temperature"),
            };

            lengthComboboxInputs = new ComboBox[]
            {
                comboBox_cublicLengthUnitInput,
                comboBox_lengthOfSidesOfCubeInput,
                comboBox_lengthByLengthByLengthX,
                comboBox_lengthByLengthByLengthY,
                comboBox_lengthByLengthByLengthZ,
                comboBox_distanceInput,
            };

            lengthComboboxOutputs = new ComboBox[]
            {
                comboBox_cublicLengthUnitOutput,
                comboBox_lengthOfSidesOfCubeOutput,
                comboBox_distanceOutput,
            };

            timeComboboxInputs = new ComboBox[]
            {
                comboBox_lightTimeInput,
                comboBox_perTimeInput,
                comboBox_perTimeOutput,
            };

            timeComboboxOutputs = new ComboBox[]
            {
                comboBox_lightTimeOutput,
            };

            volumeComboboxInputs = new ComboBox[]
            {
                comboBox_waterVolumeInput,
            };

            volumeComboboxOutputs = new ComboBox[]
            {
                comboBox_waterVolumeOutput,
            };

            lengthXYZTextBoxes = new TextBox[]
            {
                textBox_lengthByLengthByLengthX,
                textBox_lengthByLengthByLengthY,
                textBox_lengthByLengthByLengthZ,
            };

            lengthXYZComboBoxes = new ComboBox[]
            {
                comboBox_lengthByLengthByLengthX,
                comboBox_lengthByLengthByLengthY,
                comboBox_lengthByLengthByLengthZ,
            };

            lengthXYZTextBoxComboboxes = new Dictionary<TextBox, ComboBox>()
            {
                {textBox_lengthByLengthByLengthX, comboBox_lengthByLengthByLengthX },
                {textBox_lengthByLengthByLengthY, comboBox_lengthByLengthByLengthY },
                {textBox_lengthByLengthByLengthZ, comboBox_lengthByLengthByLengthZ },
            };



            comboBox_otherLengthInput.SelectedItem = "chain";
            comboBox_otherLengthOutput.SelectedItem = "furlong";
            comboBox_metersPrefixInput.SelectedItem = "d";
            comboBox_metersPrefixOutput.SelectedItem = "(auto)";
            comboBox_lightTimeInput.SelectedItem = "year";
            comboBox_lightTimeOutput.SelectedItem = "(auto)";
            comboBox_litersPrefixInput.SelectedItem = "k";
            comboBox_litersPrefixOutput.SelectedItem = "(auto)";
            comboBox_cublicLengthUnitInput.SelectedItem = "m";
            comboBox_cublicLengthUnitOutput.SelectedItem = "(auto) metric";
            comboBox_massPrefixInput.SelectedItem = "µ";
            comboBox_massInputUnit.SelectedItem = "g";
            comboBox_gramsPrefixOutput.SelectedItem = "(auto)";
            comboBox_tonnesPrefixOutput.SelectedItem = "(auto)";
            comboBox_waterVolumeInput.SelectedItem = "L (dm³)";
            comboBox_waterVolumeOutput.SelectedItem = "(auto) metric";
            comboBox_secondPrefixInput.SelectedItem = "µ";
            comboBox_secondPrefixOutput.SelectedItem = "(auto)";
            comboBox_distanceInput.SelectedItem = "m";
            comboBox_perTimeInput.SelectedItem = "s";
            comboBox_distanceOutput.SelectedItem = "(auto) metric";
            comboBox_perTimeOutput.SelectedItem = "h";
            comboBox_kelvinPrefixInput.SelectedItem = "k";
            comboBox_kelvinPrefixOutput.SelectedItem = "(auto)";
            comboBox_otherVolumeInput.SelectedItem = "tsp (metric)";
            comboBox_otherVolumeOutput.SelectedItem = "cup (metric)";
            comboBox_lengthOfSidesOfCubeInput.SelectedItem = "m";
            comboBox_lengthOfSidesOfCubeOutput.SelectedItem = "(auto) metric";
            comboBox_lengthByLengthByLengthX.SelectedItem = "m";
            comboBox_lengthByLengthByLengthY.SelectedItem = "m";
            comboBox_lengthByLengthByLengthZ.SelectedItem = "m";

            label_prefixMetersOutput.Text = "";
            label_lightTimeOutput.Text = "";
            label_prefixLitersOutput.Text = "";
            label_cublicLengthOutputUnit.Text = "";
            label_gramsOuputUnit.Text = "";
            label_tonnesOutputUnit.Text = "";
            label_secondsOutputUnit.Text = "";
            label_waterVolumeOutputUnit.Text = "";
            label_lengthOfSidesOfSquareOutputUnit.Text = "";

            PopulateComboboxes();
        }

        private void comboBox_metersPrefixOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool checkboxesEnabled = comboBox_metersPrefixOutput.SelectedItem.ToString() == "(auto)";
            checkBox_cm.Enabled = checkboxesEnabled;
            checkBox_dm.Enabled = checkboxesEnabled;
            checkBox_dam.Enabled = checkboxesEnabled;
            checkBox_hm.Enabled = checkboxesEnabled;
        }


        // Output

        private void PopulateTextBoxes(UnitTextBox[] unitTextBoxes, UnitType unitType, double inputValue, string inputPrefix, string inputUnit)
        {
            // General text boxes
            FormHandler.PopulateTextBoxes(unitTextBoxes, unitType, inputValue, inputPrefix, inputUnit);

            // Special text boxes
            switch (unitType)
            {
                // Length
                case UnitType.Length:
                    double meters = Converter.ConvertLength(inputValue, inputPrefix, inputUnit, "", "m");

                    // Feet and inches
                    if (!textBox_feetAndInches.Focused)
                    {
                        textBox_feetAndInches.Text = Formatter.FormatToFeetAndInches(inputValue, inputPrefix, inputUnit);
                    }

                    // Other length unit input
                    if (!textBox_otherLengthInput.Focused && !comboBox_otherLengthInput.Focused)
                    {
                        textBox_otherLengthInput.Text =
                            Converter.ConvertLength(inputValue, inputPrefix, inputUnit, "", comboBox_otherLengthInput.SelectedItem.ToString())
                            .ToString(Formatter.outputNumberFormat);
                    }

                    // Other length unit output
                    textBox_otherLengthOutput.Text =
                        Converter.ConvertLength(inputValue, inputPrefix, inputUnit, "", comboBox_otherLengthOutput.SelectedItem.ToString())
                            .ToString(Formatter.outputNumberFormat);

                    // Prefix meters input
                    if (!textBox_PrefixMetersInput.Focused && !comboBox_metersPrefixInput.Focused)
                    {
                        textBox_PrefixMetersInput.Text = Converter.ConvertLength(inputValue, inputPrefix, inputUnit,
                            comboBox_metersPrefixInput.SelectedItem.ToString(), "m").ToString(Formatter.outputNumberFormat);
                    }

                    // Prefix meters output;
                    double value;
                    string prefix;

                    if (comboBox_metersPrefixOutput.SelectedItem.ToString() == "(auto)")
                    {
                        Tuple<double, string> valueAndPrefix = Converter.AutoPrefix(meters,
                            checkBox_cm.Checked, checkBox_dm.Checked, checkBox_dam.Checked, checkBox_hm.Checked);
                        value = valueAndPrefix.Item1;
                        prefix = valueAndPrefix.Item2;
                    }
                    else
                    {
                        prefix = comboBox_metersPrefixOutput.SelectedItem.ToString();
                        value = Converter.ConvertLength(inputValue, inputPrefix, inputUnit, prefix, "m");
                    }

                    textBox_prefixMetersOutput.Text = value.ToString(Formatter.outputNumberFormat);
                    label_prefixMetersOutput.Text = prefix + "m";



                    // Light time input
                    if (!textBox_lightTimeInput.Focused && !comboBox_lightTimeInput.Focused)
                    {
                        string timePrefixAndUnit = comboBox_lightTimeInput.SelectedItem.ToString();
                        string timeUnit = FormHandler.timeUnitsAndPrefixes[timePrefixAndUnit][0];
                        string timePrefix = FormHandler.timeUnitsAndPrefixes[timePrefixAndUnit][1];
                        textBox_lightTimeInput.Text = Converter.ConvertMetersToLightTime(meters, timePrefix, timeUnit).ToString(Formatter.outputNumberFormat);
                    }

                    // Light time output
                    string outputTimePrefixAndUnit = comboBox_lightTimeOutput.SelectedItem.ToString();
                    string outputTimeUnit;
                    string outputTimePrefix;

                    if (outputTimePrefixAndUnit == "(auto)")
                    {
                        Tuple<double, string, string> lightTime =
                            Converter.ConvertMetersToLightTime(meters, checkBox_week.Checked, checkBox_month.Checked);
                        textBox_lightTimeOutput.Text = lightTime.Item1.ToString(Formatter.outputNumberFormat);
                        outputTimePrefix = lightTime.Item2;
                        outputTimeUnit = lightTime.Item3;
                    }
                    else
                    {
                        outputTimeUnit = FormHandler.timeUnitsAndPrefixes[outputTimePrefixAndUnit][0];
                        outputTimePrefix = FormHandler.timeUnitsAndPrefixes[outputTimePrefixAndUnit][1];

                        textBox_lightTimeOutput.Text =
                            Converter.ConvertMetersToLightTime(meters, outputTimePrefix, outputTimeUnit).ToString(Formatter.outputNumberFormat);
                    }

                    label_lightTimeOutput.Text = "light " + outputTimePrefix + outputTimeUnit;
                    break;


                // Volume
                case UnitType.Volume:

                    double liters = Converter.ConvertVolume(inputValue, inputPrefix, inputUnit, "", "L");

                    // Other volume unit input
                    if (!textBox_otherVolumeInput.Focused && !comboBox_otherVolumeInput.Focused)
                    {
                        textBox_otherVolumeInput.Text =
                            Converter.ConvertVolume(inputValue, inputPrefix, inputUnit, "", comboBox_otherVolumeInput.SelectedItem.ToString())
                            .ToString(Formatter.outputNumberFormat);
                    }

                    // Other volume unit output
                    textBox_otherVolumeOutput.Text =
                        Converter.ConvertVolume(inputValue, inputPrefix, inputUnit, "", comboBox_otherVolumeOutput.SelectedItem.ToString())
                            .ToString(Formatter.outputNumberFormat);


                    // Prefix liters input
                    if (!textBox_prefixLitersInput.Focused && !comboBox_litersPrefixInput.Focused)
                    {
                        textBox_prefixLitersInput.Text = Converter.ConvertVolume(inputValue, inputPrefix, inputUnit,
                            comboBox_litersPrefixInput.SelectedItem.ToString(), "L").ToString(Formatter.outputNumberFormat);
                    }

                    // Prefix liters output;
                    if (comboBox_litersPrefixOutput.SelectedItem.ToString() == "(auto)")
                    {
                        Tuple<double, string> valueAndPrefix = Converter.AutoPrefix(liters);
                        value = valueAndPrefix.Item1;
                        prefix = valueAndPrefix.Item2;
                    }
                    else
                    {
                        prefix = comboBox_litersPrefixOutput.SelectedItem.ToString();
                        value = Converter.ConvertVolume(inputValue, inputPrefix, inputUnit, prefix, "L");
                    }

                    textBox_prefixLitersOutput.Text = value.ToString(Formatter.outputNumberFormat);
                    label_prefixLitersOutput.Text = prefix + "L";

                    // Cublic length input
                    if (!textBox_cublicLengthInput.Focused && !comboBox_cublicLengthUnitInput.Focused)
                    {
                        string cublicLengthUnit = FormHandler.lengthUnitsAndPrefixes[comboBox_cublicLengthUnitInput.Text][0];
                        string cublicLengthPrefix = FormHandler.lengthUnitsAndPrefixes[comboBox_cublicLengthUnitInput.Text][1];
                        textBox_cublicLengthInput.Text =
                            Converter.ConvertLitersToCubicLength(liters, cublicLengthPrefix, cublicLengthUnit).ToString(Formatter.outputNumberFormat);
                    }

                    // Cublic length ouptut
                    string outputCublicLengthPrefixAndUnit = comboBox_cublicLengthUnitOutput.Text;
                    string outputCublicLengthPrefix = "";
                    string outputCublicLengthUnit = "";
                    if (outputCublicLengthPrefixAndUnit.StartsWith("(auto)"))
                    {
                        MeasurmentSystem measurmentSystem;
                        if (outputCublicLengthPrefixAndUnit.EndsWith("metric"))
                        {
                            measurmentSystem = MeasurmentSystem.Metric;
                        }
                        else
                        {
                            measurmentSystem = MeasurmentSystem.Imperial;
                        }

                        Tuple<double, string, string> valuePrefixAndUnit = Converter.ConvertLitersToCubicLength(liters, measurmentSystem);
                        textBox_cublicLengthOutput.Text = valuePrefixAndUnit.Item1.ToString(Formatter.outputNumberFormat);
                        outputCublicLengthPrefix = valuePrefixAndUnit.Item2;
                        outputCublicLengthUnit = valuePrefixAndUnit.Item3;
                    }
                    else
                    {
                        outputCublicLengthPrefix = FormHandler.lengthUnitsAndPrefixes[outputCublicLengthPrefixAndUnit][1];
                        outputCublicLengthUnit = FormHandler.lengthUnitsAndPrefixes[outputCublicLengthPrefixAndUnit][0];
                        textBox_cublicLengthOutput.Text =
                            Converter.ConvertLitersToCubicLength(liters, outputCublicLengthPrefix, outputCublicLengthUnit).ToString(Formatter.outputNumberFormat);

                    }
                    label_cublicLengthOutputUnit.Text = outputCublicLengthPrefix + outputCublicLengthUnit + "³";

                    // Cube sides length input
                    if (!textBox_lengthOfSidesOfCubeInput.Focused && !comboBox_lengthOfSidesOfCubeInput.Focused)
                    {
                        string cubeSidesLengthPrefixAndUnit = comboBox_lengthOfSidesOfCubeInput.SelectedItem.ToString();
                        string cudeSidesLengthUnit = FormHandler.lengthUnitsAndPrefixes[cubeSidesLengthPrefixAndUnit][0];
                        string cudeSidesLengthPrefix = FormHandler.lengthUnitsAndPrefixes[cubeSidesLengthPrefixAndUnit][1];

                        textBox_lengthOfSidesOfCubeInput.Text
                            = Converter.ConvertLitersToSidesOfCube(liters, cudeSidesLengthPrefix, cudeSidesLengthUnit)
                            .ToString(Formatter.outputNumberFormat);
                    }

                    // Cube sides length ouptut
                    string outputCubeSidesLengthPrefixAndUnit = comboBox_lengthOfSidesOfCubeOutput.Text;
                    string outputCubeSidesLengthPrefix = "";
                    string outputCubeSidesLengthUnit = "";
                    if (outputCubeSidesLengthPrefixAndUnit.StartsWith("(auto)"))
                    {
                        MeasurmentSystem measurmentSystem;
                        if (outputCubeSidesLengthPrefixAndUnit.EndsWith("metric"))
                        {
                            measurmentSystem = MeasurmentSystem.Metric;
                        }
                        else
                        {
                            measurmentSystem = MeasurmentSystem.Imperial;
                        }

                        Tuple<double, string, string> valuePrefixAndUnit = Converter.ConvertLitersToSidesOfCube(liters, measurmentSystem,
                            checkBox_cubeSideLength_cm.Checked, checkBox_cubeSideLength_dm.Checked,
                            checkBox_cubeSideLength_dam.Checked, checkBox_cubeSideLength_hm.Checked);

                        textBox_lengthOfSidesOfCubeOutput.Text = valuePrefixAndUnit.Item1.ToString(Formatter.outputNumberFormat);
                        outputCubeSidesLengthPrefix = valuePrefixAndUnit.Item2;
                        outputCubeSidesLengthUnit = valuePrefixAndUnit.Item3;
                    }
                    else
                    {
                        outputCubeSidesLengthPrefix = FormHandler.lengthUnitsAndPrefixes[outputCubeSidesLengthPrefixAndUnit][1];
                        outputCubeSidesLengthUnit = FormHandler.lengthUnitsAndPrefixes[outputCubeSidesLengthPrefixAndUnit][0];
                        textBox_lengthOfSidesOfCubeOutput.Text =
                            Converter.ConvertLitersToSidesOfCube(liters, outputCubeSidesLengthPrefix, outputCubeSidesLengthUnit)
                            .ToString(Formatter.outputNumberFormat);

                    }
                    label_lengthOfSidesOfSquareOutputUnit.Text = outputCubeSidesLengthPrefix + outputCubeSidesLengthUnit;


                    if (!textBox_lengthByLengthByLengthX.Focused &&
                        !textBox_lengthByLengthByLengthY.Focused &&
                        !textBox_lengthByLengthByLengthZ.Focused &&
                        !comboBox_lengthByLengthByLengthX.Focused &&
                        !comboBox_lengthByLengthByLengthY.Focused &&
                        !comboBox_lengthByLengthByLengthZ.Focused &&
                        !checkBox_linkLengthXYZUnits.Focused)
                    {
                        textBox_lengthByLengthByLengthX.Clear();
                        textBox_lengthByLengthByLengthY.Clear();
                        textBox_lengthByLengthByLengthZ.Clear();
                    }

                    break;


                // Mass
                case UnitType.Mass:

                    // Pounds and ounces
                    if (!textBox_poundsAndOunces.Focused)
                    {
                        textBox_poundsAndOunces.Text = Formatter.FormatToPoundsAndOunces(inputValue, inputPrefix, inputUnit);
                    }

                    // Stone, pounds and ounces
                    if (!textBox_stonePoundsAndOunces.Focused)
                    {
                        textBox_stonePoundsAndOunces.Text = Formatter.FormatToStonePoundsAndOunces(inputValue, inputPrefix, inputUnit);
                    }

                    // Mass prefix input
                    if (!textBox_prefixMasstInput.Focused && !comboBox_massPrefixInput.Focused && !comboBox_massInputUnit.Focused)
                    {
                        string weightInputPrefix = comboBox_massPrefixInput.SelectedItem.ToString();
                        string weightInputUnit = comboBox_massInputUnit.SelectedItem.ToString();
                        textBox_prefixMasstInput.Text =
                            Converter.ConvertMass(inputValue, inputPrefix, inputUnit, weightInputPrefix, weightInputUnit).ToString(Formatter.outputNumberFormat);
                    }

                    // Grams prefix output
                    if (comboBox_gramsPrefixOutput.SelectedItem.ToString() == "(auto)")
                    {
                        double grams = Converter.ConvertMass(inputValue, inputPrefix, inputUnit, "", "g");
                        Tuple<double, string> valueAndPrefix = Converter.AutoPrefix(grams);
                        value = valueAndPrefix.Item1;
                        prefix = valueAndPrefix.Item2;
                    }
                    else
                    {
                        prefix = comboBox_gramsPrefixOutput.SelectedItem.ToString();
                        value = Converter.ConvertMass(inputValue, inputPrefix, inputUnit, prefix, "g");
                    }
                    textBox_prefixGramsOutput.Text = value.ToString(Formatter.outputNumberFormat);
                    label_gramsOuputUnit.Text = prefix + "g";

                    // Tonnes prefix output
                    if (comboBox_tonnesPrefixOutput.SelectedItem.ToString() == "(auto)")
                    {
                        double tonnes = Converter.ConvertMass(inputValue, inputPrefix, inputUnit, "", "t");
                        Tuple<double, string> valueAndPrefix = checkBox_negativeTonnePrefixes.Checked ?
                            Converter.AutoPrefix(tonnes) : Converter.AutoNonNegativePrefix(tonnes);
                        value = valueAndPrefix.Item1;
                        prefix = valueAndPrefix.Item2;
                    }
                    else
                    {
                        prefix = comboBox_tonnesPrefixOutput.SelectedItem.ToString();
                        value = Converter.ConvertMass(inputValue, inputPrefix, inputUnit, prefix, "t");
                    }
                    textBox_prefixTonnesOutput.Text = value.ToString(Formatter.outputNumberFormat);
                    label_tonnesOutputUnit.Text = prefix + "t";

                    // Mass of water input
                    if (!textBox_waterVolumeInput.Focused && !comboBox_waterVolumeInput.Focused)
                    {
                        string volumePrefixAndUnit = comboBox_waterVolumeInput.SelectedItem.ToString();
                        string volumePrefix = FormHandler.volumeUnitsAndPrefixes[volumePrefixAndUnit][1];
                        string volumeUnit = FormHandler.volumeUnitsAndPrefixes[volumePrefixAndUnit][0];
                        textBox_waterVolumeInput.Text =
                            Converter.VolumeOfWaterMass(inputValue, inputPrefix, inputUnit, volumePrefix, volumeUnit).ToString(Formatter.outputNumberFormat);
                    }

                    // Mass of water output
                    {
                        string volumePrefix;
                        string volumeUnit;
                        if (comboBox_waterVolumeOutput.SelectedItem.ToString().StartsWith("(auto)"))
                        {
                            VolumeUnitType volumeUnitType;
                            if (comboBox_waterVolumeOutput.SelectedItem.ToString().EndsWith("imperial volume (US)"))
                            {
                                volumeUnitType = VolumeUnitType.ImperialVolumeUS;
                            }
                            else if (comboBox_waterVolumeOutput.SelectedItem.ToString().EndsWith("imperial volume (UK)"))
                            {
                                volumeUnitType = VolumeUnitType.ImperialVolumeUK;
                            }
                            else if (comboBox_waterVolumeOutput.SelectedItem.ToString().EndsWith("imperial cublic length"))
                            {
                                volumeUnitType = VolumeUnitType.ImperialCubicLength;
                            }
                            else
                            {
                                volumeUnitType = VolumeUnitType.Metric;
                            }

                            Tuple<double, string, string> volumeAndUnit = Converter.VolumeOfWaterMass(inputValue, inputPrefix, inputUnit, volumeUnitType);
                            value = volumeAndUnit.Item1;
                            volumePrefix = volumeAndUnit.Item2;
                            volumeUnit = volumeAndUnit.Item3;
                        }
                        else
                        {
                            string volumePrefixAndUnit = comboBox_waterVolumeOutput.SelectedItem.ToString();
                            volumePrefix = FormHandler.volumeUnitsAndPrefixes[volumePrefixAndUnit][1];
                            volumeUnit = FormHandler.volumeUnitsAndPrefixes[volumePrefixAndUnit][0];
                            value = Converter.VolumeOfWaterMass(inputValue, inputPrefix, inputUnit, volumePrefix, volumeUnit);
                            volumePrefix = "";
                            volumeUnit = comboBox_waterVolumeOutput.SelectedItem.ToString();
                        }

                        textBox_waterVolumeOutput.Text = value.ToString(Formatter.outputNumberFormat);
                        label_waterVolumeOutputUnit.Text = volumePrefix + volumeUnit;
                    }


                    break;

                // Time               
                case UnitType.Time:

                    // Hours, minutes and seconds
                    if (!textBox_hoursMinutesSeconds.Focused)
                    {
                        textBox_hoursMinutesSeconds.Text =
                            Formatter.FormatToHoursMinutesAndSeconds(inputValue, inputPrefix, inputUnit);
                    }

                    // Days, hours, minutes and seconds
                    if (!textBox_daysHoursMinutesSeconds.Focused)
                    {
                        textBox_daysHoursMinutesSeconds.Text =
                            Formatter.FormatToDaysHoursMinutesAndSeconds(inputValue, inputPrefix, inputUnit);
                    }

                    // Prefix seconds input
                    if (!textBox_prefixSecondInput.Focused && !comboBox_secondPrefixInput.Focused)
                    {
                        prefix = comboBox_secondPrefixInput.SelectedItem.ToString();
                        textBox_prefixSecondInput.Text =
                            Converter.ConvertTime(inputValue, inputPrefix, inputUnit, prefix, "s").ToString(Formatter.outputNumberFormat);
                    }

                    // Prefix seconds output
                    if (!textBox_prefixSecondOutput.Focused)
                    {
                        if (comboBox_secondPrefixOutput.SelectedItem.ToString() == "(auto)")
                        {
                            double seconds = Converter.ConvertTime(inputValue, inputPrefix, inputUnit, "", "s");
                            Tuple<double, string> valueAndPrefix = Converter.AutoPrefix(seconds);
                            value = valueAndPrefix.Item1;
                            prefix = valueAndPrefix.Item2;
                        }
                        else
                        {
                            prefix = comboBox_secondPrefixOutput.SelectedItem.ToString();
                            value = Converter.ConvertTime(inputValue, inputPrefix, inputUnit, prefix, "s");
                        }

                        textBox_prefixSecondOutput.Text = value.ToString(Formatter.outputNumberFormat);
                        label_secondsOutputUnit.Text = prefix + "s";
                    }

                    break;

                case UnitType.Temperature:

                    // Prefix kelvin input
                    if (!textBox_prefixKelvinInput.Focused && !comboBox_kelvinPrefixInput.Focused)
                    {
                        prefix = comboBox_kelvinPrefixInput.SelectedItem.ToString();
                        textBox_prefixKelvinInput.Text =
                            Converter.ConvertTemperature(inputValue, inputPrefix, inputUnit, prefix, "K").ToString(Formatter.outputNumberFormat);
                    }

                    // Prefix kelvin output
                    double kelvin = Converter.ConvertTemperature(inputValue, inputPrefix, inputUnit, "", "K");
                    if (comboBox_kelvinPrefixOutput.SelectedItem.ToString() == "(auto)")
                    {
                        Tuple<double, string> valueAndPrefix = Converter.AutoPrefix(kelvin);
                        value = valueAndPrefix.Item1;
                        prefix = valueAndPrefix.Item2;
                    }
                    else
                    {
                        prefix = comboBox_kelvinPrefixOutput.SelectedItem.ToString();
                        value = Converter.ConvertTemperature(inputValue, inputPrefix, inputUnit, prefix, "K");
                    }
                    textBox_prefixKelvinOutput.Text = value.ToString(Formatter.outputNumberFormat);
                    label_prefixKelvinOutput.Text = prefix + "K";
                    break;


            }

        }

        private void Convert(UnitTextBox[] unitTextBoxes, UnitType unitType)
        {
            double inputValue = 0;
            string inputPrefix = "";
            string inputUnit = "";

            try
            {
                Tuple<double, string, string> input = FormHandler.ReadInput(unitTextBoxes);
                inputValue = input.Item1;
                inputPrefix = input.Item2;
                inputUnit = input.Item3;
            }
            catch
            {
                return;
            }

            if (inputUnit == "")
            {
                switch (unitType)
                {
                    case UnitType.Length:
                        try
                        {
                            inputValue = double.Parse(textBox_meters.Text);
                            inputUnit = "m";
                        }
                        catch
                        {
                            return;
                        }
                        break;

                    case UnitType.Volume:
                        try
                        {
                            inputValue = double.Parse(textBox_liters.Text);
                            inputUnit = "L";
                        }
                        catch
                        {
                            return;
                        }
                        break;

                    case UnitType.Mass:
                        try
                        {
                            inputValue = double.Parse(textBox_grams.Text);
                            inputUnit = "g";
                        }
                        catch
                        {
                            return;
                        }
                        break;

                    case UnitType.Time:
                        try
                        {
                            inputValue = double.Parse(textBox_seconds.Text);
                            inputUnit = "s";
                        }
                        catch
                        {
                            return;
                        }
                        break;

                    case UnitType.Temperature:
                        try
                        {
                            inputValue = double.Parse(textBox_kelvin.Text);
                            inputUnit = "K";
                        }
                        catch
                        {
                            return;
                        }
                        break;
                }

            }

            PopulateTextBoxes(unitTextBoxes, unitType, inputValue, inputPrefix, inputUnit);
        }


        // Input

        // Length
        private void lengthTextBox_textChanged(object sender, EventArgs e)
        {
            if (comboBox_metersPrefixOutput.Focused)
            {
                bool enableCheckboxes = comboBox_metersPrefixOutput.SelectedItem.ToString() == "(auto)";
                checkBox_cm.Enabled = enableCheckboxes;
                checkBox_dm.Enabled = enableCheckboxes;
                checkBox_dam.Enabled = enableCheckboxes;
                checkBox_hm.Enabled = enableCheckboxes;
            }

            if (textBox_otherLengthInput.Focused || comboBox_otherLengthInput.Focused)
            {
                try
                {
                    double value = double.Parse(textBox_otherLengthInput.Text);
                    string unit = comboBox_otherLengthInput.SelectedItem.ToString();
                    PopulateTextBoxes(lengthUnitTextBoxes, UnitType.Length, value, "", unit);
                }
                catch { }
            }

            if (textBox_feetAndInches.Focused)
            {
                try
                {
                    //double meters = Converter.ConvertFromFeetAndInches(feet, inches, "", "m");

                    double meters = Parser.ParseFeetAndInchesToMeters(textBox_feetAndInches.Text);
                    PopulateTextBoxes(lengthUnitTextBoxes, UnitType.Length, meters, "", "m");
                }
                catch { }

            }
            else if (textBox_PrefixMetersInput.Focused || comboBox_metersPrefixInput.Focused)
            {
                try
                {
                    double value = double.Parse(textBox_PrefixMetersInput.Text);
                    string prefix = comboBox_metersPrefixInput.SelectedItem.ToString();
                    PopulateTextBoxes(lengthUnitTextBoxes, UnitType.Length, value, prefix, "m");
                }
                catch { }
            }
            else if (textBox_lightTimeInput.Focused || comboBox_lightTimeInput.Focused)
            {
                try
                {
                    double timeValue = double.Parse(textBox_lightTimeInput.Text);
                    string prefixAndUnit = comboBox_lightTimeInput.SelectedItem.ToString();
                    string timeUnit = FormHandler.timeUnitsAndPrefixes[prefixAndUnit][0];
                    string timePrefix = FormHandler.timeUnitsAndPrefixes[prefixAndUnit][1];

                    double meters = Converter.ConvertLightTimeToMeters(timeValue, timePrefix, timeUnit);

                    PopulateTextBoxes(lengthUnitTextBoxes, UnitType.Length, meters, "", "m");
                }
                catch { }
            }
            else
            {
                Convert(lengthUnitTextBoxes, UnitType.Length);
            }
        }



        // Volume
        private void volumeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Text == "")
                {
                    return;
                }
            }
            catch { }

            if (textBox_prefixLitersInput.Focused || comboBox_litersPrefixInput.Focused)
            {
                try
                {
                    double value = double.Parse(textBox_prefixLitersInput.Text);
                    string prefix = comboBox_litersPrefixInput.SelectedItem.ToString();
                    PopulateTextBoxes(volumeUnitTextBoxes, UnitType.Volume, value, prefix, "L");
                }
                catch { }
            }
            else if (textBox_otherVolumeInput.Focused || comboBox_otherVolumeInput.Focused)
            {
                try
                {
                    double value = double.Parse(textBox_otherVolumeInput.Text);
                    string unit = comboBox_otherVolumeInput.SelectedItem.ToString();
                    PopulateTextBoxes(volumeUnitTextBoxes, UnitType.Volume, value, "", unit);
                }
                catch { }
            }
            else if (textBox_cublicLengthInput.Focused || comboBox_cublicLengthUnitInput.Focused)
            {
                try
                {
                    double value = double.Parse(textBox_cublicLengthInput.Text);
                    string unitAndPrefix = comboBox_cublicLengthUnitInput.SelectedItem.ToString();
                    string unit = FormHandler.lengthUnitsAndPrefixes[unitAndPrefix][0];
                    string prefix = FormHandler.lengthUnitsAndPrefixes[unitAndPrefix][1];
                    double liters = Converter.ConvertCublicLengthToLiters(value, prefix, unit);
                    PopulateTextBoxes(volumeUnitTextBoxes, UnitType.Volume, liters, "", "L");
                }
                catch { }
            }
            else if (textBox_lengthOfSidesOfCubeInput.Focused || comboBox_lengthOfSidesOfCubeInput.Focused)
            {
                try
                {
                    double value = double.Parse(textBox_lengthOfSidesOfCubeInput.Text);
                    string unitAndPrefix = comboBox_lengthOfSidesOfCubeInput.Text;
                    string unit = FormHandler.lengthUnitsAndPrefixes[unitAndPrefix][0];
                    string prefix = FormHandler.lengthUnitsAndPrefixes[unitAndPrefix][1];
                    double liters = Converter.ConvertSidesOfCubeToVolume(value, prefix, unit, "", "L");
                    PopulateTextBoxes(volumeUnitTextBoxes, UnitType.Volume, liters, "", "L");
                }
                catch { }
            }
            else if (textBox_lengthByLengthByLengthX.Focused || comboBox_lengthByLengthByLengthX.Focused ||
                textBox_lengthByLengthByLengthY.Focused || comboBox_lengthByLengthByLengthY.Focused ||
                textBox_lengthByLengthByLengthZ.Focused || comboBox_lengthByLengthByLengthZ.Focused)
            {
                try
                {
                    double lengthX = double.Parse(textBox_lengthByLengthByLengthX.Text);
                    double lengthY = double.Parse(textBox_lengthByLengthByLengthY.Text);
                    double lengthZ = double.Parse(textBox_lengthByLengthByLengthZ.Text);

                    string lengthXPrefixAndUnit = comboBox_lengthByLengthByLengthX.SelectedItem.ToString();
                    string lengthYPrefixAndUnit = comboBox_lengthByLengthByLengthY.SelectedItem.ToString();
                    string lengthZPrefixAndUnit = comboBox_lengthByLengthByLengthZ.SelectedItem.ToString();

                    double liters = Converter.ConvertLengthXYZToVolume(
                        lengthX,
                        FormHandler.lengthUnitsAndPrefixes[lengthXPrefixAndUnit][1],
                        FormHandler.lengthUnitsAndPrefixes[lengthXPrefixAndUnit][0],
                        lengthY,
                        FormHandler.lengthUnitsAndPrefixes[lengthYPrefixAndUnit][1],
                        FormHandler.lengthUnitsAndPrefixes[lengthYPrefixAndUnit][0],
                        lengthZ,
                        FormHandler.lengthUnitsAndPrefixes[lengthZPrefixAndUnit][1],
                        FormHandler.lengthUnitsAndPrefixes[lengthZPrefixAndUnit][0],
                        "", "L");

                    PopulateTextBoxes(volumeUnitTextBoxes, UnitType.Volume, liters, "", "L");

                }
                catch { }
            }
            else
            {
                Convert(volumeUnitTextBoxes, UnitType.Volume);
            }


        }

        // Mass
        private void massTextBox_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_tonnesPrefixOutput.Focused)
            {
                checkBox_negativeTonnePrefixes.Enabled = comboBox_tonnesPrefixOutput.SelectedItem.ToString() == "(auto)";
            }

            if (textBox_prefixMasstInput.Focused || comboBox_massPrefixInput.Focused || comboBox_massInputUnit.Focused)
            {
                try
                {
                    double value = double.Parse(textBox_prefixMasstInput.Text);
                    string prefix = comboBox_massPrefixInput.SelectedItem.ToString();
                    string unit = comboBox_massInputUnit.SelectedItem.ToString();
                    PopulateTextBoxes(massUnitTextBoxes, UnitType.Mass, value, prefix, unit);

                }
                catch { }
            }
            else if (textBox_poundsAndOunces.Focused)
            {
                double pounds = 0;
                double ounces = 0;
                try
                {
                    string[] poundsAndOunces = textBox_poundsAndOunces.Text.Split(':');
                    pounds = double.Parse(poundsAndOunces[0]);
                    if (poundsAndOunces.Length >= 2)
                    {
                        ounces = double.Parse(poundsAndOunces[1]);
                    }
                    double grams = Converter.ConvertMass(pounds, "", "lb", "", "g") + Converter.ConvertMass(ounces, "", "oz", "", "g");
                    PopulateTextBoxes(massUnitTextBoxes, UnitType.Mass, grams, "", "g");
                }
                catch { }
            }
            else if (textBox_stonePoundsAndOunces.Focused)
            {
                double stone = 0;
                double pounds = 0;
                double ounces = 0;
                try
                {
                    string[] stonePoundsAndOunces = textBox_stonePoundsAndOunces.Text.Split(':');
                    stone = double.Parse(stonePoundsAndOunces[0]);
                    if (stonePoundsAndOunces.Length >= 2)
                    {
                        pounds = double.Parse(stonePoundsAndOunces[1]);
                    }
                    if (stonePoundsAndOunces.Length >= 3)
                    {
                        ounces = double.Parse(stonePoundsAndOunces[2]);
                    }
                    double grams = Converter.ConvertMass(stone, "", "st", "", "g") +
                        Converter.ConvertMass(pounds, "", "lb", "", "g") + Converter.ConvertMass(ounces, "", "oz", "", "g");
                    PopulateTextBoxes(massUnitTextBoxes, UnitType.Mass, grams, "", "g");

                }
                catch { }
            }
            else if (textBox_waterVolumeInput.Focused || comboBox_waterVolumeInput.Focused)
            {
                double inputValue;
                try
                {
                    inputValue = double.Parse(textBox_waterVolumeInput.Text);
                }
                catch
                {
                    return;
                }
                string waterVolumeUnit = comboBox_waterVolumeInput.SelectedItem.ToString();
                string unit = FormHandler.volumeUnitsAndPrefixes[waterVolumeUnit][0];
                string prefix = FormHandler.volumeUnitsAndPrefixes[waterVolumeUnit][1];
                double grams = Converter.MassOfWaterVolume(inputValue, prefix, unit, "", "g");
                PopulateTextBoxes(massUnitTextBoxes, UnitType.Mass, grams, "", "g");
            }
            else
            {
                Convert(massUnitTextBoxes, UnitType.Mass);
            }
        }

        // Time
        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox_hoursMinutesSeconds.Focused)
            {
                try
                {
                    double totalSeconds = Parser.ParseHoursMinutesSecondsToSeconds(textBox_hoursMinutesSeconds.Text);
                    PopulateTextBoxes(timeUnitTextBoxes, UnitType.Time, totalSeconds, "", "s");

                }
                catch { }
            }
            else if (textBox_daysHoursMinutesSeconds.Focused)
            {
                double days = 0;
                double hours = 0;
                double minutes = 0;
                double seconds = 0;
                try
                {
                    string[] daysHoursMinutesAndSeconds = textBox_daysHoursMinutesSeconds.Text.Split(':');
                    days = double.Parse(daysHoursMinutesAndSeconds[0]);
                    if (daysHoursMinutesAndSeconds.Length >= 2)
                    {
                        hours = double.Parse(daysHoursMinutesAndSeconds[1]);
                    }
                    if (daysHoursMinutesAndSeconds.Length >= 3)
                    {
                        minutes = double.Parse(daysHoursMinutesAndSeconds[2]);
                    }
                    if (daysHoursMinutesAndSeconds.Length >= 4)
                    {
                        seconds = double.Parse(daysHoursMinutesAndSeconds[3]);
                    }
                    double totalSeconds = Converter.ConvertFromDaysHoursMinutesAndSeconds(days, hours, minutes, seconds, "", "s");
                    PopulateTextBoxes(timeUnitTextBoxes, UnitType.Time, totalSeconds, "", "s");

                }
                catch { }
            }
            else if (textBox_prefixSecondInput.Focused || comboBox_secondPrefixInput.Focused)
            {
                try
                {
                    double value = double.Parse(textBox_prefixSecondInput.Text);
                    string prefix = comboBox_secondPrefixInput.SelectedItem.ToString();
                    PopulateTextBoxes(timeUnitTextBoxes, UnitType.Time, value, prefix, "s");
                }
                catch { }
            }
            else
            {
                Convert(timeUnitTextBoxes, UnitType.Time);
            }
        }


        // Speed
        private void speedTextBox_TextChanged(object sender, EventArgs e)
        {
            double inputValue = 0;
            string inputDistancePrefix = "";
            string inputDistanceUnit = "";
            string inputTimePrefix = "";
            string inputTimeUnit = "";

            if (textBox_speedOfLight.Focused)
            {
                try
                {
                    inputValue = double.Parse(textBox_speedOfLight.Text);
                }
                catch
                {
                    return;
                }

                inputValue = Converter.ConvertSpeedOfLightToSpeed(inputValue, "", "m", "", "s");
                inputDistanceUnit = "m";
                inputTimeUnit = "s";
            }
            else if (textBox_distancePerTimeInput.Focused || comboBox_distanceInput.Focused || comboBox_perTimeInput.Focused)
            {
                try
                {
                    inputValue = double.Parse(textBox_distancePerTimeInput.Text);
                }
                catch
                {
                    return;
                }

                string inputPrefixAndDistance = comboBox_distanceInput.SelectedItem.ToString();
                inputDistanceUnit = FormHandler.lengthUnitsAndPrefixes[inputPrefixAndDistance][0];
                inputDistancePrefix = FormHandler.lengthUnitsAndPrefixes[inputPrefixAndDistance][1];

                string inputPrefixAndTime = comboBox_perTimeInput.SelectedItem.ToString();
                inputTimeUnit = FormHandler.timeUnitsAndPrefixes[inputPrefixAndTime][0];
                inputTimePrefix = FormHandler.timeUnitsAndPrefixes[inputPrefixAndTime][1];

            }
            else
            {
                for (int i = 0; i < speedUnitTextBoxes.Length; i++)
                {
                    if (speedUnitTextBoxes[i].TextBox.Focused)
                    {
                        try
                        {
                            inputValue = double.Parse(speedUnitTextBoxes[i].TextBox.Text);
                            inputDistancePrefix = speedUnitTextBoxes[i].DistancePrefix;
                            inputDistanceUnit = speedUnitTextBoxes[i].DistanceUnit;
                            inputTimePrefix = speedUnitTextBoxes[i].TimePrefix;
                            inputTimeUnit = speedUnitTextBoxes[i].TimeUnit;
                        }
                        catch
                        {
                            return;
                        }
                    }
                }
            }

            if (inputDistanceUnit == "" || inputTimeUnit == "")
            {
                try
                {
                    inputValue = double.Parse(textBox_metersPerSecond.Text);
                }
                catch
                {
                    return;
                }

                inputDistanceUnit = "m";
                inputTimeUnit = "s";
            }


            for (int i = 0; i < speedUnitTextBoxes.Length; i++)
            {
                if (!speedUnitTextBoxes[i].TextBox.Focused)
                {
                    double outputValue;

                    outputValue = Converter.ConvertSpeed(inputValue, inputDistancePrefix, inputDistanceUnit, inputTimePrefix, inputTimeUnit,
                        speedUnitTextBoxes[i].DistancePrefix, speedUnitTextBoxes[i].DistanceUnit,
                        speedUnitTextBoxes[i].TimePrefix, speedUnitTextBoxes[i].TimeUnit);

                    speedUnitTextBoxes[i].TextBox.Text = outputValue.ToString(Formatter.outputNumberFormat);
                }
            }

            if (!textBox_distancePerTimeInput.Focused && !comboBox_distanceInput.Focused && !comboBox_perTimeInput.Focused)
            {
                string outputDistancePrefixAndUnit = comboBox_distanceInput.SelectedItem.ToString();
                string outputTimePrefixAndUnit = comboBox_perTimeInput.SelectedItem.ToString();
                double outputValue = Converter.ConvertSpeed(inputValue, inputDistancePrefix, inputDistanceUnit, inputTimePrefix, inputTimeUnit,
                        FormHandler.lengthUnitsAndPrefixes[outputDistancePrefixAndUnit][1], FormHandler.lengthUnitsAndPrefixes[outputDistancePrefixAndUnit][0],
                        FormHandler.timeUnitsAndPrefixes[outputTimePrefixAndUnit][1], FormHandler.timeUnitsAndPrefixes[outputTimePrefixAndUnit][0]);
                textBox_distancePerTimeInput.Text = outputValue.ToString(Formatter.outputNumberFormat);
            }

            {
                string outputTimePrefixAndUnit = comboBox_perTimeOutput.SelectedItem.ToString();
                string outputTimeUnit = FormHandler.timeUnitsAndPrefixes[outputTimePrefixAndUnit][0];
                string outputTimePrefix = FormHandler.timeUnitsAndPrefixes[outputTimePrefixAndUnit][1];

                double value;
                string prefix;
                string unit;

                // Distance per time
                if (comboBox_distanceOutput.SelectedItem.ToString().StartsWith("(auto)"))
                {
                    if (comboBox_distanceOutput.SelectedItem.ToString().EndsWith("metric"))
                    {
                        double metersPerTime = Converter.ConvertSpeed(inputValue, inputDistancePrefix, inputDistanceUnit,
                            inputTimePrefix, inputTimeUnit, "", "m", outputTimePrefix, outputTimeUnit);

                        Tuple<double, string> valueAndPrefix = Converter.AutoPrefix(metersPerTime);
                        value = valueAndPrefix.Item1;
                        prefix = valueAndPrefix.Item2;
                        unit = "m";
                    }
                    else
                    {
                        double metersPerTime = Converter.ConvertSpeed(inputValue, inputDistancePrefix, inputDistanceUnit,
                            inputTimePrefix, inputTimeUnit, "", "m", outputTimePrefix, outputTimeUnit);

                        Tuple<double, string> outputValueAndUnit = Converter.AutoImperialFromMeters(metersPerTime);
                        value = outputValueAndUnit.Item1;
                        prefix = "";
                        unit = outputValueAndUnit.Item2;
                    }
                }
                else
                {
                    string outputDistancePrefixAndUnit = comboBox_distanceOutput.SelectedItem.ToString();
                    unit = FormHandler.lengthUnitsAndPrefixes[outputDistancePrefixAndUnit][0];
                    prefix = FormHandler.lengthUnitsAndPrefixes[outputDistancePrefixAndUnit][1];
                    value = Converter.ConvertSpeed(inputValue, inputDistancePrefix, inputDistanceUnit, inputTimePrefix, inputTimeUnit,
                        prefix, unit, outputTimePrefix, outputTimeUnit);
                }

                textBox_distancePerTimeOutput.Text = value.ToString(Formatter.outputNumberFormat);
                label_distancePerTimeOutput.Text = prefix + unit + "/";

                // Distance per second
                if (comboBox_distanceOutput.SelectedItem.ToString().StartsWith("(auto)"))
                {
                    if (comboBox_distanceOutput.SelectedItem.ToString().EndsWith("metric"))
                    {
                        double metersPerSecond = Converter.ConvertSpeed(inputValue, inputDistancePrefix, inputDistanceUnit,
                            inputTimePrefix, inputTimeUnit, "", "m", "", "s");

                        Tuple<double, string> valueAndPrefix = Converter.AutoPrefix(metersPerSecond);
                        value = valueAndPrefix.Item1;
                        prefix = valueAndPrefix.Item2;
                        unit = "m";
                    }
                    else
                    {
                        double metersPerSecond = Converter.ConvertSpeed(inputValue, inputDistancePrefix, inputDistanceUnit,
                            inputTimePrefix, inputTimeUnit, "", "m", "", "s");

                        Tuple<double, string> outputValueAndUnit = Converter.AutoImperialFromMeters(metersPerSecond);
                        value = outputValueAndUnit.Item1;
                        prefix = "";
                        unit = outputValueAndUnit.Item2;
                    }
                }
                else
                {
                    string outputDistancePrefixAndUnit = comboBox_distanceOutput.SelectedItem.ToString();
                    unit = FormHandler.lengthUnitsAndPrefixes[outputDistancePrefixAndUnit][0];
                    prefix = FormHandler.lengthUnitsAndPrefixes[outputDistancePrefixAndUnit][1];
                    value = Converter.ConvertSpeed(inputValue, inputDistancePrefix, inputDistanceUnit, inputTimePrefix, inputTimeUnit,
                        prefix, unit, "", "s");
                }

                textBox_distancePerSecondOutput.Text = value.ToString(Formatter.outputNumberFormat);
                label_distancePerSecondOutput.Text = prefix + unit + "/s";

            }

            if (!textBox_speedOfLight.Focused)
            {
                textBox_speedOfLight.Text =
                    Converter.ConvertSpeedToSpeedOfLight(inputValue, inputDistancePrefix, inputDistanceUnit, inputTimePrefix, inputTimeUnit)
                    .ToString(Formatter.outputNumberFormat);
            }

        }


        // Temerature
        private void tempratureTextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox_prefixKelvinInput.Focused || comboBox_kelvinPrefixInput.Focused)
            {
                try
                {
                    double value = double.Parse(textBox_prefixKelvinInput.Text);
                    string prefix = comboBox_kelvinPrefixInput.SelectedItem.ToString();
                    PopulateTextBoxes(temperatureUnitTextBoxes, UnitType.Temperature, value, prefix, "K");
                }
                catch { }
            }
            else
            {
                Convert(temperatureUnitTextBoxes, UnitType.Temperature);
            }
        }

        private void button_energy_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void button_lengthByLengthByLength_Click(object sender, EventArgs e)
        {
            groupBox_lengthByLengthByLength.Visible = !groupBox_lengthByLengthByLength.Visible;
            textBox_lengthByLengthByLengthX.Focus();
        }

        private void checkBox_allUnits_CheckedChanged(object sender, EventArgs e)
        {
            PopulateComboboxes();
        }

        private void PopulateComboboxes()
        {
            foreach (ComboBox comboBox in lengthComboboxInputs)
            {
                FormHandler.PopulateLengthUnitCombobox(comboBox, checkBox_allUnits.Checked);
            }

            foreach (ComboBox comboBox in lengthComboboxOutputs)
            {
                FormHandler.PopulateLengthUnitCombobox(comboBox, checkBox_allUnits.Checked, true);
            }

            foreach (ComboBox comboBox in timeComboboxInputs)
            {
                FormHandler.PopulateTimeUnitCombobox(comboBox, checkBox_allUnits.Checked);
            }

            foreach (ComboBox comboBox in timeComboboxOutputs)
            {
                FormHandler.PopulateTimeUnitCombobox(comboBox, checkBox_allUnits.Checked, true);
            }

            foreach (ComboBox comboBox in volumeComboboxInputs)
            {
                FormHandler.PopulateVolumeUnitCombobox(comboBox, checkBox_allUnits.Checked);
            }

            foreach (ComboBox comboBox in volumeComboboxOutputs)
            {
                FormHandler.PopulateVolumeUnitCombobox(comboBox, checkBox_allUnits.Checked, true);
            }
        }

        public bool AllUnits
        {
            get
            {
                return checkBox_allUnits.Checked;
            }

            set
            {
                checkBox_allUnits.Checked = value;
            }
        }

        private void checkBox_linkLengthXYZUnits_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_linkLengthXYZUnits.Checked)
            {
                comboBox_lengthByLengthByLengthY.SelectedItem = comboBox_lengthByLengthByLengthX.SelectedItem;
                comboBox_lengthByLengthByLengthZ.SelectedItem = comboBox_lengthByLengthByLengthX.SelectedItem;
            }
        }

        private void LengthXYZUnitChanged(object sender, EventArgs e)
        {
            if (checkBox_linkLengthXYZUnits.Checked)
            {
                foreach(ComboBox comboBox in lengthXYZComboBoxes)
                {
                    if (!comboBox.Focused)
                    {
                        comboBox.SelectedItem = ((ComboBox)sender).SelectedItem;
                    }
                }
            }

            volumeTextBox_TextChanged(sender, e);
        }

        private void linkLabel_changeVolumeLengthFunction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VolumeLengthFunctionForm functionForm = new VolumeLengthFunctionForm(volumeLengthFunction);
            functionForm.ShowDialog();
        }
    }
}
