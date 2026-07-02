using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassingSpeedCalculator
{
    public partial class Form1 : Form
    {
        string speedUnit;

        public Form1()
        {
            InitializeComponent();
            speedUnitComboBox.SelectedIndex = 0;
            sameDirPassSpeedLabel.Text = "";
            otherDirPassSpeedLabel.Text = "";
            dirRatioLabel.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Calculate();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Calculate()
        {
            double bicycleSpeed;
            try
            {
                bicycleSpeed = double.Parse(bicycleSpeedTextBox.Text);
            }
            catch
            {
                throw new ArgumentException("Bicycle speed must be a number.");
            }

            double carSpeed;
            try
            {
                carSpeed = double.Parse(carSpeedTextBox.Text);
            }
            catch
            {
                throw new ArgumentException("Car speed must be a number.");
            }

            double[] speeds = Calculator.CalculateSpeeds(bicycleSpeed, carSpeed);

            sameDirPassSpeedLabel.Text = speeds[0] + " " + speedUnit;
            otherDirPassSpeedLabel.Text = speeds[1] + " " + speedUnit;
            dirRatioLabel.Text = speeds[2].ToString();


        }

        private void AutoUpdate()
        {
            try
            {
                Calculate();
            }
            catch { }
        }

        private void bicycleSpeedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (autoUpdateCheckBox.Checked)
            {
                AutoUpdate();
            }
        }

        private void carSpeedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (autoUpdateCheckBox.Checked)
            {
                AutoUpdate();
            }
        }

        private void autoUpdateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            calculateButton.Enabled = !autoUpdateCheckBox.Checked;
            if (autoUpdateCheckBox.Checked)
            {
                AutoUpdate();
            }


        }

        private void speedUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (convertValuesCheckBox.Checked)
            {
                try
                {
                    double bicycleSpeed = double.Parse(bicycleSpeedTextBox.Text);
                    double newBicycleSpeed = Converter.ConvertSpeed(bicycleSpeed, speedUnit, speedUnitComboBox.SelectedItem.ToString());
                    bicycleSpeedTextBox.Text = newBicycleSpeed.ToString();
                }
                catch { }

                try
                {
                    double carSpeed = double.Parse(carSpeedTextBox.Text);
                    double newCarSpeed = Converter.ConvertSpeed(carSpeed, speedUnit, speedUnitComboBox.SelectedItem.ToString());
                    carSpeedTextBox.Text = newCarSpeed.ToString();
                }
                catch { }
            }
            speedUnit = speedUnitComboBox.SelectedItem.ToString();
            bicycleSpeedUnitLabel.Text = speedUnit;
            carSpeedUnitLabel.Text = speedUnit;
            if (autoUpdateCheckBox.Checked)
            {
                AutoUpdate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
