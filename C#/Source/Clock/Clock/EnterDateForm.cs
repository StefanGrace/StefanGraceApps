using System;
using System.Windows.Forms;

namespace Clock
{
    public partial class EnterDateForm : Form
    {
        private DateTime dateTime;

        public DateTime DateTime { get => dateTime;}

        public EnterDateForm(DateTime dateTime)
        {
            this.dateTime = dateTime;
            InitializeComponent();
        }

        public EnterDateForm()
        {
            dateTime = new DateTime();
            InitializeComponent();
        }

        private void EnterDateForm_Load(object sender, EventArgs e)
        {
            // Poulate the fields
            if (dateTime != new DateTime())
            {
                textBox_year.Text = dateTime.Year.ToString("0000");
                textBox_month.Text = dateTime.Month.ToString("00");
                textBox_day.Text = dateTime.Day.ToString("00");
                textBox_hour.Text = dateTime.Hour.ToString("00");
                textBox_minute.Text = dateTime.Minute.ToString("00");
                textBox_second.Text = dateTime.Second.ToString("00");
            }
        }

        private void ShowHelpMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void button_help_year_Click(object sender, EventArgs e)
        {
            ShowHelpMessage("Year must be a number from 0001 to 9999. Years before 1000 may or may not have leading zeros. Note that 2-digit numbers like \"23\" will be interpreted as 0023, not 2023.");
        }

        private void button_help_month_Click(object sender, EventArgs e)
        {
            ShowHelpMessage("Month can be either a number from 1 to 12 (may or may not have a leading zero), or the English month name (may be either first 3 letters, or full name).");
        }

        private void button_help_day_Click(object sender, EventArgs e)
        {
            ShowHelpMessage("Day must be a number from 1 to (28 - 31, depending on the month). Day may or may not have a leading zero, and may or may not contain st/nd/rd/th.");
        }

        private void button_help_hour_Click(object sender, EventArgs e)
        {
            ShowHelpMessage("Hour can be either a number from 0 to 24 (0 and 24 being treated equal), or a number from 0 to 12 (0 and 12 being treated equal) with an AM/PM symbol. May or may not have a leading zero.");
        }

        private void button_help_minute_Click(object sender, EventArgs e)
        {
            ShowHelpMessage("Minute must be a number from 0 to 59. May or may not have a leading zero.");
        }

        private void button_help_second_Click(object sender, EventArgs e)
        {
            ShowHelpMessage("Second must be a number from 0 to 59. May or may not have a leading zero. Leap seconds are not supported.");
        }

    
        private void button_ok_Click(object sender, EventArgs e)
        { 
            // Interpret year
            int year = -1;
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

            // Interpret month
            int month = -1;
            try
            {
                month = int.Parse(textBox_month.Text);
            }
            catch
            {
                for (int i = 1; i <= 12; i++)
                {
                    if (textBox_month.Text.ToLower().StartsWith(Formatter.Months[i].Substring(0, 3).ToLower()))
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

            // Interpret day
            int day = -1;
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
                        invalidDayMessage = Formatter.Months[month] + " " + year.ToString("0000") + " only has " + daysInMonth + " days";
                    }
                }
                else
                {
                    invalidDayMessage = Formatter.Months[month] + " only has " + daysInMonth + " days";
                }
                MessageBox.Show(invalidDayMessage, "Invalid Day");
                return;
            }

            // Interpret hour
            int hour = -1;
            try
            {
                hour = int.Parse(textBox_hour.Text.ToLower().Replace("h", "").Replace(" ", ""));
            }
            catch
            {
                bool am = textBox_hour.Text.ToLower().Contains("a");
                bool pm = textBox_hour.Text.ToLower().Contains("p");
                if (am ^ pm)
                {
                    try
                    {
                        hour = int.Parse(textBox_hour.Text.ToLower().Replace("a", "").Replace("p", "").Replace("m", "").Replace(".", "").Replace(" ", ""));
                    }
                    catch { }
                    if (hour > 24)
                    {
                        hour = -1;
                    }
                    else if (hour > 12)
                    {
                        MessageBox.Show("24-hour time doesn't use AM/PM.");
                        return;
                    }
                    else if (hour == 12)
                    {
                        hour = 0;
                    }
                    if (pm && hour > -1)
                    {
                        hour += 12;
                    }
                }
            }
            if (hour == 24)
            {
                hour = 0;
            }
            if (hour < 0 || hour > 23)
            {
                MessageBox.Show("Hour must be either a number from 0 to 24, or a number from 0 to 12 with an AM or PM symbol.", "Invalid Hour");
                return;
            }

            // Interpret minute
            int minute = -1;
            try
            {
                minute = int.Parse(textBox_minute.Text);
            }
            catch { }
            if (minute < 0 || minute > 59)
            {
                MessageBox.Show("Minute must be a number from 0 to 59.", "Invalid Minute");
                return;
            }

            // Interpret second
            int second = -1;
            try
            {
                second = int.Parse(textBox_second.Text);
            }
            catch { }
            if (second < 0 || second > 60)
            {
                MessageBox.Show("Second must be a number from 0 to 59.", "Invalid Second");
                return;
            }
            else if (second == 60)
            {
                MessageBox.Show("Leap seconds are not supported.", "Invalid Second");
                return;
            }

            // If each of the text boxes has been interpreted successfully, create a DateTime object with the entered values
            try
            {
                dateTime = new DateTime(year, month, day, hour, minute, second);
            }
            catch
            {
                MessageBox.Show("The values that you entered do not represent a valid date/time", "Invalid Date/Time");
                return;
            }
            Close();
        }
    }
}
