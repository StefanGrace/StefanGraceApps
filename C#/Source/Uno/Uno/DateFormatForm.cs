using System;
using System.Windows.Forms;

// Stefan Grace
// Uno
// DateFormatForm.cs

namespace Uno
{
    public partial class DateFormatForm : Form
    {
        private bool system = true;
        private string dateOrder = "YMD";
        private string dateTimeOrder = "Date Time";
        private string dateSeperator = "-";
        private int yearFormat = 4;
        private string monthFormat = "Number";
        private int timeFormat = 24;
        private bool showYear = true;
        private bool showTime = true;
        private bool showSeconds = true;

        public DateFormatForm()
        {
            InitializeComponent();
            loadDateFormatFromatFile();
        }

        private void DateFormatForm_Load(object sender, EventArgs e)
        {
            if (!system)
            {
                systemRadioButton.Checked = false;
                customRadioButton.Checked = true;
            }
            if(dateOrder == "MDY")
            {
                ymdRadioButton.Checked = false;
                mdyRadioButton.Checked = true;
            }
            if (dateOrder == "DMY")
            {
                ymdRadioButton.Checked = false;
                dmyRadioButton.Checked = true;
            }
            if (dateTimeOrder == "Time Date")
            {
                dtRadioButton.Checked = true;
                tdRadioButton.Checked = false;
            }
            if (dateSeperator == "/")
            {
                hyphenRadioButton.Checked = false;
                slashRadioButton.Checked = true;
            }
            if (dateSeperator == ".")
            {
                hyphenRadioButton.Checked = false;
                dotRadioButton.Checked = true;
            }
            if (yearFormat == 2)
            {
                twoDigitRadioButton.Checked = true;
                fourDigitRadioButton.Checked = false;
            }
            if (monthFormat == "Word")
            {
                monthNumberRadioButton.Checked = false;
                monthWordRadioButton.Checked = true;
            }
            if (timeFormat == 12)
            {
                _12hourRadioButton.Checked = true;
                _24hourRadioButton.Checked = true;
            }
            if (!showYear)
            {
                showYearCheckBox.Checked = false;
            }
            if (!showTime)
            {
                showTimeCheckBox.Checked = false;
            }
            if (!showSeconds)
            {
                showSecondsCheckBox.Checked = false;
            }
        }

