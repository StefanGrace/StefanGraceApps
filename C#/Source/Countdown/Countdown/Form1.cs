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

        public Countdown()
        {
            
            
        }

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
            timeUntilString += Math.Floor(timeUntil.TotalDays / 1d) + " days, ";
            timeUntilString += Math.Floor(timeUntil.Hours / 1d) + " hours, ";
            timeUntilString += Math.Floor(timeUntil.Minutes / 1d) + " minutes, ";
            timeUntilString += Math.Floor(timeUntil.Seconds / 1d) + " seconds ";
            return timeUntilString;
        }

        public string getDaysUntil()
        {
            TimeSpan timeUntil = until.Subtract(currentDate);
            return "Total days: " + Math.Floor(timeUntil.TotalDays);
        }

        public string getHoursUntil()
        {
            TimeSpan timeUntil = until.Subtract(currentDate);
            return "Total hours: " + Math.Floor(timeUntil.TotalHours);
        }

        public string getMinutesUntil()
        {
            TimeSpan timeUntil = until.Subtract(currentDate);
            return "Total minutes: " + Math.Floor(timeUntil.TotalMinutes);
        }

        public string getSecondsUntil()
        {
            TimeSpan timeUntil = until.Subtract(currentDate);
            return "Total seconds: " + Math.Floor(timeUntil.TotalSeconds);
        }

        private string formatDate(DateTime date)
        {
            string dateString = "";
            dateString += date.Year + "-";
            dateString += addLeadingZero(date.Month) + "-";
            dateString += addLeadingZero(date.Day) + " ";
            dateString += addLeadingZero(date.Hour) + ":";
            dateString += addLeadingZero(date.Minute) + ":";
            dateString += addLeadingZero(date.Second);
            return dateString;
        }

        private string addLeadingZero(int number)
        {
            if (number < 10)
            {
                return "0" + number;
            }
            else
            {
                return number + "";
            }
        }
    }
}
