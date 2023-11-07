using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Pixel and Aspect to Dimensions
// Stefan Grace
// Created: 2020-08-13
// Modified: 2020-08-13

namespace PixelAndAspectToDimensions
{
    public partial class Form1 : Form
    {
        Converter converter = new Converter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            unitComboBox.SelectedIndex = 2; // set the default unit to megapixels
            dimensionsLabel.Text = "";
            
        }

        private void pixelsTextBox_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void ratioWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void ratioHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void AspectTextBox_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void ratioRadioButton_CheckedChanged(object sender, EventArgs e)
        { 
            update();
        }

        private void numberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        private void unitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            dimensionsLabel.Text = converter.convert(pixelsTextBox.Text, unitComboBox.Text, ratioRadioButton.Checked, 
                ratioWidthTextBox.Text, ratioHeightTextBox.Text, AspectTextBox.Text);
        }
    }

   class Converter
   {

        public string convert(string numberStr, string unit, bool ratio, string aspectWidthStr, string aspectHeightStr, string aspectStr)
        {
            try
            {
                double number = double.Parse(numberStr);
                double aspectWidth;
                double aspectHeight;
                double aspect;
                if (ratio)
                {
                    aspectWidth = double.Parse(aspectWidthStr);
                    aspectHeight = double.Parse(aspectHeightStr);
                    aspect = aspectWidth / aspectHeight;
                }
                else
                {
                    aspect = double.Parse(aspectStr);
                }
                int multiplier = 0;
                switch (unit)
                {
                    case "pixels":
                        multiplier = 1;
                        break;
                    case "kilopixels":
                        multiplier = 1000;
                        break;
                    case "megapixels":
                        multiplier = 1000000;
                        break;
                    case "gigapixels":
                        multiplier = 1000000000;
                        break;
                }
                double pixels = number * multiplier;
                double width = calculateWidth(pixels, aspect);
                double height = calculateHeight(pixels, aspect);
                int widthInt = Convert.ToInt32(Math.Round(width));
                int heightInt = Convert.ToInt32(Math.Round(height));
                double widthRound = Math.Round(width, 2);
                double heightRound = Math.Round(height, 2);
                if ((width % 1) + (height % 1) == 0) // if the both the dimensions are whole numbers
                {
                    return "Dimensions: " + widthInt + " x " + heightInt;
                }
                else
                {
                    return "Dimensions (rounded): " + widthInt + " x " + heightInt + 
                    "\n\nDimensions (decimal): " + widthRound + " x " + heightRound;
                        
                }
            }
            catch
            {
                return "";
            }  
        }

        private double calculateWidth(double pixels, double aspect)
        {
            return Math.Sqrt(pixels * aspect);
        }

        private double calculateHeight(double pixels, double aspect)
        {
            return Math.Sqrt(pixels / aspect);
        }
   }
}
