using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public static class FormHandler
    {
        public static readonly Dictionary<string, string[]> timeUnitsAndPrefixes = new Dictionary<string, string[]>
        {
            {"planck time", new string[] { "planck time", "" } },
            {"qs", new string[] {"s", "q" } },
            {"rs", new string[] {"s", "r" } },
            {"ys", new string[] {"s", "y" } },
            {"zs", new string[] {"s", "z" } },
            {"as", new string[] {"s", "a" } },
            {"fs", new string[] {"s", "f" } },
            {"ps", new string[] {"s", "p" } },
            {"ns", new string[] {"s", "n" } },
            {"µs", new string[] {"s", "µ" } },
            {"ms", new string[] {"s", "m" } },
            {"s", new string[] {"s", "" } },
            {"min", new string[] {"min", "" } },
            {"h", new string[] {"h", "" } },
            {"day", new string[] {"day", "" } },
            {"week", new string[] {"week", "" } },
            {"month", new string[] {"month", "" } },
            {"year", new string[] {"year", "" } },
            {"decade", new string[] {"decade", "" } },
            {"century", new string[] { "century", "" } },
            {"millennium", new string[] { "millennium", "" } },
        };

        public static readonly Dictionary<string, string[]> lengthUnitsAndPrefixes = new Dictionary<string, string[]>
        {
            {"in", new string[] {"in", "" } },
            {"ft", new string[] {"ft", "" } },
            {"yd", new string[] {"yd", "" } },
            {"mi", new string[] {"mi", "" } },
            {"qm", new string[] {"m", "q" } },
            {"rm", new string[] {"m", "r" } },
            {"ym", new string[] {"m", "y" } },
            {"zm", new string[] {"m", "z" } },
            {"am", new string[] {"m", "a" } },
            {"fm", new string[] {"m", "f" } },
            {"pm", new string[] {"m", "p" } },
            {"nm", new string[] {"m", "n" } },
            {"µm", new string[] {"m", "µ" } },
            {"mm", new string[] {"m", "m" } },
            {"cm", new string[] {"m", "c" } },
            {"dm", new string[] {"m", "d" } },
            {"m", new string[] {"m", "" } },
            {"dam", new string[] {"m", "da" } },
            {"hm", new string[] {"m", "h" } },
            {"km", new string[] {"m", "k" } },
            {"Mm", new string[] {"m", "M" } },
            {"Gm", new string[] {"m", "G" } },
            {"Tm", new string[] {"m", "T" } },
            {"Pm", new string[] {"m", "P" } },
            {"Em", new string[] {"m", "E" } },
            {"Zm", new string[] {"m", "Z" } },
            {"Ym", new string[] {"m", "Y" } },
            {"Rm", new string[] {"m", "R" } },
            {"Qm", new string[] {"m", "Q" } },
            {"NM", new string[] { "NM", "" } },
            {"AU", new string[] { "AU", "" } },
            {"pc", new string[] { "pc", "" } },
            {"planck length", new string[] { "planck length", "" } },
            {"thou", new string[] { "thou", "" } },
            {"barleycorn", new string[] { "barleycorn", "" } },
            {"hand", new string[] { "hand", "" } },
            {"chain", new string[] {"chain", "" } },
            {"furlong", new string[] {"furlong", "" } },
            {"league", new string[] { "league", "" } },
            {"fathom", new string[] { "fathom", "" } },
            {"cable", new string[] { "cable", "" } },
            {"link", new string[] { "link", "" } },
            {"rod", new string[] { "rod", "" } },
        };

        public static readonly Dictionary<string, string[]> volumeUnitsAndPrefixes = new Dictionary<string, string[]>
        {
            {"fl oz (US)", new string[] { "fl oz (US)", "" } },
            {"fl oz (UK)", new string[] { "fl oz (UK)", "" } },
            {"pt (US)", new string[] { "pt (US)", "" } },
            {"pt (UK)", new string[] { "pt (UK)", "" } },
            {"quart (US)", new string[] { "quart (US)", "" } },
            {"quart (UK)", new string[] { "quart (UK)", "" } },
            {"gal (US)", new string[] { "gal (US)", "" } },
            {"gal (UK)", new string[] { "gal (UK)", "" } },
            {"in³", new string[] { "in³", "" } },
            {"ft³", new string[] { "ft³", "" } },
            {"yd³", new string[] { "yd³", "" } },
            {"mi³", new string[] { "mi³", "" } },
            {"qm³", new string[] { "m³", "q" } },
            {"rm³", new string[] { "m³", "r" } },
            {"ym³", new string[] { "m³", "y" } },
            {"zm³", new string[] { "m³", "z" } },
            {"am³", new string[] { "m³", "a" } },
            {"fm³", new string[] { "m³", "f" } },
            {"pm³", new string[] { "m³", "p" } },
            {"qL", new string[] { "L", "q" } },
            {"rL", new string[] { "L", "r" } },
            {"yL (nm³)", new string[] { "L", "y" } },
            {"zL", new string[] { "L", "z" } },
            {"aL", new string[] { "L", "a" } },
            {"fL (µm³)", new string[] { "L", "f" } },
            {"pL", new string[] { "L", "p" } },
            {"nL", new string[] { "L", "n" } },
            {"µL (mm³)", new string[] { "L", "µ" } },
            {"mL (cm³)", new string[] { "L", "m" } },
            {"L (dm³)", new string[] { "L", "" } },
            {"kL (m³)", new string[] { "L", "k" } },
            {"ML (dam³)", new string[] { "L", "M" } },
            {"GL (hm³)", new string[] { "L", "G" } },
            {"TL (km³)", new string[] { "L", "T" } },
            {"PL", new string[] { "L", "P" } },
            {"EL", new string[] { "L", "E" } },
            {"ZL (Mm³)", new string[] { "L", "Z" } },
            {"YL", new string[] { "L", "Y" } },
            {"RL", new string[] { "L", "R" } },
            {"QL (Gm³)", new string[] { "L", "Q" } },
            {"Tm³", new string[] { "m³", "T" } },
            {"Pm³", new string[] { "m³", "P" } },
            {"Em³", new string[] { "m³", "E" } },
            {"Zm³", new string[] { "m³", "Z" } },
            {"Ym³", new string[] { "m³", "Y" } },
            {"Rm³", new string[] { "m³", "R" } },
            {"Qm³", new string[] { "m³", "Q" } },
            {"tsp (US)", new string[] { "tsp (US)", "" } },
            {"tsp (UK)", new string[] { "tsp (UK)", "" } },
            {"tsp (metric)", new string[] { "tsp (metric)", "" } },
            {"Tbsp (US)", new string[] { "Tbsp (US)", "" } },
            {"Tbsp (UK)", new string[] { "Tbsp (UK)", "" } },
            {"Tbsp (Australia)", new string[] { "Tbsp (Australia)", "" } },
            {"Tbsp (metric)", new string[] { "Tbsp (metric)", "" } },
            {"cup (US)", new string[] { "cup (US)", "" } },
            {"cup (US legal)", new string[] { "cup (US legal)", "" } },
            {"cup (UK)", new string[] { "cup (UK)", "" } },
            {"cup (metric)", new string[] { "cup (metric)", "" } },
            {"breakfast cup", new string[] { "breakfast cup", "" } },
            {"oil barrel", new string[] { "oil barrel", "" } },
            {"planck volume", new string[] { "planck volume", "" } },
        };

        public static void PopulateLengthUnitCombobox(ComboBox comboBox, bool allUnits = false, bool output = false)
        {
            string currentSelection = comboBox.SelectedItem.ToString();
            comboBox.Items.Clear();
            if (output)
            {
                comboBox.Items.AddRange(new string[] { "(auto) imperial", "(auto) metric" });
            }
            comboBox.Items.AddRange(GetLengthUnits(allUnits));
            if (comboBox.Items.Contains(currentSelection))
            {
                comboBox.SelectedItem = currentSelection;
            }
            else
            {
                comboBox.SelectedItem = "m";
            }
            if (allUnits)
            {
                comboBox.DropDownWidth = 90;
                comboBox.DropDownHeight = Screen.PrimaryScreen.WorkingArea.Height;
            }
            else
            {
                comboBox.DropDownWidth = comboBox.Size.Width;
            }
        }

        public static void PopulateTimeUnitCombobox(ComboBox comboBox, bool allUnits = false, bool output = false)
        {
            string currentSelection = comboBox.SelectedItem.ToString();
            comboBox.Items.Clear();
            if (output)
            {
                comboBox.Items.AddRange(new string[] { "(auto)" });
            }
            comboBox.Items.AddRange(GetTimeUnits(allUnits));
            if (comboBox.Items.Contains(currentSelection))
            {
                comboBox.SelectedItem = currentSelection;
            }
            else
            {
                comboBox.SelectedItem = "s";
            }
            if (allUnits)
            {
                comboBox.DropDownWidth = 70;
                comboBox.DropDownHeight = Screen.PrimaryScreen.WorkingArea.Height;
            }
            else
            {
                comboBox.DropDownWidth = comboBox.Size.Width;
            }
        }

        public static void PopulateVolumeUnitCombobox(ComboBox comboBox, bool allUnits = false, bool output = false)
        {
            string currentSelection = comboBox.SelectedItem.ToString();
            comboBox.Items.Clear();
            if (output)
            {
                comboBox.Items.AddRange(new string[] {
                    "(auto) imperial volume (US)", "(auto) imperial volume (UK)", "(auto) imperial cublic length", "(auto) metric"});
            }
            comboBox.Items.AddRange(GetVolumeUnits(allUnits));
            if (comboBox.Items.Contains(currentSelection))
            {
                comboBox.SelectedItem = currentSelection;
            }
            else
            {
                comboBox.SelectedItem = "L";
            }
            if (allUnits)
            {
                comboBox.DropDownWidth = 100;
                comboBox.DropDownHeight = Screen.PrimaryScreen.WorkingArea.Height;
            }
            else
            {
                comboBox.DropDownWidth = comboBox.Size.Width;
            }
        }

        private static string[] GetLengthUnits(bool allUnits = false)
        {
            string[] commonImperial = { "in", "ft", "yd", "mi" };
            string[] allImperial = { "thou", "barleycorn", "in", "ft", "hand", "yd", "chain", "furlong", "mi", "league" };
            string[] maritime = { "fathom", "cable", "NM" };
            string[] survery = { "link", "rod" };
            string[] commonMetric = { "nm", "µm", "mm", "cm", "dm", "m", "dam", "hm", "km", "Mm", "Gm" };
            string[] extendedMetricLow = { "qm", "rm", "ym", "zm", "am", "fm", "pm" };
            string[] extendedMetricHigh = { "Tm", "Pm", "Em", "Zm", "Ym", "Rm", "Qm" };
            string[] scientific = { "AU", "pc", "planck length" };

            if (allUnits)
            {
                return allImperial
                    .Concat(maritime)
                    .Concat(survery)
                    .Concat(extendedMetricLow)
                    .Concat(commonMetric)
                    .Concat(extendedMetricHigh)
                    .Concat(scientific).ToArray();
            }
            else
            {
                return commonImperial.Concat(commonMetric).ToArray();
            }
        }

        private static string[] GetTimeUnits(bool allUnits = false)
        {
            string[] scientific = { "planck time" };
            string[] subNanoseconds = { "qs", "rs", "ys", "zs", "as", "fs", "ps" };
            string[] common = { "ns", "µs", "ms", "s", "min", "h", "day", "week", "month", "year" };
            string[] multipleYears = {"decade", "century", "millennium"};

            if (allUnits)
            {
                return scientific
                    .Concat(subNanoseconds)
                    .Concat(common)
                    .Concat(multipleYears).ToArray();
            }
            else
            {
                return common;
            }
        }

        private static string[] GetVolumeUnits(bool allUnits = false)
        {
            string[] commonImperial = { "fl oz (US)", "fl oz (UK)", "pt (US)", "pt (UK)", "gal (US)", "gal (UK)" };
            string[] allImperial = { "fl oz (US)", "fl oz (UK)", "pt (US)", "pt (UK)", "quart (US)", "quart (UK)", "gal (US)", "gal (UK)" };
            string[] commonMetric = { "µL (mm³)", "mL (cm³)", "L (dm³)", "kL (m³)", "ML (dam³)", "GL (hm³)", "TL (km³)" };
            string[] extendedMetricLow = { "qm³", "rm³", "ym³", "zm³", "am³", "fm³", "pm³", "qL", "rL", "yL (nm³)", "zL", "aL", "fL (µm³)", "pL", "nL" };
            string[] extendedMetricHigh = { "PL", "EL", "ZL (Mm³)", "YL", "RL", "QL (Gm³)", "Tm³", "Pm³", "Em³", "Zm³", "Ym³", "Rm³", "Qm³" };
            string[] kitchen = { "tsp (US)", "tsp (UK)", "tsp (metric)", "Tbsp (US)", "Tbsp (UK)", "Tbsp (Australia)", "Tbsp (metric)",
                "cup (US)", "cup (US legal)", "cup (UK)", "cup (metric)", "breakfast cup" };
            string[] other = { "oil barrel" };
            string[] scientific = { "planck volume" };

            if (allUnits)
            {
                return allImperial
                    .Concat(extendedMetricLow)
                    .Concat(commonMetric)
                    .Concat(extendedMetricHigh)
                    .Concat(kitchen)
                    .Concat(other)
                    .Concat(scientific).ToArray();
            }
            else
            {
                return commonImperial.Concat(commonMetric).ToArray();
            }

        }


        public static Tuple<double, string, string> ReadInput(UnitTextBox[] unitTextBoxes)
        {
            double inputValue = 0;
            string inputPrefix = "";
            string inputUnit = "";

            for (int i = 0; i < unitTextBoxes.Length; i++)
            {
                if (unitTextBoxes[i].TextBox.Focused)
                {
                    inputValue = double.Parse(unitTextBoxes[i].TextBox.Text);
                    inputPrefix = unitTextBoxes[i].Prefix;
                    inputUnit = unitTextBoxes[i].Unit;
                }
            }

            return new Tuple<double, string, string>(inputValue, inputPrefix, inputUnit);
        }


        public static void PopulateTextBoxes(UnitTextBox[] unitTextBoxes, UnitType unitType, double inputValue, string inputPrefix, string inputUnit)
        {
            for (int i = 0; i < unitTextBoxes.Length; i++)
            {
                if (!unitTextBoxes[i].TextBox.Focused)
                {
                    double outputValue;

                    switch (unitType)
                    {
                        case UnitType.Length:
                            outputValue = Converter.ConvertLength(inputValue, inputPrefix, inputUnit, unitTextBoxes[i].Prefix, unitTextBoxes[i].Unit);
                            break;

                        case UnitType.Volume:
                            outputValue = Converter.ConvertVolume(inputValue, inputPrefix, inputUnit, unitTextBoxes[i].Prefix, unitTextBoxes[i].Unit);
                            break;

                        case UnitType.Mass:
                            outputValue = Converter.ConvertMass(inputValue, inputPrefix, inputUnit, unitTextBoxes[i].Prefix, unitTextBoxes[i].Unit);
                            break;

                        case UnitType.Time:
                            outputValue = Converter.ConvertTime(inputValue, inputPrefix, inputUnit, unitTextBoxes[i].Prefix, unitTextBoxes[i].Unit);
                            break;

                        case UnitType.Temperature:
                            outputValue = Converter.ConvertTemperature(inputValue, inputPrefix, inputUnit, unitTextBoxes[i].Prefix, unitTextBoxes[i].Unit);
                            break;

                        case UnitType.Energy:
                            outputValue = Converter.ConvertEnergy(inputValue, inputPrefix, inputUnit, unitTextBoxes[i].Prefix, unitTextBoxes[i].Unit);
                            break;

                        case UnitType.Area:
                            outputValue = Converter.ConvertSquareLength(inputValue, inputPrefix, inputUnit, unitTextBoxes[i].Prefix, unitTextBoxes[i].Unit);
                            break;

                        case UnitType.Angle:
                            outputValue = Converter.ConvertAngle(inputValue, inputPrefix, inputUnit, unitTextBoxes[i].Prefix, unitTextBoxes[i].Unit);
                            break;

                        default:
                            return;
                    }

                    unitTextBoxes[i].TextBox.Text = outputValue.ToString(Formatter.outputNumberFormat);
                }
            }
        }

    }
}
