using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourteenSegmentDisplay
{
    public partial class Form1 : Form
    {
        Display disp;
        string input;

        public Form1(string input)
        {
            InitializeComponent();
            this.input = input;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics canvas = pictureBox_display.CreateGraphics();
            disp = new Display(new CanvasHandler(canvas));
            textBox_input.Text = input;
            comboBox_displayColor.SelectedIndex = 2;
            comboBox_align.SelectedIndex = 0;
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            disp.Update(textBox_input.Text);
        }

        private void comboBox_displayColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_displayColor.SelectedItem.ToString().ToLower())
            {
                case "red":
                    disp.SetColor(
                        new SolidBrush(Color.FromArgb(96, 0, 0)),
                        new SolidBrush(Color.FromArgb(116, 0, 0)),
                        new SolidBrush(Color.FromArgb(255, 32, 0)));
                    break;

                case "orange":
                    disp.SetColor(
                        new SolidBrush(Color.FromArgb(96, 48, 0)),
                        new SolidBrush(Color.FromArgb(116, 48, 0)),
                        new SolidBrush(Color.FromArgb(255, 128, 0)));
                    break;

                case "green":
                    disp.SetColor(
                        new SolidBrush(Color.FromArgb(0, 64, 0)), 
                        new SolidBrush(Color.FromArgb(0, 78, 0)), 
                        new SolidBrush(Color.FromArgb(0, 255, 0)));
                    break;

                case "blue":
                    disp.SetColor(
                        new SolidBrush(Color.FromArgb(0, 24, 64)),
                        new SolidBrush(Color.FromArgb(0, 36, 96)),
                        new SolidBrush(Color.FromArgb(16, 116, 255)));
                    break;
            }
            UpdateDisplay();
        }

        private void comboBox_algin_SelectedIndexChanged(object sender, EventArgs e)
        {
            disp.Align = comboBox_align.SelectedItem.ToString().ToLower();
        }

        private void timer_startup_Tick(object sender, EventArgs e)
        {
            timer_startup.Stop();
            UpdateDisplay();
        }

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}
