// Form1.cs
// Stefan Grace
// Created: 2018-11-21
// Modified: 2018-11-21
// This program calculates the aspect ratio for a given resoluion

using System;
using System.Windows.Forms;

namespace AspectRatioCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            int width;
            int height;
            try
            {
                width = int.Parse(widthTextBox.Text);
            }
            catch
            {
                width = 0;
            }
            try
            {
                height = int.Parse(heightTextBox.Text);
            }
            catch
            {
                height = 0;
            }
            if (width > 0 && height > 0)
            {
                aspectRatioLabel.Text = new aspectRatio(width, height).toString();
            }
            else
            {
                aspectRatioLabel.Text = "";
            }
        }

        private void clearWidthButton_Click(object sender, EventArgs e)
        {
            clearWidth();
        }

        private void clearHeightButton_Click(object sender, EventArgs e)
        {
            clearHeight();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            clearWidth();
            clearHeight();
        }

        private void clearWidth()
        {
            widthTextBox.Text = "";
        }

        private void clearHeight()
        {
            heightTextBox.Text = "";
        }
    }

    class aspectRatio
    {
        private int x;
        private int y;
        
        public aspectRatio(int width, int height)
        {
            int i = 1;
            int newX = width;
            int newY = height;
            while (i < width && i < height)
            {
                if (isCleanDivison(width, i) && isCleanDivison(height, i))
                {
                    newX = width / i;
                    newY = height / i;
                }
                i++;
            }
            if (isEven(newX) && isEven(newY))
            {
                newX /= 2;
                newY /= 2;
            }
            x = newX;
            y = newY;
        }

        private bool isCleanDivison(int a, int b)
        {
            return Convert.ToDouble(a) / Convert.ToDouble(b) % 1 == 0;
        }

        private bool isEven(int a)
        {
            return a % 2 == 0;
        }

        public string toString()
        {
            return x + ":" + y;
        }
    }
}
