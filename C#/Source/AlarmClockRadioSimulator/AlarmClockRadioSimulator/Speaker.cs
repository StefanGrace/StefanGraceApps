namespace AlarmClockRadioSimulator
{ 
    class Speaker
    {
        private byte volume = 10;
        private bool playing = false;
        private bool buzzing = false;

        public byte Volume
        {
            get
            {
                if (playing || buzzing)
                {
                    return volume;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                volume = value;
            }
        }

        public bool Buzzing
        {
            get
            {
                return buzzing;
            }
            set
            {
                buzzing = value;
            }
        }

        public bool Playing
        {
            set
            {
                playing = value;
            }
        }
    }
}
