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
    public partial class Form2 : Form
    {
        private UnitTextBox[] energyUnitTextBoxes;
        private UnitTextBox[] areaUnitTextBoxes;
        private DataUnitType[] dataUnitTypes;
        private UnitTextBox[] angleUnitTextBoxes;

        private ComboBox[] lengthComboboxInputs;
        private ComboBox[] lengthComboboxOutputs;
        private ComboBox[] timeComboboxInputs;
        private ComboBox[] timeComboboxOutputs;

        private Form1 form1;
        private bool formLoaded = false;

        public Form2(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            energyUnitTextBoxes = new UnitTextBox[]
            {
                new UnitTextBox(textBox_joules, "J"),
                new UnitTextBox(textBox_killojoules, "J", "k"),
                new UnitTextBox(textBox_megajoules, "J", "M"),
                new UnitTextBox(textBox_watthours, "Wh"),
                new UnitTextBox(textBox_killowatthours, "Wh", "k"),
                new UnitTextBox(textBox_calories, "cal"),
                new UnitTextBox(textBox_killocalories, "cal", "k"),
                new UnitTextBox(textBox_britishThermalUnits, "BTU"),
                new UnitTextBox(textBox_electronVolts, "eV"),
                new UnitTextBox(textBox_planckEnergy, "planck energy")
            };

            areaUnitTextBoxes = new UnitTextBox[]
            {
                new UnitTextBox(textBox_squareInches, "in"),
                new UnitTextBox(textBox_squareFeet, "ft"),
                new UnitTextBox(textBox_squareYards, "yd"),
                new UnitTextBox(textBox_squareMiles, "mi"),
                new UnitTextBox(textBox_squareMillimeters, "m", "m"),
                new UnitTextBox(textBox_squareCentimeters, "m", "c"),
                new UnitTextBox(textBox_squareMeters, "m"),
                new UnitTextBox(textBox_hectares, "m", "h"),
                new UnitTextBox(textBox_squareKillometers, "m", "k"),
            };

            dataUnitTypes = new DataUnitType[]
            {
                new DataUnitType(textBox_bitsDecInput, textBox_bitsDecOutput, comboBox_bitsDecInput, comboBox_bitsDecOutput, label_bitsDecOutput, "b"),
                new DataUnitType(textBox_bitsBinInput, textBox_bitsBinOutput, comboBox_bitsBinInput, comboBox_bitsBinOutput, label_bitsBinOutput, "b"),
                new DataUnitType(textBox_bytesDecInput, textBox_bytesDecOutput, comboBox_bytesDecInput, comboBox_bytesDecOutput, label_bytesDecOutput, "B"),
                new DataUnitType(textBox_bytesBinInput, textBox_bytesBinOutput, comboBox_bytesBinInput, comboBox_bytesBinOutput, label_bytesBinOutput, "B"),
            };

            angleUnitTextBoxes = new UnitTextBox[]
            {
                new UnitTextBox(textBox_degrees, "deg"),
                new UnitTextBox(textBox_radians, "rad"),
                new UnitTextBox(textBox_gradians, "grad"),
                new UnitTextBox(textBox_turns, "turn"),
                new UnitTextBox(textBox_arcminutes, "arcmin"),
                new UnitTextBox(textBox_arcseconds, "arcsec"),
                new UnitTextBox(textBox_milliradians, "rad", "m"),
                new UnitTextBox(textBox_milligradians, "grad", "m"),
                new UnitTextBox(textBox_mturn, "turn", "m"),
            };

            lengthComboboxInputs = new ComboBox[]
            {
                comboBox_lengthOfSidesOfSquareInput,
                comboBox_lengthByLengthX,
                comboBox_lengthByLengthY,
            };

            lengthComboboxOutputs = new ComboBox[]
            {
                comboBox_lengthOfSidesOfSquareOutput,
            };

            timeComboboxInputs = new ComboBox[]
            {
                comboBox_wattTimeInput,
                comboBox_wattTimeOutput,
            };

            comboBox_energyPrefixInput.SelectedItem = "k";
            comboBox_energyInputUnit.SelectedItem = "J";
            comboBox_wattPrefixInput.SelectedItem = "k";
            comboBox_wattTimeInput.SelectedItem = "h";
            comboBox_energyPrefixOutput.SelectedItem = "(auto)";
            comboBox_energyOutputUnit.SelectedItem = "J";
            comboBox_watthoursPrefixOutput.SelectedItem = "(auto)";
            comboBox_wattTimeOutput.SelectedItem = "h";
            comboBox_ampHourInputPrefix.SelectedItem = "m";
            comboBox_ampHoursPrefixOutput.SelectedItem = "(auto)";
            comboBox_massInputUnit.SelectedItem = "µg";
            comboBox_massOutputUnit.SelectedItem = "(auto) metric";
            comboBox_squareMetersPrefixInput.SelectedItem = "da";
            comboBox_squareMetersPrefixOutput.SelectedItem = "(auto)";
            comboBox_lengthByLengthX.SelectedItem = "m";
            comboBox_lengthByLengthY.SelectedItem = "m";
            comboBox_lengthOfSidesOfSquareInput.SelectedItem = "m";
            comboBox_lengthOfSidesOfSquareOutput.SelectedItem = "(auto) metric";
            comboBox_bitsDecInput.SelectedItem = "M";
            comboBox_bitsDecOutput.SelectedItem = "(auto) dec";
            comboBox_bitsBinInput.SelectedItem = "Mi";
            comboBox_bitsBinOutput.SelectedItem = "(auto) bin";
            comboBox_bytesDecInput.SelectedItem = "M";
            comboBox_bytesDecOutput.SelectedItem = "(auto) dec";
            comboBox_bytesBinInput.SelectedItem = "Mi";
            comboBox_bytesBinOutput.SelectedItem = "(auto) bin";

            label_energyOuputPrefix.Text = "";
            label_bitsDecOutput.Text = "";
            label_bitsBinOutput.Text = "";
            label_bytesDecOutput.Text = "";
            label_bytesBinOutput.Text = "";
            label_angleOutputPrefix.Text = "";

            checkBox_allUnits.Checked = form1.AllUnits;
            formLoaded = true;
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
                    case UnitType.Area:
                        try
                        {
                            inputValue = double.Parse(textBox_squareMeters.Text);
                            inputUnit = "m";
                        }
                        catch
                        {
                            return;
                        }
                        break;

                    case UnitType.Energy:
                        try
                        {
                            inputValue = double.Parse(textBox_joules.Text);
                            inputUnit = "J";
                        }
                        catch
                        {
                            return;
                        }
                        break;

                    case UnitType.Angle:
                        try
                        {
                            inputValue = double.Parse(textBox_turns.Text);
                            inputUnit = "turn";
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

        private void PopulateTextBoxes(UnitTextBox[] unitTextBoxes, UnitType unitType, double inputValue, string inputPrefix, string inputUnit)
        {
            // General text boxes
            FormHandler.PopulateTextBoxes(unitTextBoxes, unitType, inputValue, inputPrefix, inputUnit);

            // Speical unit text boxes
            switch (unitType)
            {
                case UnitType.Energy:

                    // Prefix energy input
                    if (!textBox_prefixEnergyInput.Focused && !comboBox_energyInputUnit.Focused && !comboBox_energyPrefixInput.Focused)
                    {
                        string prefix = comboBox_energyPrefixInput.SelectedItem.ToString();
                        string unit = comboBox_energyInputUnit.SelectedItem.ToString();

                        textBox_prefixEnergyInput.Text =
                            Converter.ConvertEnergy(inputValue, inputPrefix, inputUnit, prefix, unit).ToString(Formatter.outputNumberFormat);
                    }

                    // Prefix energy output
                    {
                        double value;
                        string prefix;
                        if (comboBox_energyPrefixOutput.SelectedItem.ToString() == "(auto)")
                        {

                        }
                        else
                        {

                        }
                    }

                    break;

                case UnitType.Area:

                    // Acres
                    if (!textBox_acres.Focused)
                    {
                        textBox_acres.Text = 
                           Converter.ConvertSquareLengthToArea(inputValue, inputPrefix, inputUnit, "", "acre").ToString(Formatter.outputNumberFormat);
                    }

                    // Square prefix meters input
                    if (!textBox_squarePrefixMetersInput.Focused && !comboBox_squareMetersPrefixInput.Focused)
                    {
                        textBox_squarePrefixMetersInput.Text = Converter.ConvertSquareLength(inputValue, inputPrefix, inputUnit, 
                            comboBox_squareMetersPrefixInput.SelectedItem.ToString(), "m").ToString(Formatter.outputNumberFormat);
                    }

                    // Square prefix meters output
                    {
                        double value;
                        string prefix;
                        if (comboBox_squareMetersPrefixOutput.SelectedItem.ToString() == "(auto)")
                        {
                            Tuple<double, string> valueAndPrefix =
                                Converter.ConvertSquareLengthToSquarePrefixMeters(inputValue, inputPrefix, inputUnit,
                                checkBox_cm2.Checked, checkBox_dm2.Checked, checkBox_dam2.Checked, checkBox_hm2.Checked);

                            value = valueAndPrefix.Item1;
                            prefix = valueAndPrefix.Item2;
                        }
                        else
                        {
                            prefix = comboBox_squareMetersPrefixOutput.SelectedItem.ToString();
                            value = Converter.ConvertSquareLength(inputValue, inputPrefix, inputUnit, prefix, "m");
                        }
                        textBox_squarePrefixMetersOutput.Text = value.ToString(Formatter.outputNumberFormat);
                        label_squarePrefixMetersOutput.Text = prefix + "m";
                    }

                    // Length of sides of square input
                    if (!textBox_lengthOfSidesOfSquareInput.Focused && !comboBox_lengthOfSidesOfSquareInput.Focused)
                    {
                        string prefixAndUnit = comboBox_lengthOfSidesOfSquareInput.SelectedItem.ToString();
                        string prefix = FormHandler.lengthUnitsAndPrefixes[prefixAndUnit][1];
                        string unit = FormHandler.lengthUnitsAndPrefixes[prefixAndUnit][0];
                        textBox_lengthOfSidesOfSquareInput.Text =
                            Converter.ConvertSquareLengthToSideLengthOfSquare(inputValue, inputPrefix, inputUnit, prefix, unit)
                            .ToString(Formatter.outputNumberFormat);
                    }

                    // Length of sides of square output
                    {
                        double value;
                        string prefix;
                        string unit;
                        double meters = Converter.ConvertSquareLengthToSideLengthOfSquare(inputValue, inputPrefix, inputUnit, "", "m");
                        if (comboBox_lengthOfSidesOfSquareOutput.SelectedItem.ToString().StartsWith("(auto)"))
                        {
                            
                            if (comboBox_lengthOfSidesOfSquareOutput.SelectedItem.ToString().EndsWith("imperial"))
                            {
                                Tuple<double, string> valueAndUnit = Converter.AutoImperialFromMeters(meters);
                                value = valueAndUnit.Item1;
                                prefix = "";
                                unit = valueAndUnit.Item2;
                            }
                            else
                            {
                                Tuple<double, string> valueAndPrefix = 
                                    Converter.AutoPrefix(meters, checkBox_cm.Checked, checkBox_dm.Checked, checkBox_dam.Checked, checkBox_hm.Checked);
                                value = valueAndPrefix.Item1;
                                prefix = valueAndPrefix.Item2;
                                unit = "m";
                            }
                        }
                        else
                        {
                            string prefixAndUnit = comboBox_lengthOfSidesOfSquareOutput.SelectedItem.ToString();
                            prefix = FormHandler.lengthUnitsAndPrefixes[prefixAndUnit][1];
                            unit = FormHandler.lengthUnitsAndPrefixes[prefixAndUnit][0];
                            value = Converter.ConvertLength(meters, "", "m", prefix, unit);
                        }
                        textBox_lengthOfSidesOfSquareOutput.Text = value.ToString(Formatter.outputNumberFormat);
                        label_lengthOfSidesOfSquareOutputUnit.Text = prefix + unit;
                    }

                    break;

                case UnitType.Angle:
                    
                    // Degrees, arcminutes, arcseconds
                    if (!textBox_degreesArcminutesArcseconds.Focused)
                    {
                        textBox_degreesArcminutesArcseconds.Text =
                            Formatter.FormatToDegreesArcminutesArcseconds(inputValue, inputPrefix, inputUnit);
                    }

                    break;
            }
        }

        // Energy
        private void energyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox_prefixEnergyInput.Focused || comboBox_energyPrefixInput.Focused || comboBox_energyInputUnit.Focused)
            {
                try
                {
                    double value = double.Parse(textBox_prefixEnergyInput.Text);
                    string prefix = comboBox_energyPrefixInput.SelectedItem.ToString();
                    string unit = comboBox_energyInputUnit.SelectedItem.ToString();
                    PopulateTextBoxes(energyUnitTextBoxes, UnitType.Energy, value, prefix, unit);
                }
                catch { }
            }
            else if (textBox_prefixWattTimeInput.Focused || comboBox_wattPrefixInput.Focused || comboBox_wattTimeInput.Focused)
            {
                try
                {
                    double watts = double.Parse(textBox_prefixWattTimeInput.Text);
                    string wattPrefix = comboBox_wattPrefixInput.SelectedItem.ToString();
                    string timeUnit = comboBox_wattTimeInput.SelectedItem.ToString();
                    double joules = Converter.ConvertWattTimeToEnergy(watts, wattPrefix, timeUnit, "", "J");
                    PopulateTextBoxes(energyUnitTextBoxes, UnitType.Energy, joules, "", "J");
                }
                catch { }
            }
            else
            {
                Convert(energyUnitTextBoxes, UnitType.Energy);
            }
        }

        // Area
        private void areaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox_acres.Focused)
            {
                try
                {
                    double squareMeters = Converter.ConvertAreaToSquareLength(double.Parse(textBox_acres.Text), "", "acre", "", "m");
                    PopulateTextBoxes(areaUnitTextBoxes, UnitType.Area, squareMeters, "", "m");
                }
                catch { }
            }
            else if (textBox_squarePrefixMetersInput.Focused || comboBox_squareMetersPrefixInput.Focused)
            {
                try
                {
                    double value = double.Parse(textBox_squarePrefixMetersInput.Text);
                    string prefix = comboBox_squareMetersPrefixInput.SelectedItem.ToString();
                    PopulateTextBoxes(areaUnitTextBoxes, UnitType.Area, value, prefix, "m");
                }
                catch { }
            }
            else if (textBox_lengthOfSidesOfSquareInput.Focused || comboBox_lengthOfSidesOfSquareInput.Focused)
            {
                try
                {
                    double value = double.Parse(textBox_lengthOfSidesOfSquareInput.Text);
                    string prefixAndUnit = comboBox_lengthOfSidesOfSquareInput.SelectedItem.ToString();
                    string prefix = FormHandler.lengthUnitsAndPrefixes[prefixAndUnit][1];
                    string unit = FormHandler.lengthUnitsAndPrefixes[prefixAndUnit][0];
                    double squareMeters = Converter.ConvertSideLengthOfSqueareToSquareMeters(value, prefix, unit);
                    PopulateTextBoxes(areaUnitTextBoxes, UnitType.Area, squareMeters, "", "m");
                }
                catch { }
            }
            else if (textBox_lengthByLengthX.Focused || comboBox_lengthByLengthX.Focused || 
                     textBox_lengthByLengthY.Focused || comboBox_lengthByLengthY.Focused)
            {
                try
                {
                    double lengthX = double.Parse(textBox_lengthByLengthX.Text);
                    double lengthY = double.Parse(textBox_lengthByLengthY.Text);

                    string xPrefixAndUnit = comboBox_lengthByLengthX.SelectedItem.ToString();
                    string xPrefix = FormHandler.lengthUnitsAndPrefixes[xPrefixAndUnit][1];
                    string xUnit = FormHandler.lengthUnitsAndPrefixes[xPrefixAndUnit][0];

                    string yPrefixAndUnit = comboBox_lengthByLengthY.SelectedItem.ToString();
                    string yPrefix = FormHandler.lengthUnitsAndPrefixes[yPrefixAndUnit][1];
                    string yUnit = FormHandler.lengthUnitsAndPrefixes[yPrefixAndUnit][0];

                    double squareMeters = Converter.ConvertLengthXYToSquareMeters(lengthX, xPrefix, xUnit, lengthY, yPrefix, yUnit);
                    PopulateTextBoxes(areaUnitTextBoxes, UnitType.Area, squareMeters, "", "m");

                }
                catch { }
            }
            else
            {
                Convert(areaUnitTextBoxes, UnitType.Area);
            }
        }

        // Data
        private void dataTextBox_TextChanged(object sender, EventArgs e)
        {
            double inputValue = 0;
            string inputPrefix = "";
            string inputUnit = "";
            foreach (DataUnitType dataUnitType in dataUnitTypes)
            {
                if (dataUnitType.InputTextBox.Focused || dataUnitType.InputPrefixComboBox.Focused)
                {
                    try
                    {
                        inputValue = double.Parse(dataUnitType.InputTextBox.Text);
                        inputPrefix = dataUnitType.InputPrefixComboBox.SelectedItem.ToString();
                        inputUnit = dataUnitType.Unit;
                    }
                    catch { }

                    break;
                }
            }

            if (inputUnit == "")
            {
                return;
            }

            foreach (DataUnitType dataUnitType in dataUnitTypes)
            {
                if (!dataUnitType.InputTextBox.Focused && !dataUnitType.InputPrefixComboBox.Focused)
                {
                    string outputPrefix = dataUnitType.InputPrefixComboBox.SelectedItem.ToString();
                    dataUnitType.InputTextBox.Text =
                        Converter.ConvertData(inputValue, inputPrefix, inputUnit, outputPrefix, dataUnitType.Unit).ToString(Formatter.outputNumberFormat);
                }

                if (dataUnitType.OutputPrefixComboBox.SelectedItem.ToString().StartsWith("(auto)"))
                {
                    double bitsOrBytes = Converter.ConvertData(inputValue, inputPrefix, inputUnit, "", dataUnitType.Unit);

                    Tuple<double, string> valueAndPrefix;

                    if (dataUnitType.OutputPrefixComboBox.SelectedItem.ToString().EndsWith("bin"))
                    {
                        valueAndPrefix = Converter.AutoBinaryPrefix(bitsOrBytes);
                    }
                    else
                    {
                        valueAndPrefix = Converter.AutoNonNegativePrefix(bitsOrBytes);
                    }

                    dataUnitType.OutputTextBox.Text = valueAndPrefix.Item1.ToString(Formatter.outputNumberFormat);
                    dataUnitType.OutputLabel.Text = valueAndPrefix.Item2 + dataUnitType.Unit;
                }
                else
                {
                    string outputPrefix = dataUnitType.OutputPrefixComboBox.SelectedItem.ToString();
                    dataUnitType.OutputTextBox.Text =
                        Converter.ConvertData(inputValue, inputPrefix, inputUnit, outputPrefix, dataUnitType.Unit).ToString(Formatter.outputNumberFormat);
                }

            }

        }

        // Angle
        private void angleTextBox_TextChanged(object sender, EventArgs e)
        {
            Convert(angleUnitTextBoxes, UnitType.Angle);
        }

        private void checkBox_allUnits_CheckedChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                form1.AllUnits = checkBox_allUnits.Checked;
            }
        }
    }
}
