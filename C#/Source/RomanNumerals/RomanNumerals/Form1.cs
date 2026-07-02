using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanNumerals
{
    public partial class Form1 : Form
    {
        ValueToNumerals valueToNumerals = new ValueToNumerals();
        NumeralsToValue numeralsToValue = new NumeralsToValue();

        HelpForm help = new HelpForm();

        public Form1()
        {
            InitializeComponent();
            label_error.Text = "";
        }

        private void textBox_decimal_TextChanged(object sender, EventArgs e)
        {
            if (textBox_decimal.Focused)
            {
                if (textBox_decimal.Text == "")
                {
                    textBox_romanNumerals.Clear();
                    label_error.Text = "";
                    return;
                }

                try
                {
                    textBox_romanNumerals.Text = valueToNumerals.NumeralFromValue(double.Parse(textBox_decimal.Text));
                    label_error.Text = "";
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    textBox_romanNumerals.Clear();
                    label_error.Text = ex.Message;

                }
                catch (FormatException)
                {
                    textBox_romanNumerals.Clear();
                    label_error.Text = "Input decimal value is not formatted correcty.";
                }
            }
        }

        private void textBox_romanNumerals_TextChanged(object sender, EventArgs e)
        {
            if (textBox_romanNumerals.Focused || button_middleDot.Focused)
            {
                try
                {
                    textBox_decimal.Text = numeralsToValue.ValueFromNumerals(textBox_romanNumerals.Text).ToString();
                    label_error.Text = "";
                }
                catch (FormatException ex)
                {
                    textBox_decimal.Clear();
                    label_error.Text = ex.Message;
                }
            }
        }

        private void button_middleDot_Click(object sender, EventArgs e)
        {
            textBox_romanNumerals.Text += "·";
        }

        private void radioButton_lowercase_CheckedChanged(object sender, EventArgs e)
        {
            valueToNumerals.Lowercase = radioButton_lowercase.Checked;
            ChangeTextBoxCase();
            if (!checkBox_convertInputCase.Checked)
            {
                if (radioButton_lowercase.Checked)
                {
                    textBox_romanNumerals.Text = textBox_romanNumerals.Text.ToLower();
                }
                else
                {
                    textBox_romanNumerals.Text = textBox_romanNumerals.Text.ToUpper();
                }
            }
        }

        private void checkBox_convertInputCase_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextBoxCase();
        }

        private void ChangeTextBoxCase()
        {
            if (checkBox_convertInputCase.Checked)
            {
                if (radioButton_lowercase.Checked)
                {
                    textBox_romanNumerals.CharacterCasing = CharacterCasing.Lower;
                }
                else
                {
                    textBox_romanNumerals.CharacterCasing = CharacterCasing.Upper;
                }
            }
            else
            {
                textBox_romanNumerals.CharacterCasing = CharacterCasing.Normal;
            }
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            help.Show();
            help.Focus();
        }

        private void KeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button_help_Click(sender, e);
            }
        }
    }
}
