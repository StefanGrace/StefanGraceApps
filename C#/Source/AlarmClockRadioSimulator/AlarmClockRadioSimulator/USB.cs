namespace AlarmClockRadioSimulator
{
    class USB
    {
        byte state = 2;

        int[][] tracks = new int[3][];

        public USB()
        {
            tracks[0] = new int[3] { 80, 200, 125 };
            tracks[1] = new int[5] { 90, 94, 198, 147, 112 };
            tracks[2] = new int[4] { 131, 211, 104, 118 };
        }

        public int[][] Tracks
        {
            get
            {
                if (state == 2)
                {
                    return tracks;
                }
                else
                {
                    return new int[0][];
                }
            }
        }

        public bool Present
        {
            get
            {
                return state != 0;
            }
        }

        public byte State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }
    }
}
