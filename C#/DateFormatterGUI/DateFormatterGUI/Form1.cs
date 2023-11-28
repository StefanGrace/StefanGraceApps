using System;
using System.Windows.Forms;

namespace DateFormatter
{
    public partial class Form1 : Form
    {
        private OutputFormat format = new OutputFormat();
        private Formatter formatter = new Formatter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                format.Load();
            }
            catch
            {
                ShowFormatForm();
                if (format.DateOrder < 1)
                {
                    Application.Exit();
                }
               
            }
            UpdateFormatterFormat();
        }

        private void radioButton_convertDateFormat_CheckedChanged(object sender, EventArgs e)
        {
            label_input.Enabled = radioButton_convertDateFormat.Checked;
            textBox_input.Enabled = radioButton_convertDateFormat.Checked;
        }

        private void radioButton_inputDateByElement_CheckedChanged(object sender, EventArgs e)
        {
            label_year.Enabled = radioButton_inputDateByElement.Checked;
            label_month.Enabled = radioButton_inputDateByElement.Checked;
            label_day.Enabled = radioButton_inputDateByElement.Checked;
            textBox_year.Enabled = radioButton_inputDateByElement.Checked;
            textBox_month.Enabled = radioButton_inputDateByElement.Checked;
            textBox_day.Enabled = radioButton_inputDateByElement.Checked;
        }

        private void button_outputFormat_Click(object sender, EventArgs e)
        {
            ShowFormatForm();
        }

        private void ShowFormatForm()
        {
            DefineOutputFormatForm outputFormatForm = new DefineOutputFormatForm(format);
            outputFormatForm.ShowDialog();
            UpdateFormatterFormat();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show(format.Save());
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete \"" + format.FileName + "\"?","", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(format.Delete());
            }
        }

        private void button_formatDate_Click(object sender, EventArgs e)
        {
            if (radioButton_inputDateByElement.Checked)
            {
                int year = -1;
                int month = -1;
                int day = -1;

                try
                {
                    year = int.Parse(textBox_year.Text);
                }
                catch { }
                if (year < 1 || year > 9999)
                {
                    MessageBox.Show("Year must be a number from 0001 to 9999", "Invalid Year");
                    return;
                }

                try
                {
                    month = int.Parse(textBox_month.Text);
                }
                catch
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        if (textBox_month.Text.ToLower().StartsWith(formatter.Months[i].Substring(0, 3).ToLower()))
                        {
                            month = i;
                        }
                    }
                }
                if (month < 1 || month > 12)
                { 
                    MessageBox.Show("Month must ethier be a number from 1 to 12, or a month name from (Jan)uary to (Dec)ember", "Invalid Month");
                    return;
                }

                try
                {
                    day = int.Parse(textBox_day.Text.Replace("st", "").Replace("nd", "").Replace("rd", "").Replace("th", ""));
                }
                catch { }
                int daysInMonth = DateTime.DaysInMonth(year, month);
                
                if (day < 1 || day > 31)
                {
                    MessageBox.Show("Day must be a number from 1 to " + daysInMonth, "Invalid Day");
                    return;
                }
                else if (day > daysInMonth)
                {
                    string invalidDayMessage = "";
                    if (month == 2)
                    {
                        if (day == 29)
                        {
                            invalidDayMessage = year.ToString("0000") + " is not a leap year";
                        }
                        else
                        {
                            invalidDayMessage = formatter.Months[month] + " " + year.ToString("0000") + " only has " + daysInMonth + " days";
                        }
                    }
                    else
                    {
                        invalidDayMessage = formatter.Months[month] + " only has " + daysInMonth + " days";
                    }
                    MessageBox.Show(invalidDayMessage, "Invalid Day");
                    return;
                }

                try
                {
                    textBox_output.Text = formatter.FormatDate(year, month, day);
                }
                catch 
                {
                    MessageBox.Show("Invalid Date");
                }
            }
            else if (radioButton_convertDateFormat.Checked)
            {
                if (textBox_input.Text == "")
                {
                    MessageBox.Show("Enter a date into the input text box");
                }
                else
                {
                    try
                    {
                        textBox_output.Text = formatter.FormatDate(textBox_input.Text);
                    }
                    catch (InvalidDateException ex)
                    {
                        MessageBox.Show("Cannot interpret \"" + ex.Date + "\" as a valid date", "Invalid Date");
                    }
                    catch (AmbiguousDateException ex)
                    {
                        AmbiguousDateForm dateForm = new AmbiguousDateForm(ex.Interpretations, textBox_input.Text);
                        dateForm.ShowDialog();
                        if (dateForm.Index != -1)
                        {
                            try
                            {
                                textBox_output.Text = formatter.FormatDate(ex.Interpretations[dateForm.Index]);
                            }
                            catch (InvalidDateException except)
                            {
                                MessageBox.Show("Cannot interpret \"" + except.Date + "\" as a valid date", "Invalid Date");
                            }
                        }
                    }
                    catch (InvalidDateElementException ex)
                    {
                        MessageBox.Show(ex.Message, "Invalid Date");
                    }
                }
            }
            else if (radioButton_formatCurrrentDate.Checked)
            {
                FormatCurrentDate();
            }
        }

        private void UpdateFormatterFormat()
        {
            formatter.SetFormat(format.DateOrder, format.YearFormat, format.MonthFormat, format.DayFormat, format.Separator, format.CommaAfterDay);
        }

        private void radioButton_formatCurrrentDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_formatCurrrentDate.Checked)
            {
                FormatCurrentDate();
            }
        }

        private void FormatCurrentDate()
        {
            DateTime currentDate = DateTime.Now;
            textBox_output.Text = formatter.FormatDate(currentDate.Year, currentDate.Month, currentDate.Day);
        }
    }
}
