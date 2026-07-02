using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTransferTime
{
    public partial class Form1 : Form
    {
        private const string dateFormat = "yyyy-MM-dd HH:mm";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_dataRatePrefix.SelectedItem = "M";
            comboBox_dataRateUnit.SelectedItem = "B";
            comboBox_dataRateTime.SelectedItem = "s";
            comboBox_dataTotalPrefix.SelectedItem = "G";
            comboBox_dataTotalUnit.SelectedItem = "B";
            comboBox_outputTimeFormat.SelectedItem = "unit + subunit";

            label_outputTime.Text = "";
            label_outputDateTime.Text = "";

            DateTime startTime = DateTime.Now;
            numericUpDown_startYear.Value = startTime.Year;
            numericUpDown_startMonth.Value = startTime.Month;
            numericUpDown_startDay.Value = startTime.Day;
            numericUpDown_startHour.Value = startTime.Hour;
            numericUpDown_startMinute.Value = startTime.Minute;
        }

        private void InputUpdated(object sender, EventArgs e)
        {
            double dataRateValue;
            try
            {
                dataRateValue = double.Parse(textBox_dataTrasferRate.Text);
            }
            catch
            {
                return;
            }

            DataAmount dataRateData = new DataAmount(dataRateValue, 
                comboBox_dataRatePrefix.SelectedItem.ToString(), 
                comboBox_dataRateUnit.SelectedItem.ToString());

            double totalDataValue;
            try
            {
                totalDataValue = double.Parse(textBox_dataTotal.Text);
            }
            catch
            {
                return;
            }

            DataAmount totalData = new DataAmount(totalDataValue, 
                comboBox_dataTotalPrefix.SelectedItem.ToString(), 
                comboBox_dataTotalUnit.SelectedItem.ToString());


            TimeSpan dataRateTime = Formatter.CreateTimeSpan(comboBox_dataRateTime.SelectedItem.ToString()); 

            DateTime startTime = new DateTime(
                (int)numericUpDown_startYear.Value, 
                (int)numericUpDown_startMonth.Value, 
                (int)numericUpDown_startDay.Value, 
                (int)numericUpDown_startHour.Value, 
                (int)numericUpDown_startMinute.Value, 0);

            TimeSpan trasferTime;
            try
            {
                trasferTime = Calculator.CalculateTrasferTime(dataRateData, dataRateTime, totalData);
            }
            catch (OverflowException ex)
            {
                label_outputTime.Text = ex.Message;
                try
                {
                    long finishYear = Calculator.CalculateFinishYear(startTime, dataRateData, dataRateTime, totalData);
                    label_outputDateTime.Text = Formatter.FormatYear(finishYear);
                }
                catch (OverflowException)
                {
                    label_outputDateTime.Text = "";
                }
                return;
            }
            catch (ArithmeticException ex)
            {
                label_outputTime.Text = ex.Message;
                label_outputDateTime.Text = "";
                return;
            }
            catch (InvalidCastException ex)
            {
                label_outputTime.Text = ex.Message;
                label_outputDateTime.Text = startTime.ToString(dateFormat);
                return;
            }
            

            label_outputTime.Text = Formatter.FormatTransferTime(trasferTime, comboBox_outputTimeFormat.SelectedItem.ToString());

            try
            {
                DateTime finishTime = Calculator.CalculateFinishDate(startTime, trasferTime);
                label_outputDateTime.Text = finishTime.ToString(dateFormat);
            }
            catch (ArgumentOutOfRangeException)
            {
                try
                {
                    long finishYear = Calculator.CalculateFinishYear(startTime, dataRateData, dataRateTime, totalData);
                    label_outputDateTime.Text = Formatter.FormatYear(finishYear);
                }
                catch (OverflowException)
                {
                    label_outputDateTime.Text = "";
                }
            }


        }

        private void OutputTimeFormatChanged(object sender, EventArgs e)
        {
            InputUpdated(sender, e);
        }

        private void StartYearOrMonthChanged(object sender, EventArgs e)
        {
            numericUpDown_startDay.Maximum =
                DateTime.DaysInMonth((int)numericUpDown_startYear.Value, (int)numericUpDown_startMonth.Value);

            StartDateChanged(sender, e);
        }

        private void StartDateChanged(object sender, EventArgs e)
        {
            InputUpdated(sender, e);
        }
    }
}
