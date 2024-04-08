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
    public partial class Form1 : Form
    {
        private DateFormat format = new DateFormat();
        private DateTime[] outputDates = new DateTime[0];
        private DateTime endDate;
        private DateTime startDate;

        public Form1()
        {
            endDate = DateTime.Now;
            startDate = endDate.AddYears(-100).AddDays(1);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_filterWeekday.SelectedIndex = 0;
            comboBox_filterMonth.SelectedIndex = 0;

            // Load date format
            try
            {
                string[] dateFormatLines = System.IO.File.ReadAllLines("DateListGenerator_OutputFormat.txt");

                format.SetFormat(int.Parse(dateFormatLines[0]),
                    int.Parse(dateFormatLines[1]),
                    int.Parse(dateFormatLines[2]),
                    int.Parse(dateFormatLines[3]),
                    dateFormatLines[4],
                    int.Parse(dateFormatLines[5]),
                    int.Parse(dateFormatLines[6]),
                    dateFormatLines[7],
                    bool.Parse(dateFormatLines[8]));
            }
            catch { }

            // Load settings
            try
            {
             
                string[] settingsLines = System.IO.File.ReadAllLines("DateListGenerator_Settings.txt");

                startDate = new DateTime(int.Parse(settingsLines[0]), int.Parse(settingsLines[1]), int.Parse(settingsLines[2]));
                endDate = new DateTime(int.Parse(settingsLines[3]), int.Parse(settingsLines[4]), int.Parse(settingsLines[5]));

                switch (int.Parse(settingsLines[6]))
                {
                    case 0: radioButton_generateSome.Checked = true; break;
                    case 1: radioButton_generateRandom.Checked = true; break;
                    case 2: radioButton_generateOrder.Checked = true; break;
                }

                numericUpDown_numDates.Value = int.Parse(settingsLines[7]);
                checkBox_duplicates.Checked = bool.Parse(settingsLines[8]);
                comboBox_filterWeekday.SelectedIndex = int.Parse(settingsLines[9]);
                comboBox_filterMonth.SelectedIndex = int.Parse(settingsLines[10]);
                numericUpDown_minDay.Value = int.Parse(settingsLines[11]);
                numericUpDown_maxDay.Value = int.Parse(settingsLines[12]);
            }
            catch { }

            textBox_startYear.Text = startDate.Year.ToString("0000");
            comboBox_startMonth.SelectedIndex = startDate.Month - 1;
            comboBox_startDay.Text = startDate.Day.ToString();

            textBox_endYear.Text = endDate.Year.ToString("0000");
            comboBox_endMonth.SelectedIndex = endDate.Month - 1;
            comboBox_endDay.Text = endDate.Day.ToString();
        }

        private void PopulateDaysList(TextBox yearTextBox, ComboBox monthComboBox, ComboBox DayComboBox)
        {
            DayComboBox.Items.Clear();
            try
            {
                for (int i = 1; i <= DateTime.DaysInMonth(int.Parse(yearTextBox.Text), monthComboBox.SelectedIndex + 1); i++)
                {
                    DayComboBox.Items.Add(i);
                }
            }
            catch { }
        }

        private void radioButton_generateSome_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_dates.Enabled = radioButton_generateSome.Checked;
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            // Star and end dates
            DateTime startDate;
            DateTime endDate;
            try
            {
                startDate = ParseDate(textBox_startYear, comboBox_startMonth, comboBox_startDay, "Start");
                endDate = ParseDate(textBox_endYear, comboBox_endMonth, comboBox_endDay, "End");
            }
            catch
            {
                return;
            }
            if (endDate.Ticks < startDate.Ticks)
            {
                MessageBox.Show("End date can't be before start date.", "Invalid Date Range");
                return;
            }

            // List to generate
            int listToGenerate = ParseListToGenerate();
            

            // Filters
            if (numericUpDown_maxDay.Value < numericUpDown_minDay.Value)
            {
                MessageBox.Show("The maximum day filter cannot be smaller than the minimum day filter.", "Invalid Day Filter");
                return;
            }
            DateFilter filter = new DateFilter();
            switch (comboBox_filterWeekday.SelectedItem.ToString().ToLower())
            {
                case "all": filter.Weekdays = new bool[] { true, true, true, true, true, true, true }; break;
                case "week": filter.Weekdays = new bool[] { true, true, true, true, true, false, false }; break;
                case "weekend": filter.Weekdays = new bool[] { false, false, false, false, false, true, true }; break;

                case "monday": filter.Weekdays = new bool[] { true, false, false, false, false, false, false }; break;
                case "tuesday": filter.Weekdays = new bool[] { false, true, false, false, false, false, false }; break;
                case "wednesday": filter.Weekdays = new bool[] { false, false, true, false, false, false, false }; break;
                case "thursday": filter.Weekdays = new bool[] { false, false, false, true, false, false, false }; break;
                case "friday": filter.Weekdays = new bool[] { false, false, false, false, true, false, false }; break;
                case "saturday": filter.Weekdays = new bool[] { false, false, false, false, false, true, false }; break;
                case "sunday": filter.Weekdays = new bool[] { false, false, false, false, false, false, true }; break;
            }
            switch (comboBox_filterMonth.SelectedItem.ToString().ToLower())
            {
                case "all": filter.Months = new bool[] { true, true, true, true, true, true, true, true, true, true, true, true }; break;

                case "q1": filter.Months = new bool[] { true, true, true, false, false, false, false, false, false, false, false, false }; break;
                case "q2": filter.Months = new bool[] { false, false, false, true, true, true, false, false, false, false, false, false }; break;
                case "q3": filter.Months = new bool[] { false, false, false, false, false, false, true, true, true, false, false, false }; break;
                case "q4": filter.Months = new bool[] { false, false, false, false, false, false, false, false, false, true, true, true }; break;

                case "january": filter.Months = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false }; break;
                case "february": filter.Months = new bool[] { false, true, false, false, false, false, false, false, false, false, false, false }; break;
                case "march": filter.Months = new bool[] { false, false, true, false, false, false, false, false, false, false, false, false }; break;
                case "april": filter.Months = new bool[] { false, false, false, true, false, false, false, false, false, false, false, false }; break;
                case "may": filter.Months = new bool[] { false, false, false, false, true, false, false, false, false, false, false, false }; break;
                case "june": filter.Months = new bool[] { false, false, false, false, false, true, false, false, false, false, false, false }; break;
                case "july": filter.Months = new bool[] { false, false, false, false, false, false, true, false, false, false, false, false }; break;
                case "august": filter.Months = new bool[] { false, false, false, false, false, false, false, true, false, false, false, false }; break;
                case "september": filter.Months = new bool[] { false, false, false, false, false, false, false, false, true, false, false, false }; break;
                case "october": filter.Months = new bool[] { false, false, false, false, false, false, false, false, false, true, false, false }; break;
                case "november": filter.Months = new bool[] { false, false, false, false, false, false, false, false, false, false, true, false }; break;
                case "december": filter.Months = new bool[] { false, false, false, false, false, false, false, false, false, false, false, true }; break;
            }
            filter.MinDay = (int)numericUpDown_minDay.Value;
            filter.MaxDay = (int)numericUpDown_maxDay.Value;

            // Generate dates
            try
            {
                outputDates = DateGenerator.GenerateDates(startDate, endDate, listToGenerate, (int)numericUpDown_numDates.Value, checkBox_duplicates.Checked, filter);
                if (outputDates.Length > 12_000)
                {
                    DialogResult result =  MessageBox.Show("The list you have specified contains " + outputDates.Length.ToString("###,###,###")
                        + " dates, which may take a while to generate. Do you want to continue?", "Large List of Dates", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                UpdateOutputDates();
                this.startDate = startDate;
                this.endDate = endDate;
                
            }
            catch (DateRangeSmallerThanNumDatesException)
            {
                MessageBox.Show("The date range you have specified is smaller than the number of dates you have specified to generate. " +
                    "Increase the date range, decrease the number of dates to generate, or allow duclicates.",
                    "Date Range Smaller Than Number of Dates");
                return;
            }
        }

        private void UpdateOutputDates()
        {
            string formattedDates = "";
            foreach (DateTime date in outputDates)
            {
                formattedDates += format.FormatDate(date) + "\n";
            }
            richTextBox_output.Text = formattedDates.TrimEnd('\n');

        }

        private DateTime ParseDate(TextBox yearTextBox, ComboBox monthComboBox, ComboBox DayComboBox, string startOrEnd)
        {
            int year;
            try
            {
                year = int.Parse(yearTextBox.Text);
                if (year > 9998 || year < 1)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show(startOrEnd +  " year must be a number from 0001 to 9998 (incusive).", "Invalid " + startOrEnd + " Year");
                throw new Exception();
            }

            int month = monthComboBox.SelectedIndex + 1;

            int day;
            try
            {
                day = int.Parse(DayComboBox.Text);
                if (day > 31 || day < 1)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show(startOrEnd + " day must be a number from 1 to 31 (incusive).", "Invalid " + startOrEnd + " Day");
                throw new Exception();
            }
            if (day > DateTime.DaysInMonth(year, month))
            {
                string monthText = DateFormat.Months[month];
                if (month == 2)
                {
                    monthText += " " + year.ToString("0000");
                }
                MessageBox.Show(monthText + " only has " + DateTime.DaysInMonth(year, month) + " days.", "Invalid " + startOrEnd + " Day");
                throw new Exception();
            }
            return new DateTime(year, month, day);
        }

        private int ParseListToGenerate()
        {
            if (radioButton_generateSome.Checked)
            {
                return 0;
            }
            else if (radioButton_generateRandom.Checked)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private void textBox_startYear_TextChanged(object sender, EventArgs e)
        {
            PopulateDaysList(textBox_startYear, comboBox_startMonth, comboBox_startDay);
        }

        private void comboBox_startMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDaysList(textBox_startYear, comboBox_startMonth, comboBox_startDay);
        }

        private void textBox_endYear_TextChanged(object sender, EventArgs e)
        {
            PopulateDaysList(textBox_endYear, comboBox_endMonth, comboBox_endDay);
        }

        private void comboBox_endMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDaysList(textBox_endYear, comboBox_endMonth, comboBox_endDay);
        }

        private void button_format_Click(object sender, EventArgs e)
        {
            DateFormatForm formatForm = new DateFormatForm(format);
            formatForm.ShowDialog();
            UpdateOutputDates();
        }

        private void button_saveOutput_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBox_output.Lines;
            DateTime currentDateTime = DateTime.Now;
            string filename = FormatDateToISO8601(currentDateTime) + "_"
                + currentDateTime.Hour.ToString("00") + "-"
                + currentDateTime.Minute.ToString("00") + "-"
                + currentDateTime.Second.ToString("00") + "_"
                + "DateList" + "_" + FormatDateToISO8601(startDate) + "_to_"
                + FormatDateToISO8601(endDate) + ".txt";

            try
            {
                System.IO.File.WriteAllLines(filename, lines);
            }
            catch
            {
                MessageBox.Show("Unable to write output file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatDateToISO8601(DateTime date)
        {
            return date.Year.ToString("0000") + "-" + date.Month.ToString("00") + "-" + date.Day.ToString("00");
        }

        private void button_saveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dateFormatLines = new string[9];
                dateFormatLines[0] = format.DateOrder.ToString();
                dateFormatLines[1] = format.YearFormat.ToString();
                dateFormatLines[2] = format.MonthFormat.ToString();
                dateFormatLines[3] = format.DayFormat.ToString();
                dateFormatLines[4] = format.DateSep.ToString();
                dateFormatLines[5] = format.Weekday.ToString();
                dateFormatLines[6] = format.WeekdayFormat.ToString();
                dateFormatLines[7] = format.WeekdaySep.ToString();
                dateFormatLines[8] = format.CommaAfterDay.ToString();

                string[] settingsLines = new string[13];
                DateTime startDate = ParseDate(textBox_startYear, comboBox_startMonth, comboBox_startDay, "Start");
                DateTime endDate = ParseDate(textBox_endYear, comboBox_endMonth, comboBox_endDay, "End");
                settingsLines[0] = startDate.Year.ToString("0000");
                settingsLines[1] = startDate.Month.ToString("00");
                settingsLines[2] = startDate.Day.ToString("00");
                settingsLines[3] = endDate.Year.ToString("0000");
                settingsLines[4] = endDate.Month.ToString("00");
                settingsLines[5] = endDate.Day.ToString("00");
                settingsLines[6] = ParseListToGenerate().ToString();
                settingsLines[7] = numericUpDown_numDates.Value.ToString();
                settingsLines[8] = checkBox_duplicates.Checked.ToString();
                settingsLines[9] = comboBox_filterWeekday.SelectedIndex.ToString();
                settingsLines[10] = comboBox_filterMonth.SelectedIndex.ToString();
                settingsLines[11] = numericUpDown_minDay.Value.ToString();
                settingsLines[12] = numericUpDown_maxDay.Value.ToString();

                System.IO.File.WriteAllLines("DateListGenerator_OutputFormat.txt", dateFormatLines);
                System.IO.File.WriteAllLines("DateListGenerator_Settings.txt", settingsLines);
            }
            catch
            {
                MessageBox.Show("Unable to save settings");
            }

        }
    }
}
