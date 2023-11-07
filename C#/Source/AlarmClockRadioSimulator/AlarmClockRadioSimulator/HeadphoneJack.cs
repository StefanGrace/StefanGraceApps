namespace AlarmClockRadioSimulator
{
    class HeadphoneJack : Speaker
    {
        private bool headphonesPluggedIn;

        public bool HeadphonesPluggedIn
        {
            get
            {
                return headphonesPluggedIn;
            }
            set
            {
                headphonesPluggedIn = value;
            }
        }
    }
}
