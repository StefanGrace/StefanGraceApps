using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateListGenerator
{
    public partial class DateFormatForm : Form
    {
        private DateFormat format;
        private DateFormat newFormat;

        public DateFormatForm(DateFormat format)
        {
            this.format = format;
            newFormat = new DateFormat(format);
            InitializeComponent();
        }

        private void DateFormatForm_Load(object sender, EventArgs e)
        {
            comboBox_dateOrder.SelectedIndex = format.DateOrder;
            comboBox_yearFormat.SelectedIndex = format.YearFormat;
            comboBox_monthFormat.SelectedIndex = format.MonthFormat;
            comboBox_dayFormat.SelectedIndex = format.DayFormat;
            switch (format.DateSep)
            {
                case "/": comboBox_separator.SelectedIndex = 0; break;
                case ".": comboBox_separator.SelectedIndex = 1; break;
                case "-": comboBox_separator.SelectedIndex = 2; break;
                case " ": comboBox_separator.SelectedIndex = 3; break;
            }
            comboBox_weekday.SelectedIndex = format.Weekday;
            comboBox_weekdayFormat.SelectedIndex = format.WeekdayFormat;
            switch (format.WeekdaySep)
            {
                case " ": comboBox_weekdaySep.SelectedIndex = 0; break;
                case ", ": comboBox_weekdaySep.SelectedIndex = 1; break;
                case "-": comboBox_weekdaySep.SelectedIndex = 2; break;
                case "_": comboBox_weekdaySep.SelectedIndex = 3; break;
            }
            checkBox_commaAfterDay.Checked = format.CommaAfterDay;
        }

        

        private void EnableCommaCheckBox()
        {
            checkBox_commaAfterDay.Enabled = comboBox_dateOrder.SelectedIndex == 2 &&
                (comboBox_monthFormat.SelectedIndex == 2 || comboBox_monthFormat.SelectedIndex == 3) &&
                comboBox_separator.SelectedIndex == 3;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            format.SetFormat(newFormat);
            Close();
        }

        private void UpdateSample()
        {
            label_sample.Text = "Sample: " + newFormat.FormatDate(DateTime.Now);
        }

        private void comboBox_dateOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableCommaCheckBox();
            newFormat.DateOrder = comboBox_dateOrder.SelectedIndex;
            UpdateSample();
        }

        private void comboBox_yearFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            newFormat.YearFormat = comboBox_yearFormat.SelectedIndex;
            UpdateSample();
        }

        private void comboBox_dayFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            newFormat.DayFormat = comboBox_dayFormat.SelectedIndex;
            UpdateSample();
        }

        private void comboBox_monthFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            newFormat.MonthFormat = comboBox_monthFormat.SelectedIndex;
            EnableCommaCheckBox();
            UpdateSample();
        }

        private void comboBox_separator_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_separator.SelectedIndex)
            {
                case 0: newFormat.DateSep = "/"; break;
                case 1: newFormat.DateSep = "."; break;
                case 2: newFormat.DateSep = "-"; break;
                case 3: newFormat.DateSep = " "; break;
            }
            EnableCommaCheckBox();
            UpdateSample();
        }

        private void comboBox_weekday_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool weekday = comboBox_weekday.SelectedIndex != 0;
            label_weekdayFormat.Enabled = weekday;
            label_weekdaySep.Enabled = weekday;
            comboBox_weekdayFormat.Enabled = weekday;
            comboBox_weekdaySep.Enabled = weekday;
            newFormat.Weekday = comboBox_weekday.SelectedIndex;
            UpdateSample();
        }

        private void comboBox_weekdayFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            newFormat.WeekdayFormat = comboBox_weekdayFormat.SelectedIndex;
            UpdateSample();
        }

        private void comboBox_weekdaySep_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_weekdaySep.SelectedIndex)
            {
                case 0: newFormat.WeekdaySep = " "; break;
                case 1: newFormat.WeekdaySep = ", "; break;
                case 2: newFormat.WeekdaySep = "-"; break;
                case 3: newFormat.WeekdaySep = "_"; break;
            }
            UpdateSample();
        }

        private void checkBox_commaAfterDay_CheckedChanged(object sender, EventArgs e)
        {
            newFormat.CommaAfterDay = checkBox_commaAfterDay.Checked;
            UpdateSample();
        }
    }
}