        private void loadDateFormatFromatFile()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("DateFormat.txt");
                system = stringToBool(lines[0], true);
                dateOrder = lines[1];
                dateTimeOrder = lines[2];
                dateSeperator = lines[3];
                yearFormat = int.Parse(lines[4]);
                monthFormat = lines[5];
                timeFormat = int.Parse(lines[6]);
                showYear = stringToBool(lines[7], true);
                showTime = stringToBool(lines[8], true);
                showSeconds = stringToBool(lines[9], true);
            }
            catch { }
        }

        public bool stringToBool(string text, bool defualt)
        {
            bool output;
            if (text.ToLower() == "true")
            {
                output = true;
            }
            else if (text.ToLower() == "false")
            {
                output = false;
            }
            else
            {
                output = defualt;
            }
            return output;
        }

        public void saveDateFormatToFile()
        {
            string[] lines = {
                system.ToString(),
                dateOrder,
                dateTimeOrder,
                dateSeperator,
                yearFormat.ToString(),
                monthFormat,
                timeFormat.ToString(),
                showYear.ToString(),
                showTime.ToString(),
                showSeconds.ToString() };
            System.IO.File.WriteAllLines("DateFormat.txt", lines);
        }

        public string formatDate(DateTime date)
        {
            if (system)
            {
                return date.ToString();
            }
            else
            {
                string yearText;
                if (yearFormat == 2)
                {
                    yearText = addLeadingZero(date.Year % 100);
                }
                else
                {
                    int year = date.Year;
                    if (year < 10)
                    {
                        yearText = "000" + year;
                    }
                    else if(year < 100)
                    {
                        yearText = "00" + year;
                    }
                    else if(year < 1000)
                    {
                        yearText = "0" + year;
                    }
                    else
                    {
                        yearText = year.ToString();
                    }
                }
                string monthText;
                if(monthFormat == "Number") // Number
                {
                    monthText = addLeadingZero(date.Month);
                }
                else // Word
                {
                    string[] months = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                    monthText = months[date.Month - 1];
                }
                string dayText = addLeadingZero(date.Day);
                string amPm;
                if (date.Hour < 12)
                {
                    amPm = "AM";
                }
                else
                {
                    amPm = "PM";
                }
                string hourText;
                if (timeFormat == 12) // 12 hour
                {
                    int _12hour = date.Hour % 12;
                    if (_12hour == 0)
                    {
                        _12hour = 12;
                    }
                    hourText = addLeadingZero(_12hour);
                }
                else // 24 hour
                {
                    hourText = addLeadingZero(date.Hour);
                }
                string minuteText = addLeadingZero(date.Minute);
                string secondText = addLeadingZero(date.Second);
                string dateText;
                if (showYear)
                {
                    switch (dateOrder)
                    {
                        default: // YMD
                            dateText = yearText + dateSeperator + monthText + dateSeperator + dayText;
                            break;
                        case "MDY":
                            dateText = monthText + dateSeperator + dayText + dateSeperator + yearText;
                            break;
                        case "DMY":
                            dateText = dayText + dateSeperator + monthText + dateSeperator + yearText;
                            break;
                    }
                }
                else
                {
                    switch (dateOrder)
                    {
                        default: // YMD, MDY
                            dateText = monthText + dateSeperator + dayText;
                            break;
                        case "DMY":
                            dateText = dayText + dateSeperator + monthText;
                            break;
                    }
                }
                string timeText;
                if (showSeconds)
                {
                    if (timeFormat == 12)
                    {
                        timeText = hourText + ":" + minuteText + ":" + secondText + " " + amPm;
                    }
                    else
                    {
                        timeText = hourText + ":" + minuteText + ":" + secondText;
                    }
                }
                else
                {
                    if (timeFormat == 12)
                    {
                        timeText = hourText + ":" + minuteText + " " + amPm;
                    }
                    else
                    {
                        timeText = hourText + ":" + minuteText;
                    }
                }
                string dateTimeText;
                if (showTime)
                {
                    if (dateTimeOrder == "Time Date")
                    {
                        dateTimeText = timeText + " " + dateText;
                    }
                    else
                    {
                        dateTimeText = dateText + " " + timeText;
                    }
                }
                else
                {
                    dateTimeText = dateText;
                }
                return dateTimeText;
            }
        }

        private string addLeadingZero(int value)
        {
            if (value < 10)
            {
                return "0" + value;
            }
            else
            {
                return value.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTimeLabel.Text = "Sample: " + formatDate(DateTime.Now);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            saveDateFormatToFile();
            Close();
        }

        private void changeSytemFormat(bool system)
        {
            this.system = system;
            systemRadioButton.Checked = system;
            customRadioButton.Checked = !system;
        }

        private void changeYearFormat(bool ymd, bool mdy, bool dmy, string value)
        {
            ymdRadioButton.Checked = ymd;
            mdyRadioButton.Checked = mdy;
            dmyRadioButton.Checked = dmy;
            dateOrder = value;
            changeSytemFormat(false);
        }

        private void changeDateTimeOrder(bool dateTime, bool timeDate, string value)
        {
            dtRadioButton.Checked = dateTime;
            tdRadioButton.Checked = timeDate;
            dateTimeOrder = value;
            changeSytemFormat(false);
        }

        private void changeDateSeperator(bool hyphen, bool slash, bool dot, string value)
        {
            hyphenRadioButton.Checked = hyphen;
            slashRadioButton.Checked = slash;
            dateSeperator = value;
            changeSytemFormat(false);
        }

        private void changeYearFormat(bool twoDigit, bool fourDigit, int value)
        {
            twoDigitRadioButton.Checked = twoDigit;
            fourDigitRadioButton.Checked = fourDigit;
            yearFormat = value;
            changeSytemFormat(false);
        }

        private void changeMonthFormat(bool number, bool word, string value)
        {
            monthNumberRadioButton.Checked = number;
            monthWordRadioButton.Checked = word;
            monthFormat = value;
            changeSytemFormat(false);
        }

        private void changeTimeFormat(bool _12hour, bool _24hour, int value)
        {
            _12hourRadioButton.Checked = _12hour;
            _24hourRadioButton.Checked = _24hour;
            timeFormat = value;
            changeSytemFormat(false);
        }

        // Checkboxes

        private void showYearCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            showYear = showYearCheckBox.Checked;
            changeSytemFormat(false);
        }

        private void showTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            showTime = showTimeCheckBox.Checked;
            changeSytemFormat(false);
        }

        private void showSecondsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            showSeconds = showSecondsCheckBox.Checked;
            changeSytemFormat(false);
        }

        // System Roadio Buttons

        private void systemRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (systemRadioButton.Checked)
            {
                changeSytemFormat(true);
            }
        }

        private void customRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (customRadioButton.Checked)
            {
                changeSytemFormat(false);
            }
        }

        // Date Order Radio Buttons

        private void ymdRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ymdRadioButton.Checked)
            {
                changeYearFormat(true, false, false, "YMD");
            }
        }

        private void mdyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mdyRadioButton.Checked)
            {
                changeYearFormat(false, true, false, "MDY");
            }
        }

        private void dmyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dmyRadioButton.Checked)
            {
                changeYearFormat(false, false, true, "DMY");
            }
            
        }
        // Date Time Order Radio Buttons

        private void dtRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dtRadioButton.Checked)
            {
                changeDateTimeOrder(true, false, "Date Time");
            }
        }

        private void tdRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (tdRadioButton.Checked)
            {
                changeDateTimeOrder(false, true, "Time Date");
            }
        }

        // Date Seperator Radio Buttons

        private void hyphenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (hyphenRadioButton.Checked)
            {
                changeDateSeperator(true, false, false, "-");
            }
        }

        private void slashRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (slashRadioButton.Checked)
            {
                changeDateSeperator(false, true, false, "/");
            }
        }

        private void dotRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dotRadioButton.Checked)
            {
                changeDateSeperator(false, false, true, ".");
            }
        }

        // Year Format Radio Buttons

        private void twoDigitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (twoDigitRadioButton.Checked)
            {
                changeYearFormat(true, false, 2);
            }
        }

        private void fourDigitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fourDigitRadioButton.Checked)
            {
                changeYearFormat(false, true, 4);
            }
        }

        // Month Format Radio Buttons

        private void monthNumberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (monthNumberRadioButton.Checked)
            {
                changeMonthFormat(true, false, "Number");
            }
        }

        private void monthWordRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (monthWordRadioButton.Checked)
            {
                changeMonthFormat(false, true, "Word");
            }
        }

        // Time Format Radio Buttons

        private void _12hourRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (_12hourRadioButton.Checked)
            {
                changeTimeFormat(true, false, 12);
            }
        }

        private void _24hourRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (_24hourRadioButton.Checked)
            {
                changeTimeFormat(false, true, 24);
            }
        }
    }
}
