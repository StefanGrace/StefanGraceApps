using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_shutterUnit.SelectedIndex = 0;
        }

        private void comboBox_shutterUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_shutterSpeed1.Clear();
            textBox_shutterSpeed2.Clear();

            switch (comboBox_shutterUnit.SelectedIndex)
            {
                case 0:
                case 1:
                    label_min.Visible = false;
                    textBox_shutterSpeed2.Visible = false;
                    label_sec.Visible = false;
                    break;

                case 2:
                    label_min.Visible = true;
                    textBox_shutterSpeed2.Visible = true;
                    label_sec.Visible = true;
                    break;
            }
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            // Aperture
            if (textBox_aperture.Text == "")
            {
                MessageBox.Show("Please enter the aperture f/number.", "Invalid input");
                return;
            }
            double fNumber;
            try
            {
                fNumber = double.Parse(textBox_aperture.Text);
            }
            catch
            {
                MessageBox.Show("Aperture f/number must be a number.", "Invalid input");
                return;
            }
            if (fNumber == 0)
            {
                MessageBox.Show("Aperture f/number cannot be zero.", "Invalid input");
                return;
            }
            if (fNumber < 0)
            {
                MessageBox.Show("Aperture f/number cannot be negative.", "Invalid input");
                return;
            }

            // Shutter speed
            double shutterSpeedSec;
            try
            {
                switch (comboBox_shutterUnit.SelectedIndex)
                {
                    case 0:
                        if (textBox_shutterSpeed1.Text == "")
                        {
                            MessageBox.Show("Please enter the shutter speed.", "Invalid input");
                            return;
                        }
                        shutterSpeedSec = 1 / double.Parse(textBox_shutterSpeed1.Text);
                        break;

                    case 1:
                        if (textBox_shutterSpeed1.Text == "")
                        {
                            MessageBox.Show("Please enter the shutter speed.", "Invalid input");
                            return;
                        }
                        shutterSpeedSec = double.Parse(textBox_shutterSpeed1.Text);
                        break;

                    case 2:
                        if (textBox_shutterSpeed1.Text == "")
                        {
                            textBox_shutterSpeed1.Text = "0";
                        }
                        if (textBox_shutterSpeed2.Text == "")
                        {
                            textBox_shutterSpeed2.Text = "0";
                        }
                        shutterSpeedSec = (double.Parse(textBox_shutterSpeed1.Text) * 60) + double.Parse(textBox_shutterSpeed2.Text);
                        break;

                    default:
                        throw new Exception();

                }
            }
            catch
            {
                MessageBox.Show("Shutter speed must be a number.", "Invalid input");
                return;
            }
            if (shutterSpeedSec == 0 || shutterSpeedSec == double.PositiveInfinity)
            {
                MessageBox.Show("Shutter speed cannot be zero.", "Invalid input");
                return;
            }
            if (shutterSpeedSec < 0)
            {
                MessageBox.Show("Shutter speed cannot be negative.", "Invalid input");
                return;
            }

            // ISO
            if (textBox_iso.Text == "")
            {
                MessageBox.Show("Please enter the ISO.", "Invalid input");
                return;
            }
            double iso;
            try
            {
                iso = double.Parse(textBox_iso.Text);
            }
            catch
            {
                MessageBox.Show("ISO must be a number.", "Invalid input");
                return;
            }
            if (iso == 0)
            {
                MessageBox.Show("ISO cannot be zero.", "Invalid input");
                return;
            }
            if (iso < 0)
            {
                MessageBox.Show("ISO cannot be negative.", "Invalid input");
                return;
            }

            // Calculate lux
            double lux = Calculator.CalculateLux(fNumber, shutterSpeedSec, iso);

            label_output.Text = "lux: " + lux.ToString("#,###,##0.####");
        }
    }
}
