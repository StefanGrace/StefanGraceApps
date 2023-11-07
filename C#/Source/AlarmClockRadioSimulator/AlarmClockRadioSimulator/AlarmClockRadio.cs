using System;

namespace AlarmClockRadioSimulator
{
    class AlarmClockRadio
    {
        private TempSensor ts;
        private RhSensor rh;
        private Display display;
        private USB usb;
        private Battery batt;
        private Speaker speaker;
        private HeadphoneJack hpj;

        private const int erilestYear = 2009;
        private const int latestYear = 2408;
        private const float minFM = 87.5f;
        private const float maxFM = 108f;
        private const short minAM = 530;
        private const short maxAM = 1600;
        private string[] alarmDays = {"WEEK", "WKND", "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN", "ALL"};

        private DateTime dateAndTime;
        private byte setMode;
        private byte timeFormat;
        private Alarm alarm1;
        private Alarm alarm2;
        private byte function;
        private byte tempUnit;
        private float fmStation;
        private short amStation;
        private byte folderNumber;
        private int trackNumber;
        private int trackTime;
        private int sleepTime;
        private byte sleepFunction;
        private byte sleepSetMode;
        private int flashTimer;
        private bool pluggedIn;
        private bool usbPaused;
        private byte displayMode;
        private byte displayPowerMode;
        private bool settingDisplayPowerMode;
        private long halfSeconds;
        private long displayModeSet;
        private long displayPowerModeSet;
        private bool displayingLowBatt;
        private long displayTempOnTime;
        private bool usbReading;
        private byte usbReadTime;
        private byte fmPreset;
        private byte amPreset;
        private float[] fmPresets;
        private short[] amPresets;
        private bool settingStation;
        private int battLowTime;

        public AlarmClockRadio(Display disp, TempSensor ts, RhSensor rh, USB usb, Battery batt, Speaker speaker, HeadphoneJack hpj)
        {
            pluggedIn = true;
            display = disp;
            this.ts = ts;
            this.rh = rh;
            this.usb = usb;
            this.batt = batt;
            this.speaker = speaker;
            this.hpj = hpj;
            dateAndTime = new DateTime(erilestYear, 1, 1, 0, 0, 0);
            setMode = 0;
            alarm1 = new Alarm(0, 0, 0, 0);
            alarm2 = new Alarm(0, 0, 0, 0);
            sleepTime = 0;
            function = 0;
            tempUnit = 0;
            flashTimer = 0;
            sleepSetMode = 0;
            sleepFunction = 0;
            usbPaused = false;
            displayMode = 0;
            displayPowerMode = 0;
            settingDisplayPowerMode = false;
            halfSeconds = 0;
            displayModeSet = long.MaxValue;
            displayPowerModeSet = long.MaxValue;
            displayingLowBatt = false;
            usbReading = false;
            folderNumber = 1;
            trackNumber = 1;
            trackTime = 0;
            fmPreset = 1;
            amPreset = 1;
            fmStation = (float) Math.Round((minFM + maxFM) / 2, 1);
            amStation = (minAM + maxAM) / 2;
            fmPresets = new float[9];
            amPresets = new short[9];
            for (byte i = 0; i < fmPresets.Length; i++)
            {
                fmPresets[i] = fmStation;
            }
            for (byte i = 0; i < amPresets.Length; i++)
            {
                amPresets[i] = amStation;
            }
            settingStation = false;
            displayTempOnTime = 0;
            battLowTime = 0;
        }

        public void tick()
        {
            dateAndTime = dateAndTime.AddSeconds(1);
            if (dateAndTime.Year > latestYear)
            {
                dateAndTime = new DateTime(erilestYear, dateAndTime.Month, dateAndTime.Day, dateAndTime.Hour, dateAndTime.Minute, dateAndTime.Second);
            }
            if (sleepTime > 0 && sleepSetMode == 0)
            {
                sleepTime--;
            }
            Alarm[] alarms = { alarm1, alarm2 };
            foreach (Alarm alarm in alarms)
            {
                if (dateAndTime.Hour == alarm.Hour && dateAndTime.Minute == alarm.Minute && dateAndTime.Second == 0 && alarm.Function > 0)
                {
                    if (dateAndTime.DayOfWeek.ToString().ToUpper().Substring(0, 3) == alarmDays[alarm.Weekday] ||
                        ((int) dateAndTime.DayOfWeek < 6 && alarmDays[alarm.Weekday] == "WEEK") ||
                        ((int) dateAndTime.DayOfWeek > 5 && alarmDays[alarm.Weekday] == "WKND"))
                    {
                        alarm.Active = true;
                    }
                }
                alarm.checkSnooze(dateAndTime);
            }
            if (getCurrentFunction() == 3)
            {
                playUSB();
            }
            if (batt.Low && !pluggedIn && battLowTime < 2)
            {
                battLowTime++;
            }
        }

