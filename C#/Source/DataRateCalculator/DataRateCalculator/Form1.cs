using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataRateCalculator
{
    public partial class Form1 : Form
    {
        float outputFontSizeBig;
        float outputFontSizeSmall;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outputFontSizeBig = outputLabel.Font.Size;
            outputFontSizeSmall = 10f;

            inputUnitComboBox.SelectedIndex = 8; // MB
            inputTimeComboBox.SelectedIndex = 1; // s

            outputMagnitudeComboBox.SelectedIndex = 0; // Auto
            outputPrefixTypeComboBox.SelectedIndex = 0; // dec
            outputUnitComboBox.SelectedIndex = 0; // b
            outputTimeComboBox.SelectedIndex = 1; // s

            autoUpdateCheckBox.Checked = true;

            outputLabel.Text = "";
        }

        private void UpdateOutput()
        {
            if (inputTextBox.Text == "")
            {
                throw new ArgumentException("Please enter an input data value.");
            }

            double inputDataValue;

            try
            {
                inputDataValue = double.Parse(inputTextBox.Text);
            }
            catch
            {
                throw new ArgumentException("Input data value must be a number.");
            }

            string inputDataUnit = inputUnitComboBox.SelectedItem.ToString();

            if (inputTimeTextBox.Text == "")
            {
                if (autoUpdateCheckBox.Checked)
                {
                    throw new ArgumentException("Please enter an input time value.");
                }
                else
                {
                    inputTimeTextBox.Text = "1";
                }
            }

            double inputTime;

            try
            {
                inputTime = double.Parse(inputTimeTextBox.Text);
            }
            catch
            {
                throw new ArgumentException("Input time must be a number.");
            }

            if (inputTime == 0)
            {
                throw new ArgumentException("Input time cannot be zero.");
            }

            string inputTimeUnit = inputTimeComboBox.SelectedItem.ToString();

            string outputMagnitune = outputMagnitudeComboBox.SelectedItem.ToString();
            string ouputPrefixType = outputPrefixTypeComboBox.SelectedItem.ToString();
            string outputUnit = outputUnitComboBox.SelectedItem.ToString();
            string outputTimeUnit = outputTimeComboBox.SelectedItem.ToString();

            if (outputTimeTextBox.Text == "")
            {
                if (autoUpdateCheckBox.Checked)
                {
                    throw new ArgumentException("Please enter an output time value.");
                }
                else
                {
                    outputTimeTextBox.Text = "1";
                }
            }

            double outputTime;

            try
            {
                outputTime = double.Parse(outputTimeTextBox.Text);
            }
            catch
            {
                throw new ArgumentException("Output time must be a number.");
            }

            if (outputTime == 0)
            {
                throw new ArgumentException("Output time cannot be zero.");
            }


            Tuple<double, string> output = DataRateCalc.CalculateDataRate(inputDataValue, inputDataUnit, inputTime, inputTimeUnit,
                outputMagnitune, ouputPrefixType, outputUnit, outputTime, outputTimeUnit);

            double outputValue = output.Item1;
            string outputUnitText = output.Item2;

            string numberFormat = "#,0." + new string('#', (int)MaxDecPlacesNumericUpDown.Value);
            outputLabel.Text = outputValue.ToString(numberFormat) + " " + outputUnitText;

            // Make the output font smaller if it's too big to fit in the window
            float fontSize = outputLabel.Text.Length > 36 ? outputFontSizeSmall : outputFontSizeBig;
            outputLabel.Font = new Font(outputLabel.Font.FontFamily, fontSize, outputLabel.Font.Style);
                
        }

        private void AutoUpdate()
        {
            if (autoUpdateCheckBox.Checked)
            {
                try
                {
                    UpdateOutput();
                }
                catch { }
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateOutput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void autoUpdateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            calculateButton.Enabled = !autoUpdateCheckBox.Checked;
            AutoUpdate();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            AutoUpdate();
        }

        private void inputUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoUpdate();
        }

        private void inputTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            AutoUpdate();
        }

        private void inputTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoUpdate();
        }

        private void outputMagnitudeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoUpdate();
        }

        private void outputPrefixTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoUpdate();
        }

        private void outputUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoUpdate();
        }

        private void outputTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoUpdate();
        }

        private void MaxDecPlacesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            AutoUpdate();
        }

        private void outputTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            AutoUpdate();
        }
    }
}
