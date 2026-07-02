using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendedClock
{
    public partial class Form1 : Form
    {
        private TimeFormatter formatter = new TimeFormatter();
        private int modeIndex = 0;

        private int initalFormat;
        private bool initalShowSeconds;
        private bool initalTimeInTitle;

        public Form1(int format, bool showSeconds, bool timeInTitle)
        {
            initalFormat = format;
            initalShowSeconds = showSeconds;
            initalTimeInTitle = timeInTitle;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_mode.SelectedIndex = 0;

            switch (initalFormat)
            {
                case 6: radioButton_6hour.Checked = true; break;
                case 12: radioButton_12hour.Checked = true; break;
                case 24: radioButton_24hour.Checked = true; break;
                case 30: radioButton_30hour.Checked = true; break;
                case 36: radioButton_36hour.Checked = true; break;
                case 48: radioButton_48hour.Checked = true; break;

                default:
                    radioButton_custom.Checked = true;
                    numericUpDown_custom.Value = initalFormat;
                    break;
            }
            checkBox_seconds.Checked = initalShowSeconds;
            checkBox_timeInTitle.Checked = initalTimeInTitle;


            // Popuploate minute and second comboboxes
            for (int i = 0; i < 60; i++)
            {
                comboBox_minute.Items.Add(i.ToString("00"));
                comboBox_second.Items.Add(i.ToString("00"));
            }
            comboBox_minute.SelectedIndex = 0;
            comboBox_second.SelectedIndex = 0;
        }

        private void UpdateOutput()
        {
            DateTime time;
            if (modeIndex == 0)
            {
                time = DateTime.Now;
            }
            else
            {
                int hour;
                switch (modeIndex)
                {
                    case 4: hour = (comboBox_hour.SelectedIndex + 6) % 24; break;
                    case 5: hour = (comboBox_hour.SelectedIndex + 12) % 24; break;
                    default: hour = comboBox_hour.SelectedIndex; break;
                }

                if (comboBox_meridian.SelectedIndex == -1)
                {
                    time = formatter.ParseTime(hour, comboBox_minute.SelectedIndex, comboBox_second.SelectedIndex, GetInputTimeFormat());
                }
                else
                {
                    time = formatter.ParseTime(hour, comboBox_minute.SelectedIndex, comboBox_second.SelectedIndex, GetInputTimeFormat(), comboBox_meridian.SelectedIndex);
                }
            }

            string timeText = formatter.FormatTime(time, GetOutputFormat(), checkBox_seconds.Checked);

            label_time.Text = timeText;

            // Center the output date/time in the window vertically
            label_time.Location = new Point((Size.Width / 2) - (label_time.Width / 2), label_time.Location.Y);

            // Display time in title bar is the option is enabled
            if (checkBox_timeInTitle.Checked)
            {
                Text = timeText;
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private int GetOutputFormat()
        {
            if (radioButton_6hour.Checked)
            {
                return 6;
            }
            else if (radioButton_12hour.Checked)
            {
                return 12;
            }
            else if(radioButton_24hour.Checked)
            {
                return 24;
            }
            else if (radioButton_30hour.Checked)
            {
                return 30;
            }
            else if (radioButton_36hour.Checked)
            {
                return 36;
            }
            else if (radioButton_48hour.Checked)
            {
                return 48;
            }
            else
            {
                return (int)numericUpDown_custom.Value;
            }
        }

        private void PopulateHourDropdown(int hours)
        {
            if (hours < 24)
            {
                comboBox_hour.Items.Add(hours.ToString("0"));
                for (int i = 1; i < hours; i++)
                {
                    comboBox_hour.Items.Add(i.ToString("0"));
                }
            }
            else
            {
                for (int i = hours - 24; i < hours; i++)
                {
                    comboBox_hour.Items.Add(i.ToString("00"));
                }
            }
            
        }

        private void comboBox_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            modeIndex = comboBox_mode.SelectedIndex;

            comboBox_hour.Items.Clear();

            comboBox_hour.Visible = comboBox_mode.SelectedIndex > 0;
            label_hourMinuteColon.Visible = comboBox_mode.SelectedIndex > 0;
            comboBox_minute.Visible = comboBox_mode.SelectedIndex > 0;

            UpdateSecondInputVisability();

            comboBox_meridian.Visible = comboBox_mode.SelectedIndex == 1 || comboBox_mode.SelectedIndex == 2;

            comboBox_meridian.Items.Clear();

            switch (comboBox_mode.SelectedIndex)
            {
                case 1:
                    PopulateHourDropdown(GetInputTimeFormat());
                    comboBox_meridian.Items.AddRange(new string[] { "early morning", "morning", "afternoon", "evening" });
                    comboBox_meridian.SelectedIndex = 0;
                    break;

                case 2:
                    PopulateHourDropdown(GetInputTimeFormat());
                    comboBox_meridian.Items.AddRange(new string[] { "AM", "PM" });
                    comboBox_meridian.SelectedIndex = 0;
                    break;

                case 3:
                case 4:
                case 5:
                case 6:
                    PopulateHourDropdown(GetInputTimeFormat());
                    break;
            }

            if (comboBox_hour.Items.Count > 0)
            {
                comboBox_hour.SelectedIndex = 0;
            }
            
        }

        private void checkBox_seconds_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSecondInputVisability();
        }

        private void UpdateSecondInputVisability()
        {
            label_minuteSecondColon.Visible = comboBox_mode.SelectedIndex > 0 && checkBox_seconds.Checked;
            comboBox_second.Visible = comboBox_mode.SelectedIndex > 0 && checkBox_seconds.Checked;
        }

        private void numericUpDown_custom_ValueChanged(object sender, EventArgs e)
        {
            radioButton_custom.Checked = true;
        }

        private void checkBox_timeInTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_timeInTitle.Checked)
            {
                UpdateOutput();
            }
            else
            {
                Text = "Extended 24-hour Clock";
            }
        }

        private int GetInputTimeFormat()
        {
            switch (modeIndex)
            {
                case 1: return 6;
                case 2: return 12;
                case 3: return 24; 
                case 4: return 30;
                case 5: return 36;
                case 6: return 48;
                default: return 0;
            }
        }


    }
}
