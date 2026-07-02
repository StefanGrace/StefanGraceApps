using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TimeCalculator
{
    public partial class Form1 : Form
    {
        private Function currentFunction = Function.AddDurations;
        private DataType input1Type = DataType.Duration;
        private DataType input2Type = DataType.None;
        private DataType previousInput1Type = DataType.Duration;
        private DataType previousInput2Type = DataType.None;

        private Formatter formatter = new Formatter();

        private string outputDurationFormat = "unit + subunits";
        private DateFormat outputDateFormat = DateFormat.SystemShort;

        private bool formLoaded = false;

        private static readonly Dictionary<DataType, string> dataTypeStrings = new Dictionary<DataType, string>()
        {
            { DataType.None, "" },
            { DataType.Number, "number" },
            { DataType.Duration, "duration" },
            { DataType.Date, "date" },
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_input1Type.Text = "Duration";
            label_input2Type.Text = "Duration";
            comboBox_outputDurationFormat.SelectedItem = outputDurationFormat;
            comboBox_outputDateFormat.SelectedItem = "System short";
            LoadSettings();
        }

        private void FunctionChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }

            if (radioButton_displayDuration.Checked)
            {
                currentFunction = Function.DisplayDuration;
                input1Type = DataType.Duration;
                input2Type = DataType.None;
            }
            else if (radioButton_addDurations.Checked)
            {
                currentFunction = Function.AddDurations;
                input1Type = DataType.Duration;
                input2Type = DataType.Duration;
            }
            else if (radioButton_differenceBetweenDurations.Checked)
            {
                currentFunction = Function.DifferenceBetweenDurations;
                input1Type = DataType.Duration;
                input2Type = DataType.Duration;
            }
            else if (radioButton_durationTimesNumber.Checked)
            {
                currentFunction = Function.DurationTimesNumber;
                input1Type = DataType.Duration;
                input2Type = DataType.Number;
            }
            else if (radioButton_durationDividedByNumber.Checked)
            {
                currentFunction = Function.DurationDividedByNumber;
                input1Type = DataType.Duration;
                input2Type = DataType.Number;
            }
            else if (radioButton_addDurationToDate.Checked)
            {
                currentFunction = Function.AddDurationToDate;
                input1Type = DataType.Date;
                input2Type = DataType.Duration;
            }
            else if (radioButton_subtractDurationFromDate.Checked)
            {
                currentFunction = Function.SubtractDurationFromDate;
                input1Type = DataType.Date;
                input2Type = DataType.Duration;
            }
            else if (radioButton_differenceBetweenDates.Checked)
            {
                currentFunction = Function.DifferenceBetweenDates;
                input1Type = DataType.Date;
                input2Type = DataType.Date;
            }
            else if (radioButton_addDurationToCurrentDate.Checked)
            {
                currentFunction = Function.AddDurationToCurrentDate;
                input1Type = DataType.Duration;
                input2Type = DataType.None;
            }
            else if (radioButton_subtractDurationFromCurrentDate.Checked)
            {
                currentFunction = Function.SubtractDurationFromCurrentDate;
                input1Type = DataType.Duration;
                input2Type = DataType.None;
            }
            else if (radioButton_differenceBetweenDateAndCurrentDate.Checked)
            {
                currentFunction = Function.DifferenceBetweenDateAndCurrentDate;
                input1Type = DataType.Date;
                input2Type = DataType.None;
            }

            label_input1Type.Text = dataTypeStrings[input1Type];
            label_input2Type.Text = dataTypeStrings[input2Type];

            textBox_input2.Enabled = input2Type != DataType.None;
            label_input2.Enabled = input2Type != DataType.None;

            timer1.Enabled =
                currentFunction == Function.AddDurationToCurrentDate ||
                currentFunction == Function.SubtractDurationFromCurrentDate ||
                currentFunction == Function.DifferenceBetweenDateAndCurrentDate;

            if (input1Type != previousInput1Type)
            {
                textBox_input1.Clear();
            }
            if (input2Type != previousInput2Type)
            {
                textBox_input2.Clear();
            }

            previousInput1Type = input1Type;
            previousInput2Type = input2Type;

            InputUpdated(sender, e);
            SaveSettings();
        }

        private void InputUpdated(object sender, EventArgs e)
        {
            if (textBox_input1.Text == "" || (textBox_input2.Text == "" && input2Type != DataType.None))
            {
                textBox_output.Text = "";
                return;
            }

            string output = "";

            try
            {
                switch (currentFunction)
                {
                    case Function.DisplayDuration:
                        {
                            TimeSpan duration = Parser.ParseDuration(textBox_input1.Text);
                            output = formatter.FormatDuration(duration, outputDurationFormat);
                            break;
                        }

                    case Function.AddDurations:
                        {
                            TimeSpan duration1 = Parser.ParseDuration(textBox_input1.Text);
                            TimeSpan duration2 = Parser.ParseDuration(textBox_input2.Text);
                            TimeSpan durationOutput = Calculator.AddDurations(duration1, duration2);
                            output = formatter.FormatDuration(durationOutput, outputDurationFormat);
                            break;
                        }

                    case Function.DifferenceBetweenDurations:
                        {
                            TimeSpan duration1 = Parser.ParseDuration(textBox_input1.Text);
                            TimeSpan duration2 = Parser.ParseDuration(textBox_input2.Text);
                            TimeSpan durationOutput = Calculator.DifferenceBetweenDurations(duration1, duration2);
                            output = formatter.FormatDuration(durationOutput, outputDurationFormat);
                            break;
                        }

                    case Function.DurationTimesNumber:
                        {
                            TimeSpan duration = Parser.ParseDuration(textBox_input1.Text);
                            double number = Parser.ParseNumber(textBox_input2.Text);
                            TimeSpan durationOutput = Calculator.DurationTimesNumber(duration, number);
                            output = formatter.FormatDuration(durationOutput, outputDurationFormat);
                            break;
                        }

                    case Function.DurationDividedByNumber:
                        {
                            TimeSpan duration = Parser.ParseDuration(textBox_input1.Text);
                            double number = Parser.ParseNumber(textBox_input2.Text);
                            TimeSpan durationOutput = Calculator.DurationDividedByNumber(duration, number);
                            output = formatter.FormatDuration(durationOutput, outputDurationFormat);
                            break;
                        }

                    case Function.AddDurationToDate:
                        {
                            DateTime date = Parser.ParseDateTime(textBox_input1.Text);
                            TimeSpan duration = Parser.ParseDuration(textBox_input2.Text);
                            DateTime dateTimeOutput = Calculator.AddDurationToDate(date, duration);
                            output = formatter.FormatDate(dateTimeOutput, outputDateFormat);
                            break;
                        }

                    case Function.SubtractDurationFromDate:
                        {
                            DateTime date = Parser.ParseDateTime(textBox_input1.Text);
                            TimeSpan duration = Parser.ParseDuration(textBox_input2.Text);
                            DateTime dateTimeOutput = Calculator.SubtractDurationFromDate(date, duration);
                            output = formatter.FormatDate(dateTimeOutput, outputDateFormat);
                            break;
                        }

                    case Function.DifferenceBetweenDates:
                        {
                            DateTime date1 = Parser.ParseDateTime(textBox_input1.Text);
                            DateTime date2 = Parser.ParseDateTime(textBox_input2.Text);
                            TimeSpan durationOutput = Calculator.DifferenceBetweenDates(date1, date2);
                            output = formatter.FormatDuration(durationOutput, outputDurationFormat);
                            break;
                        }

                    case Function.AddDurationToCurrentDate:
                        {
                            TimeSpan duration = Parser.ParseDuration(textBox_input1.Text);
                            DateTime dateTimeOutput = Calculator.AddDurationToCurrentDate(duration);
                            output = formatter.FormatDate(dateTimeOutput, outputDateFormat);
                            break;
                        }

                    case Function.SubtractDurationFromCurrentDate:
                        {
                            TimeSpan duration = Parser.ParseDuration(textBox_input1.Text);
                            DateTime dateTimeOutput = Calculator.SubtractDurationFromCurrentDate(duration);
                            output = formatter.FormatDate(dateTimeOutput, outputDateFormat);
                            break;
                        }

                    case Function.DifferenceBetweenDateAndCurrentDate:
                        {
                            DateTime date = Parser.ParseDateTime(textBox_input1.Text);
                            TimeSpan durationOutput = Calculator.DifferenceBetweenDateAndCurrentDate(date);
                            output = formatter.FormatDuration(durationOutput, outputDurationFormat);
                            break;
                        }
                }
            }
            catch (FormatException)
            {
                output = "Input is not formatted correctly.";
            }
            catch (OverflowException)
            {
                output = "Value is out of range.";
            }

            textBox_output.Text = output;
        }

        private void OutputFormatChanged(object sender, EventArgs e)
        {
            if (comboBox_outputDurationFormat.SelectedItem == null || comboBox_outputDateFormat.SelectedItem == null)
            {
                return;
            }

            outputDurationFormat = comboBox_outputDurationFormat.SelectedItem.ToString();
            formatter.OutputDurationYears = checkBox_years.Checked;
            checkBox_years.Enabled = outputDurationFormat == "unit + subunit" || outputDurationFormat == "unit + subunits";


            switch (comboBox_outputDateFormat.SelectedItem.ToString().ToLower())
            {
                case "system short":
                    outputDateFormat = DateFormat.SystemShort;
                    break;

                case "system long":
                    outputDateFormat = DateFormat.SystemLong;
                    break;

                case "iso 8601":
                    outputDateFormat = DateFormat.ISO8601;
                    break;
            }

            formatter.DecimalSecondDigits = (int)numericUpDown_secondDecimalPlaces.Value;

            InputUpdated(sender, e);

            if (formLoaded)
            {
                SaveSettings();
            }
        }

        private void SaveSettings()
        {
            try
            {
                string[] outputLines = new string[5];
                outputLines[0] = currentFunction.ToString();
                outputLines[1] = outputDurationFormat;
                outputLines[2] = checkBox_years.Checked.ToString();
                outputLines[3] = outputDateFormat.ToString();
                outputLines[4] = numericUpDown_secondDecimalPlaces.Value.ToString();
                Directory.CreateDirectory("AppData");
                File.WriteAllLines(@"AppData\TimeCalculator_settings.txt", outputLines);
            }
            catch { }
        }

        private void LoadSettings()
        {
            formLoaded = true;

            try
            {
                string[] inputLines = File.ReadAllLines(@"AppData\TimeCalculator_settings.txt");

                currentFunction = (Function)Enum.Parse(typeof(Function), inputLines[0]);
                switch (currentFunction)
                {
                    case Function.DisplayDuration:
                        radioButton_displayDuration.Checked = true;
                        break;

                    case Function.AddDurations:
                        radioButton_addDurations.Checked = true;
                        break;

                    case Function.DifferenceBetweenDurations:
                        radioButton_differenceBetweenDurations.Checked = true;
                        break;

                    case Function.DurationTimesNumber:
                        radioButton_differenceBetweenDurations.Checked = true;
                        break;

                    case Function.DurationDividedByNumber:
                        radioButton_durationDividedByNumber.Checked = true;
                        break;

                    case Function.AddDurationToDate:
                        radioButton_addDurationToDate.Checked = true;
                        break;

                    case Function.SubtractDurationFromDate:
                        radioButton_subtractDurationFromDate.Checked = true;
                        break;

                    case Function.DifferenceBetweenDates:
                        radioButton_differenceBetweenDates.Checked = true;
                        break;

                    case Function.AddDurationToCurrentDate:
                        radioButton_addDurationToCurrentDate.Checked = true;
                        break;

                    case Function.SubtractDurationFromCurrentDate:
                        radioButton_subtractDurationFromCurrentDate.Checked = true;
                        break;

                    case Function.DifferenceBetweenDateAndCurrentDate:
                        radioButton_differenceBetweenDateAndCurrentDate.Checked = true;
                        break;
                }

                if (comboBox_outputDurationFormat.Items.Contains(inputLines[1]))
                {
                    comboBox_outputDurationFormat.SelectedItem = inputLines[1];
                }

                checkBox_years.Checked = bool.Parse(inputLines[2]);

                outputDateFormat = (DateFormat)Enum.Parse(typeof(DateFormat), inputLines[3]);
                switch (outputDateFormat)
                {
                    case DateFormat.SystemShort:
                        comboBox_outputDateFormat.SelectedIndex = 0;
                        break;

                    case DateFormat.SystemLong:
                        comboBox_outputDateFormat.SelectedIndex = 1;
                        break;

                    case DateFormat.ISO8601:
                        comboBox_outputDateFormat.SelectedIndex = 2;
                        break;
                }

                numericUpDown_secondDecimalPlaces.Value = int.Parse(inputLines[4]);
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InputUpdated(sender, e);
        }
    }
}
