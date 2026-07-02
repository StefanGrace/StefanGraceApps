using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecimalTime
{
    public partial class Form1 : Form
    {
        private Clock clock =  new Clock();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_function.SelectedIndex = 0;
        }

        private void comboBox_function_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool inputEnabled = comboBox_function.SelectedIndex != 0;
            numericUpDown_inputHours.Enabled = inputEnabled;
            numericUpDown_inputMinutes.Enabled = inputEnabled;
            numericUpDown_inputSeconds.Enabled = inputEnabled;

            Funcion funcion = Funcion.DisplayCurrentTime;

            switch (comboBox_function.SelectedIndex)
            {
                case 1:
                    numericUpDown_inputHours.Maximum = 23;
                    numericUpDown_inputMinutes.Maximum = 59;
                    numericUpDown_inputSeconds.Maximum = 59;
                    funcion = Funcion.ConvertFrom24_60_60;
                    break;

                case 2:
                    numericUpDown_inputHours.Maximum = 9;
                    numericUpDown_inputMinutes.Maximum = 99;
                    numericUpDown_inputSeconds.Maximum = 99;
                    funcion = Funcion.ConvertFrom10_100_100;
                    break;

                case 3:
                    numericUpDown_inputHours.Maximum = 19;
                    numericUpDown_inputMinutes.Maximum = 49;
                    numericUpDown_inputSeconds.Maximum = 99;
                    funcion = Funcion.ConvertFrom20_50_100;
                    break;

                case 4:
                    numericUpDown_inputHours.Maximum = 23;
                    numericUpDown_inputMinutes.Maximum = 99;
                    numericUpDown_inputSeconds.Maximum = 99;
                    funcion = Funcion.ConvertFrom24_100_100;
                    break;

            }

            clock.Funcion = funcion;

            UpdateOutput();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox_function.SelectedIndex == 0)
            {
                UpdateOutput();
            }
        }

        private void numericUpDown_inputHours_ValueChanged(object sender, EventArgs e)
        {
            clock.InputHour = (int)numericUpDown_inputHours.Value;
            InputUpdated();
        }

        private void numericUpDown_inputMinutes_ValueChanged(object sender, EventArgs e)
        {
            clock.InputMinute = (int)numericUpDown_inputMinutes.Value;
            InputUpdated();
        }

        private void numericUpDown_inputSeconds_ValueChanged(object sender, EventArgs e)
        {
            clock.InputSecond = (int)numericUpDown_inputSeconds.Value;
            InputUpdated();
        }

        private void InputUpdated()
        {
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            Tuple<int, int, int> hoursMinuteSecond24_60_60 = clock.GetHoursMinuteSeconds(24, 60, 60);
            label_output24_60_60.Text = hoursMinuteSecond24_60_60.Item1.ToString("00") + ":" +
                hoursMinuteSecond24_60_60.Item2.ToString("00") + ":" + hoursMinuteSecond24_60_60.Item3.ToString("00");

            Tuple<int, int, int> hoursMinuteSecond10_100_100 = clock.GetHoursMinuteSeconds(10, 100, 100);
            label_output10_100_100.Text = hoursMinuteSecond10_100_100.Item1.ToString("0") + ":" +
                hoursMinuteSecond10_100_100.Item2.ToString("00") + ":" + hoursMinuteSecond10_100_100.Item3.ToString("00");

            Tuple<int, int, int> hoursMinuteSecond20_50_100 = clock.GetHoursMinuteSeconds(20, 50, 100);
            label_output20_50_100.Text = hoursMinuteSecond20_50_100.Item1.ToString("00") + ":" +
                hoursMinuteSecond20_50_100.Item2.ToString("00") + ":" + hoursMinuteSecond20_50_100.Item3.ToString("00");

            Tuple<int, int, int> hoursMinuteSecond24_100_100 = clock.GetHoursMinuteSeconds(24, 100, 100);
            label_output24_100_100.Text = hoursMinuteSecond24_100_100.Item1.ToString("00") + ":" +
                hoursMinuteSecond24_100_100.Item2.ToString("00") + ":" + hoursMinuteSecond24_100_100.Item3.ToString("00");

        }
    }
}
