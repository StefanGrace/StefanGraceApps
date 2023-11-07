// Stefan Grace
// Created: 2020-01-27
// Modified: 2020-01-27

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelDensityCalculator
{
    public partial class pixelDensityCalculatorForm : Form
    {
        public pixelDensityCalculatorForm()
        {
            InitializeComponent();
        }

        private void pixelDensityCalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void screenSize_ValueChanged(object sender, EventArgs e)
        {
            update();
        }

        private void width_ValueChanged(object sender, EventArgs e)
        {
            update();
        }

        private void height_ValueChanged(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            float screenSize = (float)screenSizeInput.Value;
            float width = (float)widthInput.Value;
            float height = (float)heightInput.Value;

            if (screenSize > 0f && width > 0f && height > 0f)
            {
                ppiLabel.Text = new PixelDensity(screenSize, width, height).toString();
            }
            else
            {
                ppiLabel.Text = "";
            }
        }
    }

    class PixelDensity
    {
        private double ppi;

        public PixelDensity(float screenSize, float width, float height)
        {
            ppi = (Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2))) / screenSize;
        }

        public string toString()
        {
            return Math.Round(ppi, 2) + " PPI";
        }
    }

}
