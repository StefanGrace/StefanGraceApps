using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreateMonthTimestampsFromSrtDates
{
    public partial class Form1 : Form
    {
        TimestampCreator tsc = new TimestampCreator();
        string inputFile;

        public Form1(string inputFile)
        {
            InitializeComponent();
            this.inputFile = inputFile;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_input.Text = inputFile;
        }

        private void button_create_Click(object sender, EventArgs e)
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

            string[] outputLines = tsc.CreateMonthTimestamps(inputLines);

            File.WriteAllLines(outputFile, outputLines);
        }
    }
}
