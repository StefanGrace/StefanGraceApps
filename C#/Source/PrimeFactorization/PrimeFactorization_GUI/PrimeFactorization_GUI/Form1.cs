using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeFactorization
{
    public partial class Form1 : Form
    {
        PrimeFactorizer pf = new PrimeFactorizer();
        uint number;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_factorize_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateOutput();
            }
            catch
            {
                MessageBox.Show("Number must be a positive integer.", "Invaid input!");
            }
        }

        private void checkBox_seperateLines_CheckedChanged(object sender, EventArgs e)
        {
            pf.SeperateLines = checkBox_seperateLines.Checked;
            RefreshOutput();
        }

        private void checkBox_expNotation_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_showExp1.Enabled = checkBox_expNotation.Checked;
            pf.ExpNotation = checkBox_expNotation.Checked;
            RefreshOutput();
        }
       
        private void checkBox_showExp1_CheckedChanged(object sender, EventArgs e)
        {
            pf.ShowExp1 = checkBox_showExp1.Checked;
            RefreshOutput();
        }

        private void RefreshOutput()
        {
            try
            {
                if (number > 1)
                {
                    textBox_output.Text = pf.GeneratePrimeFactorsString(number).Replace("\n", "\r\n");
                }
            }
            catch { }
        }

        private void UpdateOutput()
        {
            number = uint.Parse(textBox_input.Text);
            textBox_output.Text = pf.GeneratePrimeFactorsString(number).Replace("\n", "\r\n");
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {
            button_factorize.Enabled = textBox_input.Text.Length > 0;
            if (checkBox_autoUpdate.Checked)
            {
                try
                {
                    UpdateOutput();
                }
                catch
                {
                    textBox_output.Clear();
                }
            }
        }
    }
}
