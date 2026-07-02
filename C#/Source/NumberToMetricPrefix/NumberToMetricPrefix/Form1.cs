using System;
using System.Windows.Forms;

namespace NumberToMetricPrefix
{
    public partial class Form1 : Form
    {
        Formatter formatter = new Formatter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_max.SelectedIndex = 0;
        }

        private void textBox_inputNumber_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void textBox_inputUnitSymbol_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            if (textBox_inputNumber.Text == "")
            {
                textBox_output.Text = "";
            }
            else
            {
                try
                {
                    double inputValue = double.Parse(textBox_inputNumber.Text);
                    textBox_output.Text = formatter.FormatValue(inputValue, textBox_inputUnitSymbol.Text);
                }
                catch (FormatException)
                {
                    textBox_output.Text = "Invalid input";
                }
                catch (OverflowException)
                {
                    if (textBox_inputNumber.Text.StartsWith("-"))
                    {
                        textBox_output.Text = "Value too small";
                    }
                    else
                    {
                        textBox_output.Text = "Value too large";
                    }
                }
            } 
        }

        private void radioButton_decimal_CheckedChanged(object sender, EventArgs e)
        {
            formatter.Binary = radioButton_binary.Checked;
            label_nonThou.Enabled = radioButton_decimal.Checked;
            checkBox_c.Enabled = radioButton_decimal.Checked;
            checkBox_d.Enabled = radioButton_decimal.Checked;
            checkBox_da.Enabled = radioButton_decimal.Checked;
            checkBox_h.Enabled = radioButton_decimal.Checked;
            UpdateOutput();
        }

        private void checkBox_c_CheckedChanged(object sender, EventArgs e)
        {
            formatter.Use_c = checkBox_c.Checked;
            UpdateOutput();
        }

        private void checkBox_d_CheckedChanged(object sender, EventArgs e)
        {
            formatter.Use_d = checkBox_d.Checked;
            UpdateOutput();
        }

        private void checkBox_da_CheckedChanged(object sender, EventArgs e)
        {
            formatter.Use_da = checkBox_da.Checked;
            UpdateOutput();
        }

        private void checkBox_h_CheckedChanged(object sender, EventArgs e)
        {
            formatter.Use_h = checkBox_h.Checked;
            UpdateOutput();
        }

        private void numericUpDown_maxLimit_ValueChanged(object sender, EventArgs e)
        {
            formatter.MaxDigits = (int) numericUpDown_maxLimit.Value;
            UpdateOutput();
        }

        private void checkBox_limit_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_max.Enabled = checkBox_limit.Checked;
            numericUpDown_maxLimit.Enabled = checkBox_limit.Checked;
            formatter.LimitDigits = checkBox_limit.Checked;
            UpdateOutput();
        }

        private void comboBox_max_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the max to total digits
            if (comboBox_max.SelectedIndex == 0)
            {
                formatter.DecimalPlaces = false;
                numericUpDown_maxLimit.Minimum = 3;
                numericUpDown_maxLimit.Value = 3;
            }
            // Set the max to decimal places
            else
            {
                formatter.DecimalPlaces = true;
                numericUpDown_maxLimit.Minimum = 0;
                numericUpDown_maxLimit.Value = 2;
            }

            UpdateOutput();
        }

       
    }
}
