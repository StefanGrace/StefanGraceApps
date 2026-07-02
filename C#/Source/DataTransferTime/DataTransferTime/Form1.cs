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

            TimeSpan trasferTime;
            try
            {
                trasferTime = Calculator.CalculateTrasferTime(dataRateData, dataRateTime, totalData);
            }
            catch (Exception ex)
            {
                label_outputTime.Text = ex.Message;
                return;
            }

            label_outputTime.Text = Formatter.FormatTransferTime(trasferTime, comboBox_outputTimeFormat.SelectedItem.ToString());


        }

        private void OutputTimeFormatChanged(object sender, EventArgs e)
        {
            InputUpdated(sender, e);
        }
    }
}
