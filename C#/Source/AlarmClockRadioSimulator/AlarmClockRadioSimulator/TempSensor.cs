namespace AlarmClockRadioSimulator
{
    class TempSensor
    {
        private float tempC = 20.4f;

        public float TempC
        {
            get
            {
                return tempC;
            }
            set
            {
                tempC = value;
            }
        }

        public float TempF
        {
            get
            {
                return (tempC * 1.8f) + 32f;
            }
        }
    }
}
