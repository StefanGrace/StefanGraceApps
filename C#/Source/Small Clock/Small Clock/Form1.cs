using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Small_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string leadingZeroMonth;
            string leadingZeroDay;
            string leadingZeroHour;
            string leadingZeroMinute;
            string leadingZeroSecond;
            if (dateTime.Month < 10)
            {
                leadingZeroMonth = "0" + dateTime.Month;
            }
            else
            {
                leadingZeroMonth = dateTime.Month.ToString();
            }
            if (dateTime.Day < 10)
            {
                leadingZeroDay = "0" + dateTime.Day;
            }
            else
            {
                leadingZeroDay = dateTime.Day.ToString();
            }
            if (dateTime.Hour < 10)
            {
                leadingZeroHour = "0" + dateTime.Hour;
            }
            else
            {
                leadingZeroHour = dateTime.Hour.ToString();
            }
            if (dateTime.Hour < 10)
            {
                leadingZeroHour = "0" + dateTime.Hour;
            }
            else
            {
                leadingZeroHour = dateTime.Hour.ToString();
            }
            if (dateTime.Minute < 10)
            {
                leadingZeroMinute = "0" + dateTime.Minute;
            }
            else
            {
                leadingZeroMinute = dateTime.Minute.ToString();
            }
            if (dateTime.Second < 10)
            {
                leadingZeroSecond = "0" + dateTime.Second;
            }
            else
            {
                leadingZeroSecond = dateTime.Second.ToString();
            }
            string dateTimeText = dateTime.Year + "-" + leadingZeroMonth + "-" + leadingZeroDay + " " + leadingZeroHour + ":" + leadingZeroMinute + ":" + leadingZeroSecond;
            setTitle(dateTimeText);
        }
    }
}
