using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlickerSafeShutterCalculator
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator(2);

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_frameRate_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void textBox_flickerFrequency_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void radioButton_shutterSpeed_CheckedChanged(object sender, EventArgs e)
        {
            UpdateShutterFormat();
        }

        private void radioButton_shutterAngle_CheckedChanged(object sender, EventArgs e)
        {
            UpdateShutterFormat();
        }

        private void UpdateShutterFormat()
        {
            if (radioButton_shutterSpeed.Checked)
            {
                calc.ShutterUnit = 0;
            }
            else if (radioButton_shutterAngle.Checked)
            {
                calc.ShutterUnit = 1;
            }
            else
            {
                calc.ShutterUnit = 2;
            }
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            listBox_safeShutters.Items.Clear();

            try
            {
                double fps = double.Parse(textBox_frameRate.Text);
                double flickerFrequency = double.Parse(textBox_flickerFrequency.Text);
                listBox_safeShutters.Items.AddRange(calc.CalculateSafeShutters(fps, flickerFrequency));
            }
            catch { }
        }
    }
}
