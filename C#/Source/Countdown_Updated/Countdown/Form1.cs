using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countdown
{
    public partial class Form1 : Form
    {
        Countdown countdown = new Countdown();

        public Form1()
        {
            InitializeComponent();
        }

        private void monthTextBox_TextChanged(object sender, EventArgs e)
        {
            updateUntilDate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            countdown.update();
            currentDateLabel.Text = "Current Date: " + countdown.getCurrentDate();
            timeLabel.Text = countdown.getTimeUntil();
            hoursLabel.Text = countdown.getHoursUntil();
            minutesLabel.Text = countdown.getMinutesUntil();
            secondsLabel.Text = countdown.getSecondsUntil();
        }

        private void updateUntilDate()
        {
            try
            {
                bool error = countdown.update(int.Parse(yearTextBox.Text), int.Parse(monthTextBox.Text), int.Parse(dayTextBox.Text),
                    int.Parse(hourTextBox.Text), int.Parse(minuteTextBox.Text), int.Parse(secondTextBox.Text));

                if (error)
                {
                    InvalidDateLabel.Visible = true;
                }
                else
                {
                    InvalidDateLabel.Visible = false;
                    string[] lines = new string[6];
                    lines[0] = yearTextBox.Text;
                    lines[1] = monthTextBox.Text;
                    lines[2] = dayTextBox.Text;
                    lines[3] = hourTextBox.Text;
                    lines[4] = minuteTextBox.Text;
                    lines[5] = secondTextBox.Text;
                    try
                    {
                        System.IO.File.WriteAllLines("CountdownDate.txt", lines);
                    }
                    catch { }
                }
            }
            catch
            {
                InvalidDateLabel.Visible = true;
            }
        }

        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {
            updateUntilDate();
        }

        private void untilLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("CountdownDate.txt");
                yearTextBox.Text = lines[0];
                monthTextBox.Text = lines[1];
                dayTextBox.Text = lines[2];
                hourTextBox.Text = lines[3];
                minuteTextBox.Text = lines[4];
                secondTextBox.Text = lines[5];
                countdown.update(int.Parse(yearTextBox.Text), int.Parse(monthTextBox.Text), int.Parse(dayTextBox.Text),
                    int.Parse(hourTextBox.Text), int.Parse(minuteTextBox.Text), int.Parse(secondTextBox.Text));
            }
            catch { }
        }
    }


    public class Countdown
    {
        private DateTime currentDate = DateTime.Now;
        private DateTime until = new DateTime(2100, 1, 1, 0, 0, 0);

        public void update()
        {
            currentDate = DateTime.Now;
        }

        public bool update(int year, int month, int day, int hour, int minute, int second)
        {
            try
            {
                until = new DateTime(year, month, day, hour, minute, second);
                return false;
            }
            catch
            {
                return true;
            }
        }

        public string getCurrentDate()
        {
            return formatDate(currentDate);
        }

        public string getTimeUntil()
        {
            string timeUntilString = "";
            TimeSpan timeUntil = until.Subtract(currentDate);
            long daysUntil = (long)timeUntil.TotalDays;
            timeUntilString += daysUntil.ToString("###,##0") + " day" + getPlural(daysUntil) + ", ";
            timeUntilString += timeUntil.Hours + " hour" + getPlural(timeUntil.Hours) + ", ";
            timeUntilString += timeUntil.Minutes + " minute" + getPlural(timeUntil.Minutes) + ", ";
            timeUntilString += timeUntil.Seconds + " second" + getPlural(timeUntil.Seconds);
            return timeUntilString;
        }

        public string getHoursUntil()
        {
            TimeSpan timeUntil = until.Subtract(currentDate);
            return "Total hours: " + ((long)timeUntil.TotalHours).ToString("###,##0");
        }

        public string getMinutesUntil()
        {
            TimeSpan timeUntil = until.Subtract(currentDate);
            return "Total minutes: " + ((long)timeUntil.TotalMinutes).ToString("###,##0");
        }

        public string getSecondsUntil()
        {
            TimeSpan timeUntil = until.Subtract(currentDate);
            return "Total seconds: " + ((long)timeUntil.TotalSeconds).ToString("###,##0");
        }

        private string formatDate(DateTime date)
        {
            string dateString = "";
            dateString += date.Year.ToString("0000") + "-";
            dateString += date.Month.ToString("00") + "-";
            dateString += date.Day.ToString("00") + " ";
            dateString += date.Hour.ToString("00") + ":";
            dateString += date.Minute.ToString("00") + ":";
            dateString += date.Second.ToString("00");
            return dateString;
        }

        private string getPlural(long number)
        {
            if (Math.Abs(number) == 1)
            {
                return "";
            }
            else
            {
                return "s";
            }
        }
    }
}