        public void setBrihgtness(int brightness)
        {
            display.setBrightness(brightness);
            updateDisplay();
        }

        private byte getCurrentFunction()
        {
            if (function > 0)
            {
                return function;
            }
            else
            {
                if (sleepTime > 0 && sleepSetMode == 0)
                {
                    return (byte) (sleepFunction + 1);
                }
                else
                {
                    if (alarm1.Active)
                    {
                        return alarm1.Function;
                    }
                    else if (alarm2.Active)
                    {
                        return alarm2.Function;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        public void updateDisplay()
        {
            string bigNumbers = "";
            string smallNumbers = "";
            string letters = "";
            bool bigColon = false;
            bool bigDot = false;
            bool smallColon = false;
            bool smallDot = false;
            bool a1 = false;
            bool a2 = false;
            bool ac = false;
            bool fmr = false;
            bool amr = false;
            bool usb = false;
            bool pm = false;
            bool leftBigFlashing = false;
            bool rightBigFlashing = false;
            bool lettersFlashing = false;
            bool smallFlashing = false;

            if (isDisplayOn())
            {
                ac = pluggedIn;
                if (alarm1.Function > 0)
                {
                    a1 = true;
                }
                if (alarm2.Function > 0)
                {
                    a2 = true;
                }
                switch (getCurrentFunction())
                {
                    case 1:
                        fmr = true;
                        break;
                    case 2:
                        amr = true;
                        break;
                    case 3:
                        usb = true;
                        break;
                }

                if (settingDisplayPowerMode)
                {
                    bigNumbers = "DISP";
                    switch (displayPowerMode)
                    {
                        case 0:
                            letters = "BATT";
                            smallNumbers = "AC";
                            break;
                        case 1:
                            letters = "ON";
                            break;
                        case 2:
                            letters = "OFF";
                            break;
                    }
                }
                else
                {
                    switch (setMode)
                    {
                        case 0:
                            switch (sleepSetMode)
                            {
                                case 0:
                                    switch (getCurrentFunction())
                                    {
                                        case 0:
                                        case 4:
                                            if (displayMode == 0)
                                            {
                                                displayTime(ref bigNumbers, ref smallNumbers, ref letters, ref bigColon, ref bigDot, ref smallColon, ref smallDot, ref pm);
                                            }
                                            else
                                            {
                                                displayAlarm(displayMode, ref bigNumbers, ref pm, ref smallNumbers, ref letters, ref bigColon);
                                            }
                                            break;
                                        case 1:
                                            if ((function == 0 && displayMode == 0) || (function == 1 && displayMode == 1))
                                            {
                                                displayTime(ref bigNumbers, ref smallNumbers, ref letters, ref bigColon, ref bigDot, ref smallColon, ref smallDot, ref pm);
                                            }
                                            else
                                            {
                                                displayFMR(ref bigNumbers, ref letters, ref smallNumbers, ref bigDot);
                                            }
                                            break;
                                        case 2:
                                            if ((function == 0 && displayMode == 0) || (function == 2 && displayMode == 1))
                                            {
                                                displayTime(ref bigNumbers, ref smallNumbers, ref letters, ref bigColon, ref bigDot, ref smallColon, ref smallDot, ref pm);
                                            }
                                            else
                                            {
                                                displayAMR(ref bigNumbers, ref letters, ref smallNumbers);
                                            }
                                            break;
                                        case 3:
                                            if ((function == 0 && displayMode == 0) || (function == 3 && displayMode == 1))
                                            {
                                                displayTime(ref bigNumbers, ref smallNumbers, ref letters, ref bigColon, ref bigDot, ref smallColon, ref smallDot, ref pm);
                                            }
                                            else
                                            {
                                                displayUSB(ref bigNumbers, ref letters, ref smallNumbers, ref bigColon);
                                            }
                                            break;
                                    }
                                    break;

                                case 1:
                                case 2:
                                case 3:
                                    bigNumbers = Math.Floor(sleepTime / 3600.0).ToString() + Math.Floor((sleepTime % 3600) / 60.0).ToString().PadLeft(2, '0');
                                    switch (sleepFunction)
                                    {
                                        case 0: letters = "FM R"; break;
                                        case 1: letters = "AM R"; break;
                                        case 2: letters = "USB"; break;
                                    }
                                    bigColon = true;
                                    break;
                            }

                            break;
                        case 1:
                            bigNumbers = dateAndTime.Year.ToString();
                            letters = "YEAR";
                            leftBigFlashing = true;
                            rightBigFlashing = true;
                            break;
                        case 2:
                        case 3:
                            bigNumbers = dateAndTime.Month.ToString().PadLeft(2, '0') + dateAndTime.Day.ToString().PadLeft(2, '0');
                            letters = "DATE";
                            break;
                        case 4:
                        case 5:
                            bigNumbers = formatTime(dateAndTime.Hour, dateAndTime.Minute);
                            pm = dateAndTime.Hour >= 12 && timeFormat == 1;
                            letters = "TIME";
                            bigColon = true;
                            break;
                        case 6:
                        case 7:
                        case 8:
                            displayAlarm(1, ref bigNumbers, ref pm, ref smallNumbers, ref letters, ref bigColon);
                            break;
                        case 9:
                        case 10:
                        case 11:
                            displayAlarm(2, ref bigNumbers, ref pm, ref smallNumbers, ref letters, ref bigColon);
                            break;
                    }

                    switch (setMode)
                    {
                        case 0:
                            switch (sleepSetMode)
                            {
                                case 0:
                                    if (function == 1 || function == 2)
                                    {
                                        if (settingStation)
                                        {
                                            leftBigFlashing = true;
                                            rightBigFlashing = true;
                                        }
                                    }
                                    break;
                                case 1:
                                    leftBigFlashing = true;
                                    break;
                                case 2:
                                    rightBigFlashing = true;
                                    break;
                                case 3:
                                    lettersFlashing = true;
                                    break;
                            }
                            break;
                        case 2:
                        case 4:
                        case 6:
                        case 9:
                            leftBigFlashing = true;
                            break;
                        case 3:
                        case 5:
                        case 7:
                        case 10:
                            rightBigFlashing = true;
                            break;
                        case 8:
                        case 11:
                            lettersFlashing = true;
                            break;
                    }

                    if (flashTimer % 2 == 1)
                    {
                        if (leftBigFlashing)
                        {
                            bigNumbers = bigNumbers.PadLeft(4, ' ');
                            bigNumbers = "  " + bigNumbers[2].ToString() + bigNumbers[3].ToString();
                        }
                        if (rightBigFlashing)
                        {
                            bigNumbers = bigNumbers.PadLeft(4, ' ');
                            bigNumbers = bigNumbers[0].ToString() + bigNumbers[1].ToString() + "  ";
                        }
                        if (lettersFlashing)
                        {
                            letters = "";
                        }
                        if (smallFlashing)
                        {
                            smallNumbers = "";
                        }
                    }
                }
            }
            else
            {
                if (batt.Low && !pluggedIn && battLowTime < 2)
                {
                    bigNumbers = "LO";
                    letters = "BATT";
                }
            }

            display.update(bigNumbers, smallNumbers, letters, bigColon, bigDot, smallColon, smallDot, a1, a2, ac, fmr, amr, usb , pm);
        }

        private string formatTime(int hour, int minute)
        {
            if (timeFormat == 0)
            {
                return hour + minute.ToString().PadLeft(2, '0');
            }
            else
            {
                int hour12;
                if (hour < 1)
                {
                    hour12 = 12;
                } 
                else if (hour < 13)
                {
                    hour12 = hour;
                }
                else
                {
                    hour12 = hour - 12;
                }
                return hour12 + minute.ToString().PadLeft(2, '0');
            }
        }

        public void pressSetButton()
        {
            if (batt.Low && !pluggedIn)
            {
                if (battLowTime >= 2)
                {
                    battLowTime = 0;
                }
                return;
            }
            displayTempOnTime = halfSeconds;
            if (sleepSetMode == 0)
            {
                switch (function)
                {
                    case 0:
                        if (!alarm1.Active && !alarm2.Active)
                        {
                            switch (function)
                            {
                                case 0:
                                    if (sleepTime == 0)
                                    {
                                        if (setMode < 11)
                                        {
                                            setMode++;
                                        }
                                        else
                                        {
                                            setMode = 0;
                                        }
                                    }
                                    else
                                    {
                                        sleepTime = 0;
                                    }
                                    break;
                            }
                        }
                        if (alarm1.Active)
                        {
                            alarm1.Active = false;
                        }
                        if (alarm2.Active)
                        {
                            alarm2.Active = false;
                        }
                        break;

                    case 1:
                    case 2:
                        settingStation = !settingStation;
                        break;

                    case 3:
                        if (!usbReading && usb.Present && !isUsbEmpty())
                        { 
                            usbPaused = !usbPaused;
                        }
                        break;
                }
                
            }
            else
            {
                sleepSetMode = 0;
                sleepTime = 0;
            }
            if (displayMode > 0 && function == 0)
            {
                displayMode = 0;
            }
            displayPowerModeSet = halfSeconds;
            updateDisplay();
        }

        public void pressUpButton()
        {
            if (batt.Low && !pluggedIn)
            {
                if (battLowTime >= 2)
                {
                    battLowTime = 0;
                }
                return;
            }
            displayTempOnTime = halfSeconds;
            switch (setMode)
            {
                case 0:
                    switch (sleepSetMode)
                    {
                        case 0:
                            switch (getCurrentFunction())
                            {
                                case 1:
                                    if (settingStation)
                                    {
                                        if (fmStation < maxFM)
                                        {
                                            fmStation += 0.1f;
                                        }
                                        else
                                        {
                                            fmStation = minFM;
                                        }
                                    }
                                    else
                                    {
                                        if (fmPreset < 9)
                                        {
                                            fmPreset++;
                                        }
                                        else
                                        {
                                            fmPreset = 1;
                                        }
                                        fmStation = fmPresets[fmPreset - 1];
                                    }
                                    break;

                                case 2:
                                    if (settingStation)
                                    {
                                        if (amStation < maxAM)
                                        {
                                            amStation += 1;
                                        }
                                        else
                                        {
                                            amStation = minAM;
                                        }
                                    }
                                    else
                                    {
                                        if (amPreset < 9)
                                        {
                                            amPreset++;
                                        }
                                        else
                                        {
                                            amPreset = 1;
                                        }
                                        amStation = amPresets[amPreset - 1];
                                    }
                                    break;

                                case 3:
                                    usbPaused = false;
                                    if (!usbReading && usb.Present && !isUsbEmpty())
                                    {
                                        nextTrack();
                                    }
                                    break;
                            }
                            break;
                        case 1:
                            if (sleepTime < 5 * 3600)
                            {
                                sleepTime += 3600;
                            }
                            else
                            {
                                sleepTime = sleepTime % 3600;
                            }
                            break;
                        case 2:
                            if (sleepTime % 3600 < 59 * 60)
                            {
                                sleepTime += 60;
                            }
                            else
                            {
                                sleepTime -= 59 * 60;
                            }
                            break;
                        case 3:
                            if (sleepFunction < 2)
                            {
                                sleepFunction++;
                            }
                            else
                            {
                                sleepFunction = 0;
                            }
                            break;
                    }
                    break;
                case 1:
                    if (dateAndTime.Year < latestYear)
                    {
                        dateAndTime = dateAndTime.AddYears(1);
                    }
                    else
                    {
                        dateAndTime = dateAndTime.AddYears((latestYear - erilestYear) * -1);
                    }
                    break;
                case 2:
                    if (dateAndTime.Month < 12)
                    {
                        dateAndTime = dateAndTime.AddMonths(1);
                    }
                    else
                    {
                        dateAndTime = dateAndTime.AddMonths(-11);
                    }
                    break;
                case 3:
                    if (dateAndTime.AddDays(1).Day != 1)
                    {
                        dateAndTime = dateAndTime.AddDays(1);
                    }
                    else
                    {
                        dateAndTime = new DateTime(dateAndTime.Year, dateAndTime.Month, 1, dateAndTime.Hour, dateAndTime.Minute, dateAndTime.Second);
                    }
                    break;
                case 4:
                    if (dateAndTime.Hour < 23)
                    {
                        dateAndTime = dateAndTime.AddHours(1);
                    }
                    else
                    {
                        dateAndTime = dateAndTime.AddHours(-23);
                    }
                    break;
                case 5:
                    if (dateAndTime.Minute < 59)
                    {
                        dateAndTime = dateAndTime.AddMinutes(1);
                    }
                    else
                    {
                        dateAndTime = dateAndTime.AddMinutes(-59);
                    }
                    break;
                case 6:
                    if (alarm1.Hour < 23)
                    {
                        alarm1.Hour++;
                    }
                    else
                    {
                        alarm1.Hour = 0;
                    }
                    break;
                case 7:
                    if (alarm1.Minute < 59)
                    {
                        alarm1.Minute++;
                    }
                    else
                    {
                        alarm1.Minute = 0;
                    }
                    break;
                case 8:
                    if (alarmDays[alarm1.Weekday] != "ALL")
                    {
                        alarm1.Weekday++;
                    }
                    else
                    {
                        alarm1.Weekday = 0;
                    }
                    break;
                case 9:
                    if (alarm2.Hour < 23)
                    {
                        alarm2.Hour++;
                    }
                    else
                    {
                        alarm2.Hour = 0;
                    }
                    break;
                case 10:
                    if (alarm2.Minute < 59)
                    {
                        alarm2.Minute++;
                    }
                    else
                    {
                        alarm2.Minute = 0;
                    }
                    break;
                case 11:
                    if (alarmDays[alarm2.Weekday] != "ALL")
                    {
                        alarm2.Weekday++;
                    }
                    else
                    {
                        alarm2.Weekday = 0;
                    }
                    break;
            }
            flashTimer = -2;
            updateDisplay();
        }

        public void pressDownButton()
        {
            if (batt.Low && !pluggedIn)
            {
                if (battLowTime >= 2)
                {
                    battLowTime = 0;
                }
                return;
            }
            displayTempOnTime = halfSeconds;
            switch (setMode)
            {
                case 0:
                    switch (sleepSetMode)
                    {
                        case 0:
                            switch (getCurrentFunction())
                            {
                                case 1:
                                    if (settingStation)
                                    {
                                        if (fmStation < maxFM)
                                        {
                                            fmStation -= 0.1f;
                                        }
                                        else
                                        {
                                            fmStation = minFM;
                                        }
                                    }
                                    else
                                    {
                                        if (fmPreset > 1)
                                        {
                                            fmPreset--;
                                        }
                                        else
                                        {
                                            fmPreset = 9;
                                        }
                                        fmStation = fmPresets[fmPreset - 1];
                                    }
                                    break;
                                case 2:
                                    if (settingStation)
                                    {
                                        if (amStation < maxAM)
                                        {
                                            amStation--;
                                        }
                                        else
                                        {
                                            amStation = minAM;
                                        }
                                    }
                                    else
                                    {
                                        if (amPreset > 1)
                                        {
                                            amPreset--;
                                        }
                                        else
                                        {
                                            amPreset = 9;
                                        }
                                        amStation = amPresets[amPreset - 1];
                                    }
                                    break;
                                case 3:
                                    usbPaused = false;
                                    if (!usbPaused && !usbReading && usb.Present && !isUsbEmpty())
                                    {
                                        if (trackTime < 2)
                                        {
                                            if (trackNumber > 1)
                                            {
                                                trackNumber--;
                                            }
                                            else if (folderNumber > 1)
                                            {
                                                folderNumber--;
                                                trackNumber = usb.Tracks[folderNumber - 1].Length;
                                            }
                                            else
                                            {
                                                folderNumber = (byte)usb.Tracks.Length;
                                                trackNumber = usb.Tracks[folderNumber - 1].Length;
                                            }
                                        }
                                    }
                                    trackTime = 0;
                                    break;
                            }
                            break;
                        case 1:
                            if (sleepTime >= 3600)
                            {
                                sleepTime -= 3600;
                            }
                            else
                            {
                                sleepTime = (5 * 3600) + (sleepTime % 3600);
                            }
                            break;
                        case 2:
                            if (sleepTime % 3600 >= 60)
                            {
                                sleepTime -= 60;
                            }
                            else
                            {
                                sleepTime += 59 * 60;
                            }
                            break;
                        case 3:
                            if (sleepFunction > 0)
                            {
                                sleepFunction--;
                            }
                            else
                            {
                                sleepFunction = 2;
                            }
                            break;
                    }
                    break;
                case 1:
                    if (dateAndTime.Year > erilestYear)
                    {
                        dateAndTime = dateAndTime.AddYears(-1);
                    }
                    else
                    {
                        dateAndTime = dateAndTime.AddYears((latestYear - erilestYear));
                    }
                    break;
                case 2:
                    if (dateAndTime.Month > 1)
                    {
                        dateAndTime = dateAndTime.AddMonths(-1);
                    }
                    else
                    {
                        dateAndTime = dateAndTime.AddMonths(11);
                    }
                    break;
                case 3:
                    if (dateAndTime.Day != 1)
                    {
                        dateAndTime = dateAndTime.AddDays(-1);
                    }
                    else
                    {
                        DateTime nextMonth = dateAndTime.AddMonths(1);
                        dateAndTime = new DateTime(dateAndTime.Year, dateAndTime.Month, nextMonth.AddDays(-1).Day, dateAndTime.Hour, dateAndTime.Minute, dateAndTime.Second);
                    }
                    break;
                case 4:
                    if (dateAndTime.Hour > 0)
                    {
                        dateAndTime = dateAndTime.AddHours(-1);
                    }
                    else
                    {
                        dateAndTime = dateAndTime.AddHours(23);
                    }
                    break;
                case 5:
                    if (dateAndTime.Minute > 0)
                    {
                        dateAndTime = dateAndTime.AddMinutes(-1);
                    }
                    else
                    {
                        dateAndTime = dateAndTime.AddMinutes(59);
                    }
                    break;
                case 6:
                    if (alarm1.Hour > 0)
                    {
                        alarm1.Hour--;
                    }
                    else
                    {
                        alarm1.Hour = 23;
                    }
                    break;
                case 7:
                    if (alarm1.Minute > 0)
                    {
                        alarm1.Minute--;
                    }
                    else
                    {
                        alarm1.Minute = 59;
                    }
                    break;
                case 8:
                    if (alarmDays[alarm1.Weekday] != "WEEK")
                    {
                        alarm1.Weekday--;
                    }
                    else
                    {
                        alarm1.Weekday = (byte) (alarmDays.Length - 1);
                    }
                    break;
                case 9:
                    if (alarm2.Hour > 0)
                    {
                        alarm2.Hour--;
                    }
                    else
                    {
                        alarm2.Hour = 23;
                    }
                    break;
                case 10:
                    if (alarm2.Minute > 0)
                    {
                        alarm2.Minute--;
                    }
                    else
                    {
                        alarm2.Minute = 59;
                    }
                    break;
                case 11:
                    if (alarmDays[alarm2.Weekday] != "WEEK")
                    {
                        alarm2.Weekday--;
                    }
                    else
                    {
                        alarm2.Weekday = (byte)(alarmDays.Length - 1);
                    }
                    break;
            }
            flashTimer = -2;
            updateDisplay();
        }

        public void pressSleepButton()
        {
            if (batt.Low && !pluggedIn)
            {
                if (battLowTime >= 2)
                {
                    battLowTime = 0;
                }
                return;
            }
            displayTempOnTime = halfSeconds;
            if (setMode > 0)
            {
                setMode = 0;
            }
            else
            {
                if (sleepSetMode == 0 && sleepTime == 0)
                {
                    sleepTime = 30 * 60;
                }

                if (sleepSetMode < 3)
                {
                    sleepSetMode++;
                }
                else
                {
                    sleepSetMode = 0;
                }
                if (displayMode > 0 && function == 0)
                {
                    displayMode = 0;
                }
            }
            updateDisplay();
        }

        public void pressSnoozeButton()
        {
            if (batt.Low && !pluggedIn)
            {
                if (battLowTime >= 2)
                {
                    battLowTime = 0;
                }
                return;
            }
            if (isDisplayOn())
            {
                if (settingDisplayPowerMode)
                {
                    if (displayPowerMode < 2)
                    {
                        displayPowerMode += 1;
                    }
                    else
                    {
                        displayPowerMode = 0;
                    }
                    displayPowerModeSet = halfSeconds;
                }
                else
                {
                    if (getCurrentFunction() == 0)
                    {
                        if (displayMode < 2)
                        {
                            displayMode++;
                        }
                        else
                        {
                            displayMode = 0;
                        }
                        displayModeSet = halfSeconds;
                    }
                    else if (!alarm1.Active && !alarm2.Active)
                    {
                        if (displayMode > 0)
                        {
                            displayMode = 0;
                        }
                        else
                        {
                            displayMode = 1;
                        }
                    }
                    Alarm[] alarms = { alarm1, alarm2 };
                    foreach (Alarm alarm in alarms)
                    {
                        if (alarm.Active)
                        {
                            alarm.snooze(new DateTime(dateAndTime.Ticks));
                        }
                    }
                }
            }
            else
            {
                displayTempOnTime = halfSeconds;
            }
            updateDisplay();
        }

        public void longPressSnoozeButton()
        {
            if (batt.Low && !pluggedIn)
            {
                return;
            }
            settingDisplayPowerMode = true;
            displayPowerModeSet = halfSeconds;
        }

        public void longPressUpButton()
        {
            if (batt.Low && !pluggedIn)
            {
                return;
            }
            if (getCurrentFunction() == 3 && !usbReading && usb.Present && !isUsbEmpty())
            {
                usbPaused = false;
                if (folderNumber < usb.Tracks.Length)
                {
                    folderNumber++;
                    trackNumber = 1;
                    trackTime = 0;
                }
                else
                {
                    folderNumber = 1;
                    trackNumber = 1;
                    trackTime = 0;
                }
            }
        }

        public void longPressDownButton()
        {
            if (batt.Low && !pluggedIn)
            {
                return;
            }
            if (getCurrentFunction() == 3 && !usbReading && usb.Present && !isUsbEmpty())
            {
                usbPaused = false;
                if (trackNumber == 1)
                {
                    if (folderNumber > 1)
                    {
                        folderNumber--;
                        trackNumber = 1;
                        trackTime = 0;
                    }
                    else
                    {
                        folderNumber = (byte) usb.Tracks.Length;
                        trackNumber = usb.Tracks[folderNumber - 1].Length;
                        trackTime = 0;
                    }
                }
                else
                {
                    trackNumber = 1;
                    trackTime = 0;
                }
            }
        }

        public void longPressSetButton()
        {
            if (batt.Low && !pluggedIn)
            {
                return;
            }
            switch (getCurrentFunction())
            {
                case 1:
                    fmPresets[fmPreset - 1] = fmStation;
                    break;
                case 2:
                    amPresets[amPreset - 1] = amStation;
                    break;
                case 3:
                    trackNumber = 1;
                    folderNumber = 1;
                    trackTime = 0;
                    usbPaused = false;
                    break;
            }
        }

        public void setTimeFormat(byte timeFormat)
        {
            this.timeFormat = timeFormat;
            updateDisplay();
        }

        public void setAlarm1(byte alarm1)
        {
            this.alarm1.Function = alarm1;
            updateDisplay();
        }

        public void setAlarm2(byte alarm2)
        {
            this.alarm2.Function = alarm2;
            updateDisplay();
        }

        public void setFuncion(byte function)
        {
            this.function = function;
            displayMode = 0;
            updateDisplay();
        }

        public void setTempUnit(byte tempUnit)
        {
            this.tempUnit = tempUnit;
            updateDisplay();
        }

        public void flashTick()
        {
            if (flashTimer == 1)
            {
                flashTimer = 0;
            }
            else
            {
                flashTimer++;
            }
            halfSeconds++;
            if (displayMode > 0 && getCurrentFunction() == 0)
            {
                if (halfSeconds - displayModeSet > 6)
                {
                    displayMode = 0;
                    displayModeSet = long.MaxValue;
                }
            }
            if (settingDisplayPowerMode)
            {
                if (halfSeconds - displayPowerModeSet > 6)
                {
                    settingDisplayPowerMode = false;
                    displayPowerModeSet = long.MaxValue;
                }
            }
            if (!usb.Present || isUsbEmpty())
            {
                usbPaused = false;
                folderNumber = 1;
                trackNumber = 1;
                trackTime = 1;
            }
            updateSpeaker();

        }

        public bool PluggedIn
        {
            get
            {
                return pluggedIn;
            }

            set
            {
                if (pluggedIn != value)
                {
                    displayTempOnTime = halfSeconds;
                }
                pluggedIn = value;
            }
        }

        private void displayAlarm(byte al, ref string bigNumbers, ref bool pm, ref string smallNumbers, ref string letters, ref bool bigColon)
        {
            Alarm[] alarms = { alarm1, alarm2 };
            bigNumbers = formatTime(alarms[al - 1].Hour, alarms[al - 1].Minute);
            pm = alarms[al - 1].Hour >= 12 && timeFormat == 1;
            smallNumbers = "A" + al;
            letters = alarmDays[alarms[al - 1].Weekday];
            bigColon = true;
        }

        private void displayTime(ref string bigNumbers, ref string smallNumbers, ref string letters, ref bool bigColon, ref bool bigDot, ref bool smallColon, ref bool smallDot, ref bool pm)
        {
            bigNumbers = formatTime(dateAndTime.Hour, dateAndTime.Minute);
            pm = dateAndTime.Hour >= 12 && timeFormat == 1;
            smallNumbers = dateAndTime.Second.ToString().PadLeft(2, '0');
            bigColon = true;
            if (sleepTime == 0)
            {
                if (dateAndTime.Second % 15 < 3)
                {
                    letters = dateAndTime.Year.ToString();
                }
                else if (dateAndTime.Second % 15 < 6)
                {
                    letters = dateAndTime.Month.ToString().PadLeft(2, '0') + dateAndTime.Day.ToString().PadLeft(2, '0');
                    smallDot = true;
                }
                else if (dateAndTime.Second % 15 < 9)
                {
                    letters = dateAndTime.DayOfWeek.ToString().ToUpper().Substring(0, 3);
                }
                else if (dateAndTime.Second % 15 < 12)
                {
                    if (tempUnit == 0)
                    {
                        letters = ((int)Math.Round(ts.TempC * 10)).ToString("D2").PadLeft(3, ' ') + "C";
                        smallDot = true;
                    }
                    else
                    {
                        letters = ((int)Math.Round(ts.TempF)).ToString().PadLeft(3, ' ') + "F";
                    }
                }
                else
                {
                    letters = rh.Rh.ToString().PadLeft(2, ' ') + " %";
                }
            }
            else
            {
                if (sleepTime >= 3600)
                {
                    letters = Math.Floor(sleepTime / 3600.0).ToString().PadLeft(2, ' ') + Math.Floor((sleepTime % 3600) / 60.0).ToString().PadLeft(2, '0');
                }
                else
                {
                    letters = Math.Floor(sleepTime / 60.0).ToString().PadLeft(2, ' ') + (sleepTime % 60).ToString().PadLeft(2, '0');
                }
                smallColon = true;
            }
        }

        private void displayFMR(ref string bigNumbers, ref string letters, ref string smallNumbers, ref bool bigDot)
        {
            letters = "FM R";
            smallNumbers = fmPreset.ToString();
            bigNumbers = ((int)(fmStation * 10)).ToString();
            bigDot = true;
        }

        private void displayAMR(ref string bigNumbers, ref string letters, ref string smallNumbers)
        {
            letters = "AM R";
            smallNumbers = amPreset.ToString();
            bigNumbers = amStation.ToString();
        }

        private void displayUSB(ref string bigNumbers, ref string letters, ref string smallNumbers, ref bool bigColon)
        {
            if (usb.Present)
            {
                if (usbReading)
                {
                    letters = "READ";
                    if (halfSeconds % 2 > 0)
                    {
                        bigNumbers = "----";
                        smallNumbers = "--";
                    }
                }
                else if (usbPaused)
                {
                    letters = AbsoluteTrackNumber.ToString().PadLeft(4, '0');
                    bigNumbers = "PAUS";
                    smallNumbers = "E";
                } 
                else
                {
                    if (usb.Tracks.Length > 0)
                    {
                        letters = AbsoluteTrackNumber.ToString().PadLeft(4, '0');
                        smallNumbers = folderNumber.ToString().PadLeft(2, '0');
                        bigColon = true;
                        bigNumbers = Math.Floor(trackTime / 60.0).ToString() + (trackTime % 60).ToString().PadLeft(2, '0');
                    }
                    else
                    {
                        bigNumbers = "----";
                        letters = "EMTY";
                        smallNumbers = "--";
                    }
                }
            }
            else
            {
                bigNumbers = "NO";
                letters = "USB";
            }
        }

        private void playUSB()
        {
            if (!usbPaused && !usbReading && usb.Present && !isUsbEmpty() && (!batt.Low || pluggedIn))
            {
                if (trackTime < usb.Tracks[folderNumber - 1][trackNumber - 1] - 1)
                {
                    trackTime++;
                }
                else
                {
                    nextTrack();
                }
            }
        }

        private void nextTrack()
        {
            if (trackNumber < usb.Tracks[folderNumber - 1].Length)
            {
                trackTime = 0;
                trackNumber++;
            }
            else if (folderNumber < usb.Tracks.Length)
            {
                trackTime = 0;
                trackNumber = 1;
                folderNumber++;
            }
            else
            {
                trackTime = 0;
                trackNumber = 1;
                folderNumber = 1;
            }
        }

        private int AbsoluteTrackNumber
        {
            get
            {
                int tracksInFolders = 0;
                for(int i = 0; i < folderNumber - 1; i++)
                {
                    tracksInFolders += usb.Tracks[i].Length;
                }
                return tracksInFolders + trackNumber;
            }
        }

        private bool isUsbEmpty()
        {
            return usb.Tracks.Length == 0;
        }

        private void updateSpeaker()
        {
            Speaker soundOutput;
            if (hpj.HeadphonesPluggedIn)
            {
                soundOutput = hpj;
                speaker.Playing = false;
                speaker.Buzzing = false;
            }
            else
            {
                soundOutput = speaker;
                hpj.Playing = false;
                hpj.Buzzing = false;
            }
            if (!batt.Low || pluggedIn)
            {
                switch (getCurrentFunction())
                {
                    case 0:
                        soundOutput.Playing = false;
                        break;
                    case 1:
                    case 2:
                        soundOutput.Playing = true;
                        break;
                    case 3:
                        if (usb.Present && !usbReading && !isUsbEmpty() && !usbPaused)
                        {
                            soundOutput.Playing = true;
                        }
                        else
                        {
                            soundOutput.Playing = false;
                        }
                        break;
                    case 4:
                        soundOutput.Buzzing = true;
                        break;
                }
                if (getCurrentFunction() != 4)
                {
                    soundOutput.Buzzing = false;
                }
            }
            else
            {
                soundOutput.Playing = false;
                soundOutput.Buzzing = false;
            }
            updateDisplay();
        }

        private bool isDisplayOn()
        {
            if (batt.Low && !pluggedIn)
            {
                return false;
            }
            else if (settingDisplayPowerMode || alarm1.Active || alarm2.Active || halfSeconds - displayTempOnTime < 12 || setMode > 0 || sleepSetMode > 0)
            {
                return true;
            }
            else
            {
                switch (displayPowerMode)
                {
                    case 0:
                        return pluggedIn;
                    case 1:
                        return true;
                    case 2:
                        return false;
                    default:
                        return true;
                }
            }
        }
    }
}
