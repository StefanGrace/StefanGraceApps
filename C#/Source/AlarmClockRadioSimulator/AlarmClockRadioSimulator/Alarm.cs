using System;

namespace AlarmClockRadioSimulator
{
    class Alarm
    {
        private byte hour;
        private byte minute;
        private byte weekday;
        private byte function;
        private bool active = false;
        private bool snoozed = false;
        private DateTime snoozeTime = DateTime.MaxValue;
        private const int snoozeDuration = 6 * 60;

        public Alarm(byte hour, byte minute, byte weekday, byte function)
        {
            Hour = hour;
            Minute = minute;
            Weekday = weekday;
            Function = function;
        }

        public byte Hour { get => hour; set => hour = value; }
        public byte Minute { get => minute; set => minute = value; }
        public byte Weekday { get => weekday; set => weekday = value; }
        public bool Active { get => active; set => active = value; }

        public byte Function
        {
            get
            {
                return function;
            }
            set
            {
                function = value; 
                if (value == 0)
                {
                    active = false;
                }
            }
         }

        public void checkSnooze(DateTime currentTime)
        {
            if (snoozed)
            {
                if (currentTime.CompareTo(snoozeTime.AddSeconds(snoozeDuration)) >= 0)
                {
                    snoozed = false;
                    active = true;
                }
            }
        }

        public void snooze(DateTime snoozeTime)
        {
            active = false;
            snoozed = true;
            this.snoozeTime = snoozeTime;
        }
    }
}
