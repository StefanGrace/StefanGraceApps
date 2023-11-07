using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revised12hourClock
{
    public partial class Form1 : Form
    {
        Converter converter = new Converter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeSourceComboBox.SelectedIndex = 0;
            amPmComboBox.SelectedIndex = 0;
            outputFormatComboBox.SelectedIndex = 0;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            if (minutesCheckBox.Checked)
            {
                minuteInputTextbox.Show();
                hourMinuteColon.Show();
                secondsCheckBox.Show();
                if (secondsCheckBox.Checked)
                {
                    secondInputTextbox.Show();
                    minuteSecondColon.Show();
                }
                else
                {
                    secondInputTextbox.Hide();
                    minuteSecondColon.Hide();
                }
            }
            else
            {
                minuteInputTextbox.Hide();
                hourMinuteColon.Hide();
                secondsCheckBox.Hide();
                secondInputTextbox.Hide();
                minuteSecondColon.Hide();
            }

            switch (timeSourceComboBox.SelectedIndex)
            {
                case 0:
                    hourInputTextbox.Hide();
                    hourMinuteColon.Hide();
                    minuteInputTextbox.Hide();
                    minuteSecondColon.Hide();
                    secondInputTextbox.Hide();
                    amPmComboBox.Hide();
                    DateTime currentDate = DateTime.Now;
                    if (minutesCheckBox.Checked)
                    {
                        if (secondsCheckBox.Checked)
                        {
                            if (outputFormatComboBox.SelectedIndex == 0)
                            {
                                timeOutput.Text = converter.convertToCompact(currentDate.Hour, currentDate.Minute, currentDate.Second);
                            }
                            else
                            {
                                timeOutput.Text = converter.convertToLong(currentDate.Hour, currentDate.Minute, currentDate.Second);
                            }
                        }
                        else
                        {
                            if (outputFormatComboBox.SelectedIndex == 0)
                            {
                                timeOutput.Text = converter.convertToCompact(currentDate.Hour, currentDate.Minute);
                            }
                            else
                            {
                                timeOutput.Text = converter.convertToLong(currentDate.Hour, currentDate.Minute);
                            }
                        }
                    }
                    else
                    {
                        if (outputFormatComboBox.SelectedIndex == 0)
                        {
                            timeOutput.Text = converter.convertToCompact(currentDate.Hour);
                        }
                        else
                        {
                            timeOutput.Text = converter.convertToLong(currentDate.Hour);
                        }
                            
                    }
                    break;
                case 1:
                    amPmComboBox.Show();
                    showTimeInput();
                    int hour;
                    int minute;
                    int second;
                    bool pm = amPmComboBox.SelectedIndex == 1;
                    try
                    {
                        hour = int.Parse(hourInputTextbox.Text);
                        minute = int.Parse(minuteInputTextbox.Text);
                        second = int.Parse(secondInputTextbox.Text);
                        if (minutesCheckBox.Checked)
                        {
                            if (secondsCheckBox.Checked)
                            {
                                if (outputFormatComboBox.SelectedIndex == 0)
                                {
                                    timeOutput.Text = converter.convertToCompact(hour, minute, second, pm);
                                }
                                else
                                {
                                    timeOutput.Text = converter.convertToLong(hour, minute, second, pm);
                                }
                                
                            }
                            else
                            {
                                if (outputFormatComboBox.SelectedIndex == 0)
                                {
                                    timeOutput.Text = converter.convertToCompact(hour, minute, pm);
                                }
                                else
                                {
                                    timeOutput.Text = converter.convertToLong(hour, minute, pm);
                                }
                            }
                        }
                        else
                        {
                            if (outputFormatComboBox.SelectedIndex == 0)
                            {
                                timeOutput.Text = converter.convertToCompact(hour, pm);
                            }
                            else
                            {
                                timeOutput.Text = converter.convertToLong(hour, pm);
                            }
                                
                        }
                    }
                    catch
                    {
                        timeOutput.Text = "Invalid";
                    }

                    break;
                case 2:
                    amPmComboBox.Hide();
                    showTimeInput();
                    try
                    {
                        hour = int.Parse(hourInputTextbox.Text);
                        minute = int.Parse(minuteInputTextbox.Text);
                        second = int.Parse(secondInputTextbox.Text);
                        if (minutesCheckBox.Checked)
                        {
                            if (secondsCheckBox.Checked)
                            {
                                if (outputFormatComboBox.SelectedIndex == 0)
                                {
                                    timeOutput.Text = converter.convertToCompact(hour, minute, second);
                                }
                                else
                                {
                                    timeOutput.Text = converter.convertToLong(hour, minute, second);
                                }
                            }
                            else
                            {
                                if (outputFormatComboBox.SelectedIndex == 0)
                                {
                                    timeOutput.Text = converter.convertToCompact(hour, minute);
                                }
                                else
                                {
                                    timeOutput.Text = converter.convertToLong(hour, minute);
                                }
                                    
                            }
                        }
                        else
                        {
                            if (outputFormatComboBox.SelectedIndex == 0)
                            {
                                timeOutput.Text = converter.convertToCompact(hour);
                            }
                            else
                            {
                                timeOutput.Text = converter.convertToLong(hour);
                            }
                                
                        }
                        
                    }
                    catch
                    {
                        timeOutput.Text = "Invalid";
                    }
                    break;
            }
        }

        private void showTimeInput()
        {
            hourInputTextbox.Show();
            if (minutesCheckBox.Checked)
            {
                hourMinuteColon.Show();
                minuteInputTextbox.Show();
                if (secondsCheckBox.Checked)
                {
                    minuteSecondColon.Show();
                    secondInputTextbox.Show();
                }
            }
        }


    }
}
