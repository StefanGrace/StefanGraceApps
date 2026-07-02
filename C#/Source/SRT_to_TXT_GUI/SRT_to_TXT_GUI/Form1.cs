using System;
using System.Windows.Forms;
using System.IO;

namespace SRT_to_TXT_GUI
{
    public partial class Form1 : Form
    {
        string inputFile;
        string outputFile;

        public Form1(string inputFile, string outputFile)
        {
            InitializeComponent();
            this.inputFile = inputFile;
            this.outputFile = outputFile;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_input.Text = inputFile;
            textBox_output.Text = outputFile;
        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            string inputFile = textBox_input.Text.Replace("\"", "");
            if (inputFile == "")
            {
                MessageBox.Show("Please enter a path for the input SRT file.");
                return;
            }

            string outputFile = textBox_output.Text.Replace("\"", "");
            if (outputFile == "")
            {
                MessageBox.Show("Please enter a path for the output TXT file.");
                return;
            }

            string[] inputLines = File.ReadAllLines(inputFile);

            string[] outputLines;
            if (checkBox_singleLine.Checked)
            {
                outputLines = new string[] { Converter.CreateTXT_SingleLine(inputLines) };
            }
            else
            {
                outputLines = Converter.CreateTXT(inputLines, checkBox_gapBetweenSubs.Checked, checkBox_joinLines.Checked);
            }

            File.WriteAllLines(outputFile, outputLines);
        }

        private void checkBox_singleLine_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_gapBetweenSubs.Enabled = !checkBox_singleLine.Checked;
            checkBox_joinLines.Enabled = !checkBox_singleLine.Checked;
        }
    }
}
