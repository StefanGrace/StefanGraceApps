using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutterAngleCalculator
{
    public partial class Form1 : Form
    {
        private Calculator calc = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_shutterAngleUnit.SelectedIndex = 0;
        }

        private void radioButton_shutterSpeed_CheckedChanged(object sender, EventArgs e)
        {
            textBox_shutterSpeed.ReadOnly = !radioButton_shutterSpeed.Checked;
        }

        private void radioButton_shutterAngle_CheckedChanged(object sender, EventArgs e)
        {
            textBox_shutterAngle.ReadOnly = !radioButton_shutterAngle.Checked;
        }

        private void textBox_frameRate_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            if (radioButton_shutterSpeed.Checked)
            {
                try
                {
                    double fps = double.Parse(textBox_frameRate.Text);
                    double shutter = double.Parse(textBox_shutterSpeed.Text);
                    textBox_shutterAngle.Text = calc.ShutterSpeedToAngle(fps, shutter).ToString("0.##");
                }
                catch
                {
                    textBox_shutterAngle.Clear();
                }
            }
            else
            {
                try
                {
                    double fps = double.Parse(textBox_frameRate.Text);
                    double angle = double.Parse(textBox_shutterAngle.Text);
                    textBox_shutterSpeed.Text = calc.ShutterAngleToSpeed(fps, angle).ToString("0.##");
                }
                catch
                {
                    textBox_shutterSpeed.Clear();
                }
            }
        }

        private void textBox_shutterSpeed_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void textBox_shutterAngle_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void comboBox_shutterAngleUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            double angleUnit = 360;

            switch (comboBox_shutterAngleUnit.SelectedItem.ToString())
            {
                case "°": angleUnit = 360; break;
                case "rad": angleUnit = Math.PI * 2; break;
                case "grad": angleUnit = 400; break;
                case "%": angleUnit = 100; break;
                case "dec": angleUnit = 1; break;
            }

            calc.AngleUnit = angleUnit;
            UpdateOutput();
        }
    }
}
