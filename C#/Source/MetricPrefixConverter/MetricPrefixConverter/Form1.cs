using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetricPrefixConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void outputText_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            double inputValue = 0.0;
            try
            {
                inputValue = double.Parse(inputTextBox.Text);
            }
            catch { }
            PrefixConverter prefixConverter = new PrefixConverter();
            outputText.Text = prefixConverter.convert(inputValue, inputPrefixes.Text, outputPrefixes.Text);
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void inputPrefixes_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void outputPrefixes_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }
    }

    class PrefixConverter
    {
        public string convert(double inputValue, string inputPrefix, string outputPrefix)
        {
            double outputValue = inputValue * Math.Pow(10, prefixToMagnitute(inputPrefix) - prefixToMagnitute(outputPrefix));
            string outputText = outputValue.ToString();
            return outputText;
        }

        private int prefixToMagnitute(string prefix)
        {
            int magnitute = 0;
            switch (prefix)
            {
                case "Y":
                    magnitute = 24;
                    break;
                case "Z":
                    magnitute = 21;
                    break;
                case "E":
                    magnitute = 18;
                    break;
                case "P":
                    magnitute = 15;
                    break;
                case "T":
                    magnitute = 12;
                    break;
                case "G":
                    magnitute = 9;
                    break;
                case "M":
                    magnitute = 6;
                    break;
                case "k":
                    magnitute = 3;
                    break;
                case "h":
                    magnitute = 2;
                    break;
                case "da":
                    magnitute = 1;
                    break;
                case "d":
                    magnitute = -1;
                    break;
                case "c":
                    magnitute = -2;
                    break;
                case "m":
                    magnitute = -3;
                    break;
                case "µ":
                    magnitute = -6;
                    break;
                case "n":
                    magnitute = -9;
                    break;
                case "p":
                    magnitute = -12;
                    break;
                case "f":
                    magnitute = -15;
                    break;
                case "a":
                    magnitute = -18;
                    break;
                case "z":
                    magnitute = -21;
                    break;
                case "y":
                    magnitute = -24;
                    break;

            }
            return magnitute;
        }
    }
}
