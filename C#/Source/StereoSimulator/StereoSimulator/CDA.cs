using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StereoSimulator
{
    class CDA : CD
    {
        private TimeSpan[] tracks;

        public CDA(TimeSpan[] tracks)
        {
            if (tracks.Length > 99)
            {
                throw new ArgumentOutOfRangeException("CD-DA can only have up to 99 tracks.");
            }

            if (GetTotalDuration(tracks) > new TimeSpan(0, 80, 0))
            {
                throw new ArgumentOutOfRangeException("CD-DA can only hold up to 80 minutes.");
            }

            this.tracks = tracks;
        }

        public int Tracks
        {
            get
            {
                return tracks.Length;
            }
        }

        public TimeSpan GetTrackDuration(int track)
        {
            
            return tracks[track];
        }

        public TimeSpan TotalDuration
        {
            get
            {
                return GetTotalDuration(tracks);
            }
        }

        private TimeSpan GetTotalDuration(TimeSpan[] tracks)
        {
            TimeSpan total = new TimeSpan(0);

            foreach (TimeSpan track in tracks)
            {
                total += track;
            }

            return total;
        }
    }
}
