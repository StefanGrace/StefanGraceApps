using System;
using System.Windows.Forms;

namespace DateFormatter
{
    public partial class DefineOutputFormatForm : Form
    {
        private OutputFormat format;

        public DefineOutputFormatForm(OutputFormat format)
        {
            this.format = format;
            InitializeComponent();
        }

        private void DefineOutputFormatForm_Load(object sender, EventArgs e)
        {
            comboBox_dateOrder.SelectedIndex = format.DateOrder;
            comboBox_yearFormat.SelectedIndex = format.YearFormat;
            comboBox_monthFormat.SelectedIndex = format.MonthFormat;
            comboBox_dayFormat.SelectedIndex = format.DayFormat;
            comboBox_separator.SelectedIndex = format.SeparatorIndex;
            checkBox_commaAfterDay.Checked = format.CommaAfterDay;

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            bool formatSet = true;
            ComboBox[] comboBoxes = { comboBox_dateOrder, comboBox_yearFormat, comboBox_monthFormat, comboBox_dayFormat, comboBox_separator };
            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox.SelectedIndex == 0)
                {
                    formatSet = false;
                }
            }
            if (formatSet)
            {
                format.SetFormat(comboBox_dateOrder.SelectedIndex, comboBox_yearFormat.SelectedIndex, comboBox_monthFormat.SelectedIndex,
                   comboBox_dayFormat.SelectedIndex, comboBox_separator.SelectedIndex, checkBox_commaAfterDay.Checked);
                DialogResult saveFormat = MessageBox.Show("Would you like to save current output format to load next time program is opened?",
                    "Save output format to file?", MessageBoxButtons.YesNoCancel);
                if (saveFormat != DialogResult.Cancel)
                {
                    if (saveFormat == DialogResult.Yes)
                    {
                        MessageBox.Show(format.Save());
                    }
                    Close();
                }
                
            }
            else
            {
                MessageBox.Show("Please set all options before continuing", "Format Not Defined");
            }
        }

        private void EnableCommaCheckBox()
        {
            checkBox_commaAfterDay.Enabled = comboBox_dateOrder.SelectedIndex == 3 && 
                (comboBox_monthFormat.SelectedIndex == 3 || comboBox_monthFormat.SelectedIndex == 4) &&
                (comboBox_separator.SelectedIndex == 4 || comboBox_separator.SelectedIndex == 6);
        }

        private void comboBox_dateOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableCommaCheckBox();
        }

        private void comboBox_monthFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableCommaCheckBox();
        }

        private void comboBox_separator_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableCommaCheckBox();
        }
    }
}
