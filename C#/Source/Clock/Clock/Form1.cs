using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        private Formatter formatter;
        private DateTime customDateTime = new DateTime();
        private DateTime lastDateTime = DateTime.Now;
        private bool loadedCustomFormat = false;

        private string[] customPresetNames = new string[0];
        private DateTimeFormat[] customPresets = new DateTimeFormat[0];

        public Form1()
        {
            try
            {
                formatter = new Formatter(new DateTimeFormat(System.IO.File.ReadAllLines("CurrentFormat.txt")));
                loadedCustomFormat = true;
            }
            catch
            {
                formatter = new Formatter(DateTimeFormat.ISO8601withSpace);
            }

           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (loadedCustomFormat)
            {
                checkBox_loadSettings.Checked = true;
            }
            comboBox_displayDate.SelectedIndex = 0;

            try
            {
                checkBox_showDateInTitle.Checked = bool.Parse(System.IO.File.ReadAllText("ShowDateTimeInTitle.txt"));
            }
            catch { }

            try
            {
                string[] lines = System.IO.File.ReadAllLines("CustomPresets.txt");
                for (int i = 0; i < lines.Length; i += 44)
                {
                    customPresetNames = customPresetNames.Concat(new string[] { lines[i] }).ToArray();
                    string[] preset = new string[43];
                    for (int j = 0; j < preset.Length; j++)
                    {
                        preset[j] = lines[i + j + 1];
                    }
                    customPresets = customPresets.Concat(new DateTimeFormat[] { new DateTimeFormat(preset) }).ToArray();
                }
                UpdatePresetsMenu();
            }
            catch { }

            UpdateChecks();
        }

        private void UpdatePresetsMenu()
        {
            // Remove existing custom presets from the menu
            while (toolStripMenuItem_presets.DropDownItems.Count > 14)
            {
                toolStripMenuItem_presets.DropDownItems.RemoveAt(14);
            }

            // Add all cutom presets to the menu
            for (int i = 0; i < customPresetNames.Length; i++)
            {
                ToolStripMenuItem newItem = new ToolStripMenuItem(customPresetNames[i]);
                newItem.Click += new EventHandler(CustomPresetClick);

                toolStripMenuItem_presets.DropDownItems.Add(newItem);
            }
        }

        private void CustomPresetClick(object sender, EventArgs e)
        {
            // Get the name of the custom preset that was clicked
            string presetName = ((ToolStripMenuItem)sender).Text;

            int index = -1;
            for (int i = 0; i < customPresetNames.Length; i++)
            {
                if (customPresetNames[i] == presetName)
                {
                    index = i;
                }
            }

            if (index == -1)
            {
                MessageBox.Show("An error has occurred ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                formatter.Format = customPresets[index];
                UpdateChecks();

            }
        }

        private void comboBox_displayDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_changeCustomDateTime.Visible = comboBox_displayDate.SelectedIndex == 1;

            // If the comb box is changed to "Enter custom date", bring up the "Enter date" form
            if (comboBox_displayDate.SelectedIndex == 1)
            {
                if (customDateTime == new DateTime())
                {
                    ShowCustomDateDialouge();
                    // The the "Enter date" for gets canceled, set the combo box back to "Display current date"
                    if (customDateTime == new DateTime())
                    {
                        comboBox_displayDate.SelectedIndex = 0;
                    }
                }
            } 
            
            UpdateDisplay();
        }

        private void ShowCustomDateDialouge()
        {
            EnterDateForm enterDate = new EnterDateForm(customDateTime);
            enterDate.ShowDialog();
            customDateTime = enterDate.DateTime;
        }

        private void ShowCustomMonthsDialouge()
        {
            CustomMonthNamesForm monthNamesForm = new CustomMonthNamesForm(formatter.Format.CustomMonths);
            monthNamesForm.ShowDialog();
            formatter.Format.CustomMonths = monthNamesForm.CustomMonths;
        }

        private void ShowCustomWeekdaysDialouge()
        {
            CustomWeekdayNamesForm weekdayNamesForm = new CustomWeekdayNamesForm(formatter.Format.CustomWeekdays);
            weekdayNamesForm.ShowDialog();
            formatter.Format.CustomWeekdays = weekdayNamesForm.CustomWeekdays;
        }

        private void button_customizeMonthFormat_Click(object sender, EventArgs e)
        {
            ShowCustomMonthsDialouge();
        }

        private void button_customizeWeekdayFormat_Click(object sender, EventArgs e)
        {
            ShowCustomWeekdaysDialouge();
        }

        private void UpdateDisplay()
        {
            lastDateTime = DateTime.Now;
            DateTime dateTime = comboBox_displayDate.SelectedIndex == 0 ? lastDateTime : customDateTime;
            string dateTimeOutput;
            try
            {
                dateTimeOutput = formatter.FormatDateTime(dateTime);
            }
            catch (InvalidDateTimeFormatException)
            {
                dateTimeOutput = "Invalid date/time format";
            }
            label_outputDateTime.Text = dateTimeOutput;

            // Center the output date/time in the window vertically
            label_outputDateTime.Location = new Point((Size.Width / 2) - (label_outputDateTime.Width / 2), label_outputDateTime.Location.Y);

            // Display the output date/time in the title bar if the option is checked
            if (checkBox_showDateInTitle.Checked)
            {
                Text = dateTimeOutput;
            }
        }

        private void toolStripMenuItem_presets_Click(object sender, EventArgs e)
        {

        }

        private void button_changeCustomDateTime_Click(object sender, EventArgs e)
        {
            ShowCustomDateDialouge();
        }

        private void EnableDisableAmPmOptions()
        {
            bool _24hour = radioButton_timeFormat_0_23.Checked || radioButton_timeFormat_1_24.Checked;
            groupBox_amPmFormat.Enabled = !_24hour;
            groupBox_amPmSep.Enabled = !_24hour;
        }

        private void checkBox_showDateInTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showDateInTitle.Checked)
            {
                UpdateDisplay();
            }
            else
            {
                Text = "Clock";
            }

            // Save checked state to file
            try
            {
                System.IO.File.WriteAllText("ShowDateTimeInTitle.txt", checkBox_showDateInTitle.Checked.ToString());
            }
            catch { }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (formatter.Format.ShowDateTime == 2)
            {
                {
                    if (lastDateTime.Day != DateTime.Now.Day)
                    {
                        UpdateDisplay();
                    }
                }
            }
            else
            {
                if (formatter.Format.ShowSeconds)
                {
                    if (lastDateTime.Second != DateTime.Now.Second)
                    {
                        UpdateDisplay();
                    }
                }
                else
                {
                    if (lastDateTime.Minute != DateTime.Now.Minute)
                    {
                        UpdateDisplay();
                    }
                }
            }
        }

        private void button_saveDateTimeToFile_Click(object sender, EventArgs e)
        {
            Formatter fileDateTimeFormatter = new Formatter(DateTimeFormat.SuitableForFilenames);
            string file;
            if (comboBox_displayDate.SelectedIndex == 0)
            {
                file = fileDateTimeFormatter.FormatDateTime(DateTime.Now) + ".txt";
            }
            else
            {
                file = "entered_" + fileDateTimeFormatter.FormatDateTime(customDateTime) + "_"
                    + "saved_" + fileDateTimeFormatter.FormatDateTime(DateTime.Now) + ".txt";
            }

            try
            {
                System.IO.File.WriteAllText(file, label_outputDateTime.Text);
                MessageBox.Show("Successfully saved the formatted date/time to\"" + file + "\".", "File Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Unable to save \"" + file + "\".", "Unable to Save File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_copyDateTime_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(label_outputDateTime.Text);
                MessageBox.Show("\"" + label_outputDateTime.Text + "\" has been copied to your clipboard.", "Date/Time Copied to Clipboard");
            }
            catch
            {
                MessageBox.Show("Unable to come date/time to clipboard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_savePreset_Click(object sender, EventArgs e)
        {
            SavePreset();
        }

        private void SavePreset()
        {
            PresetNameForm nameForm = new PresetNameForm();
            nameForm.ShowDialog();
            if (nameForm.PresetName != "")
            {
                foreach (string name in customPresetNames)
                {
                    if (nameForm.PresetName.ToLower() == name.ToLower())
                    {
                        DialogResult result = MessageBox.Show("A custom preset with the name \"" + name + "\" already exists. Do you want to replace it?",
                            "Replace existing preset?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            DeletePreset(nameForm.PresetName);
                        }
                        else
                        {
                            SavePreset();
                            return;
                        }
                    }
                }
                string[] currentPresetName = { nameForm.PresetName };
                customPresetNames = customPresetNames.Concat(currentPresetName).ToArray();

                DateTimeFormat[] currentPreset = { formatter.Format };
                customPresets = customPresets.Concat(currentPreset).ToArray();

                UpdatePresetsMenu();
                SavePresetsToFile();
            }
        }

        private void SavePresetsToFile()
        {
            string[] lines = new string[0];
            for (int i = 0; i < customPresetNames.Length; i++)
            {
                lines = lines.Concat(new string[] { customPresetNames[i] }).ToArray();
                lines = lines.Concat(customPresets[i].ToStringArray()).ToArray();
            }

            try
            {
                System.IO.File.WriteAllLines("CustomPresets.txt", lines);
            }
            catch { }
        }


        private void UpdateFormat()
        {
            UpdateDisplay();
            if (checkBox_loadSettings.Checked)
            {
                try
                {
                    System.IO.File.WriteAllLines("CurrentFormat.txt", formatter.Format.ToStringArray());
                }
                catch { }
            }
            
        }

        private void checkBox_loadSettings_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_loadSettings.Checked)
            {
                if (!loadedCustomFormat)
                {
                    UpdateFormat();
                }
            }
            else
            {
                loadedCustomFormat = false;
                try
                {
                    System.IO.File.Delete("CurrentFormat.txt");
                }
                catch { }
            }
        }

        private void button_deletePreset_Click(object sender, EventArgs e)
        {
            DeletePreset();
        }

        private void DeletePreset(string presetName = "")
        {
            bool showMessage = false;
            if (presetName == "")
            {
                PresetNameForm nameForm = new PresetNameForm();
                nameForm.ShowDialog();
                presetName = nameForm.PresetName;
                showMessage = true;
            }
            
            if (presetName != "")
            {
                int indexToDelete = -1;
                for (int i = 0; i < customPresetNames.Length; i++)
                {
                    if (customPresetNames[i].ToLower() == presetName.ToLower())
                    {
                        indexToDelete = i;
                    }
                }
                if (indexToDelete == -1)
                {
                    MessageBox.Show("There is no custom preset named \"" + presetName + "\".");
                    DeletePreset();
                }
                else
                {
                    string[] newPresetNames = new string[customPresetNames.Length - 1];
                    DateTimeFormat[] newPresets = new DateTimeFormat[customPresets.Length - 1];
                    for (int i = 0; i < indexToDelete; i++)
                    {
                        newPresetNames[i] = customPresetNames[i];
                        newPresets[i] = customPresets[i];
                    }
                    for (int i = indexToDelete + 1; i < customPresetNames.Length; i++)
                    {
                        newPresetNames[i - 1] = customPresetNames[i];
                        newPresets[i - 1] = customPresets[i];
                    }
                    customPresetNames = newPresetNames;
                    customPresets = newPresets;
                    
                    UpdatePresetsMenu();
                    SavePresetsToFile();

                    if (showMessage)
                    {
                        MessageBox.Show("Custom preset \"" + presetName + "\" deleted successfully.");
                    }
                }
            }
        }



        // Updates the radio buttons, checkboxes and text boxes to match the current date/time format
        private void UpdateChecks()
        {
            switch (formatter.Format.ShowDateTime)
            {
                case 0: radioButton_dateThenTime.Checked = true; break;
                case 1: radioButton_timeThenDate.Checked = true; break;
                case 2: radioButton_dateOnly.Checked = true; break;
                case 3: radioButton_timeOnly.Checked = true; break;
            }

            switch (formatter.Format.DateTimeSep)
            {
                case " ": radioButton_dateTimeSep_space.Checked = true; break;
                case ", ": radioButton_dateTimeSep_commaSpace.Checked = true; break;
                case "T": radioButton_dateTimeSep_t.Checked = true; break;
                case "_": radioButton_dateTimeSep_underscore.Checked = true; break;
                case "-": radioButton_dateTimeSep_hyphen.Checked = true; break;
                case ".": radioButton_dateTimeSep_dot.Checked = true; break;
                case "": radioButton_dateTimeSep_none.Checked = true; break;
                default:
                    textBox_dateTimeSep_custom.Text = formatter.Format.DateTimeSep;
                    radioButton_dateTimeSep_custom.Checked = true;
                    break;
            }

            switch (formatter.Format.DateOrder)
            {
                case "YMD": radioButton_ymd.Checked = true; break;
                case "DMY": radioButton_dmy.Checked = true; break;
                case "MDY": radioButton_mdy.Checked = true; break;
            }

            switch (formatter.Format.YearDigits)
            {
                case 4: radioButton_year4digit.Checked = true; break;
                case 2: radioButton_year2digit.Checked = true; break;
            }

            switch (formatter.Format.MonthFormat)
            {
                case 0: radioButton_monthFormat_withoutLeadingZero.Checked = true; break;
                case 1: radioButton_monthFormat_withLeadingZero.Checked = true; break;
                case 2: radioButton_monthFormat_3letter.Checked = true; break;
                case 3: radioButton_monthFormat_full.Checked = true; break;
                case 4: radioButton_monthFormat_custom.Checked = true; break;
            }

            switch (formatter.Format.DayFomrat)
            {
                case 0: radioButton_dayFormat_withoutLeadingZero.Checked = true; break;
                case 1: radioButton_dayFormat_withLeadingZero.Checked = true; break;
                case 2: radioButton_dayFormat_ordinal.Checked = true; break;
            }

            switch (formatter.Format.DateSep1)
            {
                case "-": radioButton_dateSep1_hyphen.Checked = true; break;
                case ".": radioButton_dateSep1_dot.Checked = true; break;
                case "/": radioButton_dateSep1_slash.Checked = true; break;
                case " ": radioButton_dateSep1_space.Checked = true; break;
                case ", ": radioButton_dateSep1_commaSpace.Checked = true; break;
                case ". ": radioButton_dateSep1_dotSpace.Checked = true; break;
                case "": radioButton_dateSep1_none.Checked = true; break;
                case "_": radioButton_dateSep1_underscore.Checked = true; break;
                default:
                    textBox_dateSep1_custom.Text = formatter.Format.DateSep1;
                    radioButton_dateSep1_custom.Checked = true;
                    break;
            }

            checkBox_dateSep2_sameAsDateSep1.Checked = formatter.Format.DateSep1sameAsDateSep2;

            switch (formatter.Format.DateSep2)
            {
                case "-": radioButton_dateSep2_hyphen.Checked = true; break;
                case ".": radioButton_dateSep2_dot.Checked = true; break;
                case "/": radioButton_dateSep2_slash.Checked = true; break;
                case " ": radioButton_dateSep2_space.Checked = true; break;
                case ", ": radioButton_dateSep2_commaSpace.Checked = true; break;
                case ". ": radioButton_dateSep2_dotSpace.Checked = true; break;
                case "": radioButton_dateSep2_none.Checked = true; break;
                case "_": radioButton_dateSep2_underscore.Checked = true; break;
                default:
                    textBox_dateSep2_custom.Text = formatter.Format.DateSep2;
                    radioButton_dateSep2_custom.Checked = true;
                    break;
            }

            switch (formatter.Format.DateEndChar)
            {
                case "": radioButton_dateEndChar_none.Checked = true; break;
                case ".": radioButton_dateEndChar_dot.Checked = true; break;
                default:
                    textBox_dateEndChar_custom.Text = formatter.Format.DateEndChar;
                    radioButton_dateEndChar_custom.Checked = true;
                    break;
            }

            switch (formatter.Format.Weekday)
            {
                case 0:
                    switch (formatter.Format.DateOrder)
                    {
                        case "YMD":
                            radioButton_weekdayAfterDate.Checked = true;
                            break;
                        case "DMY":
                        case "MDY":
                            radioButton_weekdayBeforeDate.Checked = true;
                            break;
                    }
                    checkBox_showWeekday.Checked = false;
                    break;
                case 1:
                    radioButton_weekdayBeforeDate.Checked = true;
                    checkBox_showWeekday.Checked = true;
                    break;
                case 2:
                    radioButton_weekdayAfterDate.Checked = true;
                    checkBox_showWeekday.Checked = true;
                    break;
            }

            switch (formatter.Format.WeekdayFormat)
            {
                case 0: radioButton_weekday_3letter.Checked = true; break;
                case 1: radioButton_weekdayFull.Checked = true; break;
                case 2: radioButton_customWeekday.Checked = true; break;
            }

            switch (formatter.Format.WeekdaySep)
            {
                case " ": radioButton_weekdaySep_space.Checked = true; break;
                case ", ": radioButton_weekdaySep_commaSpace.Checked = true; break;
                case ". ": radioButton_weekdaySep_dotSpace.Checked = true; break;
                case "-": radioButton_weekdaySep_hyphen.Checked = true; break;
                case ".": radioButton_weekdaySep_dot.Checked = true; break;
                case "": radioButton_weekdaySep_none.Checked = true; break;
                case "_": radioButton_weekdaySep_underscore.Checked = true; break;
                default:
                    textBox_weekdaySep_custom.Text = formatter.Format.WeekdaySep;
                    radioButton_weekdaySep_custom.Checked = true;
                    break;
            }

            switch (formatter.Format.TimeFormat)
            {
                case 0: radioButton_timeFormat_0_23.Checked = true; break;
                case 1: radioButton_timeFormat_1_24.Checked = true; break;
                case 2: radioButton_timeFormat_0_11amPmFirst.Checked = true; break;
                case 3: radioButton_timeFormat_0_11amPmLast.Checked = true; break;
                case 4: radioButton_timeFormat_1_12amPmFirst.Checked = true; break;
                case 5: radioButton_timeFormat_1_12amPmLast.Checked = true; break;
            }

            checkBox_zeroPadHour.Checked = formatter.Format.ZeroPadHour;

            checkBox_showSeconds.Checked = formatter.Format.ShowSeconds;

            if (formatter.Format.AmFormat == "AM" && formatter.Format.PmFormat == "PM")
            {
                radioButton_amPmCapital.Checked = true;
            }
            else if (formatter.Format.AmFormat == "am" && formatter.Format.PmFormat == "pm")
            {
                radioButton_amPmLowercase.Checked = true;
            }
            else if (formatter.Format.AmFormat == "A.M." && formatter.Format.PmFormat == "P.M.")
            {
                radioButton_amPmCapitalDots.Checked = true;
            }
            else if (formatter.Format.AmFormat == "a.m." && formatter.Format.PmFormat == "p.m.")
            {
                radioButton_amPmLowercaseDots.Checked = true;
            }
            else if (formatter.Format.AmFormat == "A" && formatter.Format.PmFormat == "P")
            {
                radioButton_ap_capital.Checked = true;
            }
            else if (formatter.Format.AmFormat == "a" && formatter.Format.PmFormat == "p")
            {
                radioButton_ap_lowercase.Checked = true;
            }
            else
            {  
                textBox_amCustom.Text = formatter.Format.AmFormat;
                textBox_pmCustom.Text = formatter.Format.PmFormat;
                radioButton_amPmCustom.Checked = true;
            }

            switch (formatter.Format.HourMinSep)
            {
                case ":": radioButton_hrMinSep_colon.Checked = true; break;
                case ".": radioButton_hrMinSep_dot.Checked = true; break;
                case "-": radioButton_hrMinSep_hyphen.Checked = true; break;
                case " ": radioButton_hrMinSep_space.Checked = true; break;
                case "": radioButton_hrMinSep_none.Checked = true; break;
                default:
                    textBox_hrMinSep_custom.Text = formatter.Format.HourMinSep;
                    radioButton_hrMinSep_custom.Checked = true;
                    break;
            }

            checkBox_minSecSep_sameAsHrMin.Checked = formatter.Format.MinSecSepSameAsHourMinSep;

            switch (formatter.Format.MinSecSep)
            {
                case ":": radioButton_minSecSep_colon.Checked = true; break;
                case ".": radioButton_minSecSep_dot.Checked = true; break;
                case "-": radioButton_minSecSep_hyphen.Checked = true; break;
                case " ": radioButton_minSecSep_space.Checked = true; break;
                case "": radioButton_minSecSep_none.Checked = true; break;
                default:
                    textBox_minSecSep_custom.Text = formatter.Format.MinSecSep;
                    radioButton_minSecSep_custom.Checked = true;
                    break;
            }

            switch (formatter.Format.TimeAmPmSep)
            {
                case " ": radioButton_amPmSep_space.Checked = true; break;
                case "": radioButton_amPmSep_none.Checked = true; break;
                case "_": radioButton_amPmSep_underscore.Checked = true; break;
                case ".": radioButton_amPmSep_dot.Checked = true; break;
                default:
                    textBox_amPmSep_custom.Text = formatter.Format.TimeAmPmSep;
                    radioButton_amPmSep_custom.Checked = true;
                    break;
            }

            UpdateDisplay();

        }


        // Presets

        private void toolStripMenuItem_ISOwithSpace_Click(object sender, EventArgs e)
        {
            formatter.Format = DateTimeFormat.ISO8601withSpace;
            UpdateChecks();
        }

        private void toolStripMenuItem_ISOwithT_Click(object sender, EventArgs e)
        {
            formatter.Format = DateTimeFormat.ISO8601withT;
            UpdateChecks();
        }

        private void toolStripMenuItem_suitableForFilenames_Click(object sender, EventArgs e)
        {
            formatter.Format = DateTimeFormat.SuitableForFilenames;
            UpdateChecks();
        }

        private void toolStripMenuItem_europeanShort_Click(object sender, EventArgs e)
        {
            formatter.Format = DateTimeFormat.EuropeanShort;
            UpdateChecks();
        }

        private void toolStripMenuItem_europeanNumerical_Click(object sender, EventArgs e)
        {
            formatter.Format = DateTimeFormat.EuropeanNumerical;
            UpdateChecks();
        }

        private void toolStripMenuItem_britishMedium_Click(object sender, EventArgs e)
        {
            formatter.Format = DateTimeFormat.BritishMedium;
            UpdateChecks();
        }

        private void toolStripMenuItem_britishFull_Click(object sender, EventArgs e)
        {
            formatter.Format = DateTimeFormat.BritishFull;
            UpdateChecks();
        }

        private void toolStripMenuItem_americanShort_Click(object sender, EventArgs e)
        {
            formatter.Format = DateTimeFormat.AmericanShort;
            UpdateChecks();
        }

        private void toolStripMenuItem_americanNumerical_Click(object sender, EventArgs e)
        {
            formatter.Format = DateTimeFormat.AmericanNumerical;
            UpdateChecks();
        }

        private void toolStripMenuItem_americanMedium_Click(object sender, EventArgs e)
        {
            formatter.Format = DateTimeFormat.AmericanMedium;
            UpdateChecks();
        }

        private void toolStripMenuItem_americanFull_Click(object sender, EventArgs e)
        {
            formatter.Format = DateTimeFormat.AmericanFull;
            UpdateChecks();
        }

        private void toolStripMenuItem_chinese_Click(object sender, EventArgs e)
        {
            formatter.Format = DateTimeFormat.Chinese;
            formatter.Format.CustomWeekdays = DateTimeFormat.ChineseWeekdayNames;
            UpdateChecks();
        }

        private void toolStripMenuItem_hungarian_Click(object sender, EventArgs e)
        {
            formatter.Format = DateTimeFormat.Hungarian;
            formatter.Format.CustomMonths = DateTimeFormat.HungarianMonthNames;
            formatter.Format.CustomWeekdays = DateTimeFormat.HungarianWeekdayNames;
            UpdateChecks();
        }

        private void toolStripMenuItem_vietnamese_Click(object sender, EventArgs e)
        {
            formatter.Format = DateTimeFormat.Vietnamese;
            formatter.Format.CustomWeekdays = DateTimeFormat.VietnameseWeekdayNames;
            UpdateChecks();
        }


        // "Show date/time" group

        private void radioButton_dateThenTime_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateThenTime.Checked)
            {
                formatter.Format.ShowDateTime = 0;
                UpdateFormat();
            }
        }

        private void radioButton_timeThenDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_timeThenDate.Checked)
            {
                formatter.Format.ShowDateTime = 1;
                UpdateFormat();
            }
        }

        private void radioButton_dateOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateOnly.Checked)
            {
                formatter.Format.ShowDateTime = 2;
                UpdateFormat();
            }
            groupBox_time.Enabled = !radioButton_dateOnly.Checked;
        }

        private void radioButton_timeOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_timeOnly.Checked)
            {
                formatter.Format.ShowDateTime = 3;
                UpdateFormat();
            }
            groupBox_date.Enabled = !radioButton_timeOnly.Checked;
        }
       

        // Date-time seperator

        private void radioButton_dateTimeSep_space_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateTimeSep_space.Checked)
            {
                formatter.Format.DateTimeSep = " ";
                UpdateFormat();
            }
        }

        private void radioButton_dateTimeSep_commaSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateTimeSep_commaSpace.Checked)
            {
                formatter.Format.DateTimeSep = ", ";
                UpdateFormat();
            }
        }

        private void radioButton_dateTimeSep_t_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateTimeSep_t.Checked)
            {
                formatter.Format.DateTimeSep = "T";
                UpdateFormat();
            }
        }

        private void radioButton_dateTimeSep_underscore_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateTimeSep_underscore.Checked)
            {
                formatter.Format.DateTimeSep = "_";
                UpdateFormat();
            }
        }

        private void radioButton_dateTimeSep_hyphen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateTimeSep_hyphen.Checked)
            {
                formatter.Format.DateTimeSep = "-";
                UpdateFormat();
            }
        }

        private void radioButton_dateTimeSep_dot_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateTimeSep_dot.Checked)
            {
                formatter.Format.DateTimeSep = ".";
                UpdateFormat();
            }
        }

        private void radioButton_dateTimeSep_none_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateTimeSep_none.Checked)
            {
                formatter.Format.DateTimeSep = "";
                UpdateFormat();
            }
        }

        private void radioButton_dateTimeSep_custom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateTimeSep_custom.Checked)
            {
                formatter.Format.DateTimeSep = textBox_dateTimeSep_custom.Text;
                UpdateFormat();
            }
            textBox_dateTimeSep_custom.Enabled = radioButton_dateTimeSep_custom.Checked;
        }

        private void textBox_dateTimeSep_custom_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_dateTimeSep_custom.Checked)
            {
                formatter.Format.DateTimeSep = textBox_dateTimeSep_custom.Text;
                UpdateFormat();
            }
        }


        // "Date order" group

        private void radioButton_ymd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ymd.Checked)
            {
                formatter.Format.DateOrder = "YMD";
                if (!checkBox_showWeekday.Checked)
                {
                    radioButton_weekdayAfterDate.Checked = true;
                }
                UpdateFormat();
            }
        }

        private void radioButton_dmy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dmy.Checked)
            {
                formatter.Format.DateOrder = "DMY";
                if (!checkBox_showWeekday.Checked)
                {
                    radioButton_weekdayBeforeDate.Checked = true;
                }
                UpdateFormat();
            }
        }

        private void radioButton_mdy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_mdy.Checked)
            {
                formatter.Format.DateOrder = "MDY";
                if (!checkBox_showWeekday.Checked)
                {
                    radioButton_weekdayBeforeDate.Checked = true;
                }
                UpdateFormat();
            }
        }


        // Year format

        private void radioButton_year2digit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_year2digit.Checked)
            {
                formatter.Format.YearDigits = 2;
                UpdateFormat();
            }
        }

        private void radioButton_year4digit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_year4digit.Checked)
            {
                formatter.Format.YearDigits = 4;
                UpdateFormat();
            }
        }


        // Month format

        private void radioButton_monthFormat_withoutLeadingZero_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_monthFormat_withoutLeadingZero.Checked)
            {
                formatter.Format.MonthFormat = 0;
                UpdateFormat();
            }
        }

        private void radioButton_monthFormat_withLeadingZero_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_monthFormat_withLeadingZero.Checked)
            {
                formatter.Format.MonthFormat = 1;
                UpdateFormat();
            }
        }

        private void radioButton_monthFormat_3letter_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_monthFormat_3letter.Checked)
            {
                formatter.Format.MonthFormat = 2;
                UpdateFormat();
            }
        }

        private void radioButton_monthFormat_full_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_monthFormat_full.Checked)
            {
                formatter.Format.MonthFormat = 3;
                UpdateFormat();
            }
        }

        private void radioButton_monthFormat_custom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_monthFormat_custom.Checked)
            {
                if (formatter.Format.CustomMonths[0] == null)
                {
                    ShowCustomMonthsDialouge();
                }
                if (formatter.Format.CustomMonths[0] == null)
                {
                    UpdateChecks();
                }
                else
                {
                    formatter.Format.MonthFormat = 4;
                }
                UpdateFormat();
            }
            button_customizeMonthFormat.Enabled = radioButton_monthFormat_custom.Checked;
        }


        // Day format

        private void radioButton_dayFormat_withoutLeadingZero_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dayFormat_withoutLeadingZero.Checked)
            {
                formatter.Format.DayFomrat = 0;
                UpdateFormat();
            }
        }

        private void radioButton_dayFormat_withLeadingZero_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dayFormat_withLeadingZero.Checked)
            {
                formatter.Format.DayFomrat = 1;
                UpdateFormat();
            }
        }

        private void radioButton_dayFormat_ordinal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dayFormat_ordinal.Checked)
            {
                formatter.Format.DayFomrat = 2;
                UpdateFormat();
            }
        }


        // Date seperator 1

        private void radioButton_dateSep1_hyphen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep1_hyphen.Checked)
            {
                formatter.Format.DateSep1 = "-";
                UpdateFormat();
            }
        }

        private void radioButton_dateSep1_dot_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep1_dot.Checked)
            {
                formatter.Format.DateSep1 = ".";
                UpdateFormat();
            }
        }

        private void radioButton_dateSep1_slash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep1_slash.Checked)
            {
                formatter.Format.DateSep1 = "/";
                UpdateFormat();
            }
        }

        private void radioButton_dateSep1_space_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep1_space.Checked)
            {
                formatter.Format.DateSep1 = " ";
                UpdateFormat();
            }
        }

        private void radioButton_dateSep1_commaSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep1_commaSpace.Checked)
            {
                formatter.Format.DateSep1 = ", ";
                UpdateFormat();
            }
        }

        private void radioButton_dateSep1_dotSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep1_dotSpace.Checked)
            {
                formatter.Format.DateSep1 = ". ";
                UpdateFormat();
            }
        }

        private void radioButton_dateSep1_none_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep1_none.Checked)
            {
                formatter.Format.DateSep1 = "";
                UpdateFormat();
            }
        }

        private void radioButton_dateSep1_underscore_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep1_underscore.Checked)
            {
                formatter.Format.DateSep1 = "_";
                UpdateFormat();
            }
        }

        private void radioButton_dateSep1_custom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep1_custom.Checked)
            {
                formatter.Format.DateSep1 = textBox_dateSep1_custom.Text;
                UpdateFormat();
            }
            textBox_dateSep1_custom.Enabled = radioButton_dateSep1_custom.Checked;
        }

        private void textBox_dateSep1_custom_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep1_custom.Checked)
            {
                formatter.Format.DateSep1 = textBox_dateSep1_custom.Text;
                UpdateFormat();
            }
        }


        // Date seperator 2

        private void checkBox_dateSep2_sameAsDateSep1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_dateSep2_custom.Enabled = !checkBox_dateSep2_sameAsDateSep1.Checked && radioButton_dateSep2_custom.Checked;
            radioButton_dateSep2_hyphen.Enabled = !checkBox_dateSep2_sameAsDateSep1.Checked;
            radioButton_dateSep2_dot.Enabled = !checkBox_dateSep2_sameAsDateSep1.Checked;
            radioButton_dateSep2_slash.Enabled = !checkBox_dateSep2_sameAsDateSep1.Checked;
            radioButton_dateSep2_space.Enabled = !checkBox_dateSep2_sameAsDateSep1.Checked;
            radioButton_dateSep2_commaSpace.Enabled = !checkBox_dateSep2_sameAsDateSep1.Checked;
            radioButton_dateSep2_dotSpace.Enabled = !checkBox_dateSep2_sameAsDateSep1.Checked;
            radioButton_dateSep2_none.Enabled = !checkBox_dateSep2_sameAsDateSep1.Checked;
            radioButton_dateSep2_underscore.Enabled = !checkBox_dateSep2_sameAsDateSep1.Checked;
            radioButton_dateSep2_custom.Enabled = !checkBox_dateSep2_sameAsDateSep1.Checked;
            formatter.Format.DateSep1sameAsDateSep2 = checkBox_dateSep2_sameAsDateSep1.Checked;
            UpdateFormat();
        }

        private void radioButton_dateSep2_hyphen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep2_hyphen.Checked)
            {
                formatter.Format.DateSep2 = "-";
                UpdateFormat();
            }
        }

        private void radioButton_dateSep2_dot_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep2_dot.Checked)
            {
                formatter.Format.DateSep2 = ".";
                UpdateFormat();
            }
        }

        private void radioButton_dateSep2_slash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep2_slash.Checked)
            {
                formatter.Format.DateSep2 = "/";
                UpdateFormat();
            }
        }

        private void radioButton_dateSep2_space_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep2_space.Checked)
            {
                formatter.Format.DateSep2 = " ";
                UpdateFormat();
            }
        }

        private void radioButton_dateSep2_commaSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep2_commaSpace.Checked)
            {
                formatter.Format.DateSep2 = ", ";
                UpdateFormat();
            }
        }

        private void radioButton_dateSep2_dotSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep2_dotSpace.Checked)
            {
                formatter.Format.DateSep2 = ". ";
                UpdateFormat();
            }
        }

        private void radioButton_dateSep2_none_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep2_none.Checked)
            {
                formatter.Format.DateSep2 = "";
                UpdateFormat();
            }
        }

        private void radioButton_dateSep2_underscore_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep2_underscore.Checked)
            {
                formatter.Format.DateSep2 = "_";
                UpdateFormat();
            }
        }

        private void radioButton_dateSep2_custom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep2_custom.Checked)
            {
                formatter.Format.DateSep2 = textBox_dateSep2_custom.Text;
                UpdateFormat();
            }
            textBox_dateSep2_custom.Enabled = radioButton_dateSep2_custom.Checked;
        }

        private void textBox_dateSep2_custom_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_dateSep2_custom.Checked)
            {
                formatter.Format.DateSep2 = textBox_dateSep2_custom.Text;
                UpdateFormat();
            }
        }


        // Date end char

        private void radioButton_dateEndChar_none_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateEndChar_none.Checked)
            {
                formatter.Format.DateEndChar = "";
                UpdateFormat();
            }
        }

        private void radioButton_dateEndChar_dot_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateEndChar_dot.Checked)
            {
                formatter.Format.DateEndChar = ".";
                UpdateFormat();
            }
        }

        private void radioButton_dateEndChar_custom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dateEndChar_custom.Checked)
            {
                formatter.Format.DateEndChar = textBox_dateEndChar_custom.Text;
                UpdateFormat();
            }
            textBox_dateEndChar_custom.Enabled = radioButton_dateEndChar_custom.Checked;
        }

        private void textBox_dateEndChar_custom_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_dateEndChar_custom.Checked)
            {
                formatter.Format.DateEndChar = textBox_dateEndChar_custom.Text;
                UpdateFormat();
            }
        }


        // Weekday

        private void checkBox_showWeekday_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showWeekday.Checked)
            {
                formatter.Format.Weekday = radioButton_weekdayBeforeDate.Checked ? 1 : 2;
            }
            else
            {
                formatter.Format.Weekday = 0;
            }
            radioButton_weekdayBeforeDate.Enabled = checkBox_showWeekday.Checked;
            radioButton_weekdayAfterDate.Enabled = checkBox_showWeekday.Checked;
            groupBox_weekdayFormat.Enabled = checkBox_showWeekday.Checked;
            groupBox_weekdaySep.Enabled = checkBox_showWeekday.Checked;
            UpdateFormat();
        }

        private void radioButton_weekdayBeforeDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_weekdayBeforeDate.Checked)
            {
                if (radioButton_weekdayBeforeDate.Enabled = checkBox_showWeekday.Checked)
                {
                    formatter.Format.Weekday = 1;
                    UpdateFormat();
                }
            }
        }

        private void radioButton_weekdayAfterDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_weekdayAfterDate.Checked)
            {
                if (radioButton_weekdayAfterDate.Enabled = checkBox_showWeekday.Checked)
                {
                    formatter.Format.Weekday = 2;
                    UpdateFormat();
                }
            }
        }


        // Weekday format

        private void radioButton_weekday_3letter_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_weekday_3letter.Checked)
            {
                formatter.Format.WeekdayFormat = 0;
                UpdateFormat();
            }
        }

        private void radioButton_wekdayFull_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_weekdayFull.Checked)
            {
                formatter.Format.WeekdayFormat = 1;
                UpdateFormat();
            }
        }

        private void radioButton_customWeekday_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_customWeekday.Checked)
            {
                if (formatter.Format.CustomWeekdays[0] == null)
                {
                    ShowCustomWeekdaysDialouge();
                }
                if (formatter.Format.CustomWeekdays[0] == null)
                {
                    UpdateChecks();
                }
                else
                {
                    formatter.Format.WeekdayFormat = 2;
                }
                UpdateFormat();
            }
            button_customizeWeekdayFormat.Enabled = radioButton_customWeekday.Checked;
        }


        // Weekday seperator

        private void radioButton_weekdaySep_space_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_weekdaySep_space.Checked)
            {
                formatter.Format.WeekdaySep = " ";
                UpdateFormat();
            }
        }

        private void radioButton_weekdaySep_commaSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_weekdaySep_commaSpace.Checked)
            {
                formatter.Format.WeekdaySep = ", ";
                UpdateFormat();
            }
        }

        private void radioButton_weekdaySep_dotSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_weekdaySep_dotSpace.Checked)
            {
                formatter.Format.WeekdaySep = ". ";
                UpdateFormat();
            }
        }

        private void radioButton_weekdaySep_hyphen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_weekdaySep_hyphen.Checked)
            {
                formatter.Format.WeekdaySep = "-";
                UpdateFormat();
            }
        }

        private void radioButton_weekdaySep_dot_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_weekdaySep_dot.Checked)
            {
                formatter.Format.WeekdaySep = ".";
                UpdateFormat();
            }
        }

        private void radioButton_weekdaySep_none_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_weekdaySep_none.Checked)
            {
                formatter.Format.WeekdaySep = "";
                UpdateFormat();
            }
        }

        private void radioButton_weekdaySep_underscore_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_weekdaySep_underscore.Checked)
            {
                formatter.Format.WeekdaySep = "_";
                UpdateFormat();
            }
        }

        private void radioButton_weekdaySep_custom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_weekdaySep_custom.Checked)
            {
                formatter.Format.WeekdaySep = textBox_weekdaySep_custom.Text;
                UpdateFormat();
            }
            textBox_weekdaySep_custom.Enabled = radioButton_weekdaySep_custom.Checked;
        }

        private void textBox_weekdaySep_custom_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_weekdaySep_custom.Checked)
            {
                formatter.Format.WeekdaySep = textBox_weekdaySep_custom.Text;
                UpdateFormat();
            }
        }


        // Time format

        private void radioButton_timeFormat_0_23_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_timeFormat_0_23.Checked)
            {
                formatter.Format.TimeFormat = 0;
                UpdateFormat();
            }
            EnableDisableAmPmOptions();
        }

        private void radioButton_timeFormat_1_24_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_timeFormat_1_24.Checked)
            {
                formatter.Format.TimeFormat = 1;
                UpdateFormat();
            }
            EnableDisableAmPmOptions();
        }

        private void radioButton_timeFormat_0_11amPmFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_timeFormat_0_11amPmFirst.Checked)
            {
                formatter.Format.TimeFormat = 2;
                UpdateFormat();
            }
        }

        private void radioButton_timeFormat_0_11amPmLast_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_timeFormat_0_11amPmLast.Checked)
            {
                formatter.Format.TimeFormat = 3;
                UpdateFormat();
            }
        }

        private void radioButton_timeFormat_1_12amPmFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_timeFormat_1_12amPmFirst.Checked)
            {
                formatter.Format.TimeFormat = 4;
                UpdateFormat();
            }
        }

        private void radioButton_timeFormat_1_12amPmLast_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_timeFormat_1_12amPmLast.Checked)
            {
                formatter.Format.TimeFormat = 5;
                UpdateFormat();
            }
        }

        private void checkBox_zeroPadHour_CheckedChanged(object sender, EventArgs e)
        {
            formatter.Format.ZeroPadHour = checkBox_zeroPadHour.Checked;
            UpdateFormat();
        }

        private void checkBox_showSeconds_CheckedChanged(object sender, EventArgs e)
        {
            formatter.Format.ShowSeconds = checkBox_showSeconds.Checked;
            UpdateFormat();
            groupBox_minSecSep.Enabled = checkBox_showSeconds.Checked;
        }


        // AM/PM format

        private void radioButton_amPmCapital_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_amPmCapital.Checked)
            {
                formatter.Format.AmFormat = "AM";
                formatter.Format.PmFormat = "PM";
                UpdateFormat();
            }
        }

        private void radioButton_amPmLowercase_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_amPmLowercase.Checked)
            {
                formatter.Format.AmFormat = "am";
                formatter.Format.PmFormat = "pm";
                UpdateFormat();
            }
        }

        private void radioButton_amPmCapitalDots_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_amPmCapitalDots.Checked)
            {
                formatter.Format.AmFormat = "A.M.";
                formatter.Format.PmFormat = "P.M.";
                UpdateFormat();
            }
        }

        private void radioButton_amPmLowercaseDots_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_amPmLowercaseDots.Checked)
            {
                formatter.Format.AmFormat = "a.m.";
                formatter.Format.PmFormat = "p.m.";
                UpdateFormat();
            }
        }

        private void radioButton_ap_capital_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ap_capital.Checked)
            {
                formatter.Format.AmFormat = "A";
                formatter.Format.PmFormat = "P";
                UpdateFormat();
            }
        }

        private void radioButton_ap_lowercase_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ap_lowercase.Checked)
            {
                formatter.Format.AmFormat = "a";
                formatter.Format.PmFormat = "p";
                UpdateFormat();
            }
        }

        private void radioButton_amPmCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_amPmCustom.Checked)
            {
                formatter.Format.AmFormat = textBox_amCustom.Text;
                formatter.Format.PmFormat = textBox_pmCustom.Text;
                UpdateFormat();
            }
            textBox_amCustom.Enabled = radioButton_amPmCustom.Checked;
            textBox_pmCustom.Enabled = radioButton_amPmCustom.Checked;
        }

        private void textBox_amCustom_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_amPmCustom.Checked)
            {
                formatter.Format.AmFormat = textBox_amCustom.Text;
                formatter.Format.PmFormat = textBox_pmCustom.Text;
                UpdateFormat();
            }
        }

        private void textBox_pmCustom_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_amPmCustom.Checked)
            {
                formatter.Format.AmFormat = textBox_amCustom.Text;
                formatter.Format.PmFormat = textBox_pmCustom.Text;
                UpdateFormat();
            }
        }


        // Hour-minute seperator

        private void radioButton_hrMinSep_colon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_hrMinSep_colon.Checked)
            {
                formatter.Format.HourMinSep = ":";
                UpdateFormat();
            }
        }

        private void radioButton_hrMinSep_dot_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_hrMinSep_dot.Checked)
            {
                formatter.Format.HourMinSep = ".";
                UpdateFormat();
            }
        }

        private void radioButton_hrMinSep_hyphen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_hrMinSep_hyphen.Checked)
            {
                formatter.Format.HourMinSep = "-";
                UpdateFormat();
            }
        }

        private void radioButton_hrMinSep_space_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_hrMinSep_space.Checked)
            {
                formatter.Format.HourMinSep = " ";
                UpdateFormat();
            }
        }

        private void radioButton_hrMinSep_none_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_hrMinSep_none.Checked)
            {
                formatter.Format.HourMinSep = "";
                UpdateFormat();
            }
        }

        private void radioButton_hrMinSep_custom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_hrMinSep_custom.Checked)
            {
                formatter.Format.HourMinSep = textBox_hrMinSep_custom.Text;
                UpdateFormat();
            }
            textBox_hrMinSep_custom.Enabled = radioButton_hrMinSep_custom.Checked;
        }

        private void textBox_hrMinSep_custom_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_hrMinSep_custom.Checked)
            {
                formatter.Format.HourMinSep = textBox_hrMinSep_custom.Text;
                UpdateFormat();
            }
        }


        // Minute-second seperator

        private void checkBox_minSecSep_sameAsHrMin_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_minSecSep_colon.Enabled = !checkBox_minSecSep_sameAsHrMin.Checked;
            radioButton_minSecSep_dot.Enabled = !checkBox_minSecSep_sameAsHrMin.Checked;
            radioButton_minSecSep_hyphen.Enabled = !checkBox_minSecSep_sameAsHrMin.Checked;
            radioButton_minSecSep_space.Enabled = !checkBox_minSecSep_sameAsHrMin.Checked;
            radioButton_minSecSep_none.Enabled = !checkBox_minSecSep_sameAsHrMin.Checked;
            radioButton_minSecSep_custom.Enabled = !checkBox_minSecSep_sameAsHrMin.Checked;
            textBox_minSecSep_custom.Enabled = !checkBox_minSecSep_sameAsHrMin.Checked && radioButton_minSecSep_custom.Checked;
            formatter.Format.MinSecSepSameAsHourMinSep = checkBox_minSecSep_sameAsHrMin.Checked;
            UpdateFormat();
        }

        private void radioButton_minSecSep_colon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_minSecSep_colon.Checked)
            {
                formatter.Format.MinSecSep = ":";
                UpdateFormat();
            }
        }

        private void radioButton_minSecSep_dot_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_minSecSep_dot.Checked)
            {
                formatter.Format.MinSecSep = ".";
                UpdateFormat();
            }
        }

        private void radioButton_minSecSep_hyphen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_minSecSep_hyphen.Checked)
            {
                formatter.Format.MinSecSep = "-";
                UpdateFormat();
            }
        }

        private void radioButton_minSecSep_space_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_minSecSep_space.Checked)
            {
                formatter.Format.MinSecSep = " ";
                UpdateFormat();
            }
        }

        private void radioButton_minSecSep_none_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_minSecSep_none.Checked)
            {
                formatter.Format.MinSecSep = "";
                UpdateFormat();
            }
        }

        private void radioButton_minSecSep_custom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_minSecSep_custom.Checked)
            {
                formatter.Format.MinSecSep = textBox_minSecSep_custom.Text;
                UpdateFormat();
            }
            textBox_minSecSep_custom.Enabled = radioButton_minSecSep_custom.Checked;
        }

        private void textBox_minSecSep_custom_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_minSecSep_custom.Checked)
            {
                formatter.Format.MinSecSep = textBox_minSecSep_custom.Text;
                UpdateFormat();
            }
        }


        // Time-AM/PM seperator

        private void radioButton_amPmSep_space_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_amPmSep_space.Checked)
            {
                formatter.Format.TimeAmPmSep = " ";
                UpdateFormat();
            }
        }

        private void radioButton_amPmSep_none_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_amPmSep_none.Checked)
            {
                formatter.Format.TimeAmPmSep = "";
                UpdateFormat();
            }
        }

        private void radioButton_amPmSep_undercore_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_amPmSep_underscore.Checked)
            {
                formatter.Format.TimeAmPmSep = "_";
                UpdateFormat();
            }
        }

        private void radioButton_amPmSep_dot_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_amPmSep_dot.Checked)
            {
                formatter.Format.TimeAmPmSep = ".";
                UpdateFormat();
            }
        }

        private void radioButton_amPmSep_custom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_amPmSep_custom.Checked)
            {
                formatter.Format.TimeAmPmSep = textBox_amPmSep_custom.Text;
                UpdateFormat();
            }
            textBox_amPmSep_custom.Enabled = radioButton_amPmSep_custom.Checked;
        }

        private void textBox_amPmSep_custom_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_amPmSep_custom.Checked)
            {
                formatter.Format.TimeAmPmSep = textBox_amPmSep_custom.Text;
                UpdateFormat();
            }
        }


    }
}
