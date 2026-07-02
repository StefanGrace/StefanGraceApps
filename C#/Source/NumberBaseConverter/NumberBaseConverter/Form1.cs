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

namespace NumberBaseConverter
{
    public partial class Form1 : Form
    {
        private static readonly Dictionary<string, char> seperators = new Dictionary<string, char>()
        {
            {"Space", ' ' },
            {"Comma", ',' },
            {"Apostrophe", '\'' },
            {"Underscore", '_' },
        };

        private DigitSeperation outputDigitSeperation = new DigitSeperation(false, true, true, ' ', 3);
        private bool formLoaded = false;

        public Form1()
        {
            InitializeComponent();
            PopulateKeys();
            comboBox_seperatorChar.SelectedItem = "Space";
            LoadSettings();
        }

        private void InputUpdated(object sender, EventArgs e)
        {
            if (textBox_input.Text == "")
            {
                textBox_output.Text = "";
                return;
            }

            try
            {
                textBox_output.Text =
                    BaseConverter.ConvertBase(
                        textBox_input.Text, 
                        (int)numericUpDown_inputBase.Value, 
                        (int)numericUpDown_outputBase.Value, 
                        outputDigitSeperation);
            }
            catch (OverflowException)
            {
                textBox_output.Text = "Value is too high to convert";
            }
            catch (FormatException)
            {
                textBox_output.Text = "Input is not formatted correctly for the chosen input base";
            }
        }

        private void PopulateKeys()
        {
            label_keyNumbers.Text = string.Join("\n", BaseConverter.GetKeys(0, 10));
            label_keyUppercase.Text = string.Join("\n", BaseConverter.GetKeys(10, 26));
            label_keyLowercase.Text = string.Join("\n", BaseConverter.GetKeys(36, 26));
            label_keySymbols.Text = string.Join("\n", BaseConverter.GetKeys(62, 2));
        }

        private void BaseUpdated(object sender, EventArgs e)
        {
            InputUpdated(sender, e);
            SaveSettings();
        }

        private void DigitSeperationUpdated(object sender, EventArgs e)
        {
            bool digitSeperation = checkBox_digitSeperators.Checked;
            checkBox_integerSeperators.Enabled = digitSeperation;
            checkBox_fractionalSeperators.Enabled = digitSeperation;
            comboBox_seperatorChar.Enabled = digitSeperation;
            label_every.Enabled = digitSeperation;
            numericUpDown_seperatorDigits.Enabled = digitSeperation;
            label_digits.Enabled = digitSeperation;

            outputDigitSeperation = new DigitSeperation(
                digitSeperation,
                checkBox_integerSeperators.Checked,
                checkBox_fractionalSeperators.Checked,
                seperators[comboBox_seperatorChar.SelectedItem.ToString()],
                (int)numericUpDown_seperatorDigits.Value);

            InputUpdated(sender, e);
            SaveSettings();
        }

        private void SaveSettings()
        {
            if (!formLoaded)
            {
                return;
            }

            string[] outputLines = new string[7];

            outputLines[0] = numericUpDown_inputBase.Value.ToString();
            outputLines[1] = numericUpDown_outputBase.Value.ToString();
            outputLines[2] = checkBox_digitSeperators.Checked.ToString();
            outputLines[3] = checkBox_integerSeperators.Checked.ToString();
            outputLines[4] = checkBox_fractionalSeperators.Checked.ToString();
            outputLines[5] = comboBox_seperatorChar.SelectedItem.ToString();
            outputLines[6] = numericUpDown_seperatorDigits.Value.ToString();

            try
            {
                Directory.CreateDirectory("AppData");
                File.WriteAllLines(@"AppData\NumberBaseConverter_settings.txt", outputLines);
            }
            catch { }
        }

        private void LoadSettings()
        {
            formLoaded = true;

            try
            {
                string[] inputLines = File.ReadAllLines(@"AppData\NumberBaseConverter_settings.txt");

                numericUpDown_inputBase.Value = int.Parse(inputLines[0]);
                numericUpDown_outputBase.Value = int.Parse(inputLines[1]);
                checkBox_digitSeperators.Checked = bool.Parse(inputLines[2]);
                checkBox_integerSeperators.Checked = bool.Parse(inputLines[3]);
                checkBox_fractionalSeperators.Checked = bool.Parse(inputLines[4]);
                if (comboBox_seperatorChar.Items.Contains(inputLines[5]))
                {
                    comboBox_seperatorChar.SelectedItem = inputLines[5];
                }
                numericUpDown_seperatorDigits.Value = int.Parse(inputLines[6]);
            }
            catch { }
        }

    }
}
