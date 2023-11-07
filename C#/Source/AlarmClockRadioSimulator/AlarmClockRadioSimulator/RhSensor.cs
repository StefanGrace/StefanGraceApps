namespace AlarmClockRadioSimulator
{
    class RhSensor
    {
        private byte rh = 75;

        public byte Rh
        {
            get
            {
                return rh;
            }

            set
            {
                rh = value;
            }
        }
    }
}
